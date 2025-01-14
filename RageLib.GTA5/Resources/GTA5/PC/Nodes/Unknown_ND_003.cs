using System;

namespace RageLib.Resources.GTA5.PC.Nodes
{
	// Token: 0x02000055 RID: 85
	public class Unknown_ND_003 : ResourceSystemBlock
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002D6D File Offset: 0x00000F6D
		public override long Length
		{
			get
			{
				return 12L;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000B64B File Offset: 0x0000984B
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000B671 File Offset: 0x00009871
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
		}

		// Token: 0x04000419 RID: 1049
		public uint Unknown_0h;

		// Token: 0x0400041A RID: 1050
		public uint Unknown_4h;

		// Token: 0x0400041B RID: 1051
		public uint Unknown_8h;
	}
}
