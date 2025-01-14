using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001C0 RID: 448
	public class MCScenarioChain : MetaStructureWrapper<CScenarioChain>
	{
		// Token: 0x06000774 RID: 1908 RVA: 0x00033B45 File Offset: 0x00031D45
		public MCScenarioChain()
		{
			this.MetaName = MetaName.CScenarioChain;
			this.MetaStructure = default(CScenarioChain);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00033B64 File Offset: 0x00031D64
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCScenarioChain._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCScenarioChain._MetaName);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00033BA3 File Offset: 0x00031DA3
		public override void Parse(MetaFile meta, CScenarioChain CScenarioChain)
		{
			this.Meta = meta;
			this.MetaStructure = CScenarioChain;
			this.Unk_1156691834 = CScenarioChain.Unk_1156691834;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00033BBF File Offset: 0x00031DBF
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.Unk_1156691834 = this.Unk_1156691834;
			MCScenarioChain.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CScenarioChain>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038C0 RID: 14528
		public static MetaName _MetaName = MetaName.CScenarioChain;

		// Token: 0x040038C1 RID: 14529
		public MetaFile Meta;

		// Token: 0x040038C2 RID: 14530
		public byte Unk_1156691834;

		// Token: 0x040038C3 RID: 14531
		public Array_ushort EdgeIds;
	}
}
