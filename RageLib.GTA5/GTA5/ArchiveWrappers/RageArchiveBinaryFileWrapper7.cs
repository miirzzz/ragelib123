using System;
using System.IO;
using RageLib.Archives;
using RageLib.GTA5.Archives;

namespace RageLib.GTA5.ArchiveWrappers
{
	// Token: 0x020002AA RID: 682
	public class RageArchiveBinaryFileWrapper7 : IArchiveBinaryFile, IArchiveFile
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00089014 File Offset: 0x00087214
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00089021 File Offset: 0x00087221
		public string Name
		{
			get
			{
				return this.file.Name;
			}
			set
			{
				this.file.Name = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0008902F File Offset: 0x0008722F
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x0008903C File Offset: 0x0008723C
		public bool IsEncrypted
		{
			get
			{
				return this.file.IsEncrypted;
			}
			set
			{
				this.file.IsEncrypted = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x0008904A File Offset: 0x0008724A
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x0008905A File Offset: 0x0008725A
		public bool IsCompressed
		{
			get
			{
				return this.file.FileSize > 0U;
			}
			set
			{
				if (value)
				{
					this.file.FileSize = this.file.FileUncompressedSize;
					return;
				}
				this.file.FileUncompressedSize = this.file.FileSize;
				this.file.FileSize = 0U;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00089098 File Offset: 0x00087298
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x000890A6 File Offset: 0x000872A6
		public long UncompressedSize
		{
			get
			{
				return (long)((ulong)this.file.FileUncompressedSize);
			}
			set
			{
				this.file.FileUncompressedSize = (uint)value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x000890B5 File Offset: 0x000872B5
		public long CompressedSize
		{
			get
			{
				return (long)((ulong)this.file.FileSize);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x000890C3 File Offset: 0x000872C3
		public long Size
		{
			get
			{
				if (this.file.FileSize != 0U)
				{
					return (long)((ulong)this.file.FileSize);
				}
				return (long)((ulong)this.file.FileUncompressedSize);
			}
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000890EB File Offset: 0x000872EB
		internal RageArchiveBinaryFileWrapper7(RageArchiveWrapper7 archiveWrapper, RageArchiveBinaryFile7 file)
		{
			this.archiveWrapper = archiveWrapper;
			this.file = file;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00089101 File Offset: 0x00087301
		public Stream GetStream()
		{
			return this.archiveWrapper.GetStream(this.file);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00089114 File Offset: 0x00087314
		public void Import(string fileName)
		{
			using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
			{
				this.Import(fileStream);
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0008914C File Offset: 0x0008734C
		public void Import(Stream stream)
		{
			Stream stream2 = this.GetStream();
			stream2.SetLength(stream.Length);
			stream.Position = 0L;
			stream.CopyTo(stream2);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0008917C File Offset: 0x0008737C
		public void Export(string fileName)
		{
			using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
			{
				this.Export(fileStream);
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000891B4 File Offset: 0x000873B4
		public void Export(Stream stream)
		{
			this.GetStream().CopyTo(stream);
		}

		// Token: 0x0400400B RID: 16395
		internal RageArchiveWrapper7 archiveWrapper;

		// Token: 0x0400400C RID: 16396
		internal RageArchiveBinaryFile7 file;
	}
}
