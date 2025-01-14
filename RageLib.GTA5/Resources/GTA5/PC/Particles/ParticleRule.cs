using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200003F RID: 63
	public class ParticleRule : ResourceSystemBlock
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000944B File Offset: 0x0000764B
		public override long Length
		{
			get
			{
				return 576L;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00009454 File Offset: 0x00007654
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
			this.emb1 = reader.ReadBlock<EffectSpawner>(Array.Empty<object>());
			this.emb2 = reader.ReadBlock<EffectSpawner>(Array.Empty<object>());
			this.Unknown_100h = reader.ReadUInt32();
			this.Unknown_104h = reader.ReadUInt32();
			this.Unknown_108h = reader.ReadUInt32();
			this.Unknown_10Ch = reader.ReadUInt32();
			this.Unknown_110h = reader.ReadUInt32();
			this.Unknown_114h = reader.ReadUInt32();
			this.Unknown_118h = reader.ReadUInt32();
			this.Unknown_11Ch = reader.ReadUInt32();
			this.NamePointer = reader.ReadUInt64();
			this.Unknown_128h = reader.ReadBlock<ResourcePointerList64<Behaviour>>(Array.Empty<object>());
			this.Unknown_138h = reader.ReadBlock<ResourcePointerList64<Behaviour>>(Array.Empty<object>());
			this.Unknown_148h = reader.ReadBlock<ResourcePointerList64<Behaviour>>(Array.Empty<object>());
			this.Unknown_158h = reader.ReadBlock<ResourcePointerList64<Behaviour>>(Array.Empty<object>());
			this.Unknown_168h = reader.ReadBlock<ResourcePointerList64<Behaviour>>(Array.Empty<object>());
			this.Unknown_178h = reader.ReadUInt32();
			this.Unknown_17Ch = reader.ReadUInt32();
			this.Unknown_180h = reader.ReadUInt32();
			this.Unknown_184h = reader.ReadUInt32();
			this.Unknown_188h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_013>>(Array.Empty<object>());
			this.Unknown_198h = reader.ReadUInt32();
			this.Unknown_19Ch = reader.ReadUInt32();
			this.Unknown_1A0h = reader.ReadUInt32();
			this.Unknown_1A4h = reader.ReadUInt32();
			this.Unknown_1A8h = reader.ReadUInt32();
			this.Unknown_1ACh = reader.ReadUInt32();
			this.VFTx3 = reader.ReadUInt32();
			this.Unknown_1B4h = reader.ReadUInt32();
			this.p9 = reader.ReadUInt64();
			this.p10 = reader.ReadUInt64();
			this.Unknown_1C8h = reader.ReadUInt32();
			this.Unknown_1CCh = reader.ReadUInt32();
			this.Unknown_1D0h = reader.ReadUInt32();
			this.Unknown_1D4h = reader.ReadUInt32();
			this.VFTx4 = reader.ReadUInt32();
			this.Unknown_1DCh = reader.ReadUInt32();
			this.Unknown_1E0h = reader.ReadUInt32();
			this.Unknown_1E4h = reader.ReadUInt32();
			this.Unknown_1E8h = reader.ReadUInt32();
			this.Unknown_1ECh = reader.ReadUInt32();
			this.ShaderVars = reader.ReadBlock<ResourcePointerList64<ShaderVar>>(Array.Empty<object>());
			this.Unknown_200h = reader.ReadUInt32();
			this.Unknown_204h = reader.ReadUInt32();
			this.Unknown_208h = reader.ReadUInt32();
			this.Unknown_20Ch = reader.ReadUInt32();
			this.Unknown_210h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_012>>(Array.Empty<object>());
			this.Unknown_220h = reader.ReadUInt32();
			this.Unknown_224h = reader.ReadUInt32();
			this.Unknown_228h = reader.ReadUInt32();
			this.Unknown_22Ch = reader.ReadUInt32();
			this.Unknown_230h = reader.ReadUInt32();
			this.Unknown_234h = reader.ReadUInt32();
			this.Unknown_238h = reader.ReadUInt32();
			this.Unknown_23Ch = reader.ReadUInt32();
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
			this.p9data = reader.ReadBlockAt<string_r>(this.p9, Array.Empty<object>());
			this.p10data = reader.ReadBlockAt<string_r>(this.p10, Array.Empty<object>());
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000097CC File Offset: 0x000079CC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			this.p9 = (ulong)((this.p9data != null) ? this.p9data.Position : 0L);
			this.p10 = (ulong)((this.p10data != null) ? this.p10data.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.emb1);
			writer.WriteBlock(this.emb2);
			writer.Write(this.Unknown_100h);
			writer.Write(this.Unknown_104h);
			writer.Write(this.Unknown_108h);
			writer.Write(this.Unknown_10Ch);
			writer.Write(this.Unknown_110h);
			writer.Write(this.Unknown_114h);
			writer.Write(this.Unknown_118h);
			writer.Write(this.Unknown_11Ch);
			writer.Write(this.NamePointer);
			writer.WriteBlock(this.Unknown_128h);
			writer.WriteBlock(this.Unknown_138h);
			writer.WriteBlock(this.Unknown_148h);
			writer.WriteBlock(this.Unknown_158h);
			writer.WriteBlock(this.Unknown_168h);
			writer.Write(this.Unknown_178h);
			writer.Write(this.Unknown_17Ch);
			writer.Write(this.Unknown_180h);
			writer.Write(this.Unknown_184h);
			writer.WriteBlock(this.Unknown_188h);
			writer.Write(this.Unknown_198h);
			writer.Write(this.Unknown_19Ch);
			writer.Write(this.Unknown_1A0h);
			writer.Write(this.Unknown_1A4h);
			writer.Write(this.Unknown_1A8h);
			writer.Write(this.Unknown_1ACh);
			writer.Write(this.VFTx3);
			writer.Write(this.Unknown_1B4h);
			writer.Write(this.p9);
			writer.Write(this.p10);
			writer.Write(this.Unknown_1C8h);
			writer.Write(this.Unknown_1CCh);
			writer.Write(this.Unknown_1D0h);
			writer.Write(this.Unknown_1D4h);
			writer.Write(this.VFTx4);
			writer.Write(this.Unknown_1DCh);
			writer.Write(this.Unknown_1E0h);
			writer.Write(this.Unknown_1E4h);
			writer.Write(this.Unknown_1E8h);
			writer.Write(this.Unknown_1ECh);
			writer.WriteBlock(this.ShaderVars);
			writer.Write(this.Unknown_200h);
			writer.Write(this.Unknown_204h);
			writer.Write(this.Unknown_208h);
			writer.Write(this.Unknown_20Ch);
			writer.WriteBlock(this.Unknown_210h);
			writer.Write(this.Unknown_220h);
			writer.Write(this.Unknown_224h);
			writer.Write(this.Unknown_228h);
			writer.Write(this.Unknown_22Ch);
			writer.Write(this.Unknown_230h);
			writer.Write(this.Unknown_234h);
			writer.Write(this.Unknown_238h);
			writer.Write(this.Unknown_23Ch);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00009B24 File Offset: 0x00007D24
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			if (this.p9data != null)
			{
				list.Add(this.p9data);
			}
			if (this.p10data != null)
			{
				list.Add(this.p10data);
			}
			return list.ToArray();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00009B7C File Offset: 0x00007D7C
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(88L, this.emb1),
				new Tuple<long, IResourceBlock>(96L, this.emb2),
				new Tuple<long, IResourceBlock>(296L, this.Unknown_128h),
				new Tuple<long, IResourceBlock>(312L, this.Unknown_138h),
				new Tuple<long, IResourceBlock>(328L, this.Unknown_148h),
				new Tuple<long, IResourceBlock>(344L, this.Unknown_158h),
				new Tuple<long, IResourceBlock>(360L, this.Unknown_168h),
				new Tuple<long, IResourceBlock>(392L, this.Unknown_188h),
				new Tuple<long, IResourceBlock>(496L, this.ShaderVars),
				new Tuple<long, IResourceBlock>(528L, this.Unknown_210h)
			};
		}

		// Token: 0x0400031B RID: 795
		public uint VFT;

		// Token: 0x0400031C RID: 796
		public uint Unknown_4h;

		// Token: 0x0400031D RID: 797
		public uint Unknown_8h;

		// Token: 0x0400031E RID: 798
		public uint Unknown_Ch;

		// Token: 0x0400031F RID: 799
		public uint Unknown_10h;

		// Token: 0x04000320 RID: 800
		public uint Unknown_14h;

		// Token: 0x04000321 RID: 801
		public uint Unknown_18h;

		// Token: 0x04000322 RID: 802
		public uint Unknown_1Ch;

		// Token: 0x04000323 RID: 803
		public EffectSpawner emb1;

		// Token: 0x04000324 RID: 804
		public EffectSpawner emb2;

		// Token: 0x04000325 RID: 805
		public uint Unknown_100h;

		// Token: 0x04000326 RID: 806
		public uint Unknown_104h;

		// Token: 0x04000327 RID: 807
		public uint Unknown_108h;

		// Token: 0x04000328 RID: 808
		public uint Unknown_10Ch;

		// Token: 0x04000329 RID: 809
		public uint Unknown_110h;

		// Token: 0x0400032A RID: 810
		public uint Unknown_114h;

		// Token: 0x0400032B RID: 811
		public uint Unknown_118h;

		// Token: 0x0400032C RID: 812
		public uint Unknown_11Ch;

		// Token: 0x0400032D RID: 813
		public ulong NamePointer;

		// Token: 0x0400032E RID: 814
		public ResourcePointerList64<Behaviour> Unknown_128h;

		// Token: 0x0400032F RID: 815
		public ResourcePointerList64<Behaviour> Unknown_138h;

		// Token: 0x04000330 RID: 816
		public ResourcePointerList64<Behaviour> Unknown_148h;

		// Token: 0x04000331 RID: 817
		public ResourcePointerList64<Behaviour> Unknown_158h;

		// Token: 0x04000332 RID: 818
		public ResourcePointerList64<Behaviour> Unknown_168h;

		// Token: 0x04000333 RID: 819
		public uint Unknown_178h;

		// Token: 0x04000334 RID: 820
		public uint Unknown_17Ch;

		// Token: 0x04000335 RID: 821
		public uint Unknown_180h;

		// Token: 0x04000336 RID: 822
		public uint Unknown_184h;

		// Token: 0x04000337 RID: 823
		public ResourceSimpleList64<Unknown_P_013> Unknown_188h;

		// Token: 0x04000338 RID: 824
		public uint Unknown_198h;

		// Token: 0x04000339 RID: 825
		public uint Unknown_19Ch;

		// Token: 0x0400033A RID: 826
		public uint Unknown_1A0h;

		// Token: 0x0400033B RID: 827
		public uint Unknown_1A4h;

		// Token: 0x0400033C RID: 828
		public uint Unknown_1A8h;

		// Token: 0x0400033D RID: 829
		public uint Unknown_1ACh;

		// Token: 0x0400033E RID: 830
		public uint VFTx3;

		// Token: 0x0400033F RID: 831
		public uint Unknown_1B4h;

		// Token: 0x04000340 RID: 832
		public ulong p9;

		// Token: 0x04000341 RID: 833
		public ulong p10;

		// Token: 0x04000342 RID: 834
		public uint Unknown_1C8h;

		// Token: 0x04000343 RID: 835
		public uint Unknown_1CCh;

		// Token: 0x04000344 RID: 836
		public uint Unknown_1D0h;

		// Token: 0x04000345 RID: 837
		public uint Unknown_1D4h;

		// Token: 0x04000346 RID: 838
		public uint VFTx4;

		// Token: 0x04000347 RID: 839
		public uint Unknown_1DCh;

		// Token: 0x04000348 RID: 840
		public uint Unknown_1E0h;

		// Token: 0x04000349 RID: 841
		public uint Unknown_1E4h;

		// Token: 0x0400034A RID: 842
		public uint Unknown_1E8h;

		// Token: 0x0400034B RID: 843
		public uint Unknown_1ECh;

		// Token: 0x0400034C RID: 844
		public ResourcePointerList64<ShaderVar> ShaderVars;

		// Token: 0x0400034D RID: 845
		public uint Unknown_200h;

		// Token: 0x0400034E RID: 846
		public uint Unknown_204h;

		// Token: 0x0400034F RID: 847
		public uint Unknown_208h;

		// Token: 0x04000350 RID: 848
		public uint Unknown_20Ch;

		// Token: 0x04000351 RID: 849
		public ResourceSimpleList64<Unknown_P_012> Unknown_210h;

		// Token: 0x04000352 RID: 850
		public uint Unknown_220h;

		// Token: 0x04000353 RID: 851
		public uint Unknown_224h;

		// Token: 0x04000354 RID: 852
		public uint Unknown_228h;

		// Token: 0x04000355 RID: 853
		public uint Unknown_22Ch;

		// Token: 0x04000356 RID: 854
		public uint Unknown_230h;

		// Token: 0x04000357 RID: 855
		public uint Unknown_234h;

		// Token: 0x04000358 RID: 856
		public uint Unknown_238h;

		// Token: 0x04000359 RID: 857
		public uint Unknown_23Ch;

		// Token: 0x0400035A RID: 858
		public string_r Name;

		// Token: 0x0400035B RID: 859
		public string_r p9data;

		// Token: 0x0400035C RID: 860
		public string_r p10data;
	}
}
