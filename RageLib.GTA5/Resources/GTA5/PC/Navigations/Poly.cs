using System;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x0200005D RID: 93
	public class Poly : ResourceSystemBlock
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000C780 File Offset: 0x0000A980
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x04000499 RID: 1177
		public uint Unknown_0h;

		// Token: 0x0400049A RID: 1178
		public uint Unknown_4h;

		// Token: 0x0400049B RID: 1179
		public uint Unknown_8h;

		// Token: 0x0400049C RID: 1180
		public uint Unknown_Ch;

		// Token: 0x0400049D RID: 1181
		public uint Unknown_10h;

		// Token: 0x0400049E RID: 1182
		public uint Unknown_14h;

		// Token: 0x0400049F RID: 1183
		public uint Unknown_18h;

		// Token: 0x040004A0 RID: 1184
		public uint Unknown_1Ch;

		// Token: 0x040004A1 RID: 1185
		public uint Unknown_20h;

		// Token: 0x040004A2 RID: 1186
		public uint Unknown_24h;

		// Token: 0x040004A3 RID: 1187
		public uint Unknown_28h;

		// Token: 0x040004A4 RID: 1188
		public uint Unknown_2Ch;
	}
}
