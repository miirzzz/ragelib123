using System;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x02000057 RID: 87
	public class AdjPoly : ResourceSystemBlock
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000B613 File Offset: 0x00009813
		public override long Length
		{
			get
			{
				return 8L;
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000B6E3 File Offset: 0x000098E3
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000B6FD File Offset: 0x000098FD
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
		}

		// Token: 0x0400041F RID: 1055
		public uint Unknown_0h;

		// Token: 0x04000420 RID: 1056
		public uint Unknown_4h;
	}
}
