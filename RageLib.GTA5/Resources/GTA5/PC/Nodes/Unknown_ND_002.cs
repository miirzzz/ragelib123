using System;

namespace RageLib.Resources.GTA5.PC.Nodes
{
	// Token: 0x02000054 RID: 84
	public class Unknown_ND_002 : ResourceSystemBlock
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000B613 File Offset: 0x00009813
		public override long Length
		{
			get
			{
				return 8L;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000B617 File Offset: 0x00009817
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000B631 File Offset: 0x00009831
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
		}

		// Token: 0x04000417 RID: 1047
		public uint Unknown_0h;

		// Token: 0x04000418 RID: 1048
		public uint Unknown_4h;
	}
}
