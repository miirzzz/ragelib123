using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001DA RID: 474
	public class MUnk_1980345114 : MetaStructureWrapper<Unk_1980345114>
	{
		// Token: 0x060007F5 RID: 2037 RVA: 0x000363D9 File Offset: 0x000345D9
		public MUnk_1980345114()
		{
			this.MetaName = MetaName.CCompEntityAnims;
			this.MetaStructure = default(Unk_1980345114);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x000363F8 File Offset: 0x000345F8
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_1980345114._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_1980345114._MetaName);
			mb.AddStructureInfo(MetaName.CCompEntityEffectsData);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00036444 File Offset: 0x00034644
		public override void Parse(MetaFile meta, Unk_1980345114 Unk_1980345114)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_1980345114;
			this.AnimDict = Unk_1980345114.AnimDict;
			this.AnimName = Unk_1980345114.AnimName;
			this.AnimatedModel = Unk_1980345114.AnimatedModel;
			this.PunchInPhase = Unk_1980345114.punchInPhase;
			this.PunchOutPhase = Unk_1980345114.punchOutPhase;
			Unk_3430328684[] array = MetaUtils.ConvertDataArray<Unk_3430328684>(meta, Unk_1980345114.effectsData);
			this.EffectsData = ((array != null) ? array.Select(delegate(Unk_3430328684 e)
			{
				MUnk_3430328684 munk_3430328684 = new MUnk_3430328684();
				munk_3430328684.Parse(meta, e);
				return munk_3430328684;
			}).ToList<MUnk_3430328684>() : null);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000364E4 File Offset: 0x000346E4
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.AnimDict = this.AnimDict;
			this.MetaStructure.AnimName = this.AnimName;
			this.MetaStructure.AnimatedModel = this.AnimatedModel;
			this.MetaStructure.punchInPhase = this.PunchInPhase;
			this.MetaStructure.punchOutPhase = this.PunchOutPhase;
			if (this.EffectsData != null)
			{
				this.MetaStructure.effectsData = mb.AddItemArrayPtr<Unk_3430328684>(MetaName.CCompEntityEffectsData, this.EffectsData.Select(delegate(MUnk_3430328684 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<Unk_3430328684>());
			}
			MUnk_3430328684.AddEnumAndStructureInfo(mb);
			MUnk_1980345114.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_1980345114>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400397A RID: 14714
		public static MetaName _MetaName = MetaName.CCompEntityAnims;

		// Token: 0x0400397B RID: 14715
		public MetaFile Meta;

		// Token: 0x0400397C RID: 14716
		public ArrayOfChars64 AnimDict;

		// Token: 0x0400397D RID: 14717
		public ArrayOfChars64 AnimName;

		// Token: 0x0400397E RID: 14718
		public ArrayOfChars64 AnimatedModel;

		// Token: 0x0400397F RID: 14719
		public float PunchInPhase;

		// Token: 0x04003980 RID: 14720
		public float PunchOutPhase;

		// Token: 0x04003981 RID: 14721
		public List<MUnk_3430328684> EffectsData;
	}
}
