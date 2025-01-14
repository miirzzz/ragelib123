using System;

namespace RageLib.Resources.GTA5.PC.Nodes
{
	// Token: 0x02000056 RID: 86
	public class Unknown_ND_004 : ResourceSystemBlock
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000B613 File Offset: 0x00009813
		public override long Length
		{
			get
			{
				return 8L;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000B697 File Offset: 0x00009897
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt16();
			this.Unknown_2h = reader.ReadUInt16();
			this.Unknown_4h = reader.ReadUInt32();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000B6BD File Offset: 0x000098BD
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_2h);
			writer.Write(this.Unknown_4h);
		}

		// Token: 0x0400041C RID: 1052
		public ushort Unknown_0h;

		// Token: 0x0400041D RID: 1053
		public ushort Unknown_2h;

		// Token: 0x0400041E RID: 1054
		public uint Unknown_4h;
	}
}
