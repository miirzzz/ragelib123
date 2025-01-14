using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001CD RID: 461
	public class MCTimeCycleModifier : MetaStructureWrapper<CTimeCycleModifier>
	{
		// Token: 0x060007B5 RID: 1973 RVA: 0x000351BB File Offset: 0x000333BB
		public MCTimeCycleModifier()
		{
			this.MetaName = MetaName.CTimeCycleModifier;
			this.MetaStructure = default(CTimeCycleModifier);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000351DC File Offset: 0x000333DC
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCTimeCycleModifier._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCTimeCycleModifier._MetaName);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0003521C File Offset: 0x0003341C
		public override void Parse(MetaFile meta, CTimeCycleModifier CTimeCycleModifier)
		{
			this.Meta = meta;
			this.MetaStructure = CTimeCycleModifier;
			this.Name = CTimeCycleModifier.name;
			this.MinExtents = CTimeCycleModifier.minExtents;
			this.MaxExtents = CTimeCycleModifier.maxExtents;
			this.Percentage = CTimeCycleModifier.percentage;
			this.Range = CTimeCycleModifier.range;
			this.StartHour = CTimeCycleModifier.startHour;
			this.EndHour = CTimeCycleModifier.endHour;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0003528C File Offset: 0x0003348C
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.minExtents = this.MinExtents;
			this.MetaStructure.maxExtents = this.MaxExtents;
			this.MetaStructure.percentage = this.Percentage;
			this.MetaStructure.range = this.Range;
			this.MetaStructure.startHour = this.StartHour;
			this.MetaStructure.endHour = this.EndHour;
			MCTimeCycleModifier.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CTimeCycleModifier>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400392C RID: 14636
		public static MetaName _MetaName = MetaName.CTimeCycleModifier;

		// Token: 0x0400392D RID: 14637
		public MetaFile Meta;

		// Token: 0x0400392E RID: 14638
		public uint Name;

		// Token: 0x0400392F RID: 14639
		public Vector3 MinExtents;

		// Token: 0x04003930 RID: 14640
		public Vector3 MaxExtents;

		// Token: 0x04003931 RID: 14641
		public float Percentage;

		// Token: 0x04003932 RID: 14642
		public float Range;

		// Token: 0x04003933 RID: 14643
		public uint StartHour;

		// Token: 0x04003934 RID: 14644
		public uint EndHour;
	}
}
