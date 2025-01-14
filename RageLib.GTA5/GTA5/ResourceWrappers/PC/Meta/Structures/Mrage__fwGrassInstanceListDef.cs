using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001CF RID: 463
	public class Mrage__fwGrassInstanceListDef : MetaStructureWrapper<rage__fwGrassInstanceListDef>
	{
		// Token: 0x060007BE RID: 1982 RVA: 0x00035386 File Offset: 0x00033586
		public Mrage__fwGrassInstanceListDef()
		{
			this.MetaName = MetaName.rage__fwGrassInstanceListDef;
			this.MetaStructure = default(rage__fwGrassInstanceListDef);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000353B0 File Offset: 0x000335B0
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(Mrage__fwGrassInstanceListDef._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(Mrage__fwGrassInstanceListDef._MetaName);
			mb.AddStructureInfo(MetaName.rage__spdAABB);
			mb.AddStructureInfo(MetaName.rage__fwGrassInstanceListDef__InstanceData);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00035408 File Offset: 0x00033608
		public override void Parse(MetaFile meta, rage__fwGrassInstanceListDef rage__fwGrassInstanceListDef)
		{
			this.Meta = meta;
			this.MetaStructure = rage__fwGrassInstanceListDef;
			this.BatchAABB = new Mrage__spdAABB();
			this.BatchAABB.Parse(meta, rage__fwGrassInstanceListDef.BatchAABB);
			this.ScaleRange = rage__fwGrassInstanceListDef.ScaleRange;
			this.ArchetypeName = rage__fwGrassInstanceListDef.archetypeName;
			this.LodDist = rage__fwGrassInstanceListDef.lodDist;
			this.LodFadeStartDist = rage__fwGrassInstanceListDef.LodFadeStartDist;
			this.LodInstFadeRange = rage__fwGrassInstanceListDef.LodInstFadeRange;
			this.OrientToTerrain = rage__fwGrassInstanceListDef.OrientToTerrain;
			rage__fwGrassInstanceListDef__InstanceData[] array = MetaUtils.ConvertDataArray<rage__fwGrassInstanceListDef__InstanceData>(meta, rage__fwGrassInstanceListDef.InstanceList);
			this.InstanceList = ((array != null) ? array.Select(delegate(rage__fwGrassInstanceListDef__InstanceData e)
			{
				Mrage__fwGrassInstanceListDef__InstanceData mrage__fwGrassInstanceListDef__InstanceData = new Mrage__fwGrassInstanceListDef__InstanceData();
				mrage__fwGrassInstanceListDef__InstanceData.Parse(meta, e);
				return mrage__fwGrassInstanceListDef__InstanceData;
			}).ToList<Mrage__fwGrassInstanceListDef__InstanceData>() : null);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000354D4 File Offset: 0x000336D4
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.BatchAABB.Build(mb, false);
			this.MetaStructure.BatchAABB = this.BatchAABB.MetaStructure;
			Mrage__spdAABB.AddEnumAndStructureInfo(mb);
			this.MetaStructure.ScaleRange = this.ScaleRange;
			this.MetaStructure.archetypeName = this.ArchetypeName;
			this.MetaStructure.lodDist = this.LodDist;
			this.MetaStructure.LodFadeStartDist = this.LodFadeStartDist;
			this.MetaStructure.LodInstFadeRange = this.LodInstFadeRange;
			this.MetaStructure.OrientToTerrain = this.OrientToTerrain;
			if (this.InstanceList != null)
			{
				this.MetaStructure.InstanceList = mb.AddItemArrayPtr<rage__fwGrassInstanceListDef__InstanceData>(MetaName.rage__fwGrassInstanceListDef__InstanceData, this.InstanceList.Select(delegate(Mrage__fwGrassInstanceListDef__InstanceData e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<rage__fwGrassInstanceListDef__InstanceData>());
			}
			Mrage__fwGrassInstanceListDef__InstanceData.AddEnumAndStructureInfo(mb);
			Mrage__fwGrassInstanceListDef.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<rage__fwGrassInstanceListDef>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003937 RID: 14647
		public static MetaName _MetaName = MetaName.rage__fwGrassInstanceListDef;

		// Token: 0x04003938 RID: 14648
		public MetaFile Meta;

		// Token: 0x04003939 RID: 14649
		public Mrage__spdAABB BatchAABB;

		// Token: 0x0400393A RID: 14650
		public Vector3 ScaleRange;

		// Token: 0x0400393B RID: 14651
		public uint ArchetypeName;

		// Token: 0x0400393C RID: 14652
		public uint LodDist;

		// Token: 0x0400393D RID: 14653
		public float LodFadeStartDist;

		// Token: 0x0400393E RID: 14654
		public float LodInstFadeRange;

		// Token: 0x0400393F RID: 14655
		public float OrientToTerrain;

		// Token: 0x04003940 RID: 14656
		public List<Mrage__fwGrassInstanceListDef__InstanceData> InstanceList = new List<Mrage__fwGrassInstanceListDef__InstanceData>();
	}
}
