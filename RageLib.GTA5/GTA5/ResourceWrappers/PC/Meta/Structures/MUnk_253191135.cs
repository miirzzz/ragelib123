using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001DC RID: 476
	public class MUnk_253191135 : MetaStructureWrapper<Unk_253191135>
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x000366AB File Offset: 0x000348AB
		public MUnk_253191135()
		{
			this.MetaName = MetaName.CPedSelectionSet;
			this.MetaStructure = default(Unk_253191135);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000366CC File Offset: 0x000348CC
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_253191135._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_253191135._MetaName);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0003670C File Offset: 0x0003490C
		public override void Parse(MetaFile meta, Unk_253191135 Unk_253191135)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_253191135;
			this.Name = Unk_253191135.name;
			this.Unk_173599222 = Unk_253191135.Unk_173599222;
			this.Unk_2991454271 = Unk_253191135.Unk_2991454271;
			this.Unk_3598106198 = Unk_253191135.Unk_3598106198;
			this.Unk_2095974912 = Unk_253191135.Unk_2095974912;
			this.Unk_672172037 = Unk_253191135.Unk_672172037;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00036770 File Offset: 0x00034970
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.Unk_173599222 = this.Unk_173599222;
			this.MetaStructure.Unk_2991454271 = this.Unk_2991454271;
			this.MetaStructure.Unk_3598106198 = this.Unk_3598106198;
			this.MetaStructure.Unk_2095974912 = this.Unk_2095974912;
			this.MetaStructure.Unk_672172037 = this.Unk_672172037;
			MUnk_253191135.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_253191135>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003985 RID: 14725
		public static MetaName _MetaName = MetaName.CPedSelectionSet;

		// Token: 0x04003986 RID: 14726
		public MetaFile Meta;

		// Token: 0x04003987 RID: 14727
		public uint Name;

		// Token: 0x04003988 RID: 14728
		public ArrayOfBytes12 Unk_173599222;

		// Token: 0x04003989 RID: 14729
		public ArrayOfBytes12 Unk_2991454271;

		// Token: 0x0400398A RID: 14730
		public ArrayOfBytes6 Unk_3598106198;

		// Token: 0x0400398B RID: 14731
		public ArrayOfBytes6 Unk_2095974912;

		// Token: 0x0400398C RID: 14732
		public ArrayOfBytes6 Unk_672172037;
	}
}
