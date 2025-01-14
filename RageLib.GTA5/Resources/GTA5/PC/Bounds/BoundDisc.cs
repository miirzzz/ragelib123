using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x0200016D RID: 365
	public class BoundDisc : Bound
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001EE55 File Offset: 0x0001D055
		public override long Length
		{
			get
			{
				return 128L;
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0002656B File Offset: 0x0002476B
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000265A5 File Offset: 0x000247A5
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
		}

		// Token: 0x04003655 RID: 13909
		public uint Unknown_70h;

		// Token: 0x04003656 RID: 13910
		public uint Unknown_74h;

		// Token: 0x04003657 RID: 13911
		public uint Unknown_78h;

		// Token: 0x04003658 RID: 13912
		public uint Unknown_7Ch;
	}
}
