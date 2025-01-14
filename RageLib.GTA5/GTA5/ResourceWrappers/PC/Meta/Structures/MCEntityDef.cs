using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001A4 RID: 420
	public class MCEntityDef : MetaStructureWrapper<CEntityDef>
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0002E507 File Offset: 0x0002C707
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x0002E510 File Offset: 0x0002C710
		public int ParentIndex
		{
			get
			{
				return this._ParentIndex;
			}
			set
			{
				this._ParentIndex = value;
				if (this.Parent != null)
				{
					if (this._ParentEntity != null && this._ParentEntity.Children.IndexOf(this) != -1)
					{
						this._ParentEntity.Children.Remove(this);
						this._ParentEntity.NumChildren = (uint)this._ParentEntity.Children.Count;
					}
					if (value == -1)
					{
						this._ParentEntity = null;
					}
					else
					{
						MCEntityDef mcentityDef = (this.Parent.Entities.Count > value) ? this.Parent.Entities[value] : null;
						MCMapData parent = this.Parent;
						bool flag;
						if (parent == null)
						{
							flag = false;
						}
						else
						{
							MCMapData parentMapData = parent.ParentMapData;
							int? num = (parentMapData != null) ? new int?(parentMapData.Entities.Count) : null;
							flag = (num.GetValueOrDefault() > value & num != null);
						}
						MCEntityDef mcentityDef2 = flag ? this.Parent.ParentMapData.Entities[value] : null;
						int num2 = MCMapData.LodLevels.IndexOf(this.LodLevel);
						bool flag2 = false;
						if (mcentityDef != null && MCMapData.LodLevels.IndexOf(mcentityDef.LodLevel) < num2)
						{
							flag2 = true;
							this._ParentEntity = mcentityDef;
						}
						if (!flag2 && mcentityDef2 != null && MCMapData.LodLevels.IndexOf(mcentityDef2.LodLevel) < num2)
						{
							flag2 = true;
							this._ParentEntity = mcentityDef2;
						}
						if (!flag2)
						{
							this._ParentEntity = null;
						}
					}
					if (this._ParentEntity != null && this._ParentEntity.Children.IndexOf(this) == -1)
					{
						this._ParentEntity.Children.Add(this);
						this._ParentEntity.NumChildren = (uint)this._ParentEntity.Children.Count;
					}
				}
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0002E6BB File Offset: 0x0002C8BB
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x0002E6C4 File Offset: 0x0002C8C4
		public MCEntityDef ParentEntity
		{
			get
			{
				return this._ParentEntity;
			}
			set
			{
				if (this._ParentEntity != null && this.ParentEntity.Children.IndexOf(this) != -1)
				{
					this._ParentEntity.Children.Remove(this);
					this._ParentEntity.NumChildren = (uint)this._ParentEntity.Children.Count;
				}
				this._ParentEntity = value;
				if (value == null)
				{
					this._ParentIndex = -1;
				}
				else
				{
					MCMapData parent = value.Parent;
					this._ParentIndex = ((parent != null) ? parent.Entities.IndexOf(value) : -1);
				}
				if (this._ParentEntity != null && this.ParentEntity.Children.IndexOf(this) == -1)
				{
					this._ParentEntity.Children.Add(this);
					this._ParentEntity.NumChildren = (uint)this._ParentEntity.Children.Count;
				}
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0002E794 File Offset: 0x0002C994
		public MCEntityDef(MCMapData parent = null)
		{
			this.MetaName = MetaName.CEntityDef;
			this.MetaStructure = default(CEntityDef);
			this.Parent = parent;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0002E7FC File Offset: 0x0002C9FC
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCEntityDef._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCEntityDef._MetaName);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0002E83C File Offset: 0x0002CA3C
		public override void Parse(MetaFile meta, CEntityDef CEntityDef)
		{
			this.Meta = meta;
			this.MetaStructure = CEntityDef;
			this.ArchetypeName = CEntityDef.archetypeName;
			this.Flags = CEntityDef.flags;
			this.Guid = CEntityDef.guid;
			this.Position = CEntityDef.position;
			this.Rotation = CEntityDef.rotation;
			this.ScaleXY = CEntityDef.scaleXY;
			this.ScaleZ = CEntityDef.scaleZ;
			this.ParentIndex = CEntityDef.parentIndex;
			this.LodDist = CEntityDef.lodDist;
			this.ChildLodDist = CEntityDef.childLodDist;
			this.LodLevel = CEntityDef.lodLevel;
			this.NumChildren = CEntityDef.numChildren;
			this.PriorityLevel = CEntityDef.priorityLevel;
			MetaPOINTER[] pointerArray = MetaUtils.GetPointerArray(meta, CEntityDef.extensions);
			if (pointerArray != null)
			{
				foreach (MetaPOINTER ptr in pointerArray)
				{
					MetaName structureNameHash = meta.GetBlock(ptr.BlockID).StructureNameHash;
					if (structureNameHash <= MetaName.CExtensionDefLightEffect)
					{
						if (structureNameHash != MetaName.CExtensionDefSpawnPointOverride)
						{
							if (structureNameHash == MetaName.CExtensionDefLightEffect)
							{
								CExtensionDefLightEffect data = MetaUtils.GetData<CExtensionDefLightEffect>(meta, ptr);
								MCExtensionDefLightEffect mcextensionDefLightEffect = new MCExtensionDefLightEffect();
								mcextensionDefLightEffect.Parse(meta, data);
								this.ExtensionDefLightEffect.Add(mcextensionDefLightEffect);
							}
						}
						else
						{
							CExtensionDefSpawnPointOverride data2 = MetaUtils.GetData<CExtensionDefSpawnPointOverride>(meta, ptr);
							MCExtensionDefSpawnPointOverride mcextensionDefSpawnPointOverride = new MCExtensionDefSpawnPointOverride();
							mcextensionDefSpawnPointOverride.Parse(meta, data2);
							this.ExtensionDefSpawnPointOverride.Add(mcextensionDefSpawnPointOverride);
						}
					}
					else if (structureNameHash != MetaName.rage__phVerletClothCustomBounds)
					{
						if (structureNameHash == MetaName.CExtensionDefDoor)
						{
							CExtensionDefDoor data3 = MetaUtils.GetData<CExtensionDefDoor>(meta, ptr);
							MCExtensionDefDoor mcextensionDefDoor = new MCExtensionDefDoor();
							mcextensionDefDoor.Parse(meta, data3);
							this.ExtensionDefDoor.Add(mcextensionDefDoor);
						}
					}
					else
					{
						rage__phVerletClothCustomBounds data4 = MetaUtils.GetData<rage__phVerletClothCustomBounds>(meta, ptr);
						Mrage__phVerletClothCustomBounds mrage__phVerletClothCustomBounds = new Mrage__phVerletClothCustomBounds();
						mrage__phVerletClothCustomBounds.Parse(meta, data4);
						this.rage__phVerletClothCustomBounds.Add(mrage__phVerletClothCustomBounds);
					}
				}
			}
			this.AmbientOcclusionMultiplier = CEntityDef.ambientOcclusionMultiplier;
			this.ArtificialAmbientOcclusion = CEntityDef.artificialAmbientOcclusion;
			this.TintValue = CEntityDef.tintValue;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0002EA30 File Offset: 0x0002CC30
		public void ParseWithoutExtensions(MetaFile meta, CEntityDef CEntityDef)
		{
			this.Meta = meta;
			this.MetaStructure = CEntityDef;
			this.ArchetypeName = CEntityDef.archetypeName;
			this.Flags = CEntityDef.flags;
			this.Guid = CEntityDef.guid;
			this.Position = CEntityDef.position;
			this.Rotation = CEntityDef.rotation;
			this.ScaleXY = CEntityDef.scaleXY;
			this.ScaleZ = CEntityDef.scaleZ;
			this.ParentIndex = CEntityDef.parentIndex;
			this.LodDist = CEntityDef.lodDist;
			this.ChildLodDist = CEntityDef.childLodDist;
			this.LodLevel = CEntityDef.lodLevel;
			this.NumChildren = CEntityDef.numChildren;
			this.PriorityLevel = CEntityDef.priorityLevel;
			this.AmbientOcclusionMultiplier = CEntityDef.ambientOcclusionMultiplier;
			this.ArtificialAmbientOcclusion = CEntityDef.artificialAmbientOcclusion;
			this.TintValue = CEntityDef.tintValue;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0002EB0C File Offset: 0x0002CD0C
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
			List<MetaPOINTER> list = new List<MetaPOINTER>();
			if (this.ExtensionDefLightEffect != null)
			{
				base.AddMetaPointers<CExtensionDefLightEffect>(mb, list, MetaName.CExtensionDefLightEffect, this.ExtensionDefLightEffect.Select(delegate(MCExtensionDefLightEffect e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefSpawnPointOverride != null)
			{
				base.AddMetaPointers<CExtensionDefSpawnPointOverride>(mb, list, MetaName.CExtensionDefSpawnPointOverride, this.ExtensionDefSpawnPointOverride.Select(delegate(MCExtensionDefSpawnPointOverride e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefDoor != null)
			{
				base.AddMetaPointers<CExtensionDefDoor>(mb, list, MetaName.CExtensionDefDoor, this.ExtensionDefDoor.Select(delegate(MCExtensionDefDoor e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.rage__phVerletClothCustomBounds != null)
			{
				base.AddMetaPointers<rage__phVerletClothCustomBounds>(mb, list, MetaName.rage__phVerletClothCustomBounds, this.rage__phVerletClothCustomBounds.Select(delegate(Mrage__phVerletClothCustomBounds e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			this.MetaStructure.extensions = mb.AddPointerArray(list.ToArray());
			this.MetaStructure.ambientOcclusionMultiplier = this.AmbientOcclusionMultiplier;
			this.MetaStructure.artificialAmbientOcclusion = this.ArtificialAmbientOcclusion;
			this.MetaStructure.tintValue = this.TintValue;
			MCEntityDef.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CEntityDef>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003749 RID: 14153
		public static MetaName _MetaName = MetaName.CEntityDef;

		// Token: 0x0400374A RID: 14154
		public MetaFile Meta;

		// Token: 0x0400374B RID: 14155
		public uint ArchetypeName;

		// Token: 0x0400374C RID: 14156
		public uint Flags;

		// Token: 0x0400374D RID: 14157
		public uint Guid;

		// Token: 0x0400374E RID: 14158
		public Vector3 Position;

		// Token: 0x0400374F RID: 14159
		public Vector4 Rotation;

		// Token: 0x04003750 RID: 14160
		public float ScaleXY;

		// Token: 0x04003751 RID: 14161
		public float ScaleZ;

		// Token: 0x04003752 RID: 14162
		public int _ParentIndex;

		// Token: 0x04003753 RID: 14163
		public float LodDist;

		// Token: 0x04003754 RID: 14164
		public float ChildLodDist;

		// Token: 0x04003755 RID: 14165
		public Unk_1264241711 LodLevel;

		// Token: 0x04003756 RID: 14166
		public uint NumChildren;

		// Token: 0x04003757 RID: 14167
		public Unk_648413703 PriorityLevel;

		// Token: 0x04003758 RID: 14168
		public Array_StructurePointer Extensions;

		// Token: 0x04003759 RID: 14169
		public MCMapData Parent;

		// Token: 0x0400375A RID: 14170
		public MCEntityDef _ParentEntity;

		// Token: 0x0400375B RID: 14171
		public List<MCEntityDef> Children = new List<MCEntityDef>();

		// Token: 0x0400375C RID: 14172
		public List<MCExtensionDefLightEffect> ExtensionDefLightEffect = new List<MCExtensionDefLightEffect>();

		// Token: 0x0400375D RID: 14173
		public List<MCExtensionDefSpawnPointOverride> ExtensionDefSpawnPointOverride = new List<MCExtensionDefSpawnPointOverride>();

		// Token: 0x0400375E RID: 14174
		public List<MCExtensionDefDoor> ExtensionDefDoor = new List<MCExtensionDefDoor>();

		// Token: 0x0400375F RID: 14175
		public List<Mrage__phVerletClothCustomBounds> rage__phVerletClothCustomBounds = new List<Mrage__phVerletClothCustomBounds>();

		// Token: 0x04003760 RID: 14176
		public int AmbientOcclusionMultiplier;

		// Token: 0x04003761 RID: 14177
		public int ArtificialAmbientOcclusion;

		// Token: 0x04003762 RID: 14178
		public uint TintValue;
	}
}
