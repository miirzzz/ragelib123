using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using RageLib.Archives;
using RageLib.GTA5.Archives;
using RageLib.GTA5.ArchiveWrappers;

namespace RageLib.GTA5.Utilities
{
	// Token: 0x02000188 RID: 392
	public class GameRebuilder
	{
		// Token: 0x06000615 RID: 1557 RVA: 0x00028128 File Offset: 0x00026328
		public void Rebuild(string sourceGameDirectoryName, string destinationGameDirectoryName)
		{
			foreach (string text in Directory.GetFiles(sourceGameDirectoryName, "*.rpf", SearchOption.AllDirectories))
			{
				this.RebuildArchive(text, text.Replace(sourceGameDirectoryName, destinationGameDirectoryName));
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00028164 File Offset: 0x00026364
		public void RebuildParallel(string sourceGameDirectoryName, string destinationGameDirectoryName)
		{
			Parallel.ForEach<string>(Directory.GetFiles(sourceGameDirectoryName, "*.rpf", SearchOption.AllDirectories), delegate(string archiveFileName)
			{
				this.RebuildArchive(archiveFileName, archiveFileName.Replace(sourceGameDirectoryName, destinationGameDirectoryName));
			});
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000281B0 File Offset: 0x000263B0
		private void RebuildArchive(string sourceArchiveFileName, string destinationArchiveFileName)
		{
			FileInfo fileInfo = new FileInfo(sourceArchiveFileName);
			RageArchiveWrapper7 rageArchiveWrapper = RageArchiveWrapper7.Open(new FileStream(sourceArchiveFileName, FileMode.Open), fileInfo.Name, false);
			RageArchiveWrapper7 rageArchiveWrapper2 = RageArchiveWrapper7.Create(destinationArchiveFileName);
			this.RebuildDictionary(rageArchiveWrapper.Root, rageArchiveWrapper2.Root, rageArchiveWrapper.archive_.Encryption);
			rageArchiveWrapper2.FileName = fileInfo.Name;
			rageArchiveWrapper2.archive_.Encryption = rageArchiveWrapper.archive_.Encryption;
			rageArchiveWrapper2.Flush();
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00028224 File Offset: 0x00026424
		private void RebuildDictionary(IArchiveDirectory sourceDirectory, IArchiveDirectory destinationDirectory, RageArchiveEncryption7 archiveEncryption)
		{
			foreach (IArchiveFile sourceFile in sourceDirectory.GetFiles())
			{
				this.RebuildFile(sourceFile, destinationDirectory, archiveEncryption);
			}
			foreach (IArchiveDirectory archiveDirectory in sourceDirectory.GetDirectories())
			{
				IArchiveDirectory archiveDirectory2 = destinationDirectory.CreateDirectory();
				archiveDirectory2.Name = archiveDirectory.Name;
				this.RebuildDictionary(archiveDirectory, archiveDirectory2, archiveEncryption);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00028290 File Offset: 0x00026490
		private void RebuildFile(IArchiveFile sourceFile, IArchiveDirectory destinationDirectory, RageArchiveEncryption7 archiveEncryption)
		{
			if (!(sourceFile is IArchiveBinaryFile))
			{
				IArchiveResourceFile sourceFile2 = (IArchiveResourceFile)sourceFile;
				this.RebuildResourceFile(sourceFile2, destinationDirectory, archiveEncryption);
				return;
			}
			IArchiveBinaryFile archiveBinaryFile = (IArchiveBinaryFile)sourceFile;
			if (archiveBinaryFile.Name.EndsWith(".rpf", StringComparison.OrdinalIgnoreCase))
			{
				this.RebuildArchiveFile(archiveBinaryFile, destinationDirectory);
				return;
			}
			this.RebuildBinaryFile(archiveBinaryFile, destinationDirectory, archiveEncryption);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000282E4 File Offset: 0x000264E4
		private void RebuildArchiveFile(IArchiveBinaryFile sourceFile, IArchiveDirectory destinationDirectory)
		{
			RageArchiveWrapper7 rageArchiveWrapper = RageArchiveWrapper7.Open(sourceFile.GetStream(), sourceFile.Name, false);
			IArchiveBinaryFile archiveBinaryFile = destinationDirectory.CreateBinaryFile();
			archiveBinaryFile.Name = sourceFile.Name;
			RageArchiveWrapper7 rageArchiveWrapper2 = RageArchiveWrapper7.Create(archiveBinaryFile.GetStream(), sourceFile.Name, false);
			this.RebuildDictionary(rageArchiveWrapper.Root, rageArchiveWrapper2.Root, rageArchiveWrapper.archive_.Encryption);
			rageArchiveWrapper2.FileName = sourceFile.Name;
			rageArchiveWrapper2.archive_.Encryption = rageArchiveWrapper.archive_.Encryption;
			rageArchiveWrapper2.Flush();
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00028370 File Offset: 0x00026570
		private void RebuildBinaryFile(IArchiveBinaryFile sourceFile, IArchiveDirectory destinationDirectory, RageArchiveEncryption7 archiveEncryption)
		{
			foreach (IRebuildBinaryFileHandler rebuildBinaryFileHandler in this.BinaryFileHandlers)
			{
				if (rebuildBinaryFileHandler.CanRebuild(sourceFile))
				{
					rebuildBinaryFileHandler.Rebuild(sourceFile, destinationDirectory, archiveEncryption);
					return;
				}
			}
			MemoryStream memoryStream = new MemoryStream();
			sourceFile.Export(memoryStream);
			memoryStream.Position = 0L;
			byte[] array = new byte[memoryStream.Length];
			memoryStream.Position = 0L;
			memoryStream.Read(array, 0, array.Length);
			IArchiveBinaryFile archiveBinaryFile = destinationDirectory.CreateBinaryFile();
			archiveBinaryFile.Name = sourceFile.Name;
			archiveBinaryFile.Import(new MemoryStream(array));
			archiveBinaryFile.IsEncrypted = sourceFile.IsEncrypted;
			if (sourceFile.IsCompressed)
			{
				archiveBinaryFile.IsCompressed = sourceFile.IsCompressed;
				archiveBinaryFile.UncompressedSize = sourceFile.UncompressedSize;
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00028458 File Offset: 0x00026658
		private void RebuildResourceFile(IArchiveResourceFile sourceFile, IArchiveDirectory destinationDirectory, RageArchiveEncryption7 archiveEncryption)
		{
			foreach (IRebuildResourceFileHandler rebuildResourceFileHandler in this.ResourceFileHandlers)
			{
				if (rebuildResourceFileHandler.CanRebuild(sourceFile))
				{
					rebuildResourceFileHandler.Rebuild(sourceFile, destinationDirectory, archiveEncryption);
					return;
				}
			}
			GameRebuilder.CopyResource(sourceFile, destinationDirectory);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000284C0 File Offset: 0x000266C0
		private static void CopyResource(IArchiveResourceFile sourceResource, IArchiveDirectory targetDirectory)
		{
			MemoryStream memoryStream = new MemoryStream();
			sourceResource.Export(memoryStream);
			IArchiveResourceFile archiveResourceFile = targetDirectory.CreateResourceFile();
			archiveResourceFile.Name = sourceResource.Name;
			memoryStream.Position = 0L;
			archiveResourceFile.Import(memoryStream);
		}

		// Token: 0x040036DB RID: 14043
		public List<IRebuildBinaryFileHandler> BinaryFileHandlers = new List<IRebuildBinaryFileHandler>();

		// Token: 0x040036DC RID: 14044
		public List<IRebuildResourceFileHandler> ResourceFileHandlers = new List<IRebuildResourceFileHandler>();
	}
}
