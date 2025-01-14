using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001C8 RID: 456
	public class MCScenarioPointRegion : MetaStructureWrapper<CScenarioPointRegion>
	{
		// Token: 0x0600079C RID: 1948 RVA: 0x00034736 File Offset: 0x00032936
		public MCScenarioPointRegion()
		{
			this.MetaName = MetaName.CScenarioPointRegion;
			this.MetaStructure = default(CScenarioPointRegion);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00034758 File Offset: 0x00032958
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCScenarioPointRegion._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCScenarioPointRegion._MetaName);
			mb.AddStructureInfo(MetaName.CScenarioPointContainer);
			mb.AddStructureInfo(MetaName.CScenarioEntityOverride);
			mb.AddStructureInfo((MetaName)(-271226537));
			mb.AddStructureInfo(MetaName.rage__spdGrid2D);
			mb.AddStructureInfo(MetaName.CScenarioPointCluster);
			mb.AddStructureInfo(MetaName.CScenarioPointLookUps);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000347DC File Offset: 0x000329DC
		public override void Parse(MetaFile meta, CScenarioPointRegion CScenarioPointRegion)
		{
			this.Meta = meta;
			this.MetaStructure = CScenarioPointRegion;
			this.VersionNumber = CScenarioPointRegion.VersionNumber;
			this.Points = new MCScenarioPointContainer();
			this.Points.Parse(meta, CScenarioPointRegion.Points);
			CScenarioEntityOverride[] array = MetaUtils.ConvertDataArray<CScenarioEntityOverride>(meta, CScenarioPointRegion.EntityOverrides);
			this.EntityOverrides = ((array != null) ? array.Select(delegate(CScenarioEntityOverride e)
			{
				MCScenarioEntityOverride mcscenarioEntityOverride = new MCScenarioEntityOverride();
				mcscenarioEntityOverride.Parse(meta, e);
				return mcscenarioEntityOverride;
			}).ToList<MCScenarioEntityOverride>() : null);
			this.Unk_3696045377 = new MUnk_4023740759();
			this.Unk_3696045377.Parse(meta, CScenarioPointRegion.Unk_3696045377);
			this.AccelGrid = new Mrage__spdGrid2D();
			this.AccelGrid.Parse(meta, CScenarioPointRegion.AccelGrid);
			CScenarioPointCluster[] array2 = MetaUtils.ConvertDataArray<CScenarioPointCluster>(meta, CScenarioPointRegion.Clusters);
			this.Clusters = ((array2 != null) ? array2.Select(delegate(CScenarioPointCluster e)
			{
				MCScenarioPointCluster mcscenarioPointCluster = new MCScenarioPointCluster();
				mcscenarioPointCluster.Parse(meta, e);
				return mcscenarioPointCluster;
			}).ToList<MCScenarioPointCluster>() : null);
			this.LookUps = new MCScenarioPointLookUps();
			this.LookUps.Parse(meta, CScenarioPointRegion.LookUps);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00034908 File Offset: 0x00032B08
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.VersionNumber = this.VersionNumber;
			this.Points.Build(mb, false);
			this.MetaStructure.Points = this.Points.MetaStructure;
			MCScenarioPointContainer.AddEnumAndStructureInfo(mb);
			if (this.EntityOverrides != null)
			{
				this.MetaStructure.EntityOverrides = mb.AddItemArrayPtr<CScenarioEntityOverride>(MetaName.CScenarioEntityOverride, this.EntityOverrides.Select(delegate(MCScenarioEntityOverride e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CScenarioEntityOverride>());
			}
			MCScenarioEntityOverride.AddEnumAndStructureInfo(mb);
			this.Unk_3696045377.Build(mb, false);
			this.MetaStructure.Unk_3696045377 = this.Unk_3696045377.MetaStructure;
			MUnk_4023740759.AddEnumAndStructureInfo(mb);
			this.AccelGrid.Build(mb, false);
			this.MetaStructure.AccelGrid = this.AccelGrid.MetaStructure;
			Mrage__spdGrid2D.AddEnumAndStructureInfo(mb);
			if (this.Clusters != null)
			{
				this.MetaStructure.Clusters = mb.AddItemArrayPtr<CScenarioPointCluster>(MetaName.CScenarioPointCluster, this.Clusters.Select(delegate(MCScenarioPointCluster e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CScenarioPointCluster>());
			}
			MCScenarioPointCluster.AddEnumAndStructureInfo(mb);
			this.LookUps.Build(mb, false);
			this.MetaStructure.LookUps = this.LookUps.MetaStructure;
			MCScenarioPointLookUps.AddEnumAndStructureInfo(mb);
			MCScenarioPointRegion.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CScenarioPointRegion>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038FA RID: 14586
		public static MetaName _MetaName = MetaName.CScenarioPointRegion;

		// Token: 0x040038FB RID: 14587
		public MetaFile Meta;

		// Token: 0x040038FC RID: 14588
		public int VersionNumber;

		// Token: 0x040038FD RID: 14589
		public MCScenarioPointContainer Points;

		// Token: 0x040038FE RID: 14590
		public List<MCScenarioEntityOverride> EntityOverrides;

		// Token: 0x040038FF RID: 14591
		public MUnk_4023740759 Unk_3696045377;

		// Token: 0x04003900 RID: 14592
		public Mrage__spdGrid2D AccelGrid;

		// Token: 0x04003901 RID: 14593
		public Array_ushort Unk_3844724227;

		// Token: 0x04003902 RID: 14594
		public List<MCScenarioPointCluster> Clusters;

		// Token: 0x04003903 RID: 14595
		public MCScenarioPointLookUps LookUps;
	}
}
