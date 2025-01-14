using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000037 RID: 55
	public class EffectRule : ResourceSystemBlock
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000744E File Offset: 0x0000564E
		public override long Length
		{
			get
			{
				return 960L;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00007458 File Offset: 0x00005658
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.NamePointer = reader.ReadUInt64();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.EventEmittersPointer = reader.ReadUInt64();
			this.EventEmittersCount1 = reader.ReadUInt16();
			this.EventEmittersCount2 = reader.ReadUInt16();
			this.Unknown_44h = reader.ReadUInt32();
			this.p4 = reader.ReadUInt64();
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
			this.KeyframeProp0 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp1 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp2 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp3 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp4 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframePropsPointer = reader.ReadUInt64();
			this.KeyframePropsCount1 = reader.ReadUInt16();
			this.KeyframePropsCount2 = reader.ReadUInt16();
			this.Unknown_39Ch = reader.ReadUInt32();
			this.Unknown_3A0h = reader.ReadUInt32();
			this.Unknown_3A4h = reader.ReadUInt32();
			this.Unknown_3A8h = reader.ReadUInt32();
			this.Unknown_3ACh = reader.ReadUInt32();
			this.Unknown_3B0h = reader.ReadUInt32();
			this.Unknown_3B4h = reader.ReadUInt32();
			this.Unknown_3B8h = reader.ReadUInt32();
			this.Unknown_3BCh = reader.ReadUInt32();
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
			this.EventEmitters = reader.ReadBlockAt<ResourcePointerArray64<EventEmitter>>(this.EventEmittersPointer, new object[]
			{
				this.EventEmittersCount1
			});
			this.p4data = reader.ReadBlockAt<Unknown_P_004>(this.p4, Array.Empty<object>());
			this.KeyframeProps = reader.ReadBlockAt<ResourcePointerArray64<KeyframeProp>>(this.KeyframePropsPointer, new object[]
			{
				this.KeyframePropsCount2
			});
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000077EC File Offset: 0x000059EC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			this.EventEmittersPointer = (ulong)((this.EventEmitters != null) ? this.EventEmitters.Position : 0L);
			this.p4 = (ulong)((this.p4data != null) ? this.p4data.Position : 0L);
			this.KeyframePropsPointer = (ulong)((this.KeyframeProps != null) ? this.KeyframeProps.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.NamePointer);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.EventEmittersPointer);
			writer.Write(this.EventEmittersCount1);
			writer.Write(this.EventEmittersCount2);
			writer.Write(this.Unknown_44h);
			writer.Write(this.p4);
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
			writer.WriteBlock(this.KeyframeProp0);
			writer.WriteBlock(this.KeyframeProp1);
			writer.WriteBlock(this.KeyframeProp2);
			writer.WriteBlock(this.KeyframeProp3);
			writer.WriteBlock(this.KeyframeProp4);
			writer.Write(this.KeyframePropsPointer);
			writer.Write(this.KeyframePropsCount1);
			writer.Write(this.KeyframePropsCount2);
			writer.Write(this.Unknown_39Ch);
			writer.Write(this.Unknown_3A0h);
			writer.Write(this.Unknown_3A4h);
			writer.Write(this.Unknown_3A8h);
			writer.Write(this.Unknown_3ACh);
			writer.Write(this.Unknown_3B0h);
			writer.Write(this.Unknown_3B4h);
			writer.Write(this.Unknown_3B8h);
			writer.Write(this.Unknown_3BCh);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00007B64 File Offset: 0x00005D64
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			if (this.EventEmitters != null)
			{
				list.Add(this.EventEmitters);
			}
			if (this.p4data != null)
			{
				list.Add(this.p4data);
			}
			if (this.KeyframeProps != null)
			{
				list.Add(this.KeyframeProps);
			}
			return list.ToArray();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00007BD0 File Offset: 0x00005DD0
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(192L, this.KeyframeProp0),
				new Tuple<long, IResourceBlock>(336L, this.KeyframeProp1),
				new Tuple<long, IResourceBlock>(480L, this.KeyframeProp2),
				new Tuple<long, IResourceBlock>(624L, this.KeyframeProp3),
				new Tuple<long, IResourceBlock>(768L, this.KeyframeProp4)
			};
		}

		// Token: 0x04000220 RID: 544
		public uint VFT;

		// Token: 0x04000221 RID: 545
		public uint Unknown_4h;

		// Token: 0x04000222 RID: 546
		public uint Unknown_8h;

		// Token: 0x04000223 RID: 547
		public uint Unknown_Ch;

		// Token: 0x04000224 RID: 548
		public uint Unknown_10h;

		// Token: 0x04000225 RID: 549
		public uint Unknown_14h;

		// Token: 0x04000226 RID: 550
		public uint Unknown_18h;

		// Token: 0x04000227 RID: 551
		public uint Unknown_1Ch;

		// Token: 0x04000228 RID: 552
		public ulong NamePointer;

		// Token: 0x04000229 RID: 553
		public uint Unknown_28h;

		// Token: 0x0400022A RID: 554
		public uint Unknown_2Ch;

		// Token: 0x0400022B RID: 555
		public uint Unknown_30h;

		// Token: 0x0400022C RID: 556
		public uint Unknown_34h;

		// Token: 0x0400022D RID: 557
		public ulong EventEmittersPointer;

		// Token: 0x0400022E RID: 558
		public ushort EventEmittersCount1;

		// Token: 0x0400022F RID: 559
		public ushort EventEmittersCount2;

		// Token: 0x04000230 RID: 560
		public uint Unknown_44h;

		// Token: 0x04000231 RID: 561
		public ulong p4;

		// Token: 0x04000232 RID: 562
		public uint Unknown_50h;

		// Token: 0x04000233 RID: 563
		public uint Unknown_54h;

		// Token: 0x04000234 RID: 564
		public uint Unknown_58h;

		// Token: 0x04000235 RID: 565
		public uint Unknown_5Ch;

		// Token: 0x04000236 RID: 566
		public uint Unknown_60h;

		// Token: 0x04000237 RID: 567
		public uint Unknown_64h;

		// Token: 0x04000238 RID: 568
		public uint Unknown_68h;

		// Token: 0x04000239 RID: 569
		public uint Unknown_6Ch;

		// Token: 0x0400023A RID: 570
		public uint Unknown_70h;

		// Token: 0x0400023B RID: 571
		public uint Unknown_74h;

		// Token: 0x0400023C RID: 572
		public uint Unknown_78h;

		// Token: 0x0400023D RID: 573
		public uint Unknown_7Ch;

		// Token: 0x0400023E RID: 574
		public uint Unknown_80h;

		// Token: 0x0400023F RID: 575
		public uint Unknown_84h;

		// Token: 0x04000240 RID: 576
		public uint Unknown_88h;

		// Token: 0x04000241 RID: 577
		public uint Unknown_8Ch;

		// Token: 0x04000242 RID: 578
		public uint Unknown_90h;

		// Token: 0x04000243 RID: 579
		public uint Unknown_94h;

		// Token: 0x04000244 RID: 580
		public uint Unknown_98h;

		// Token: 0x04000245 RID: 581
		public uint Unknown_9Ch;

		// Token: 0x04000246 RID: 582
		public uint Unknown_A0h;

		// Token: 0x04000247 RID: 583
		public uint Unknown_A4h;

		// Token: 0x04000248 RID: 584
		public uint Unknown_A8h;

		// Token: 0x04000249 RID: 585
		public uint Unknown_ACh;

		// Token: 0x0400024A RID: 586
		public uint Unknown_B0h;

		// Token: 0x0400024B RID: 587
		public uint Unknown_B4h;

		// Token: 0x0400024C RID: 588
		public uint Unknown_B8h;

		// Token: 0x0400024D RID: 589
		public uint Unknown_BCh;

		// Token: 0x0400024E RID: 590
		public KeyframeProp KeyframeProp0;

		// Token: 0x0400024F RID: 591
		public KeyframeProp KeyframeProp1;

		// Token: 0x04000250 RID: 592
		public KeyframeProp KeyframeProp2;

		// Token: 0x04000251 RID: 593
		public KeyframeProp KeyframeProp3;

		// Token: 0x04000252 RID: 594
		public KeyframeProp KeyframeProp4;

		// Token: 0x04000253 RID: 595
		public ulong KeyframePropsPointer;

		// Token: 0x04000254 RID: 596
		public ushort KeyframePropsCount1;

		// Token: 0x04000255 RID: 597
		public ushort KeyframePropsCount2;

		// Token: 0x04000256 RID: 598
		public uint Unknown_39Ch;

		// Token: 0x04000257 RID: 599
		public uint Unknown_3A0h;

		// Token: 0x04000258 RID: 600
		public uint Unknown_3A4h;

		// Token: 0x04000259 RID: 601
		public uint Unknown_3A8h;

		// Token: 0x0400025A RID: 602
		public uint Unknown_3ACh;

		// Token: 0x0400025B RID: 603
		public uint Unknown_3B0h;

		// Token: 0x0400025C RID: 604
		public uint Unknown_3B4h;

		// Token: 0x0400025D RID: 605
		public uint Unknown_3B8h;

		// Token: 0x0400025E RID: 606
		public uint Unknown_3BCh;

		// Token: 0x0400025F RID: 607
		public string_r Name;

		// Token: 0x04000260 RID: 608
		public ResourcePointerArray64<EventEmitter> EventEmitters;

		// Token: 0x04000261 RID: 609
		public Unknown_P_004 p4data;

		// Token: 0x04000262 RID: 610
		public ResourcePointerArray64<KeyframeProp> KeyframeProps;
	}
}
