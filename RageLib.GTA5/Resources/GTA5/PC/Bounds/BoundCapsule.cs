using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x02000169 RID: 361
	public class BoundCapsule : Bound
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0001EE55 File Offset: 0x0001D055
		public override long Length
		{
			get
			{
				return 128L;
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00025FCB File Offset: 0x000241CB
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00026005 File Offset: 0x00024205
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
		}

		// Token: 0x04003636 RID: 13878
		public uint Unknown_70h;

		// Token: 0x04003637 RID: 13879
		public uint Unknown_74h;

		// Token: 0x04003638 RID: 13880
		public uint Unknown_78h;

		// Token: 0x04003639 RID: 13881
		public uint Unknown_7Ch;
	}
}
