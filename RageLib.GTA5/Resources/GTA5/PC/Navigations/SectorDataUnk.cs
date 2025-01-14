using System;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x02000063 RID: 99
	public class SectorDataUnk : ResourceSystemBlock
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000B613 File Offset: 0x00009813
		public override long Length
		{
			get
			{
				return 8L;
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000D135 File Offset: 0x0000B335
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt16();
			this.Unknown_2h = reader.ReadUInt16();
			this.Unknown_4h = reader.ReadUInt16();
			this.Unknown_6h = reader.ReadUInt16();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000D167 File Offset: 0x0000B367
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_2h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_6h);
		}

		// Token: 0x040004DF RID: 1247
		public ushort Unknown_0h;

		// Token: 0x040004E0 RID: 1248
		public ushort Unknown_2h;

		// Token: 0x040004E1 RID: 1249
		public ushort Unknown_4h;

		// Token: 0x040004E2 RID: 1250
		public ushort Unknown_6h;
	}
}
