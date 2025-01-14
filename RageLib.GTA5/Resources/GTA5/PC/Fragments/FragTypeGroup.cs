using System;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000F6 RID: 246
	public class FragTypeGroup : ResourceSystemBlock
	{
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00017799 File Offset: 0x00015999
		public override long Length
		{
			get
			{
				return 176L;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00019CBC File Offset: 0x00017EBC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
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
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
			this.Name = reader.ReadBlock<fragNameStruct>(Array.Empty<object>());
			this.Unknown_A0h = reader.ReadUInt32();
			this.Unknown_A4h = reader.ReadUInt32();
			this.Unknown_A8h = reader.ReadUInt32();
			this.Unknown_ACh = reader.ReadUInt32();
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00019E8C File Offset: 0x0001808C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
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
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
			writer.WriteBlock(this.Name);
			writer.Write(this.Unknown_A0h);
			writer.Write(this.Unknown_A4h);
			writer.Write(this.Unknown_A8h);
			writer.Write(this.Unknown_ACh);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001A055 File Offset: 0x00018255
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(128L, this.Name)
			};
		}

		// Token: 0x04003004 RID: 12292
		public uint Unknown_0h;

		// Token: 0x04003005 RID: 12293
		public uint Unknown_4h;

		// Token: 0x04003006 RID: 12294
		public uint Unknown_8h;

		// Token: 0x04003007 RID: 12295
		public uint Unknown_Ch;

		// Token: 0x04003008 RID: 12296
		public uint Unknown_10h;

		// Token: 0x04003009 RID: 12297
		public uint Unknown_14h;

		// Token: 0x0400300A RID: 12298
		public uint Unknown_18h;

		// Token: 0x0400300B RID: 12299
		public uint Unknown_1Ch;

		// Token: 0x0400300C RID: 12300
		public uint Unknown_20h;

		// Token: 0x0400300D RID: 12301
		public uint Unknown_24h;

		// Token: 0x0400300E RID: 12302
		public uint Unknown_28h;

		// Token: 0x0400300F RID: 12303
		public uint Unknown_2Ch;

		// Token: 0x04003010 RID: 12304
		public uint Unknown_30h;

		// Token: 0x04003011 RID: 12305
		public uint Unknown_34h;

		// Token: 0x04003012 RID: 12306
		public uint Unknown_38h;

		// Token: 0x04003013 RID: 12307
		public uint Unknown_3Ch;

		// Token: 0x04003014 RID: 12308
		public uint Unknown_40h;

		// Token: 0x04003015 RID: 12309
		public uint Unknown_44h;

		// Token: 0x04003016 RID: 12310
		public uint Unknown_48h;

		// Token: 0x04003017 RID: 12311
		public uint Unknown_4Ch;

		// Token: 0x04003018 RID: 12312
		public uint Unknown_50h;

		// Token: 0x04003019 RID: 12313
		public uint Unknown_54h;

		// Token: 0x0400301A RID: 12314
		public uint Unknown_58h;

		// Token: 0x0400301B RID: 12315
		public uint Unknown_5Ch;

		// Token: 0x0400301C RID: 12316
		public uint Unknown_60h;

		// Token: 0x0400301D RID: 12317
		public uint Unknown_64h;

		// Token: 0x0400301E RID: 12318
		public uint Unknown_68h;

		// Token: 0x0400301F RID: 12319
		public uint Unknown_6Ch;

		// Token: 0x04003020 RID: 12320
		public uint Unknown_70h;

		// Token: 0x04003021 RID: 12321
		public uint Unknown_74h;

		// Token: 0x04003022 RID: 12322
		public uint Unknown_78h;

		// Token: 0x04003023 RID: 12323
		public uint Unknown_7Ch;

		// Token: 0x04003024 RID: 12324
		public fragNameStruct Name;

		// Token: 0x04003025 RID: 12325
		public uint Unknown_A0h;

		// Token: 0x04003026 RID: 12326
		public uint Unknown_A4h;

		// Token: 0x04003027 RID: 12327
		public uint Unknown_A8h;

		// Token: 0x04003028 RID: 12328
		public uint Unknown_ACh;
	}
}
