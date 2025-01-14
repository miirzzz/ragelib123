using System;
using RageLib.Data;

namespace RageLib.GTA5.Archives
{
	// Token: 0x020002B2 RID: 690
	public class RageArchiveResourceFile7 : IRageArchiveFileEntry7, IRageArchiveEntry7
	{
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00089FC7 File Offset: 0x000881C7
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x00089FCF File Offset: 0x000881CF
		public uint NameOffset { get; set; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00089FD8 File Offset: 0x000881D8
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00089FE0 File Offset: 0x000881E0
		public uint FileSize { get; set; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00089FE9 File Offset: 0x000881E9
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x00089FF1 File Offset: 0x000881F1
		public uint FileOffset { get; set; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x00089FFA File Offset: 0x000881FA
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x0008A002 File Offset: 0x00088202
		public uint SystemFlags { get; set; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0008A00B File Offset: 0x0008820B
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x0008A013 File Offset: 0x00088213
		public uint GraphicsFlags { get; set; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0008A01C File Offset: 0x0008821C
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x0008A024 File Offset: 0x00088224
		public string Name { get; set; }

		// Token: 0x06000C66 RID: 3174 RVA: 0x0008A030 File Offset: 0x00088230
		public void Read(DataReader reader)
		{
			this.NameOffset = (uint)reader.ReadUInt16();
			byte[] array = reader.ReadBytes(3);
			this.FileSize = (uint)((int)array[0] + ((int)array[1] << 8) + ((int)array[2] << 16));
			byte[] array2 = reader.ReadBytes(3);
			this.FileOffset = (uint)((int)array2[0] + ((int)array2[1] << 8) + ((int)array2[2] << 16) & 8388607);
			this.SystemFlags = reader.ReadUInt32();
			this.GraphicsFlags = reader.ReadUInt32();
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0008A0A4 File Offset: 0x000882A4
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
				(byte)((this.FileOffset >> 16 & 255U) | 128U)
			};
			writer.Write(value2);
			writer.Write(this.SystemFlags);
			writer.Write(this.GraphicsFlags);
		}
	}
}
