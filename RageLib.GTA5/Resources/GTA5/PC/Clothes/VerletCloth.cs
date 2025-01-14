using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Bounds;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x0200014D RID: 333
	public class VerletCloth : ResourceSystemBlock
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x000052F7 File Offset: 0x000034F7
		public override long Length
		{
			get
			{
				return 384L;
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00023134 File Offset: 0x00021334
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.BoundPointer = reader.ReadUInt64();
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
			this.Unknown_70h = reader.ReadBlock<ResourceSimpleList64<RAGE_Vector4>>(Array.Empty<object>());
			this.Unknown_80h = reader.ReadBlock<ResourceSimpleList64<RAGE_Vector4>>(Array.Empty<object>());
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
			this.Unknown_F0h = reader.ReadUInt32();
			this.Unknown_F4h = reader.ReadUInt32();
			this.Unknown_F8h = reader.ReadUInt32();
			this.Unknown_FCh = reader.ReadUInt32();
			this.Unknown_100h = reader.ReadBlock<ResourceSimpleList64<Unknown_C_004>>(Array.Empty<object>());
			this.Unknown_110h = reader.ReadBlock<ResourceSimpleList64<Unknown_C_004>>(Array.Empty<object>());
			this.Unknown_120h = reader.ReadUInt32();
			this.Unknown_124h = reader.ReadUInt32();
			this.Unknown_128h = reader.ReadUInt32();
			this.Unknown_12Ch = reader.ReadUInt32();
			this.BehaviorPointer = reader.ReadUInt64();
			this.Unknown_138h = reader.ReadUInt32();
			this.Unknown_13Ch = reader.ReadUInt32();
			this.Unknown_140h_Pointer = reader.ReadUInt64();
			this.Unknown_148h = reader.ReadUInt32();
			this.Unknown_14Ch = reader.ReadUInt32();
			this.Unknown_150h = reader.ReadUInt32();
			this.Unknown_154h = reader.ReadUInt32();
			this.Unknown_158h = reader.ReadUInt32();
			this.Unknown_15Ch = reader.ReadUInt32();
			this.Unknown_160h = reader.ReadUInt32();
			this.Unknown_164h = reader.ReadUInt32();
			this.Unknown_168h = reader.ReadUInt32();
			this.Unknown_16Ch = reader.ReadUInt32();
			this.Unknown_170h = reader.ReadUInt32();
			this.Unknown_174h = reader.ReadUInt32();
			this.Unknown_178h = reader.ReadUInt32();
			this.Unknown_17Ch = reader.ReadUInt32();
			this.Bound = reader.ReadBlockAt<Bound>(this.BoundPointer, Array.Empty<object>());
			this.Behavior = reader.ReadBlockAt<EnvClothVerletBehavior>(this.BehaviorPointer, Array.Empty<object>());
			this.Unknown_140h_Data = reader.ReadBlockAt<Unknown_C_007>(this.Unknown_140h_Pointer, Array.Empty<object>());
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00023568 File Offset: 0x00021768
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.BoundPointer = (ulong)((this.Bound != null) ? this.Bound.Position : 0L);
			this.BehaviorPointer = (ulong)((this.Behavior != null) ? this.Behavior.Position : 0L);
			this.Unknown_140h_Pointer = (ulong)((this.Unknown_140h_Data != null) ? this.Unknown_140h_Data.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.BoundPointer);
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
			writer.WriteBlock(this.Unknown_70h);
			writer.WriteBlock(this.Unknown_80h);
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
			writer.Write(this.Unknown_F0h);
			writer.Write(this.Unknown_F4h);
			writer.Write(this.Unknown_F8h);
			writer.Write(this.Unknown_FCh);
			writer.WriteBlock(this.Unknown_100h);
			writer.WriteBlock(this.Unknown_110h);
			writer.Write(this.Unknown_120h);
			writer.Write(this.Unknown_124h);
			writer.Write(this.Unknown_128h);
			writer.Write(this.Unknown_12Ch);
			writer.Write(this.BehaviorPointer);
			writer.Write(this.Unknown_138h);
			writer.Write(this.Unknown_13Ch);
			writer.Write(this.Unknown_140h_Pointer);
			writer.Write(this.Unknown_148h);
			writer.Write(this.Unknown_14Ch);
			writer.Write(this.Unknown_150h);
			writer.Write(this.Unknown_154h);
			writer.Write(this.Unknown_158h);
			writer.Write(this.Unknown_15Ch);
			writer.Write(this.Unknown_160h);
			writer.Write(this.Unknown_164h);
			writer.Write(this.Unknown_168h);
			writer.Write(this.Unknown_16Ch);
			writer.Write(this.Unknown_170h);
			writer.Write(this.Unknown_174h);
			writer.Write(this.Unknown_178h);
			writer.Write(this.Unknown_17Ch);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00023998 File Offset: 0x00021B98
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Bound != null)
			{
				list.Add(this.Bound);
			}
			if (this.Behavior != null)
			{
				list.Add(this.Behavior);
			}
			if (this.Unknown_140h_Data != null)
			{
				list.Add(this.Unknown_140h_Data);
			}
			return list.ToArray();
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000239F0 File Offset: 0x00021BF0
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(112L, this.Unknown_70h),
				new Tuple<long, IResourceBlock>(128L, this.Unknown_80h),
				new Tuple<long, IResourceBlock>(256L, this.Unknown_100h),
				new Tuple<long, IResourceBlock>(272L, this.Unknown_110h)
			};
		}

		// Token: 0x040034F0 RID: 13552
		public uint VFT;

		// Token: 0x040034F1 RID: 13553
		public uint Unknown_4h;

		// Token: 0x040034F2 RID: 13554
		public uint Unknown_8h;

		// Token: 0x040034F3 RID: 13555
		public uint Unknown_Ch;

		// Token: 0x040034F4 RID: 13556
		public uint Unknown_10h;

		// Token: 0x040034F5 RID: 13557
		public uint Unknown_14h;

		// Token: 0x040034F6 RID: 13558
		public ulong BoundPointer;

		// Token: 0x040034F7 RID: 13559
		public uint Unknown_20h;

		// Token: 0x040034F8 RID: 13560
		public uint Unknown_24h;

		// Token: 0x040034F9 RID: 13561
		public uint Unknown_28h;

		// Token: 0x040034FA RID: 13562
		public uint Unknown_2Ch;

		// Token: 0x040034FB RID: 13563
		public uint Unknown_30h;

		// Token: 0x040034FC RID: 13564
		public uint Unknown_34h;

		// Token: 0x040034FD RID: 13565
		public uint Unknown_38h;

		// Token: 0x040034FE RID: 13566
		public uint Unknown_3Ch;

		// Token: 0x040034FF RID: 13567
		public uint Unknown_40h;

		// Token: 0x04003500 RID: 13568
		public uint Unknown_44h;

		// Token: 0x04003501 RID: 13569
		public uint Unknown_48h;

		// Token: 0x04003502 RID: 13570
		public uint Unknown_4Ch;

		// Token: 0x04003503 RID: 13571
		public uint Unknown_50h;

		// Token: 0x04003504 RID: 13572
		public uint Unknown_54h;

		// Token: 0x04003505 RID: 13573
		public uint Unknown_58h;

		// Token: 0x04003506 RID: 13574
		public uint Unknown_5Ch;

		// Token: 0x04003507 RID: 13575
		public uint Unknown_60h;

		// Token: 0x04003508 RID: 13576
		public uint Unknown_64h;

		// Token: 0x04003509 RID: 13577
		public uint Unknown_68h;

		// Token: 0x0400350A RID: 13578
		public uint Unknown_6Ch;

		// Token: 0x0400350B RID: 13579
		public ResourceSimpleList64<RAGE_Vector4> Unknown_70h;

		// Token: 0x0400350C RID: 13580
		public ResourceSimpleList64<RAGE_Vector4> Unknown_80h;

		// Token: 0x0400350D RID: 13581
		public uint Unknown_90h;

		// Token: 0x0400350E RID: 13582
		public uint Unknown_94h;

		// Token: 0x0400350F RID: 13583
		public uint Unknown_98h;

		// Token: 0x04003510 RID: 13584
		public uint Unknown_9Ch;

		// Token: 0x04003511 RID: 13585
		public uint Unknown_A0h;

		// Token: 0x04003512 RID: 13586
		public uint Unknown_A4h;

		// Token: 0x04003513 RID: 13587
		public uint Unknown_A8h;

		// Token: 0x04003514 RID: 13588
		public uint Unknown_ACh;

		// Token: 0x04003515 RID: 13589
		public uint Unknown_B0h;

		// Token: 0x04003516 RID: 13590
		public uint Unknown_B4h;

		// Token: 0x04003517 RID: 13591
		public uint Unknown_B8h;

		// Token: 0x04003518 RID: 13592
		public uint Unknown_BCh;

		// Token: 0x04003519 RID: 13593
		public uint Unknown_C0h;

		// Token: 0x0400351A RID: 13594
		public uint Unknown_C4h;

		// Token: 0x0400351B RID: 13595
		public uint Unknown_C8h;

		// Token: 0x0400351C RID: 13596
		public uint Unknown_CCh;

		// Token: 0x0400351D RID: 13597
		public uint Unknown_D0h;

		// Token: 0x0400351E RID: 13598
		public uint Unknown_D4h;

		// Token: 0x0400351F RID: 13599
		public uint Unknown_D8h;

		// Token: 0x04003520 RID: 13600
		public uint Unknown_DCh;

		// Token: 0x04003521 RID: 13601
		public uint Unknown_E0h;

		// Token: 0x04003522 RID: 13602
		public uint Unknown_E4h;

		// Token: 0x04003523 RID: 13603
		public uint Unknown_E8h;

		// Token: 0x04003524 RID: 13604
		public uint Unknown_ECh;

		// Token: 0x04003525 RID: 13605
		public uint Unknown_F0h;

		// Token: 0x04003526 RID: 13606
		public uint Unknown_F4h;

		// Token: 0x04003527 RID: 13607
		public uint Unknown_F8h;

		// Token: 0x04003528 RID: 13608
		public uint Unknown_FCh;

		// Token: 0x04003529 RID: 13609
		public ResourceSimpleList64<Unknown_C_004> Unknown_100h;

		// Token: 0x0400352A RID: 13610
		public ResourceSimpleList64<Unknown_C_004> Unknown_110h;

		// Token: 0x0400352B RID: 13611
		public uint Unknown_120h;

		// Token: 0x0400352C RID: 13612
		public uint Unknown_124h;

		// Token: 0x0400352D RID: 13613
		public uint Unknown_128h;

		// Token: 0x0400352E RID: 13614
		public uint Unknown_12Ch;

		// Token: 0x0400352F RID: 13615
		public ulong BehaviorPointer;

		// Token: 0x04003530 RID: 13616
		public uint Unknown_138h;

		// Token: 0x04003531 RID: 13617
		public uint Unknown_13Ch;

		// Token: 0x04003532 RID: 13618
		public ulong Unknown_140h_Pointer;

		// Token: 0x04003533 RID: 13619
		public uint Unknown_148h;

		// Token: 0x04003534 RID: 13620
		public uint Unknown_14Ch;

		// Token: 0x04003535 RID: 13621
		public uint Unknown_150h;

		// Token: 0x04003536 RID: 13622
		public uint Unknown_154h;

		// Token: 0x04003537 RID: 13623
		public uint Unknown_158h;

		// Token: 0x04003538 RID: 13624
		public uint Unknown_15Ch;

		// Token: 0x04003539 RID: 13625
		public uint Unknown_160h;

		// Token: 0x0400353A RID: 13626
		public uint Unknown_164h;

		// Token: 0x0400353B RID: 13627
		public uint Unknown_168h;

		// Token: 0x0400353C RID: 13628
		public uint Unknown_16Ch;

		// Token: 0x0400353D RID: 13629
		public uint Unknown_170h;

		// Token: 0x0400353E RID: 13630
		public uint Unknown_174h;

		// Token: 0x0400353F RID: 13631
		public uint Unknown_178h;

		// Token: 0x04003540 RID: 13632
		public uint Unknown_17Ch;

		// Token: 0x04003541 RID: 13633
		public Bound Bound;

		// Token: 0x04003542 RID: 13634
		public EnvClothVerletBehavior Behavior;

		// Token: 0x04003543 RID: 13635
		public Unknown_C_007 Unknown_140h_Data;
	}
}
