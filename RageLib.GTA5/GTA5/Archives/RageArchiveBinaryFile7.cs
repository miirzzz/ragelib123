using System;
using RageLib.Data;

namespace RageLib.GTA5.Archives
{
	// Token: 0x020002B1 RID: 689
	public class RageArchiveBinaryFile7 : IRageArchiveFileEntry7, IRageArchiveEntry7
	{
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00089E10 File Offset: 0x00088010
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x00089E18 File Offset: 0x00088018
		public uint NameOffset { get; set; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00089E21 File Offset: 0x00088021
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x00089E29 File Offset: 0x00088029
		public uint FileSize { get; set; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00089E32 File Offset: 0x00088032
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00089E3A File Offset: 0x0008803A
		public uint FileOffset { get; set; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00089E43 File Offset: 0x00088043
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x00089E4B File Offset: 0x0008804B
		public uint FileUncompressedSize { get; set; }

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00089E54 File Offset: 0x00088054
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00089E5C File Offset: 0x0008805C
		public bool IsEncrypted { get; set; }

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00089E65 File Offset: 0x00088065
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x00089E6D File Offset: 0x0008806D
		public string Name { get; set; }

		// Token: 0x06000C57 RID: 3159 RVA: 0x00089E78 File Offset: 0x00088078
		public void Read(DataReader reader)
		{
			this.NameOffset = (uint)reader.ReadUInt16();
			byte[] array = reader.ReadBytes(3);
			this.FileSize = (uint)((int)array[0] + ((int)array[1] << 8) + ((int)array[2] << 16));
			byte[] array2 = reader.ReadBytes(3);
			this.FileOffset = (uint)((int)array2[0] + ((int)array2[1] << 8) + ((int)array2[2] << 16));
			this.FileUncompressedSize = reader.ReadUInt32();
			uint num = reader.ReadUInt32();
			if (num == 0U)
			{
				this.IsEncrypted = false;
				return;
			}
			if (num != 1U)
			{
				throw new Exception("Error in RPF7 file entry.");
			}
			this.IsEncrypted = true;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00089F04 File Offset: 0x00088104
		public void Write(DataWriter writer)
		{
			writer.Write((ushort)this.NameOffset);
			byte[] value = new byte[]
			{
				(byte)(this.FileSize & 255U),
				(byte)(this.FileSize >> 8 & 255U),
				(byte)(this.FileSize >> 16 & 255U)
			};
			writer.Write(value);
			byte[] value2 = new byte[]
			{
				(byte)(this.FileOffset & 255U),
				(byte)(this.FileOffset >> 8 & 255U),
				(byte)(this.FileOffset >> 16 & 255U)
			};
			writer.Write(value2);
			writer.Write(this.FileUncompressedSize);
			if (this.IsEncrypted)
			{
				writer.Write(1U);
				return;
			}
			writer.Write(0U);
		}
	}
}
