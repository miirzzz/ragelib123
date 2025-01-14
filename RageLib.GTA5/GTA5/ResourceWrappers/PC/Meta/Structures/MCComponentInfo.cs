using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x0200019F RID: 415
	public class MCComponentInfo : MetaStructureWrapper<CComponentInfo>
	{
		// Token: 0x060006B9 RID: 1721 RVA: 0x0002DAF2 File Offset: 0x0002BCF2
		public MCComponentInfo()
		{
			this.MetaName = MetaName.CComponentInfo;
			this.MetaStructure = default(CComponentInfo);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0002DB14 File Offset: 0x0002BD14
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCComponentInfo._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCComponentInfo._MetaName);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0002DB54 File Offset: 0x0002BD54
		public override void Parse(MetaFile meta, CComponentInfo CComponentInfo)
		{
			this.Meta = meta;
			this.MetaStructure = CComponentInfo;
			this.Unk_802196719 = CComponentInfo.Unk_802196719;
			this.Unk_4233133352 = CComponentInfo.Unk_4233133352;
			this.Unk_128864925 = CComponentInfo.Unk_128864925;
			this.Flags = CComponentInfo.flags;
			this.Inclusions = CComponentInfo.inclusions;
			this.Exclusions = CComponentInfo.exclusions;
			this.Unk_1613922652 = CComponentInfo.Unk_1613922652;
			this.Unk_2114993291 = CComponentInfo.Unk_2114993291;
			this.Unk_3509540765 = CComponentInfo.Unk_3509540765;
			this.Unk_4196345791 = CComponentInfo.Unk_4196345791;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.Unk_802196719 = this.Unk_802196719;
			this.MetaStructure.Unk_4233133352 = this.Unk_4233133352;
			this.MetaStructure.Unk_128864925 = this.Unk_128864925;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.inclusions = this.Inclusions;
			this.MetaStructure.exclusions = this.Exclusions;
			this.MetaStructure.Unk_1613922652 = this.Unk_1613922652;
			this.MetaStructure.Unk_2114993291 = this.Unk_2114993291;
			this.MetaStructure.Unk_3509540765 = this.Unk_3509540765;
			this.MetaStructure.Unk_4196345791 = this.Unk_4196345791;
			MCComponentInfo.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CComponentInfo>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003721 RID: 14113
		public static MetaName _MetaName = MetaName.CComponentInfo;

		// Token: 0x04003722 RID: 14114
		public MetaFile Meta;

		// Token: 0x04003723 RID: 14115
		public uint Unk_802196719;

		// Token: 0x04003724 RID: 14116
		public uint Unk_4233133352;

		// Token: 0x04003725 RID: 14117
		public ArrayOfBytes5 Unk_128864925;

		// Token: 0x04003726 RID: 14118
		public uint Flags;

		// Token: 0x04003727 RID: 14119
		public int Inclusions;

		// Token: 0x04003728 RID: 14120
		public int Exclusions;

		// Token: 0x04003729 RID: 14121
		public short Unk_1613922652;

		// Token: 0x0400372A RID: 14122
		public ushort Unk_2114993291;

		// Token: 0x0400372B RID: 14123
		public byte Unk_3509540765;

		// Token: 0x0400372C RID: 14124
		public byte Unk_4196345791;
	}
}
