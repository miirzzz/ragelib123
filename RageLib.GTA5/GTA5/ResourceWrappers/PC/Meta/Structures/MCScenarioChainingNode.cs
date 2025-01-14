using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001C2 RID: 450
	public class MCScenarioChainingNode : MetaStructureWrapper<CScenarioChainingNode>
	{
		// Token: 0x0600077E RID: 1918 RVA: 0x00033D5F File Offset: 0x00031F5F
		public MCScenarioChainingNode()
		{
			this.MetaName = MetaName.CScenarioChainingNode;
			this.MetaStructure = default(CScenarioChainingNode);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00033D80 File Offset: 0x00031F80
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCScenarioChainingNode._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCScenarioChainingNode._MetaName);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00033DC0 File Offset: 0x00031FC0
		public override void Parse(MetaFile meta, CScenarioChainingNode CScenarioChainingNode)
		{
			this.Meta = meta;
			this.MetaStructure = CScenarioChainingNode;
			this.Position = CScenarioChainingNode.Position;
			this.Unk_2602393771 = CScenarioChainingNode.Unk_2602393771;
			this.ScenarioType = CScenarioChainingNode.ScenarioType;
			this.Unk_407126079 = CScenarioChainingNode.Unk_407126079;
			this.Unk_1308720135 = CScenarioChainingNode.Unk_1308720135;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00033E18 File Offset: 0x00032018
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.Position = this.Position;
			this.MetaStructure.Unk_2602393771 = this.Unk_2602393771;
			this.MetaStructure.ScenarioType = this.ScenarioType;
			this.MetaStructure.Unk_407126079 = this.Unk_407126079;
			this.MetaStructure.Unk_1308720135 = this.Unk_1308720135;
			MCScenarioChainingNode.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CScenarioChainingNode>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038CB RID: 14539
		public static MetaName _MetaName = MetaName.CScenarioChainingNode;

		// Token: 0x040038CC RID: 14540
		public MetaFile Meta;

		// Token: 0x040038CD RID: 14541
		public Vector3 Position;

		// Token: 0x040038CE RID: 14542
		public uint Unk_2602393771;

		// Token: 0x040038CF RID: 14543
		public uint ScenarioType;

		// Token: 0x040038D0 RID: 14544
		public byte Unk_407126079;

		// Token: 0x040038D1 RID: 14545
		public byte Unk_1308720135;
	}
}
