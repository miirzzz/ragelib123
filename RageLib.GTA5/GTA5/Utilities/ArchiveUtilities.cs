using System;
using System.IO;
using RageLib.Archives;
using RageLib.GTA5.Archives;
using RageLib.GTA5.ArchiveWrappers;

namespace RageLib.GTA5.Utilities
{
	// Token: 0x02000182 RID: 386
	public static class ArchiveUtilities
	{
		// Token: 0x060005FF RID: 1535 RVA: 0x000279BC File Offset: 0x00025BBC
		public static void ForEachBinaryFile(string gameDirectoryName, ProcessBinaryFileDelegate processDelegate, ErrorDelegate errorDelegate = null)
		{
			ArchiveUtilities.ForEachFile(gameDirectoryName, delegate(string fullFileName, IArchiveFile file, RageArchiveEncryption7 encryption)
			{
				if (file is IArchiveBinaryFile)
				{
					processDelegate(fullFileName, (IArchiveBinaryFile)file, encryption);
				}
			}, errorDelegate);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x000279EC File Offset: 0x00025BEC
		public static void ForEachResourceFile(string gameDirectoryName, ProcessResourceFileDelegate processDelegate, ErrorDelegate errorDelegate = null)
		{
			ArchiveUtilities.ForEachFile(gameDirectoryName, delegate(string fullFileName, IArchiveFile file, RageArchiveEncryption7 encryption)
			{
				if (file is IArchiveResourceFile)
				{
					processDelegate(fullFileName, (IArchiveResourceFile)file, encryption);
				}
			}, errorDelegate);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00027A1C File Offset: 0x00025C1C
		public static void ForEachFile(string gameDirectoryName, ProcessFileDelegate processDelegate, ErrorDelegate errorDelegate = null)
		{
			string[] files = Directory.GetFiles(gameDirectoryName, "*.rpf", SearchOption.AllDirectories);
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					string text = files[i];
					RageArchiveWrapper7 rageArchiveWrapper = RageArchiveWrapper7.Open(text);
					ArchiveUtilities.ForEachFile(text.Replace(gameDirectoryName, ""), rageArchiveWrapper.Root, rageArchiveWrapper.archive_.Encryption, processDelegate, null);
					rageArchiveWrapper.Dispose();
				}
				catch (Exception e)
				{
					if (errorDelegate != null)
					{
						errorDelegate(e);
					}
				}
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00027A98 File Offset: 0x00025C98
		public static void ForEachFile(string fullPathName, IArchiveDirectory directory, RageArchiveEncryption7 encryption, ProcessFileDelegate processDelegate, ErrorDelegate errorDelegate = null)
		{
			foreach (IArchiveFile archiveFile in directory.GetFiles())
			{
				processDelegate(fullPathName + "\\" + archiveFile.Name, archiveFile, encryption);
				if (archiveFile is IArchiveBinaryFile && archiveFile.Name.EndsWith(".rpf", StringComparison.OrdinalIgnoreCase))
				{
					try
					{
						RageArchiveWrapper7 rageArchiveWrapper = RageArchiveWrapper7.Open(((IArchiveBinaryFile)archiveFile).GetStream(), archiveFile.Name, false);
						ArchiveUtilities.ForEachFile(fullPathName + "\\" + archiveFile.Name, rageArchiveWrapper.Root, rageArchiveWrapper.archive_.Encryption, processDelegate, errorDelegate);
					}
					catch (Exception e)
					{
						if (errorDelegate != null)
						{
							errorDelegate(e);
						}
					}
				}
			}
			foreach (IArchiveDirectory archiveDirectory in directory.GetDirectories())
			{
				ArchiveUtilities.ForEachFile(fullPathName + "\\" + archiveDirectory.Name, archiveDirectory, encryption, processDelegate, null);
			}
		}
	}
}
