using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001D6 RID: 470
	public class MUnk_1036962405 : MetaStructureWrapper<Unk_1036962405>
	{
		// Token: 0x060007E1 RID: 2017 RVA: 0x00035E1B File Offset: 0x0003401B
		public MUnk_1036962405()
		{
			this.MetaName = MetaName.CPVTextureData;
			this.MetaStructure = default(Unk_1036962405);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00035E48 File Offset: 0x00034048
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_1036962405._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_1036962405._MetaName);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00035E87 File Offset: 0x00034087
		public override void Parse(MetaFile meta, Unk_1036962405 Unk_1036962405)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_1036962405;
			this.TexId = Unk_1036962405.texId;
			this.Distribution = Unk_1036962405.distribution;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00035EB0 File Offset: 0x000340B0
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.texId = this.TexId;
			this.MetaStructure.distribution = this.Distribution;
			MUnk_1036962405.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_1036962405>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003962 RID: 14690
		public static MetaName _MetaName = MetaName.CPVTextureData;

		// Token: 0x04003963 RID: 14691
		public MetaFile Meta;

		// Token: 0x04003964 RID: 14692
		public byte TexId;

		// Token: 0x04003965 RID: 14693
		public byte Distribution = byte.MaxValue;
	}
}
