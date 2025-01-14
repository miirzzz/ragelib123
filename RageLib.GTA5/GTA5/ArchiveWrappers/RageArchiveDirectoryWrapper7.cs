using System;
using System.Collections.Generic;
using RageLib.Archives;
using RageLib.GTA5.Archives;

namespace RageLib.GTA5.ArchiveWrappers
{
	// Token: 0x020002A9 RID: 681
	public class RageArchiveDirectoryWrapper7 : IArchiveDirectory, IDisposable
	{
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x00088C64 File Offset: 0x00086E64
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x00088C71 File Offset: 0x00086E71
		public string Name
		{
			get
			{
				return this.directory.Name;
			}
			set
			{
				this.directory.Name = value;
			}
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00088C7F File Offset: 0x00086E7F
		internal RageArchiveDirectoryWrapper7(RageArchiveWrapper7 archiveWrapper, RageArchiveDirectory7 directory)
		{
			this.archiveWrapper = archiveWrapper;
			this.directory = directory;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00088C98 File Offset: 0x00086E98
		public IArchiveDirectory[] GetDirectories()
		{
			List<IArchiveDirectory> list = new List<IArchiveDirectory>();
			foreach (RageArchiveDirectory7 rageArchiveDirectory in this.directory.Directories)
			{
				RageArchiveDirectoryWrapper7 item = new RageArchiveDirectoryWrapper7(this.archiveWrapper, rageArchiveDirectory);
				list.Add(item);
			}
			return list.ToArray();
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00088D0C File Offset: 0x00086F0C
		public IArchiveDirectory GetDirectory(string name)
		{
			foreach (RageArchiveDirectory7 rageArchiveDirectory in this.directory.Directories)
			{
				if (rageArchiveDirectory.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return new RageArchiveDirectoryWrapper7(this.archiveWrapper, rageArchiveDirectory);
				}
			}
			return null;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00088D80 File Offset: 0x00086F80
		public IArchiveDirectory CreateDirectory()
		{
			RageArchiveDirectory7 item = new RageArchiveDirectory7();
			IArchiveDirectory result = new RageArchiveDirectoryWrapper7(this.archiveWrapper, item);
			this.directory.Directories.Add(item);
			return result;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00088DB0 File Offset: 0x00086FB0
		public void DeleteDirectory(IArchiveDirectory directory)
		{
			this.directory.Directories.Remove(((RageArchiveDirectoryWrapper7)directory).directory);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00088DD0 File Offset: 0x00086FD0
		public IArchiveFile[] GetFiles()
		{
			List<IArchiveFile> list = new List<IArchiveFile>();
			foreach (IRageArchiveEntry7 rageArchiveEntry in this.directory.Files)
			{
				if (rageArchiveEntry is RageArchiveBinaryFile7)
				{
					list.Add(new RageArchiveBinaryFileWrapper7(this.archiveWrapper, (RageArchiveBinaryFile7)rageArchiveEntry));
				}
				if (rageArchiveEntry is RageArchiveResourceFile7)
				{
					list.Add(new RageArchiveResourceFileWrapper7(this.archiveWrapper, (RageArchiveResourceFile7)rageArchiveEntry));
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00088E6C File Offset: 0x0008706C
		public IArchiveFile GetFile(string name)
		{
			foreach (IRageArchiveEntry7 rageArchiveEntry in this.directory.Files)
			{
				if (rageArchiveEntry.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					if (rageArchiveEntry is RageArchiveResourceFile7)
					{
						return new RageArchiveResourceFileWrapper7(this.archiveWrapper, (RageArchiveResourceFile7)rageArchiveEntry);
					}
					return new RageArchiveBinaryFileWrapper7(this.archiveWrapper, (RageArchiveBinaryFile7)rageArchiveEntry);
				}
			}
			return null;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00088F00 File Offset: 0x00087100
		public IArchiveBinaryFile CreateBinaryFile()
		{
			RageArchiveBinaryFile7 rageArchiveBinaryFile = new RageArchiveBinaryFile7();
			IArchiveBinaryFile result = new RageArchiveBinaryFileWrapper7(this.archiveWrapper, rageArchiveBinaryFile);
			rageArchiveBinaryFile.Name = "";
			long num = this.archiveWrapper.FindSpace(64L);
			rageArchiveBinaryFile.FileOffset = (uint)(num / 512L);
			this.directory.Files.Add(rageArchiveBinaryFile);
			return result;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00088F5C File Offset: 0x0008715C
		public IArchiveResourceFile CreateResourceFile()
		{
			RageArchiveResourceFile7 rageArchiveResourceFile = new RageArchiveResourceFile7();
			IArchiveResourceFile result = new RageArchiveResourceFileWrapper7(this.archiveWrapper, rageArchiveResourceFile);
			rageArchiveResourceFile.Name = "";
			long num = this.archiveWrapper.FindSpace(64L);
			rageArchiveResourceFile.FileOffset = (uint)(num / 512L);
			this.directory.Files.Add(rageArchiveResourceFile);
			return result;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00088FB8 File Offset: 0x000871B8
		public void DeleteFile(IArchiveFile file)
		{
			IRageArchiveEntry7 rageArchiveEntry = this.directory.Files.Find((IRageArchiveEntry7 e) => e.Name == file.Name);
			if (rageArchiveEntry != null)
			{
				this.directory.Files.Remove(rageArchiveEntry);
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00089004 File Offset: 0x00087204
		public void Dispose()
		{
			this.archiveWrapper = null;
			this.directory = null;
		}

		// Token: 0x04004009 RID: 16393
		private RageArchiveWrapper7 archiveWrapper;

		// Token: 0x0400400A RID: 16394
		internal RageArchiveDirectory7 directory;
	}
}
