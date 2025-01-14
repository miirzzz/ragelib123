using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000023 RID: 35
	public class BehaviourDecalPool : Behaviour
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000553F File Offset: 0x0000373F
		public override long Length
		{
			get
			{
				return 80L;
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00005544 File Offset: 0x00003744
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
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000561C File Offset: 0x0000381C
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
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
		}

		// Token: 0x0400012F RID: 303
		public uint Unknown_10h;

		// Token: 0x04000130 RID: 304
		public uint Unknown_14h;

		// Token: 0x04000131 RID: 305
		public uint Unknown_18h;

		// Token: 0x04000132 RID: 306
		public uint Unknown_1Ch;

		// Token: 0x04000133 RID: 307
		public uint Unknown_20h;

		// Token: 0x04000134 RID: 308
		public uint Unknown_24h;

		// Token: 0x04000135 RID: 309
		public uint Unknown_28h;

		// Token: 0x04000136 RID: 310
		public uint Unknown_2Ch;

		// Token: 0x04000137 RID: 311
		public uint Unknown_30h;

		// Token: 0x04000138 RID: 312
		public uint Unknown_34h;

		// Token: 0x04000139 RID: 313
		public uint Unknown_38h;

		// Token: 0x0400013A RID: 314
		public uint Unknown_3Ch;

		// Token: 0x0400013B RID: 315
		public uint Unknown_40h;

		// Token: 0x0400013C RID: 316
		public uint Unknown_44h;

		// Token: 0x0400013D RID: 317
		public uint Unknown_48h;

		// Token: 0x0400013E RID: 318
		public uint Unknown_4Ch;
	}
}
