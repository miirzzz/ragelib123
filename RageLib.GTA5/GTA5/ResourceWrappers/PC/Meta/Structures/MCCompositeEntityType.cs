using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001A0 RID: 416
	public class MCCompositeEntityType : MetaStructureWrapper<CCompositeEntityType>
	{
		// Token: 0x060006BE RID: 1726 RVA: 0x0002DCD8 File Offset: 0x0002BED8
		public MCCompositeEntityType()
		{
			this.MetaName = MetaName.CCompositeEntityType;
			this.MetaStructure = default(CCompositeEntityType);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0002DCF8 File Offset: 0x0002BEF8
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCCompositeEntityType._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCCompositeEntityType._MetaName);
			mb.AddStructureInfo(MetaName.CCompEntityAnims);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0002DD44 File Offset: 0x0002BF44
		public override void Parse(MetaFile meta, CCompositeEntityType CCompositeEntityType)
		{
			this.Meta = meta;
			this.MetaStructure = CCompositeEntityType;
			this.Name = CCompositeEntityType.Name;
			this.LodDist = CCompositeEntityType.lodDist;
			this.Flags = CCompositeEntityType.flags;
			this.SpecialAttribute = CCompositeEntityType.specialAttribute;
			this.BbMin = CCompositeEntityType.bbMin;
			this.BbMax = CCompositeEntityType.bbMax;
			this.BsCentre = CCompositeEntityType.bsCentre;
			this.BsRadius = CCompositeEntityType.bsRadius;
			this.StartModel = CCompositeEntityType.StartModel;
			this.EndModel = CCompositeEntityType.EndModel;
			this.StartImapFile = CCompositeEntityType.StartImapFile;
			this.EndImapFile = CCompositeEntityType.EndImapFile;
			this.PtFxAssetName = CCompositeEntityType.PtFxAssetName;
			Unk_1980345114[] array = MetaUtils.ConvertDataArray<Unk_1980345114>(meta, CCompositeEntityType.Animations);
			this.Animations = ((array != null) ? array.Select(delegate(Unk_1980345114 e)
			{
				MUnk_1980345114 munk_ = new MUnk_1980345114();
				munk_.Parse(meta, e);
				return munk_;
			}).ToList<MUnk_1980345114>() : null);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0002DE44 File Offset: 0x0002C044
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.Name = this.Name;
			this.MetaStructure.lodDist = this.LodDist;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.specialAttribute = this.SpecialAttribute;
			this.MetaStructure.bbMin = this.BbMin;
			this.MetaStructure.bbMax = this.BbMax;
			this.MetaStructure.bsCentre = this.BsCentre;
			this.MetaStructure.bsRadius = this.BsRadius;
			this.MetaStructure.StartModel = this.StartModel;
			this.MetaStructure.EndModel = this.EndModel;
			this.MetaStructure.StartImapFile = this.StartImapFile;
			this.MetaStructure.EndImapFile = this.EndImapFile;
			this.MetaStructure.PtFxAssetName = this.PtFxAssetName;
			if (this.Animations != null)
			{
				this.MetaStructure.Animations = mb.AddItemArrayPtr<Unk_1980345114>(MetaName.CCompEntityAnims, this.Animations.Select(delegate(MUnk_1980345114 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<Unk_1980345114>());
			}
			MUnk_1980345114.AddEnumAndStructureInfo(mb);
			MCCompositeEntityType.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CCompositeEntityType>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400372D RID: 14125
		public static MetaName _MetaName = MetaName.CCompositeEntityType;

		// Token: 0x0400372E RID: 14126
		public MetaFile Meta;

		// Token: 0x0400372F RID: 14127
		public ArrayOfChars64 Name;

		// Token: 0x04003730 RID: 14128
		public float LodDist;

		// Token: 0x04003731 RID: 14129
		public uint Flags;

		// Token: 0x04003732 RID: 14130
		public uint SpecialAttribute;

		// Token: 0x04003733 RID: 14131
		public Vector3 BbMin;

		// Token: 0x04003734 RID: 14132
		public Vector3 BbMax;

		// Token: 0x04003735 RID: 14133
		public Vector3 BsCentre;

		// Token: 0x04003736 RID: 14134
		public float BsRadius;

		// Token: 0x04003737 RID: 14135
		public ArrayOfChars64 StartModel;

		// Token: 0x04003738 RID: 14136
		public ArrayOfChars64 EndModel;

		// Token: 0x04003739 RID: 14137
		public uint StartImapFile;

		// Token: 0x0400373A RID: 14138
		public uint EndImapFile;

		// Token: 0x0400373B RID: 14139
		public uint PtFxAssetName;

		// Token: 0x0400373C RID: 14140
		public List<MUnk_1980345114> Animations;
	}
}
