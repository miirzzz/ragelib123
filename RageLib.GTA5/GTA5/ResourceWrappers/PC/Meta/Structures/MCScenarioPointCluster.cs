using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001C5 RID: 453
	public class MCScenarioPointCluster : MetaStructureWrapper<CScenarioPointCluster>
	{
		// Token: 0x0600078D RID: 1933 RVA: 0x000342DF File Offset: 0x000324DF
		public MCScenarioPointCluster()
		{
			this.MetaName = MetaName.CScenarioPointCluster;
			this.MetaStructure = default(CScenarioPointCluster);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00034300 File Offset: 0x00032500
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCScenarioPointCluster._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCScenarioPointCluster._MetaName);
			mb.AddStructureInfo(MetaName.CScenarioPointContainer);
			mb.AddStructureInfo(MetaName.rage__spdSphere);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00034358 File Offset: 0x00032558
		public override void Parse(MetaFile meta, CScenarioPointCluster CScenarioPointCluster)
		{
			this.Meta = meta;
			this.MetaStructure = CScenarioPointCluster;
			this.Points = new MCScenarioPointContainer();
			this.Points.Parse(meta, CScenarioPointCluster.Points);
			this.ClusterSphere = new Mrage__spdSphere();
			this.ClusterSphere.Parse(meta, CScenarioPointCluster.ClusterSphere);
			this.Unk_1095875445 = CScenarioPointCluster.Unk_1095875445;
			this.Unk_3129415068 = CScenarioPointCluster.Unk_3129415068;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000343C8 File Offset: 0x000325C8
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.Points.Build(mb, false);
			this.MetaStructure.Points = this.Points.MetaStructure;
			MCScenarioPointContainer.AddEnumAndStructureInfo(mb);
			this.ClusterSphere.Build(mb, false);
			this.MetaStructure.ClusterSphere = this.ClusterSphere.MetaStructure;
			Mrage__spdSphere.AddEnumAndStructureInfo(mb);
			this.MetaStructure.Unk_1095875445 = this.Unk_1095875445;
			this.MetaStructure.Unk_3129415068 = this.Unk_3129415068;
			MCScenarioPointCluster.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CScenarioPointCluster>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038E8 RID: 14568
		public static MetaName _MetaName = MetaName.CScenarioPointCluster;

		// Token: 0x040038E9 RID: 14569
		public MetaFile Meta;

		// Token: 0x040038EA RID: 14570
		public MCScenarioPointContainer Points;

		// Token: 0x040038EB RID: 14571
		public Mrage__spdSphere ClusterSphere;

		// Token: 0x040038EC RID: 14572
		public float Unk_1095875445;

		// Token: 0x040038ED RID: 14573
		public byte Unk_3129415068;
	}
}
