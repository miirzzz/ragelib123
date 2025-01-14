using System;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x02000060 RID: 96
	public class Portal : ResourceSystemBlock
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000CB05 File Offset: 0x0000AD05
		public override long Length
		{
			get
			{
				return 28L;
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000CB0C File Offset: 0x0000AD0C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt16();
			this.Unknown_12h = reader.ReadUInt16();
			this.Unknown_14h = reader.ReadUInt16();
			this.Unknown_16h = reader.ReadUInt16();
			this.Unknown_18h = reader.ReadUInt32();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000CB88 File Offset: 0x0000AD88
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_12h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_16h);
			writer.Write(this.Unknown_18h);
		}

		// Token: 0x040004B5 RID: 1205
		public uint Unknown_0h;

		// Token: 0x040004B6 RID: 1206
		public uint Unknown_4h;

		// Token: 0x040004B7 RID: 1207
		public uint Unknown_8h;

		// Token: 0x040004B8 RID: 1208
		public uint Unknown_Ch;

		// Token: 0x040004B9 RID: 1209
		public ushort Unknown_10h;

		// Token: 0x040004BA RID: 1210
		public ushort Unknown_12h;

		// Token: 0x040004BB RID: 1211
		public ushort Unknown_14h;

		// Token: 0x040004BC RID: 1212
		public ushort Unknown_16h;

		// Token: 0x040004BD RID: 1213
		public uint Unknown_18h;
	}
}
