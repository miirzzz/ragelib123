using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001D7 RID: 471
	public class MUnk_1358189812 : MetaStructureWrapper<Unk_1358189812>
	{
		// Token: 0x060007E6 RID: 2022 RVA: 0x00035F18 File Offset: 0x00034118
		public MUnk_1358189812()
		{
			this.MetaName = MetaName.CStreamingRequestCommonSet;
			this.MetaStructure = default(Unk_1358189812);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00035F38 File Offset: 0x00034138
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_1358189812._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_1358189812._MetaName);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00035F77 File Offset: 0x00034177
		public override void Parse(MetaFile meta, Unk_1358189812 Unk_1358189812)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_1358189812;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00035F87 File Offset: 0x00034187
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			MUnk_1358189812.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_1358189812>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003966 RID: 14694
		public static MetaName _MetaName = MetaName.CStreamingRequestCommonSet;

		// Token: 0x04003967 RID: 14695
		public MetaFile Meta;

		// Token: 0x04003968 RID: 14696
		public Array_uint Requests;
	}
}
