using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001DD RID: 477
	public class MUnk_254518642 : MetaStructureWrapper<Unk_254518642>
	{
		// Token: 0x06000804 RID: 2052 RVA: 0x0003681C File Offset: 0x00034A1C
		public MUnk_254518642()
		{
			this.MetaName = MetaName.CPedPropTexData;
			this.MetaStructure = default(Unk_254518642);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00036848 File Offset: 0x00034A48
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_254518642._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_254518642._MetaName);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00036888 File Offset: 0x00034A88
		public override void Parse(MetaFile meta, Unk_254518642 Unk_254518642)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_254518642;
			this.Inclusions = Unk_254518642.inclusions;
			this.Exclusions = Unk_254518642.exclusions;
			this.TexId = Unk_254518642.texId;
			this.InclusionId = Unk_254518642.inclusionId;
			this.ExclusionId = Unk_254518642.exclusionId;
			this.Distribution = Unk_254518642.distribution;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000368EC File Offset: 0x00034AEC
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.inclusions = this.Inclusions;
			this.MetaStructure.exclusions = this.Exclusions;
			this.MetaStructure.texId = this.TexId;
			this.MetaStructure.inclusionId = this.InclusionId;
			this.MetaStructure.exclusionId = this.ExclusionId;
			this.MetaStructure.distribution = this.Distribution;
			MUnk_254518642.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_254518642>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400398D RID: 14733
		public static MetaName _MetaName = MetaName.CPedPropTexData;

		// Token: 0x0400398E RID: 14734
		public MetaFile Meta;

		// Token: 0x0400398F RID: 14735
		public int Inclusions;

		// Token: 0x04003990 RID: 14736
		public int Exclusions;

		// Token: 0x04003991 RID: 14737
		public byte TexId;

		// Token: 0x04003992 RID: 14738
		public byte InclusionId;

		// Token: 0x04003993 RID: 14739
		public byte ExclusionId;

		// Token: 0x04003994 RID: 14740
		public byte Distribution = byte.MaxValue;
	}
}
