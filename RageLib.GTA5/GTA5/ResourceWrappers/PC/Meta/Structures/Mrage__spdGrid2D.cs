using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001D4 RID: 468
	public class Mrage__spdGrid2D : MetaStructureWrapper<rage__spdGrid2D>
	{
		// Token: 0x060007D7 RID: 2007 RVA: 0x00035BE4 File Offset: 0x00033DE4
		public Mrage__spdGrid2D()
		{
			this.MetaName = MetaName.rage__spdGrid2D;
			this.MetaStructure = default(rage__spdGrid2D);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00035C04 File Offset: 0x00033E04
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(Mrage__spdGrid2D._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(Mrage__spdGrid2D._MetaName);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00035C44 File Offset: 0x00033E44
		public override void Parse(MetaFile meta, rage__spdGrid2D rage__spdGrid2D)
		{
			this.Meta = meta;
			this.MetaStructure = rage__spdGrid2D;
			this.Unk_860552138 = rage__spdGrid2D.Unk_860552138;
			this.Unk_3824598937 = rage__spdGrid2D.Unk_3824598937;
			this.Unk_496029782 = rage__spdGrid2D.Unk_496029782;
			this.Unk_3374647798 = rage__spdGrid2D.Unk_3374647798;
			this.Unk_2690909759 = rage__spdGrid2D.Unk_2690909759;
			this.Unk_3691675019 = rage__spdGrid2D.Unk_3691675019;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00035CA8 File Offset: 0x00033EA8
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.Unk_860552138 = this.Unk_860552138;
			this.MetaStructure.Unk_3824598937 = this.Unk_3824598937;
			this.MetaStructure.Unk_496029782 = this.Unk_496029782;
			this.MetaStructure.Unk_3374647798 = this.Unk_3374647798;
			this.MetaStructure.Unk_2690909759 = this.Unk_2690909759;
			this.MetaStructure.Unk_3691675019 = this.Unk_3691675019;
			Mrage__spdGrid2D.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<rage__spdGrid2D>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003957 RID: 14679
		public static MetaName _MetaName = MetaName.rage__spdGrid2D;

		// Token: 0x04003958 RID: 14680
		public MetaFile Meta;

		// Token: 0x04003959 RID: 14681
		public int Unk_860552138;

		// Token: 0x0400395A RID: 14682
		public int Unk_3824598937;

		// Token: 0x0400395B RID: 14683
		public int Unk_496029782;

		// Token: 0x0400395C RID: 14684
		public int Unk_3374647798;

		// Token: 0x0400395D RID: 14685
		public float Unk_2690909759;

		// Token: 0x0400395E RID: 14686
		public float Unk_3691675019;
	}
}
