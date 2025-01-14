using System;
using System.IO;
using RageLib.Archives;
using RageLib.Data;
using RageLib.GTA5.Archives;

namespace RageLib.GTA5.ArchiveWrappers
{
	// Token: 0x020002AB RID: 683
	public class RageArchiveResourceFileWrapper7 : IArchiveResourceFile, IArchiveFile
	{
		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x000891C2 File Offset: 0x000873C2
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x000891CF File Offset: 0x000873CF
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

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x000891DD File Offset: 0x000873DD
		public long Size
		{
			get
			{
				return (long)((ulong)this.file.FileSize);
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000891EB File Offset: 0x000873EB
		internal RageArchiveResourceFileWrapper7(RageArchiveWrapper7 archiveWrapper, RageArchiveResourceFile7 file)
		{
			this.archiveWrapper = archiveWrapper;
			this.file = file;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00089204 File Offset: 0x00087404
		public void Import(string fileName)
		{
			using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
			{
				this.Import(fileStream);
			}
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0008923C File Offset: 0x0008743C
		public void Import(Stream stream)
		{
			PartialStream partialStream = new PartialStream(this.archiveWrapper.archive_.BaseStream, () => (long)((ulong)this.file.FileOffset * (ulong)((long)RageArchiveWrapper7.BLOCK_SIZE)), () => (long)((ulong)this.file.FileSize), delegate(long length)
			{
				this.archiveWrapper.RequestBytesRES(this.file, length);
			});
			partialStream.SetLength(stream.Length);
			DataReader dataReader = new DataReader(stream, Endianess.LittleEndian);
			dataReader.Position = 0L;
			dataReader.ReadUInt32();
			dataReader.ReadUInt32();
			uint systemFlags = dataReader.ReadUInt32();
			uint graphicsFlags = dataReader.ReadUInt32();
			dataReader.Position = 0L;
			byte[] array = dataReader.ReadBytes((int)stream.Length);
			this.file.SystemFlags = systemFlags;
			this.file.GraphicsFlags = graphicsFlags;
			partialStream.Write(array, 0, array.Length);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000892F0 File Offset: 0x000874F0
		public void Export(string fileName)
		{
			using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
			{
				this.Export(fileStream);
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00089328 File Offset: 0x00087528
		public void Export(Stream stream)
		{
			uint value = (this.file.GraphicsFlags & 4026531840U) >> 28 | (this.file.SystemFlags & 4026531840U) >> 24;
			DataWriter dataWriter = new DataWriter(stream, Endianess.LittleEndian);
			dataWriter.Write(121852754U);
			dataWriter.Write(value);
			dataWriter.Write(this.file.SystemFlags);
			dataWriter.Write(this.file.GraphicsFlags);
			DataReader dataReader = new DataReader(new PartialStream(this.archiveWrapper.archive_.BaseStream, () => (long)((ulong)this.file.FileOffset * (ulong)((long)RageArchiveWrapper7.BLOCK_SIZE)), () => (long)((ulong)this.file.FileSize), null), Endianess.LittleEndian);
			dataReader.Position = 16L;
			byte[] value2 = dataReader.ReadBytes((int)dataReader.Length - 16);
			dataWriter.Write(value2);
		}

		// Token: 0x0400400D RID: 16397
		private RageArchiveWrapper7 archiveWrapper;

		// Token: 0x0400400E RID: 16398
		private RageArchiveResourceFile7 file;
	}
}
