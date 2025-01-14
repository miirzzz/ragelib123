using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200003A RID: 58
	public class EmitterRule : ResourceSystemBlock
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000080BD File Offset: 0x000062BD
		public override long Length
		{
			get
			{
				return 1584L;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000080C8 File Offset: 0x000062C8
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
			this.p2 = reader.ReadUInt64();
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.p3 = reader.ReadUInt64();
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.p4 = reader.ReadUInt64();
			this.Unknown_60h = reader.ReadUInt32();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.KeyframeProp0 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp1 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp2 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp3 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp4 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp5 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp6 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp7 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp8 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp9 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframePropsPointer = reader.ReadUInt64();
			this.KeyframePropsCount1 = reader.ReadUInt16();
			this.KeyframePropsCount2 = reader.ReadUInt16();
			this.Unknown_624h = reader.ReadUInt32();
			this.Unknown_628h = reader.ReadUInt32();
			this.Unknown_62Ch = reader.ReadUInt32();
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
			this.p2data = reader.ReadBlockAt<Domain>(this.p2, Array.Empty<object>());
			this.p3data = reader.ReadBlockAt<Domain>(this.p3, Array.Empty<object>());
			this.p4data = reader.ReadBlockAt<Domain>(this.p4, Array.Empty<object>());
			this.KeyframeProps = reader.ReadBlockAt<ResourcePointerArray64<KeyframeProp>>(this.KeyframePropsPointer, new object[]
			{
				this.KeyframePropsCount2
			});
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00008384 File Offset: 0x00006584
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			this.p2 = (ulong)((this.p2data != null) ? this.p2data.Position : 0L);
			this.p3 = (ulong)((this.p3data != null) ? this.p3data.Position : 0L);
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
			writer.Write(this.p2);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.p3);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.p4);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.WriteBlock(this.KeyframeProp0);
			writer.WriteBlock(this.KeyframeProp1);
			writer.WriteBlock(this.KeyframeProp2);
			writer.WriteBlock(this.KeyframeProp3);
			writer.WriteBlock(this.KeyframeProp4);
			writer.WriteBlock(this.KeyframeProp5);
			writer.WriteBlock(this.KeyframeProp6);
			writer.WriteBlock(this.KeyframeProp7);
			writer.WriteBlock(this.KeyframeProp8);
			writer.WriteBlock(this.KeyframeProp9);
			writer.Write(this.KeyframePropsPointer);
			writer.Write(this.KeyframePropsCount1);
			writer.Write(this.KeyframePropsCount2);
			writer.Write(this.Unknown_624h);
			writer.Write(this.Unknown_628h);
			writer.Write(this.Unknown_62Ch);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000861C File Offset: 0x0000681C
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			if (this.p2data != null)
			{
				list.Add(this.p2data);
			}
			if (this.p3data != null)
			{
				list.Add(this.p3data);
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

		// Token: 0x0600014B RID: 331 RVA: 0x0000869C File Offset: 0x0000689C
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(120L, this.KeyframeProp0),
				new Tuple<long, IResourceBlock>(264L, this.KeyframeProp1),
				new Tuple<long, IResourceBlock>(408L, this.KeyframeProp2),
				new Tuple<long, IResourceBlock>(552L, this.KeyframeProp3),
				new Tuple<long, IResourceBlock>(696L, this.KeyframeProp4),
				new Tuple<long, IResourceBlock>(840L, this.KeyframeProp5),
				new Tuple<long, IResourceBlock>(984L, this.KeyframeProp6),
				new Tuple<long, IResourceBlock>(1128L, this.KeyframeProp7),
				new Tuple<long, IResourceBlock>(1272L, this.KeyframeProp8),
				new Tuple<long, IResourceBlock>(1416L, this.KeyframeProp9)
			};
		}

		// Token: 0x04000289 RID: 649
		public uint VFT;

		// Token: 0x0400028A RID: 650
		public uint Unknown_4h;

		// Token: 0x0400028B RID: 651
		public uint Unknown_8h;

		// Token: 0x0400028C RID: 652
		public uint Unknown_Ch;

		// Token: 0x0400028D RID: 653
		public uint Unknown_10h;

		// Token: 0x0400028E RID: 654
		public uint Unknown_14h;

		// Token: 0x0400028F RID: 655
		public uint Unknown_18h;

		// Token: 0x04000290 RID: 656
		public uint Unknown_1Ch;

		// Token: 0x04000291 RID: 657
		public ulong NamePointer;

		// Token: 0x04000292 RID: 658
		public uint Unknown_28h;

		// Token: 0x04000293 RID: 659
		public uint Unknown_2Ch;

		// Token: 0x04000294 RID: 660
		public uint Unknown_30h;

		// Token: 0x04000295 RID: 661
		public uint Unknown_34h;

		// Token: 0x04000296 RID: 662
		public ulong p2;

		// Token: 0x04000297 RID: 663
		public uint Unknown_40h;

		// Token: 0x04000298 RID: 664
		public uint Unknown_44h;

		// Token: 0x04000299 RID: 665
		public ulong p3;

		// Token: 0x0400029A RID: 666
		public uint Unknown_50h;

		// Token: 0x0400029B RID: 667
		public uint Unknown_54h;

		// Token: 0x0400029C RID: 668
		public ulong p4;

		// Token: 0x0400029D RID: 669
		public uint Unknown_60h;

		// Token: 0x0400029E RID: 670
		public uint Unknown_64h;

		// Token: 0x0400029F RID: 671
		public uint Unknown_68h;

		// Token: 0x040002A0 RID: 672
		public uint Unknown_6Ch;

		// Token: 0x040002A1 RID: 673
		public uint Unknown_70h;

		// Token: 0x040002A2 RID: 674
		public uint Unknown_74h;

		// Token: 0x040002A3 RID: 675
		public KeyframeProp KeyframeProp0;

		// Token: 0x040002A4 RID: 676
		public KeyframeProp KeyframeProp1;

		// Token: 0x040002A5 RID: 677
		public KeyframeProp KeyframeProp2;

		// Token: 0x040002A6 RID: 678
		public KeyframeProp KeyframeProp3;

		// Token: 0x040002A7 RID: 679
		public KeyframeProp KeyframeProp4;

		// Token: 0x040002A8 RID: 680
		public KeyframeProp KeyframeProp5;

		// Token: 0x040002A9 RID: 681
		public KeyframeProp KeyframeProp6;

		// Token: 0x040002AA RID: 682
		public KeyframeProp KeyframeProp7;

		// Token: 0x040002AB RID: 683
		public KeyframeProp KeyframeProp8;

		// Token: 0x040002AC RID: 684
		public KeyframeProp KeyframeProp9;

		// Token: 0x040002AD RID: 685
		public ulong KeyframePropsPointer;

		// Token: 0x040002AE RID: 686
		public ushort KeyframePropsCount1;

		// Token: 0x040002AF RID: 687
		public ushort KeyframePropsCount2;

		// Token: 0x040002B0 RID: 688
		public uint Unknown_624h;

		// Token: 0x040002B1 RID: 689
		public uint Unknown_628h;

		// Token: 0x040002B2 RID: 690
		public uint Unknown_62Ch;

		// Token: 0x040002B3 RID: 691
		public string_r Name;

		// Token: 0x040002B4 RID: 692
		public Domain p2data;

		// Token: 0x040002B5 RID: 693
		public Domain p3data;

		// Token: 0x040002B6 RID: 694
		public Domain p4data;

		// Token: 0x040002B7 RID: 695
		public ResourcePointerArray64<KeyframeProp> KeyframeProps;
	}
}
