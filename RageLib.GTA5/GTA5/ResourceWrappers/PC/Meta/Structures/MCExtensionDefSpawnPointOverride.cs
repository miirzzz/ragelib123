using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001B1 RID: 433
	public class MCExtensionDefSpawnPointOverride : MetaStructureWrapper<CExtensionDefSpawnPointOverride>
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x00030360 File Offset: 0x0002E560
		public MCExtensionDefSpawnPointOverride()
		{
			this.MetaName = MetaName.CExtensionDefSpawnPointOverride;
			this.MetaStructure = default(CExtensionDefSpawnPointOverride);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00030380 File Offset: 0x0002E580
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefSpawnPointOverride._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefSpawnPointOverride._MetaName);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000303C0 File Offset: 0x0002E5C0
		public override void Parse(MetaFile meta, CExtensionDefSpawnPointOverride CExtensionDefSpawnPointOverride)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefSpawnPointOverride;
			this.Name = CExtensionDefSpawnPointOverride.name;
			this.OffsetPosition = CExtensionDefSpawnPointOverride.offsetPosition;
			this.ScenarioType = CExtensionDefSpawnPointOverride.ScenarioType;
			this.ITimeStartOverride = CExtensionDefSpawnPointOverride.iTimeStartOverride;
			this.ITimeEndOverride = CExtensionDefSpawnPointOverride.iTimeEndOverride;
			this.Group = CExtensionDefSpawnPointOverride.Group;
			this.ModelSet = CExtensionDefSpawnPointOverride.ModelSet;
			this.AvailabilityInMpSp = CExtensionDefSpawnPointOverride.AvailabilityInMpSp;
			this.Flags = CExtensionDefSpawnPointOverride.Flags;
			this.Radius = CExtensionDefSpawnPointOverride.Radius;
			this.TimeTillPedLeaves = CExtensionDefSpawnPointOverride.TimeTillPedLeaves;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00030460 File Offset: 0x0002E660
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.ScenarioType = this.ScenarioType;
			this.MetaStructure.iTimeStartOverride = this.ITimeStartOverride;
			this.MetaStructure.iTimeEndOverride = this.ITimeEndOverride;
			this.MetaStructure.Group = this.Group;
			this.MetaStructure.ModelSet = this.ModelSet;
			this.MetaStructure.AvailabilityInMpSp = this.AvailabilityInMpSp;
			this.MetaStructure.Flags = this.Flags;
			this.MetaStructure.Radius = this.Radius;
			this.MetaStructure.TimeTillPedLeaves = this.TimeTillPedLeaves;
			MCExtensionDefSpawnPointOverride.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefSpawnPointOverride>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040037E6 RID: 14310
		public static MetaName _MetaName = MetaName.CExtensionDefSpawnPointOverride;

		// Token: 0x040037E7 RID: 14311
		public MetaFile Meta;

		// Token: 0x040037E8 RID: 14312
		public uint Name;

		// Token: 0x040037E9 RID: 14313
		public Vector3 OffsetPosition;

		// Token: 0x040037EA RID: 14314
		public uint ScenarioType;

		// Token: 0x040037EB RID: 14315
		public byte ITimeStartOverride;

		// Token: 0x040037EC RID: 14316
		public byte ITimeEndOverride;

		// Token: 0x040037ED RID: 14317
		public uint Group;

		// Token: 0x040037EE RID: 14318
		public uint ModelSet;

		// Token: 0x040037EF RID: 14319
		public Unk_3573596290 AvailabilityInMpSp;

		// Token: 0x040037F0 RID: 14320
		public Unk_700327466 Flags;

		// Token: 0x040037F1 RID: 14321
		public float Radius;

		// Token: 0x040037F2 RID: 14322
		public float TimeTillPedLeaves;
	}
}
