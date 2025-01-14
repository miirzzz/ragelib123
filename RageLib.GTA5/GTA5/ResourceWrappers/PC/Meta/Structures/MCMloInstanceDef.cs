using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001BA RID: 442
	public class MCMloInstanceDef : MetaStructureWrapper<CMloInstanceDef>
	{
		// Token: 0x06000754 RID: 1876 RVA: 0x00032F3B File Offset: 0x0003113B
		public MCMloInstanceDef()
		{
			this.MetaName = MetaName.CMloInstanceDef;
			this.MetaStructure = default(CMloInstanceDef);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00032F5C File Offset: 0x0003115C
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCMloInstanceDef._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCMloInstanceDef._MetaName);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00032F9C File Offset: 0x0003119C
		public override void Parse(MetaFile meta, CMloInstanceDef CMloInstanceDef)
		{
			this.Meta = meta;
			this.MetaStructure = CMloInstanceDef;
			this.ArchetypeName = CMloInstanceDef.archetypeName;
			this.Flags = CMloInstanceDef.flags;
			this.Guid = CMloInstanceDef.guid;
			this.Position = CMloInstanceDef.position;
			this.Rotation = CMloInstanceDef.rotation;
			this.ScaleXY = CMloInstanceDef.scaleXY;
			this.ScaleZ = CMloInstanceDef.scaleZ;
			this.ParentIndex = CMloInstanceDef.parentIndex;
			this.LodDist = CMloInstanceDef.lodDist;
			this.ChildLodDist = CMloInstanceDef.childLodDist;
			this.LodLevel = CMloInstanceDef.lodLevel;
			this.NumChildren = CMloInstanceDef.numChildren;
			this.PriorityLevel = CMloInstanceDef.priorityLevel;
			this.Extensions = default(Array_StructurePointer);
			this.AmbientOcclusionMultiplier = CMloInstanceDef.ambientOcclusionMultiplier;
			this.ArtificialAmbientOcclusion = CMloInstanceDef.artificialAmbientOcclusion;
			this.TintValue = CMloInstanceDef.tintValue;
			this.GroupId = CMloInstanceDef.groupId;
			this.FloorId = CMloInstanceDef.floorId;
			this.DefaultEntitySets = CMloInstanceDef.defaultEntitySets;
			this.NumExitPortals = CMloInstanceDef.numExitPortals;
			this.MLOInstflags = CMloInstanceDef.MLOInstflags;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000330C0 File Offset: 0x000312C0
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.archetypeName = this.ArchetypeName;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.guid = this.Guid;
			this.MetaStructure.position = this.Position;
			this.MetaStructure.rotation = this.Rotation;
			this.MetaStructure.scaleXY = this.ScaleXY;
			this.MetaStructure.scaleZ = this.ScaleZ;
			this.MetaStructure.parentIndex = this.ParentIndex;
			this.MetaStructure.lodDist = this.LodDist;
			this.MetaStructure.childLodDist = this.ChildLodDist;
			this.MetaStructure.lodLevel = this.LodLevel;
			this.MetaStructure.numChildren = this.NumChildren;
			this.MetaStructure.priorityLevel = this.PriorityLevel;
			this.MetaStructure.extensions = this.Extensions;
			this.MetaStructure.ambientOcclusionMultiplier = this.AmbientOcclusionMultiplier;
			this.MetaStructure.artificialAmbientOcclusion = this.ArtificialAmbientOcclusion;
			this.MetaStructure.tintValue = this.TintValue;
			this.MetaStructure.groupId = this.GroupId;
			this.MetaStructure.floorId = this.FloorId;
			this.MetaStructure.defaultEntitySets = this.DefaultEntitySets;
			this.MetaStructure.numExitPortals = this.NumExitPortals;
			this.MetaStructure.MLOInstflags = this.MLOInstflags;
			MCMloInstanceDef.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CMloInstanceDef>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003876 RID: 14454
		public static MetaName _MetaName = MetaName.CMloInstanceDef;

		// Token: 0x04003877 RID: 14455
		public MetaFile Meta;

		// Token: 0x04003878 RID: 14456
		public uint ArchetypeName;

		// Token: 0x04003879 RID: 14457
		public uint Flags;

		// Token: 0x0400387A RID: 14458
		public uint Guid;

		// Token: 0x0400387B RID: 14459
		public Vector3 Position;

		// Token: 0x0400387C RID: 14460
		public Vector4 Rotation;

		// Token: 0x0400387D RID: 14461
		public float ScaleXY;

		// Token: 0x0400387E RID: 14462
		public float ScaleZ;

		// Token: 0x0400387F RID: 14463
		public int ParentIndex;

		// Token: 0x04003880 RID: 14464
		public float LodDist;

		// Token: 0x04003881 RID: 14465
		public float ChildLodDist;

		// Token: 0x04003882 RID: 14466
		public Unk_1264241711 LodLevel;

		// Token: 0x04003883 RID: 14467
		public uint NumChildren;

		// Token: 0x04003884 RID: 14468
		public Unk_648413703 PriorityLevel;

		// Token: 0x04003885 RID: 14469
		public Array_StructurePointer Extensions;

		// Token: 0x04003886 RID: 14470
		public int AmbientOcclusionMultiplier;

		// Token: 0x04003887 RID: 14471
		public int ArtificialAmbientOcclusion;

		// Token: 0x04003888 RID: 14472
		public uint TintValue;

		// Token: 0x04003889 RID: 14473
		public uint GroupId;

		// Token: 0x0400388A RID: 14474
		public uint FloorId;

		// Token: 0x0400388B RID: 14475
		public Array_uint DefaultEntitySets;

		// Token: 0x0400388C RID: 14476
		public uint NumExitPortals;

		// Token: 0x0400388D RID: 14477
		public uint MLOInstflags;
	}
}
