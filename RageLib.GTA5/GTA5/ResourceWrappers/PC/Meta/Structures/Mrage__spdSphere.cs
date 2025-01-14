using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001D5 RID: 469
	public class Mrage__spdSphere : MetaStructureWrapper<rage__spdSphere>
	{
		// Token: 0x060007DC RID: 2012 RVA: 0x00035D54 File Offset: 0x00033F54
		public Mrage__spdSphere()
		{
			this.MetaName = MetaName.rage__spdSphere;
			this.MetaStructure = default(rage__spdSphere);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00035D74 File Offset: 0x00033F74
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(Mrage__spdSphere._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(Mrage__spdSphere._MetaName);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00035DB3 File Offset: 0x00033FB3
		public override void Parse(MetaFile meta, rage__spdSphere rage__spdSphere)
		{
			this.Meta = meta;
			this.MetaStructure = rage__spdSphere;
			this.CenterAndRadius = rage__spdSphere.centerAndRadius;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00035DCF File Offset: 0x00033FCF
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.centerAndRadius = this.CenterAndRadius;
			Mrage__spdSphere.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<rage__spdSphere>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400395F RID: 14687
		public static MetaName _MetaName = MetaName.rage__spdSphere;

		// Token: 0x04003960 RID: 14688
		public MetaFile Meta;

		// Token: 0x04003961 RID: 14689
		public Vector4 CenterAndRadius;
	}
}
