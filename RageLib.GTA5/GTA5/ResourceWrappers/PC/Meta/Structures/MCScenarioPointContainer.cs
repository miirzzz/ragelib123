using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001C6 RID: 454
	public class MCScenarioPointContainer : MetaStructureWrapper<CScenarioPointContainer>
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x00034482 File Offset: 0x00032682
		public MCScenarioPointContainer()
		{
			this.MetaName = MetaName.CScenarioPointContainer;
			this.MetaStructure = default(CScenarioPointContainer);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000344A4 File Offset: 0x000326A4
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCScenarioPointContainer._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCScenarioPointContainer._MetaName);
			mb.AddStructureInfo(MetaName.CExtensionDefSpawnPoint);
			mb.AddStructureInfo(MetaName.CScenarioPoint);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000344FC File Offset: 0x000326FC
		public override void Parse(MetaFile meta, CScenarioPointContainer CScenarioPointContainer)
		{
			this.Meta = meta;
			this.MetaStructure = CScenarioPointContainer;
			CExtensionDefSpawnPoint[] array = MetaUtils.ConvertDataArray<CExtensionDefSpawnPoint>(meta, CScenarioPointContainer.LoadSavePoints);
			this.LoadSavePoints = ((array != null) ? array.Select(delegate(CExtensionDefSpawnPoint e)
			{
				MCExtensionDefSpawnPoint mcextensionDefSpawnPoint = new MCExtensionDefSpawnPoint();
				mcextensionDefSpawnPoint.Parse(meta, e);
				return mcextensionDefSpawnPoint;
			}).ToList<MCExtensionDefSpawnPoint>() : null);
			CScenarioPoint[] array2 = MetaUtils.ConvertDataArray<CScenarioPoint>(meta, CScenarioPointContainer.MyPoints);
			this.MyPoints = ((array2 != null) ? array2.Select(delegate(CScenarioPoint e)
			{
				MCScenarioPoint mcscenarioPoint = new MCScenarioPoint();
				mcscenarioPoint.Parse(meta, e);
				return mcscenarioPoint;
			}).ToList<MCScenarioPoint>() : null);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00034594 File Offset: 0x00032794
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			if (this.LoadSavePoints != null)
			{
				this.MetaStructure.LoadSavePoints = mb.AddItemArrayPtr<CExtensionDefSpawnPoint>(MetaName.CExtensionDefSpawnPoint, this.LoadSavePoints.Select(delegate(MCExtensionDefSpawnPoint e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CExtensionDefSpawnPoint>());
			}
			MCExtensionDefSpawnPoint.AddEnumAndStructureInfo(mb);
			if (this.MyPoints != null)
			{
				this.MetaStructure.MyPoints = mb.AddItemArrayPtr<CScenarioPoint>(MetaName.CScenarioPoint, this.MyPoints.Select(delegate(MCScenarioPoint e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CScenarioPoint>());
			}
			MCScenarioPoint.AddEnumAndStructureInfo(mb);
			MCScenarioPointContainer.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CScenarioPointContainer>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038EE RID: 14574
		public static MetaName _MetaName = MetaName.CScenarioPointContainer;

		// Token: 0x040038EF RID: 14575
		public MetaFile Meta;

		// Token: 0x040038F0 RID: 14576
		public List<MCExtensionDefSpawnPoint> LoadSavePoints;

		// Token: 0x040038F1 RID: 14577
		public List<MCScenarioPoint> MyPoints;
	}
}
