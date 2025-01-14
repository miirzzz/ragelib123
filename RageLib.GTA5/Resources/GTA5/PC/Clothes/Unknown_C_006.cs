using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x0200014B RID: 331
	public class Unknown_C_006 : ResourceSystemBlock
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00022969 File Offset: 0x00020B69
		public override long Length
		{
			get
			{
				return 400L;
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00022974 File Offset: 0x00020B74
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
			this.Unknown_50h = reader.ReadBlock<ResourceSimpleList64<RAGE_Vector4>>(Array.Empty<object>());
			this.Unknown_60h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_70h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_80h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_90h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_A0h = reader.ReadBlock<ResourceSimpleList64<RAGE_Vector4>>(Array.Empty<object>());
			this.Unknown_B0h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_C0h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_D0h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_E0h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_F0h = reader.ReadUInt32();
			this.Unknown_F4h = reader.ReadUInt32();
			this.Unknown_F8h = reader.ReadUInt32();
			this.Unknown_FCh = reader.ReadUInt32();
			this.Unknown_100h = reader.ReadUInt32();
			this.Unknown_104h = reader.ReadUInt32();
			this.Unknown_108h = reader.ReadUInt32();
			this.Unknown_10Ch = reader.ReadUInt32();
			this.Unknown_110h = reader.ReadUInt32();
			this.Unknown_114h = reader.ReadUInt32();
			this.Unknown_118h = reader.ReadUInt32();
			this.Unknown_11Ch = reader.ReadUInt32();
			this.Unknown_120h = reader.ReadUInt32();
			this.Unknown_124h = reader.ReadUInt32();
			this.Unknown_128h = reader.ReadUInt32();
			this.Unknown_12Ch = reader.ReadUInt32();
			this.Unknown_130h = reader.ReadUInt32();
			this.Unknown_134h = reader.ReadUInt32();
			this.Unknown_138h = reader.ReadUInt32();
			this.Unknown_13Ch = reader.ReadUInt32();
			this.Unknown_140h = reader.ReadUInt32();
			this.Unknown_144h = reader.ReadUInt32();
			this.Unknown_148h = reader.ReadUInt32();
			this.Unknown_14Ch = reader.ReadUInt32();
			this.Unknown_150h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_160h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_170h = reader.ReadUInt32();
			this.Unknown_174h = reader.ReadUInt32();
			this.Unknown_178h = reader.ReadUInt32();
			this.Unknown_17Ch = reader.ReadUInt32();
			this.Unknown_180h = reader.ReadUInt32();
			this.Unknown_184h = reader.ReadUInt32();
			this.Unknown_188h = reader.ReadUInt32();
			this.Unknown_18Ch = reader.ReadUInt32();
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00022CC0 File Offset: 0x00020EC0
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
			writer.WriteBlock(this.Unknown_50h);
			writer.WriteBlock(this.Unknown_60h);
			writer.WriteBlock(this.Unknown_70h);
			writer.WriteBlock(this.Unknown_80h);
			writer.WriteBlock(this.Unknown_90h);
			writer.WriteBlock(this.Unknown_A0h);
			writer.WriteBlock(this.Unknown_B0h);
			writer.WriteBlock(this.Unknown_C0h);
			writer.WriteBlock(this.Unknown_D0h);
			writer.WriteBlock(this.Unknown_E0h);
			writer.Write(this.Unknown_F0h);
			writer.Write(this.Unknown_F4h);
			writer.Write(this.Unknown_F8h);
			writer.Write(this.Unknown_FCh);
			writer.Write(this.Unknown_100h);
			writer.Write(this.Unknown_104h);
			writer.Write(this.Unknown_108h);
			writer.Write(this.Unknown_10Ch);
			writer.Write(this.Unknown_110h);
			writer.Write(this.Unknown_114h);
			writer.Write(this.Unknown_118h);
			writer.Write(this.Unknown_11Ch);
			writer.Write(this.Unknown_120h);
			writer.Write(this.Unknown_124h);
			writer.Write(this.Unknown_128h);
			writer.Write(this.Unknown_12Ch);
			writer.Write(this.Unknown_130h);
			writer.Write(this.Unknown_134h);
			writer.Write(this.Unknown_138h);
			writer.Write(this.Unknown_13Ch);
			writer.Write(this.Unknown_140h);
			writer.Write(this.Unknown_144h);
			writer.Write(this.Unknown_148h);
			writer.Write(this.Unknown_14Ch);
			writer.WriteBlock(this.Unknown_150h);
			writer.WriteBlock(this.Unknown_160h);
			writer.Write(this.Unknown_170h);
			writer.Write(this.Unknown_174h);
			writer.Write(this.Unknown_178h);
			writer.Write(this.Unknown_17Ch);
			writer.Write(this.Unknown_180h);
			writer.Write(this.Unknown_184h);
			writer.Write(this.Unknown_188h);
			writer.Write(this.Unknown_18Ch);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00022FD0 File Offset: 0x000211D0
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(80L, this.Unknown_50h),
				new Tuple<long, IResourceBlock>(96L, this.Unknown_60h),
				new Tuple<long, IResourceBlock>(112L, this.Unknown_70h),
				new Tuple<long, IResourceBlock>(128L, this.Unknown_80h),
				new Tuple<long, IResourceBlock>(144L, this.Unknown_90h),
				new Tuple<long, IResourceBlock>(160L, this.Unknown_A0h),
				new Tuple<long, IResourceBlock>(176L, this.Unknown_B0h),
				new Tuple<long, IResourceBlock>(192L, this.Unknown_C0h),
				new Tuple<long, IResourceBlock>(208L, this.Unknown_D0h),
				new Tuple<long, IResourceBlock>(224L, this.Unknown_E0h),
				new Tuple<long, IResourceBlock>(336L, this.Unknown_150h),
				new Tuple<long, IResourceBlock>(352L, this.Unknown_160h)
			};
		}

		// Token: 0x040034AC RID: 13484
		public uint Unknown_0h;

		// Token: 0x040034AD RID: 13485
		public uint Unknown_4h;

		// Token: 0x040034AE RID: 13486
		public uint Unknown_8h;

		// Token: 0x040034AF RID: 13487
		public uint Unknown_Ch;

		// Token: 0x040034B0 RID: 13488
		public uint Unknown_10h;

		// Token: 0x040034B1 RID: 13489
		public uint Unknown_14h;

		// Token: 0x040034B2 RID: 13490
		public uint Unknown_18h;

		// Token: 0x040034B3 RID: 13491
		public uint Unknown_1Ch;

		// Token: 0x040034B4 RID: 13492
		public uint Unknown_20h;

		// Token: 0x040034B5 RID: 13493
		public uint Unknown_24h;

		// Token: 0x040034B6 RID: 13494
		public uint Unknown_28h;

		// Token: 0x040034B7 RID: 13495
		public uint Unknown_2Ch;

		// Token: 0x040034B8 RID: 13496
		public uint Unknown_30h;

		// Token: 0x040034B9 RID: 13497
		public uint Unknown_34h;

		// Token: 0x040034BA RID: 13498
		public uint Unknown_38h;

		// Token: 0x040034BB RID: 13499
		public uint Unknown_3Ch;

		// Token: 0x040034BC RID: 13500
		public uint Unknown_40h;

		// Token: 0x040034BD RID: 13501
		public uint Unknown_44h;

		// Token: 0x040034BE RID: 13502
		public uint Unknown_48h;

		// Token: 0x040034BF RID: 13503
		public uint Unknown_4Ch;

		// Token: 0x040034C0 RID: 13504
		public ResourceSimpleList64<RAGE_Vector4> Unknown_50h;

		// Token: 0x040034C1 RID: 13505
		public ResourceSimpleList64<ushort_r> Unknown_60h;

		// Token: 0x040034C2 RID: 13506
		public ResourceSimpleList64<ushort_r> Unknown_70h;

		// Token: 0x040034C3 RID: 13507
		public ResourceSimpleList64<ushort_r> Unknown_80h;

		// Token: 0x040034C4 RID: 13508
		public ResourceSimpleList64<ushort_r> Unknown_90h;

		// Token: 0x040034C5 RID: 13509
		public ResourceSimpleList64<RAGE_Vector4> Unknown_A0h;

		// Token: 0x040034C6 RID: 13510
		public ResourceSimpleList64<ushort_r> Unknown_B0h;

		// Token: 0x040034C7 RID: 13511
		public ResourceSimpleList64<ushort_r> Unknown_C0h;

		// Token: 0x040034C8 RID: 13512
		public ResourceSimpleList64<ushort_r> Unknown_D0h;

		// Token: 0x040034C9 RID: 13513
		public ResourceSimpleList64<ushort_r> Unknown_E0h;

		// Token: 0x040034CA RID: 13514
		public uint Unknown_F0h;

		// Token: 0x040034CB RID: 13515
		public uint Unknown_F4h;

		// Token: 0x040034CC RID: 13516
		public uint Unknown_F8h;

		// Token: 0x040034CD RID: 13517
		public uint Unknown_FCh;

		// Token: 0x040034CE RID: 13518
		public uint Unknown_100h;

		// Token: 0x040034CF RID: 13519
		public uint Unknown_104h;

		// Token: 0x040034D0 RID: 13520
		public uint Unknown_108h;

		// Token: 0x040034D1 RID: 13521
		public uint Unknown_10Ch;

		// Token: 0x040034D2 RID: 13522
		public uint Unknown_110h;

		// Token: 0x040034D3 RID: 13523
		public uint Unknown_114h;

		// Token: 0x040034D4 RID: 13524
		public uint Unknown_118h;

		// Token: 0x040034D5 RID: 13525
		public uint Unknown_11Ch;

		// Token: 0x040034D6 RID: 13526
		public uint Unknown_120h;

		// Token: 0x040034D7 RID: 13527
		public uint Unknown_124h;

		// Token: 0x040034D8 RID: 13528
		public uint Unknown_128h;

		// Token: 0x040034D9 RID: 13529
		public uint Unknown_12Ch;

		// Token: 0x040034DA RID: 13530
		public uint Unknown_130h;

		// Token: 0x040034DB RID: 13531
		public uint Unknown_134h;

		// Token: 0x040034DC RID: 13532
		public uint Unknown_138h;

		// Token: 0x040034DD RID: 13533
		public uint Unknown_13Ch;

		// Token: 0x040034DE RID: 13534
		public uint Unknown_140h;

		// Token: 0x040034DF RID: 13535
		public uint Unknown_144h;

		// Token: 0x040034E0 RID: 13536
		public uint Unknown_148h;

		// Token: 0x040034E1 RID: 13537
		public uint Unknown_14Ch;

		// Token: 0x040034E2 RID: 13538
		public ResourceSimpleList64<ushort_r> Unknown_150h;

		// Token: 0x040034E3 RID: 13539
		public ResourceSimpleList64<ushort_r> Unknown_160h;

		// Token: 0x040034E4 RID: 13540
		public uint Unknown_170h;

		// Token: 0x040034E5 RID: 13541
		public uint Unknown_174h;

		// Token: 0x040034E6 RID: 13542
		public uint Unknown_178h;

		// Token: 0x040034E7 RID: 13543
		public uint Unknown_17Ch;

		// Token: 0x040034E8 RID: 13544
		public uint Unknown_180h;

		// Token: 0x040034E9 RID: 13545
		public uint Unknown_184h;

		// Token: 0x040034EA RID: 13546
		public uint Unknown_188h;

		// Token: 0x040034EB RID: 13547
		public uint Unknown_18Ch;
	}
}
