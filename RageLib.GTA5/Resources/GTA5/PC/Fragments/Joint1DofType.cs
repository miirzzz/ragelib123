using System;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000F7 RID: 247
	public class Joint1DofType : JointType
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00017799 File Offset: 0x00015999
		public override long Length
		{
			get
			{
				return 176L;
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0001A074 File Offset: 0x00018274
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
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0001A23C File Offset: 0x0001843C
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
		}

		// Token: 0x04003029 RID: 12329
		public uint Unknown_20h;

		// Token: 0x0400302A RID: 12330
		public uint Unknown_24h;

		// Token: 0x0400302B RID: 12331
		public uint Unknown_28h;

		// Token: 0x0400302C RID: 12332
		public uint Unknown_2Ch;

		// Token: 0x0400302D RID: 12333
		public uint Unknown_30h;

		// Token: 0x0400302E RID: 12334
		public uint Unknown_34h;

		// Token: 0x0400302F RID: 12335
		public uint Unknown_38h;

		// Token: 0x04003030 RID: 12336
		public uint Unknown_3Ch;

		// Token: 0x04003031 RID: 12337
		public uint Unknown_40h;

		// Token: 0x04003032 RID: 12338
		public uint Unknown_44h;

		// Token: 0x04003033 RID: 12339
		public uint Unknown_48h;

		// Token: 0x04003034 RID: 12340
		public uint Unknown_4Ch;

		// Token: 0x04003035 RID: 12341
		public uint Unknown_50h;

		// Token: 0x04003036 RID: 12342
		public uint Unknown_54h;

		// Token: 0x04003037 RID: 12343
		public uint Unknown_58h;

		// Token: 0x04003038 RID: 12344
		public uint Unknown_5Ch;

		// Token: 0x04003039 RID: 12345
		public uint Unknown_60h;

		// Token: 0x0400303A RID: 12346
		public uint Unknown_64h;

		// Token: 0x0400303B RID: 12347
		public uint Unknown_68h;

		// Token: 0x0400303C RID: 12348
		public uint Unknown_6Ch;

		// Token: 0x0400303D RID: 12349
		public uint Unknown_70h;

		// Token: 0x0400303E RID: 12350
		public uint Unknown_74h;

		// Token: 0x0400303F RID: 12351
		public uint Unknown_78h;

		// Token: 0x04003040 RID: 12352
		public uint Unknown_7Ch;

		// Token: 0x04003041 RID: 12353
		public uint Unknown_80h;

		// Token: 0x04003042 RID: 12354
		public uint Unknown_84h;

		// Token: 0x04003043 RID: 12355
		public uint Unknown_88h;

		// Token: 0x04003044 RID: 12356
		public uint Unknown_8Ch;

		// Token: 0x04003045 RID: 12357
		public uint Unknown_90h;

		// Token: 0x04003046 RID: 12358
		public uint Unknown_94h;

		// Token: 0x04003047 RID: 12359
		public uint Unknown_98h;

		// Token: 0x04003048 RID: 12360
		public uint Unknown_9Ch;

		// Token: 0x04003049 RID: 12361
		public uint Unknown_A0h;

		// Token: 0x0400304A RID: 12362
		public uint Unknown_A4h;

		// Token: 0x0400304B RID: 12363
		public uint Unknown_A8h;

		// Token: 0x0400304C RID: 12364
		public uint Unknown_ACh;
	}
}
