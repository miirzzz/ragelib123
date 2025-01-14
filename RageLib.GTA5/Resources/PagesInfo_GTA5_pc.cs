using System;

namespace RageLib.Resources
{
	// Token: 0x02000007 RID: 7
	public class PagesInfo_GTA5_pc : ResourceSystemBlock
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002875 File Offset: 0x00000A75
		public override long Length
		{
			get
			{
				return 20L;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000287C File Offset: 0x00000A7C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.SystemPagesCount = reader.ReadByte();
			this.GraphicsPagesCount = reader.ReadByte();
			this.Unknown_Ah = reader.ReadUInt16();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000028E0 File Offset: 0x00000AE0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.SystemPagesCount);
			writer.Write(this.GraphicsPagesCount);
			writer.Write(this.Unknown_Ah);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
		}

		// Token: 0x04000009 RID: 9
		public uint Unknown_0h;

		// Token: 0x0400000A RID: 10
		public uint Unknown_4h;

		// Token: 0x0400000B RID: 11
		public byte SystemPagesCount;

		// Token: 0x0400000C RID: 12
		public byte GraphicsPagesCount;

		// Token: 0x0400000D RID: 13
		public ushort Unknown_Ah;

		// Token: 0x0400000E RID: 14
		public uint Unknown_Ch;

		// Token: 0x0400000F RID: 15
		public uint Unknown_10h;
	}
}
