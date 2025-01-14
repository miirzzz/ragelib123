using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200002F RID: 47
	public class BehaviourVelocity : Behaviour
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006C84 File Offset: 0x00004E84
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006CFC File Offset: 0x00004EFC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x040001E4 RID: 484
		public uint Unknown_10h;

		// Token: 0x040001E5 RID: 485
		public uint Unknown_14h;

		// Token: 0x040001E6 RID: 486
		public uint Unknown_18h;

		// Token: 0x040001E7 RID: 487
		public uint Unknown_1Ch;

		// Token: 0x040001E8 RID: 488
		public uint Unknown_20h;

		// Token: 0x040001E9 RID: 489
		public uint Unknown_24h;

		// Token: 0x040001EA RID: 490
		public uint Unknown_28h;

		// Token: 0x040001EB RID: 491
		public uint Unknown_2Ch;
	}
}
