using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200002D RID: 45
	public class BehaviourSprite : Behaviour
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000067F5 File Offset: 0x000049F5
		public override long Length
		{
			get
			{
				return 112L;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000067FC File Offset: 0x000049FC
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
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Unknown_60h = reader.ReadUInt32();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00006934 File Offset: 0x00004B34
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
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
		}

		// Token: 0x040001BA RID: 442
		public uint Unknown_10h;

		// Token: 0x040001BB RID: 443
		public uint Unknown_14h;

		// Token: 0x040001BC RID: 444
		public uint Unknown_18h;

		// Token: 0x040001BD RID: 445
		public uint Unknown_1Ch;

		// Token: 0x040001BE RID: 446
		public uint Unknown_20h;

		// Token: 0x040001BF RID: 447
		public uint Unknown_24h;

		// Token: 0x040001C0 RID: 448
		public uint Unknown_28h;

		// Token: 0x040001C1 RID: 449
		public uint Unknown_2Ch;

		// Token: 0x040001C2 RID: 450
		public uint Unknown_30h;

		// Token: 0x040001C3 RID: 451
		public uint Unknown_34h;

		// Token: 0x040001C4 RID: 452
		public uint Unknown_38h;

		// Token: 0x040001C5 RID: 453
		public uint Unknown_3Ch;

		// Token: 0x040001C6 RID: 454
		public uint Unknown_40h;

		// Token: 0x040001C7 RID: 455
		public uint Unknown_44h;

		// Token: 0x040001C8 RID: 456
		public uint Unknown_48h;

		// Token: 0x040001C9 RID: 457
		public uint Unknown_4Ch;

		// Token: 0x040001CA RID: 458
		public uint Unknown_50h;

		// Token: 0x040001CB RID: 459
		public uint Unknown_54h;

		// Token: 0x040001CC RID: 460
		public uint Unknown_58h;

		// Token: 0x040001CD RID: 461
		public uint Unknown_5Ch;

		// Token: 0x040001CE RID: 462
		public uint Unknown_60h;

		// Token: 0x040001CF RID: 463
		public uint Unknown_64h;

		// Token: 0x040001D0 RID: 464
		public uint Unknown_68h;

		// Token: 0x040001D1 RID: 465
		public uint Unknown_6Ch;
	}
}
