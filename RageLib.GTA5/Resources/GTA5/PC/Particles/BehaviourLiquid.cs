using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000026 RID: 38
	public class BehaviourLiquid : Behaviour
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000553F File Offset: 0x0000373F
		public override long Length
		{
			get
			{
				return 80L;
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005C74 File Offset: 0x00003E74
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

		// Token: 0x060000F8 RID: 248 RVA: 0x00005D4C File Offset: 0x00003F4C
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

		// Token: 0x04000161 RID: 353
		public uint Unknown_10h;

		// Token: 0x04000162 RID: 354
		public uint Unknown_14h;

		// Token: 0x04000163 RID: 355
		public uint Unknown_18h;

		// Token: 0x04000164 RID: 356
		public uint Unknown_1Ch;

		// Token: 0x04000165 RID: 357
		public uint Unknown_20h;

		// Token: 0x04000166 RID: 358
		public uint Unknown_24h;

		// Token: 0x04000167 RID: 359
		public uint Unknown_28h;

		// Token: 0x04000168 RID: 360
		public uint Unknown_2Ch;

		// Token: 0x04000169 RID: 361
		public uint Unknown_30h;

		// Token: 0x0400016A RID: 362
		public uint Unknown_34h;

		// Token: 0x0400016B RID: 363
		public uint Unknown_38h;

		// Token: 0x0400016C RID: 364
		public uint Unknown_3Ch;

		// Token: 0x0400016D RID: 365
		public uint Unknown_40h;

		// Token: 0x0400016E RID: 366
		public uint Unknown_44h;

		// Token: 0x0400016F RID: 367
		public uint Unknown_48h;

		// Token: 0x04000170 RID: 368
		public uint Unknown_4Ch;
	}
}
