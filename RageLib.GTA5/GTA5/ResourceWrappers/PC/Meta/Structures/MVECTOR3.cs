using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001E6 RID: 486
	public class MVECTOR3 : MetaStructureWrapper<VECTOR3>
	{
		// Token: 0x06000837 RID: 2103 RVA: 0x00038296 File Offset: 0x00036496
		public MVECTOR3()
		{
			this.MetaName = MetaName.VECTOR3;
			this.MetaStructure = default(VECTOR3);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000382B8 File Offset: 0x000364B8
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MVECTOR3._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MVECTOR3._MetaName);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000382F7 File Offset: 0x000364F7
		public override void Parse(MetaFile meta, VECTOR3 VECTOR3)
		{
			this.Meta = meta;
			this.MetaStructure = VECTOR3;
			this.X = VECTOR3.x;
			this.Y = VECTOR3.y;
			this.Z = VECTOR3.z;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0003832C File Offset: 0x0003652C
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.x = this.X;
			this.MetaStructure.y = this.Y;
			this.MetaStructure.z = this.Z;
			MVECTOR3.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<VECTOR3>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00038399 File Offset: 0x00036599
		public static implicit operator Vector3(MVECTOR3 mvec)
		{
			return new Vector3(mvec.X, mvec.Y, mvec.Z);
		}

		// Token: 0x040039DB RID: 14811
		public static MetaName _MetaName = MetaName.VECTOR3;

		// Token: 0x040039DC RID: 14812
		public MetaFile Meta;

		// Token: 0x040039DD RID: 14813
		public float X;

		// Token: 0x040039DE RID: 14814
		public float Y;

		// Token: 0x040039DF RID: 14815
		public float Z;
	}
}
