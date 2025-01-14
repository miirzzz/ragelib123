using System;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x02000064 RID: 100
	public class Vertex : ResourceSystemBlock
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000D199 File Offset: 0x0000B399
		public override long Length
		{
			get
			{
				return 6L;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000D19D File Offset: 0x0000B39D
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt16();
			this.Unknown_2h = reader.ReadUInt16();
			this.Unknown_4h = reader.ReadUInt16();
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000D1C3 File Offset: 0x0000B3C3
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_2h);
			writer.Write(this.Unknown_4h);
		}

		// Token: 0x040004E3 RID: 1251
		public ushort Unknown_0h;

		// Token: 0x040004E4 RID: 1252
		public ushort Unknown_2h;

		// Token: 0x040004E5 RID: 1253
		public ushort Unknown_4h;
	}
}
