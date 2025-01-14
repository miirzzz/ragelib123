using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001D3 RID: 467
	public class Mrage__spdAABB : MetaStructureWrapper<rage__spdAABB>
	{
		// Token: 0x060007D2 RID: 2002 RVA: 0x00035AF5 File Offset: 0x00033CF5
		public Mrage__spdAABB()
		{
			this.MetaName = MetaName.rage__spdAABB;
			this.MetaStructure = default(rage__spdAABB);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00035B14 File Offset: 0x00033D14
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(Mrage__spdAABB._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(Mrage__spdAABB._MetaName);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00035B53 File Offset: 0x00033D53
		public override void Parse(MetaFile meta, rage__spdAABB rage__spdAABB)
		{
			this.Meta = meta;
			this.MetaStructure = rage__spdAABB;
			this.Min = rage__spdAABB.min;
			this.Max = rage__spdAABB.max;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00035B7C File Offset: 0x00033D7C
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.min = this.Min;
			this.MetaStructure.max = this.Max;
			Mrage__spdAABB.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<rage__spdAABB>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003953 RID: 14675
		public static MetaName _MetaName = MetaName.rage__spdAABB;

		// Token: 0x04003954 RID: 14676
		public MetaFile Meta;

		// Token: 0x04003955 RID: 14677
		public Vector4 Min;

		// Token: 0x04003956 RID: 14678
		public Vector4 Max;
	}
}
