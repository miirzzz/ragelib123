using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x0200016B RID: 363
	public class BoundCylinder : Bound
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0001EE55 File Offset: 0x0001D055
		public override long Length
		{
			get
			{
				return 128L;
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00026407 File Offset: 0x00024607
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00026441 File Offset: 0x00024641
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
		}

		// Token: 0x0400364B RID: 13899
		public uint Unknown_70h;

		// Token: 0x0400364C RID: 13900
		public uint Unknown_74h;

		// Token: 0x0400364D RID: 13901
		public uint Unknown_78h;

		// Token: 0x0400364E RID: 13902
		public uint Unknown_7Ch;
	}
}
