using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001BD RID: 445
	public class MCMloTimeCycleModifier : MetaStructureWrapper<CMloTimeCycleModifier>
	{
		// Token: 0x06000765 RID: 1893 RVA: 0x000337BB File Offset: 0x000319BB
		public MCMloTimeCycleModifier()
		{
			this.MetaName = MetaName.CMloTimeCycleModifier;
			this.MetaStructure = default(CMloTimeCycleModifier);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000337DC File Offset: 0x000319DC
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCMloTimeCycleModifier._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCMloTimeCycleModifier._MetaName);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0003381C File Offset: 0x00031A1C
		public override void Parse(MetaFile meta, CMloTimeCycleModifier CMloTimeCycleModifier)
		{
			this.Meta = meta;
			this.MetaStructure = CMloTimeCycleModifier;
			this.Name = CMloTimeCycleModifier.name;
			this.Sphere = CMloTimeCycleModifier.sphere;
			this.Percentage = CMloTimeCycleModifier.percentage;
			this.Range = CMloTimeCycleModifier.range;
			this.StartHour = CMloTimeCycleModifier.startHour;
			this.EndHour = CMloTimeCycleModifier.endHour;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00033880 File Offset: 0x00031A80
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.sphere = this.Sphere;
			this.MetaStructure.percentage = this.Percentage;
			this.MetaStructure.range = this.Range;
			this.MetaStructure.startHour = this.StartHour;
			this.MetaStructure.endHour = this.EndHour;
			MCMloTimeCycleModifier.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CMloTimeCycleModifier>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038A6 RID: 14502
		public static MetaName _MetaName = MetaName.CMloTimeCycleModifier;

		// Token: 0x040038A7 RID: 14503
		public MetaFile Meta;

		// Token: 0x040038A8 RID: 14504
		public uint Name;

		// Token: 0x040038A9 RID: 14505
		public Vector4 Sphere;

		// Token: 0x040038AA RID: 14506
		public float Percentage;

		// Token: 0x040038AB RID: 14507
		public float Range;

		// Token: 0x040038AC RID: 14508
		public uint StartHour;

		// Token: 0x040038AD RID: 14509
		public uint EndHour;
	}
}
