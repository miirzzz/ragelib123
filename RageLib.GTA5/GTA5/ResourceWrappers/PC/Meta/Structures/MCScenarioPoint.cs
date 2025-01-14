using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001C4 RID: 452
	public class MCScenarioPoint : MetaStructureWrapper<CScenarioPoint>
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x000340A4 File Offset: 0x000322A4
		public MCScenarioPoint()
		{
			this.MetaName = MetaName.CScenarioPoint;
			this.MetaStructure = default(CScenarioPoint);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000340C4 File Offset: 0x000322C4
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCScenarioPoint._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCScenarioPoint._MetaName);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00034104 File Offset: 0x00032304
		public override void Parse(MetaFile meta, CScenarioPoint CScenarioPoint)
		{
			this.Meta = meta;
			this.MetaStructure = CScenarioPoint;
			this.IType = CScenarioPoint.iType;
			this.ModelSetId = CScenarioPoint.ModelSetId;
			this.IInterior = CScenarioPoint.iInterior;
			this.IRequiredIMapId = CScenarioPoint.iRequiredIMapId;
			this.IProbability = CScenarioPoint.iProbability;
			this.UAvailableInMpSp = CScenarioPoint.uAvailableInMpSp;
			this.ITimeStartOverride = CScenarioPoint.iTimeStartOverride;
			this.ITimeEndOverride = CScenarioPoint.iTimeEndOverride;
			this.IRadius = CScenarioPoint.iRadius;
			this.ITimeTillPedLeaves = CScenarioPoint.iTimeTillPedLeaves;
			this.IScenarioGroup = CScenarioPoint.iScenarioGroup;
			this.Flags = CScenarioPoint.Flags;
			this.VPositionAndDirection = CScenarioPoint.vPositionAndDirection;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000341BC File Offset: 0x000323BC
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.iType = this.IType;
			this.MetaStructure.ModelSetId = this.ModelSetId;
			this.MetaStructure.iInterior = this.IInterior;
			this.MetaStructure.iRequiredIMapId = this.IRequiredIMapId;
			this.MetaStructure.iProbability = this.IProbability;
			this.MetaStructure.uAvailableInMpSp = this.UAvailableInMpSp;
			this.MetaStructure.iTimeStartOverride = this.ITimeStartOverride;
			this.MetaStructure.iTimeEndOverride = this.ITimeEndOverride;
			this.MetaStructure.iRadius = this.IRadius;
			this.MetaStructure.iTimeTillPedLeaves = this.ITimeTillPedLeaves;
			this.MetaStructure.iScenarioGroup = this.IScenarioGroup;
			this.MetaStructure.Flags = this.Flags;
			this.MetaStructure.vPositionAndDirection = this.VPositionAndDirection;
			MCScenarioPoint.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CScenarioPoint>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038D9 RID: 14553
		public static MetaName _MetaName = MetaName.CScenarioPoint;

		// Token: 0x040038DA RID: 14554
		public MetaFile Meta;

		// Token: 0x040038DB RID: 14555
		public byte IType;

		// Token: 0x040038DC RID: 14556
		public byte ModelSetId;

		// Token: 0x040038DD RID: 14557
		public byte IInterior;

		// Token: 0x040038DE RID: 14558
		public byte IRequiredIMapId;

		// Token: 0x040038DF RID: 14559
		public byte IProbability;

		// Token: 0x040038E0 RID: 14560
		public byte UAvailableInMpSp;

		// Token: 0x040038E1 RID: 14561
		public byte ITimeStartOverride;

		// Token: 0x040038E2 RID: 14562
		public byte ITimeEndOverride;

		// Token: 0x040038E3 RID: 14563
		public byte IRadius;

		// Token: 0x040038E4 RID: 14564
		public byte ITimeTillPedLeaves;

		// Token: 0x040038E5 RID: 14565
		public ushort IScenarioGroup;

		// Token: 0x040038E6 RID: 14566
		public Unk_700327466 Flags;

		// Token: 0x040038E7 RID: 14567
		public Vector4 VPositionAndDirection;
	}
}
