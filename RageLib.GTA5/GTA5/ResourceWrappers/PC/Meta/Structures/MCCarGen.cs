using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x0200019E RID: 414
	public class MCCarGen : MetaStructureWrapper<CCarGen>
	{
		// Token: 0x060006B4 RID: 1716 RVA: 0x0002D8D3 File Offset: 0x0002BAD3
		public MCCarGen()
		{
			this.MetaName = MetaName.CCarGen;
			this.MetaStructure = default(CCarGen);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0002D8F4 File Offset: 0x0002BAF4
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCCarGen._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCCarGen._MetaName);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0002D934 File Offset: 0x0002BB34
		public override void Parse(MetaFile meta, CCarGen CCarGen)
		{
			this.Meta = meta;
			this.MetaStructure = CCarGen;
			this.Position = CCarGen.position;
			this.OrientX = CCarGen.orientX;
			this.OrientY = CCarGen.orientY;
			this.PerpendicularLength = CCarGen.perpendicularLength;
			this.CarModel = CCarGen.carModel;
			this.Flags = CCarGen.flags;
			this.BodyColorRemap1 = CCarGen.bodyColorRemap1;
			this.BodyColorRemap2 = CCarGen.bodyColorRemap2;
			this.BodyColorRemap3 = CCarGen.bodyColorRemap3;
			this.BodyColorRemap4 = CCarGen.bodyColorRemap4;
			this.PopGroup = CCarGen.popGroup;
			this.Livery = CCarGen.livery;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0002D9E0 File Offset: 0x0002BBE0
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.position = this.Position;
			this.MetaStructure.orientX = this.OrientX;
			this.MetaStructure.orientY = this.OrientY;
			this.MetaStructure.perpendicularLength = this.PerpendicularLength;
			this.MetaStructure.carModel = this.CarModel;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.bodyColorRemap1 = this.BodyColorRemap1;
			this.MetaStructure.bodyColorRemap2 = this.BodyColorRemap2;
			this.MetaStructure.bodyColorRemap3 = this.BodyColorRemap3;
			this.MetaStructure.bodyColorRemap4 = this.BodyColorRemap4;
			this.MetaStructure.popGroup = this.PopGroup;
			this.MetaStructure.livery = this.Livery;
			MCCarGen.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CCarGen>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003713 RID: 14099
		public static MetaName _MetaName = MetaName.CCarGen;

		// Token: 0x04003714 RID: 14100
		public MetaFile Meta;

		// Token: 0x04003715 RID: 14101
		public Vector3 Position;

		// Token: 0x04003716 RID: 14102
		public float OrientX;

		// Token: 0x04003717 RID: 14103
		public float OrientY;

		// Token: 0x04003718 RID: 14104
		public float PerpendicularLength;

		// Token: 0x04003719 RID: 14105
		public uint CarModel;

		// Token: 0x0400371A RID: 14106
		public uint Flags;

		// Token: 0x0400371B RID: 14107
		public int BodyColorRemap1;

		// Token: 0x0400371C RID: 14108
		public int BodyColorRemap2;

		// Token: 0x0400371D RID: 14109
		public int BodyColorRemap3;

		// Token: 0x0400371E RID: 14110
		public int BodyColorRemap4;

		// Token: 0x0400371F RID: 14111
		public uint PopGroup;

		// Token: 0x04003720 RID: 14112
		public sbyte Livery;
	}
}
