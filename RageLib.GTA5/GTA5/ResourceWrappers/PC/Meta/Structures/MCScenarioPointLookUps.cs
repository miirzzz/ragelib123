using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001C7 RID: 455
	public class MCScenarioPointLookUps : MetaStructureWrapper<CScenarioPointLookUps>
	{
		// Token: 0x06000797 RID: 1943 RVA: 0x0003468A File Offset: 0x0003288A
		public MCScenarioPointLookUps()
		{
			this.MetaName = MetaName.CScenarioPointLookUps;
			this.MetaStructure = default(CScenarioPointLookUps);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000346AC File Offset: 0x000328AC
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCScenarioPointLookUps._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCScenarioPointLookUps._MetaName);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000346EB File Offset: 0x000328EB
		public override void Parse(MetaFile meta, CScenarioPointLookUps CScenarioPointLookUps)
		{
			this.Meta = meta;
			this.MetaStructure = CScenarioPointLookUps;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x000346FB File Offset: 0x000328FB
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			MCScenarioPointLookUps.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CScenarioPointLookUps>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038F2 RID: 14578
		public static MetaName _MetaName = MetaName.CScenarioPointLookUps;

		// Token: 0x040038F3 RID: 14579
		public MetaFile Meta;

		// Token: 0x040038F4 RID: 14580
		public Array_uint TypeNames;

		// Token: 0x040038F5 RID: 14581
		public Array_uint PedModelSetNames;

		// Token: 0x040038F6 RID: 14582
		public Array_uint VehicleModelSetNames;

		// Token: 0x040038F7 RID: 14583
		public Array_uint GroupNames;

		// Token: 0x040038F8 RID: 14584
		public Array_uint InteriorNames;

		// Token: 0x040038F9 RID: 14585
		public Array_uint RequiredIMapNames;
	}
}
