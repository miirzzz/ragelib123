using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001C3 RID: 451
	public class MCScenarioEntityOverride : MetaStructureWrapper<CScenarioEntityOverride>
	{
		// Token: 0x06000783 RID: 1923 RVA: 0x00033EB3 File Offset: 0x000320B3
		public MCScenarioEntityOverride()
		{
			this.MetaName = MetaName.CScenarioEntityOverride;
			this.MetaStructure = default(CScenarioEntityOverride);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00033ED4 File Offset: 0x000320D4
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCScenarioEntityOverride._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCScenarioEntityOverride._MetaName);
			mb.AddStructureInfo(MetaName.CExtensionDefSpawnPoint);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00033F20 File Offset: 0x00032120
		public override void Parse(MetaFile meta, CScenarioEntityOverride CScenarioEntityOverride)
		{
			this.Meta = meta;
			this.MetaStructure = CScenarioEntityOverride;
			this.EntityPosition = CScenarioEntityOverride.EntityPosition;
			this.EntityType = CScenarioEntityOverride.EntityType;
			CExtensionDefSpawnPoint[] array = MetaUtils.ConvertDataArray<CExtensionDefSpawnPoint>(meta, CScenarioEntityOverride.ScenarioPoints);
			this.ScenarioPoints = ((array != null) ? array.Select(delegate(CExtensionDefSpawnPoint e)
			{
				MCExtensionDefSpawnPoint mcextensionDefSpawnPoint = new MCExtensionDefSpawnPoint();
				mcextensionDefSpawnPoint.Parse(meta, e);
				return mcextensionDefSpawnPoint;
			}).ToList<MCExtensionDefSpawnPoint>() : null);
			this.Unk_538733109 = CScenarioEntityOverride.Unk_538733109;
			this.Unk_1035513142 = CScenarioEntityOverride.Unk_1035513142;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00033FB4 File Offset: 0x000321B4
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.EntityPosition = this.EntityPosition;
			this.MetaStructure.EntityType = this.EntityType;
			if (this.ScenarioPoints != null)
			{
				this.MetaStructure.ScenarioPoints = mb.AddItemArrayPtr<CExtensionDefSpawnPoint>(MetaName.CExtensionDefSpawnPoint, this.ScenarioPoints.Select(delegate(MCExtensionDefSpawnPoint e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CExtensionDefSpawnPoint>());
			}
			MCExtensionDefSpawnPoint.AddEnumAndStructureInfo(mb);
			this.MetaStructure.Unk_538733109 = this.Unk_538733109;
			this.MetaStructure.Unk_1035513142 = this.Unk_1035513142;
			MCScenarioEntityOverride.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CScenarioEntityOverride>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038D2 RID: 14546
		public static MetaName _MetaName = MetaName.CScenarioEntityOverride;

		// Token: 0x040038D3 RID: 14547
		public MetaFile Meta;

		// Token: 0x040038D4 RID: 14548
		public Vector3 EntityPosition;

		// Token: 0x040038D5 RID: 14549
		public uint EntityType;

		// Token: 0x040038D6 RID: 14550
		public List<MCExtensionDefSpawnPoint> ScenarioPoints;

		// Token: 0x040038D7 RID: 14551
		public byte Unk_538733109;

		// Token: 0x040038D8 RID: 14552
		public byte Unk_1035513142;
	}
}
