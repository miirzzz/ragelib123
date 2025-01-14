using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200003D RID: 61
	public class KeyframeProp : ResourceSystemBlock
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00004243 File Offset: 0x00002443
		public override long Length
		{
			get
			{
				return 144L;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00008DA8 File Offset: 0x00006FA8
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
			this.Unknown_70h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_011>>(Array.Empty<object>());
			this.Unknown_80h = reader.ReadUInt32();
			this.Unknown_84h = reader.ReadUInt32();
			this.Unknown_88h = reader.ReadUInt32();
			this.Unknown_8Ch = reader.ReadUInt32();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00008F48 File Offset: 0x00007148
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
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
			writer.WriteBlock(this.Unknown_70h);
			writer.Write(this.Unknown_80h);
			writer.Write(this.Unknown_84h);
			writer.Write(this.Unknown_88h);
			writer.Write(this.Unknown_8Ch);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000090E1 File Offset: 0x000072E1
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(112L, this.Unknown_70h)
			};
		}

		// Token: 0x040002E6 RID: 742
		public uint VFT;

		// Token: 0x040002E7 RID: 743
		public uint Unknown_4h;

		// Token: 0x040002E8 RID: 744
		public uint Unknown_8h;

		// Token: 0x040002E9 RID: 745
		public uint Unknown_Ch;

		// Token: 0x040002EA RID: 746
		public uint Unknown_10h;

		// Token: 0x040002EB RID: 747
		public uint Unknown_14h;

		// Token: 0x040002EC RID: 748
		public uint Unknown_18h;

		// Token: 0x040002ED RID: 749
		public uint Unknown_1Ch;

		// Token: 0x040002EE RID: 750
		public uint Unknown_20h;

		// Token: 0x040002EF RID: 751
		public uint Unknown_24h;

		// Token: 0x040002F0 RID: 752
		public uint Unknown_28h;

		// Token: 0x040002F1 RID: 753
		public uint Unknown_2Ch;

		// Token: 0x040002F2 RID: 754
		public uint Unknown_30h;

		// Token: 0x040002F3 RID: 755
		public uint Unknown_34h;

		// Token: 0x040002F4 RID: 756
		public uint Unknown_38h;

		// Token: 0x040002F5 RID: 757
		public uint Unknown_3Ch;

		// Token: 0x040002F6 RID: 758
		public uint Unknown_40h;

		// Token: 0x040002F7 RID: 759
		public uint Unknown_44h;

		// Token: 0x040002F8 RID: 760
		public uint Unknown_48h;

		// Token: 0x040002F9 RID: 761
		public uint Unknown_4Ch;

		// Token: 0x040002FA RID: 762
		public uint Unknown_50h;

		// Token: 0x040002FB RID: 763
		public uint Unknown_54h;

		// Token: 0x040002FC RID: 764
		public uint Unknown_58h;

		// Token: 0x040002FD RID: 765
		public uint Unknown_5Ch;

		// Token: 0x040002FE RID: 766
		public uint Unknown_60h;

		// Token: 0x040002FF RID: 767
		public uint Unknown_64h;

		// Token: 0x04000300 RID: 768
		public uint Unknown_68h;

		// Token: 0x04000301 RID: 769
		public uint Unknown_6Ch;

		// Token: 0x04000302 RID: 770
		public ResourceSimpleList64<Unknown_P_011> Unknown_70h;

		// Token: 0x04000303 RID: 771
		public uint Unknown_80h;

		// Token: 0x04000304 RID: 772
		public uint Unknown_84h;

		// Token: 0x04000305 RID: 773
		public uint Unknown_88h;

		// Token: 0x04000306 RID: 774
		public uint Unknown_8Ch;
	}
}
