using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001E0 RID: 480
	public class MUnk_3430328684 : MetaStructureWrapper<Unk_3430328684>
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x00036F43 File Offset: 0x00035143
		public MUnk_3430328684()
		{
			this.MetaName = MetaName.CCompEntityEffectsData;
			this.MetaStructure = default(Unk_3430328684);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00036F64 File Offset: 0x00035164
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_3430328684._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_3430328684._MetaName);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00036FA4 File Offset: 0x000351A4
		public override void Parse(MetaFile meta, Unk_3430328684 Unk_3430328684)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_3430328684;
			this.FxType = Unk_3430328684.fxType;
			this.FxOffsetPos = Unk_3430328684.fxOffsetPos;
			this.FxOffsetRot = Unk_3430328684.fxOffsetRot;
			this.BoneTag = Unk_3430328684.boneTag;
			this.StartPhase = Unk_3430328684.startPhase;
			this.EndPhase = Unk_3430328684.endPhase;
			this.PtFxIsTriggered = Unk_3430328684.ptFxIsTriggered;
			this.PtFxTag = Unk_3430328684.ptFxTag;
			this.PtFxScale = Unk_3430328684.ptFxScale;
			this.PtFxProbability = Unk_3430328684.ptFxProbability;
			this.PtFxHasTint = Unk_3430328684.ptFxHasTint;
			this.PtFxTintR = Unk_3430328684.ptFxTintR;
			this.PtFxTintG = Unk_3430328684.ptFxTintG;
			this.PtFxTintB = Unk_3430328684.ptFxTintB;
			this.PtFxSize = Unk_3430328684.ptFxSize;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00037074 File Offset: 0x00035274
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.fxType = this.FxType;
			this.MetaStructure.fxOffsetPos = this.FxOffsetPos;
			this.MetaStructure.fxOffsetRot = this.FxOffsetRot;
			this.MetaStructure.boneTag = this.BoneTag;
			this.MetaStructure.startPhase = this.StartPhase;
			this.MetaStructure.endPhase = this.EndPhase;
			this.MetaStructure.ptFxIsTriggered = this.PtFxIsTriggered;
			this.MetaStructure.ptFxTag = this.PtFxTag;
			this.MetaStructure.ptFxScale = this.PtFxScale;
			this.MetaStructure.ptFxProbability = this.PtFxProbability;
			this.MetaStructure.ptFxHasTint = this.PtFxHasTint;
			this.MetaStructure.ptFxTintR = this.PtFxTintR;
			this.MetaStructure.ptFxTintG = this.PtFxTintG;
			this.MetaStructure.ptFxTintB = this.PtFxTintB;
			this.MetaStructure.ptFxSize = this.PtFxSize;
			MUnk_3430328684.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_3430328684>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040039A2 RID: 14754
		public static MetaName _MetaName = MetaName.CCompEntityEffectsData;

		// Token: 0x040039A3 RID: 14755
		public MetaFile Meta;

		// Token: 0x040039A4 RID: 14756
		public uint FxType;

		// Token: 0x040039A5 RID: 14757
		public Vector3 FxOffsetPos;

		// Token: 0x040039A6 RID: 14758
		public Vector4 FxOffsetRot;

		// Token: 0x040039A7 RID: 14759
		public uint BoneTag;

		// Token: 0x040039A8 RID: 14760
		public float StartPhase;

		// Token: 0x040039A9 RID: 14761
		public float EndPhase;

		// Token: 0x040039AA RID: 14762
		public byte PtFxIsTriggered;

		// Token: 0x040039AB RID: 14763
		public ArrayOfChars64 PtFxTag;

		// Token: 0x040039AC RID: 14764
		public float PtFxScale;

		// Token: 0x040039AD RID: 14765
		public float PtFxProbability;

		// Token: 0x040039AE RID: 14766
		public byte PtFxHasTint;

		// Token: 0x040039AF RID: 14767
		public byte PtFxTintR;

		// Token: 0x040039B0 RID: 14768
		public byte PtFxTintG;

		// Token: 0x040039B1 RID: 14769
		public byte PtFxTintB;

		// Token: 0x040039B2 RID: 14770
		public Vector3 PtFxSize;
	}
}
