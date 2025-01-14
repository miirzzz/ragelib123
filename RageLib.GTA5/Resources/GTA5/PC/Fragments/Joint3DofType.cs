using System;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000F8 RID: 248
	public class Joint3DofType : JointType
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00006A69 File Offset: 0x00004C69
		public override long Length
		{
			get
			{
				return 240L;
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001A40C File Offset: 0x0001860C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
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
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Unknown_60h = reader.ReadUInt32();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
			this.Unknown_80h = reader.ReadUInt32();
			this.Unknown_84h = reader.ReadUInt32();
			this.Unknown_88h = reader.ReadUInt32();
			this.Unknown_8Ch = reader.ReadUInt32();
			this.Unknown_90h = reader.ReadUInt32();
			this.Unknown_94h = reader.ReadUInt32();
			this.Unknown_98h = reader.ReadUInt32();
			this.Unknown_9Ch = reader.ReadUInt32();
			this.Unknown_A0h = reader.ReadUInt32();
			this.Unknown_A4h = reader.ReadUInt32();
			this.Unknown_A8h = reader.ReadUInt32();
			this.Unknown_ACh = reader.ReadUInt32();
			this.Unknown_B0h = reader.ReadUInt32();
			this.Unknown_B4h = reader.ReadUInt32();
			this.Unknown_B8h = reader.ReadUInt32();
			this.Unknown_BCh = reader.ReadUInt32();
			this.Unknown_C0h = reader.ReadUInt32();
			this.Unknown_C4h = reader.ReadUInt32();
			this.Unknown_C8h = reader.ReadUInt32();
			this.Unknown_CCh = reader.ReadUInt32();
			this.Unknown_D0h = reader.ReadUInt32();
			this.Unknown_D4h = reader.ReadUInt32();
			this.Unknown_D8h = reader.ReadUInt32();
			this.Unknown_DCh = reader.ReadUInt32();
			this.Unknown_E0h = reader.ReadUInt32();
			this.Unknown_E4h = reader.ReadUInt32();
			this.Unknown_E8h = reader.ReadUInt32();
			this.Unknown_ECh = reader.ReadUInt32();
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0001A694 File Offset: 0x00018894
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
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
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
			writer.Write(this.Unknown_80h);
			writer.Write(this.Unknown_84h);
			writer.Write(this.Unknown_88h);
			writer.Write(this.Unknown_8Ch);
			writer.Write(this.Unknown_90h);
			writer.Write(this.Unknown_94h);
			writer.Write(this.Unknown_98h);
			writer.Write(this.Unknown_9Ch);
			writer.Write(this.Unknown_A0h);
			writer.Write(this.Unknown_A4h);
			writer.Write(this.Unknown_A8h);
			writer.Write(this.Unknown_ACh);
			writer.Write(this.Unknown_B0h);
			writer.Write(this.Unknown_B4h);
			writer.Write(this.Unknown_B8h);
			writer.Write(this.Unknown_BCh);
			writer.Write(this.Unknown_C0h);
			writer.Write(this.Unknown_C4h);
			writer.Write(this.Unknown_C8h);
			writer.Write(this.Unknown_CCh);
			writer.Write(this.Unknown_D0h);
			writer.Write(this.Unknown_D4h);
			writer.Write(this.Unknown_D8h);
			writer.Write(this.Unknown_DCh);
			writer.Write(this.Unknown_E0h);
			writer.Write(this.Unknown_E4h);
			writer.Write(this.Unknown_E8h);
			writer.Write(this.Unknown_ECh);
		}

		// Token: 0x0400304D RID: 12365
		public uint Unknown_20h;

		// Token: 0x0400304E RID: 12366
		public uint Unknown_24h;

		// Token: 0x0400304F RID: 12367
		public uint Unknown_28h;

		// Token: 0x04003050 RID: 12368
		public uint Unknown_2Ch;

		// Token: 0x04003051 RID: 12369
		public uint Unknown_30h;

		// Token: 0x04003052 RID: 12370
		public uint Unknown_34h;

		// Token: 0x04003053 RID: 12371
		public uint Unknown_38h;

		// Token: 0x04003054 RID: 12372
		public uint Unknown_3Ch;

		// Token: 0x04003055 RID: 12373
		public uint Unknown_40h;

		// Token: 0x04003056 RID: 12374
		public uint Unknown_44h;

		// Token: 0x04003057 RID: 12375
		public uint Unknown_48h;

		// Token: 0x04003058 RID: 12376
		public uint Unknown_4Ch;

		// Token: 0x04003059 RID: 12377
		public uint Unknown_50h;

		// Token: 0x0400305A RID: 12378
		public uint Unknown_54h;

		// Token: 0x0400305B RID: 12379
		public uint Unknown_58h;

		// Token: 0x0400305C RID: 12380
		public uint Unknown_5Ch;

		// Token: 0x0400305D RID: 12381
		public uint Unknown_60h;

		// Token: 0x0400305E RID: 12382
		public uint Unknown_64h;

		// Token: 0x0400305F RID: 12383
		public uint Unknown_68h;

		// Token: 0x04003060 RID: 12384
		public uint Unknown_6Ch;

		// Token: 0x04003061 RID: 12385
		public uint Unknown_70h;

		// Token: 0x04003062 RID: 12386
		public uint Unknown_74h;

		// Token: 0x04003063 RID: 12387
		public uint Unknown_78h;

		// Token: 0x04003064 RID: 12388
		public uint Unknown_7Ch;

		// Token: 0x04003065 RID: 12389
		public uint Unknown_80h;

		// Token: 0x04003066 RID: 12390
		public uint Unknown_84h;

		// Token: 0x04003067 RID: 12391
		public uint Unknown_88h;

		// Token: 0x04003068 RID: 12392
		public uint Unknown_8Ch;

		// Token: 0x04003069 RID: 12393
		public uint Unknown_90h;

		// Token: 0x0400306A RID: 12394
		public uint Unknown_94h;

		// Token: 0x0400306B RID: 12395
		public uint Unknown_98h;

		// Token: 0x0400306C RID: 12396
		public uint Unknown_9Ch;

		// Token: 0x0400306D RID: 12397
		public uint Unknown_A0h;

		// Token: 0x0400306E RID: 12398
		public uint Unknown_A4h;

		// Token: 0x0400306F RID: 12399
		public uint Unknown_A8h;

		// Token: 0x04003070 RID: 12400
		public uint Unknown_ACh;

		// Token: 0x04003071 RID: 12401
		public uint Unknown_B0h;

		// Token: 0x04003072 RID: 12402
		public uint Unknown_B4h;

		// Token: 0x04003073 RID: 12403
		public uint Unknown_B8h;

		// Token: 0x04003074 RID: 12404
		public uint Unknown_BCh;

		// Token: 0x04003075 RID: 12405
		public uint Unknown_C0h;

		// Token: 0x04003076 RID: 12406
		public uint Unknown_C4h;

		// Token: 0x04003077 RID: 12407
		public uint Unknown_C8h;

		// Token: 0x04003078 RID: 12408
		public uint Unknown_CCh;

		// Token: 0x04003079 RID: 12409
		public uint Unknown_D0h;

		// Token: 0x0400307A RID: 12410
		public uint Unknown_D4h;

		// Token: 0x0400307B RID: 12411
		public uint Unknown_D8h;

		// Token: 0x0400307C RID: 12412
		public uint Unknown_DCh;

		// Token: 0x0400307D RID: 12413
		public uint Unknown_E0h;

		// Token: 0x0400307E RID: 12414
		public uint Unknown_E4h;

		// Token: 0x0400307F RID: 12415
		public uint Unknown_E8h;

		// Token: 0x04003080 RID: 12416
		public uint Unknown_ECh;
	}
}
