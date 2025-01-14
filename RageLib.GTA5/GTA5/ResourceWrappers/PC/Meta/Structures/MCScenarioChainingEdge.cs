using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001C1 RID: 449
	public class MCScenarioChainingEdge : MetaStructureWrapper<CScenarioChainingEdge>
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x00033C0B File Offset: 0x00031E0B
		public MCScenarioChainingEdge()
		{
			this.MetaName = MetaName.CScenarioChainingEdge;
			this.MetaStructure = default(CScenarioChainingEdge);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00033C2C File Offset: 0x00031E2C
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCScenarioChainingEdge._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCScenarioChainingEdge._MetaName);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00033C6C File Offset: 0x00031E6C
		public override void Parse(MetaFile meta, CScenarioChainingEdge CScenarioChainingEdge)
		{
			this.Meta = meta;
			this.MetaStructure = CScenarioChainingEdge;
			this.NodeIndexFrom = CScenarioChainingEdge.NodeIndexFrom;
			this.NodeIndexTo = CScenarioChainingEdge.NodeIndexTo;
			this.Action = CScenarioChainingEdge.Action;
			this.NavMode = CScenarioChainingEdge.NavMode;
			this.NavSpeed = CScenarioChainingEdge.NavSpeed;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00033CC4 File Offset: 0x00031EC4
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.NodeIndexFrom = this.NodeIndexFrom;
			this.MetaStructure.NodeIndexTo = this.NodeIndexTo;
			this.MetaStructure.Action = this.Action;
			this.MetaStructure.NavMode = this.NavMode;
			this.MetaStructure.NavSpeed = this.NavSpeed;
			MCScenarioChainingEdge.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CScenarioChainingEdge>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038C4 RID: 14532
		public static MetaName _MetaName = MetaName.CScenarioChainingEdge;

		// Token: 0x040038C5 RID: 14533
		public MetaFile Meta;

		// Token: 0x040038C6 RID: 14534
		public ushort NodeIndexFrom;

		// Token: 0x040038C7 RID: 14535
		public ushort NodeIndexTo;

		// Token: 0x040038C8 RID: 14536
		public Unk_3609807418 Action;

		// Token: 0x040038C9 RID: 14537
		public Unk_3971773454 NavMode;

		// Token: 0x040038CA RID: 14538
		public Unk_941086046 NavSpeed;
	}
}
