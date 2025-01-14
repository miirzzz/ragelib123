using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001B6 RID: 438
	public class MCMapData : MetaStructureWrapper<CMapData>
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x0003118B File Offset: 0x0002F38B
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00031194 File Offset: 0x0002F394
		public MCMapData ParentMapData
		{
			get
			{
				return this._ParentMapData;
			}
			set
			{
				this._ParentMapData = value;
				for (int i = 0; i < this.Entities.Count; i++)
				{
					MCEntityDef mcentityDef = this.Entities[i];
					mcentityDef.ParentIndex = mcentityDef.ParentIndex;
				}
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000311D8 File Offset: 0x0002F3D8
		public MCMapData(MCMapData parentMapData = null)
		{
			this.MetaName = MetaName.CMapData;
			this.MetaStructure = default(CMapData);
			this.ParentMapData = parentMapData;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0003122C File Offset: 0x0002F42C
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCMapData._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCMapData._MetaName);
			mb.AddStructureInfo(MetaName.BoxOccluder);
			mb.AddStructureInfo(MetaName.OccludeModel);
			mb.AddStructureInfo(MetaName.rage__fwInstancedMapData);
			mb.AddStructureInfo(MetaName.CTimeCycleModifier);
			mb.AddStructureInfo(MetaName.CCarGen);
			mb.AddStructureInfo(MetaName.CLODLight);
			mb.AddStructureInfo(MetaName.CDistantLODLight);
			mb.AddStructureInfo(MetaName.CBlockDesc);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000312C4 File Offset: 0x0002F4C4
		public override void Parse(MetaFile meta, CMapData CMapData)
		{
			this.Meta = meta;
			this.MetaStructure = CMapData;
			this.Name = (MetaName)CMapData.name;
			this.Parent = (MetaName)CMapData.parent;
			this.Flags = CMapData.flags;
			this.ContentFlags = CMapData.contentFlags;
			this.StreamingExtentsMin = CMapData.streamingExtentsMin;
			this.StreamingExtentsMax = CMapData.streamingExtentsMax;
			this.EntitiesExtentsMin = CMapData.entitiesExtentsMin;
			this.EntitiesExtentsMax = CMapData.entitiesExtentsMax;
			CEntityDef[] typedDataArray = MetaUtils.GetTypedDataArray<CEntityDef>(this.Meta, MetaName.CEntityDef);
			this.Entities = (((typedDataArray != null) ? typedDataArray.Select(delegate(CEntityDef e)
			{
				MCEntityDef mcentityDef = new MCEntityDef(this);
				mcentityDef.Parse(meta, e);
				return mcentityDef;
			}).ToList<MCEntityDef>() : null) ?? new List<MCEntityDef>());
			CMloInstanceDef[] typedDataArray2 = MetaUtils.GetTypedDataArray<CMloInstanceDef>(this.Meta, MetaName.CMloInstanceDef);
			this.MloInstances = (((typedDataArray2 != null) ? typedDataArray2.Select(delegate(CMloInstanceDef e)
			{
				MCMloInstanceDef mcmloInstanceDef = new MCMloInstanceDef();
				mcmloInstanceDef.Parse(meta, e);
				return mcmloInstanceDef;
			}).ToList<MCMloInstanceDef>() : null) ?? new List<MCMloInstanceDef>());
			this.ContainerLods = default(Array_Structure);
			Unk_975711773[] array = MetaUtils.ConvertDataArray<Unk_975711773>(meta, CMapData.boxOccluders);
			this.BoxOccluders = ((array != null) ? array.Select(delegate(Unk_975711773 e)
			{
				MUnk_975711773 munk_ = new MUnk_975711773();
				munk_.Parse(meta, e);
				return munk_;
			}).ToList<MUnk_975711773>() : null);
			Unk_2741784237[] array2 = MetaUtils.ConvertDataArray<Unk_2741784237>(meta, CMapData.occludeModels);
			this.OccludeModels = ((array2 != null) ? array2.Select(delegate(Unk_2741784237 e)
			{
				MUnk_2741784237 munk_2741784237 = new MUnk_2741784237();
				munk_2741784237.Parse(meta, e);
				return munk_2741784237;
			}).ToList<MUnk_2741784237>() : null);
			this.PhysicsDictionaries = CMapData.physicsDictionaries;
			this.InstancedData = new Mrage__fwInstancedMapData();
			this.InstancedData.Parse(meta, CMapData.instancedData);
			CTimeCycleModifier[] array3 = MetaUtils.ConvertDataArray<CTimeCycleModifier>(meta, CMapData.timeCycleModifiers);
			this.TimeCycleModifiers = ((array3 != null) ? array3.Select(delegate(CTimeCycleModifier e)
			{
				MCTimeCycleModifier mctimeCycleModifier = new MCTimeCycleModifier();
				mctimeCycleModifier.Parse(meta, e);
				return mctimeCycleModifier;
			}).ToList<MCTimeCycleModifier>() : null);
			CCarGen[] array4 = MetaUtils.ConvertDataArray<CCarGen>(meta, CMapData.carGenerators);
			this.CarGenerators = ((array4 != null) ? array4.Select(delegate(CCarGen e)
			{
				MCCarGen mccarGen = new MCCarGen();
				mccarGen.Parse(meta, e);
				return mccarGen;
			}).ToList<MCCarGen>() : null);
			this.LODLightsSOA = new MCLODLight();
			this.LODLightsSOA.Parse(meta, CMapData.LODLightsSOA);
			this.DistantLODLightsSOA = new MCDistantLODLight();
			this.DistantLODLightsSOA.Parse(meta, CMapData.DistantLODLightsSOA);
			this.Block = new MCBlockDesc();
			this.Block.Parse(meta, CMapData.block);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00031548 File Offset: 0x0002F748
		public void ParseFast(MetaFile meta, CMapData CMapData)
		{
			this.Meta = meta;
			this.MetaStructure = CMapData;
			this.Name = (MetaName)CMapData.name;
			this.Parent = (MetaName)CMapData.parent;
			this.Flags = CMapData.flags;
			this.ContentFlags = CMapData.contentFlags;
			this.StreamingExtentsMin = CMapData.streamingExtentsMin;
			this.StreamingExtentsMax = CMapData.streamingExtentsMax;
			this.EntitiesExtentsMin = CMapData.entitiesExtentsMin;
			this.EntitiesExtentsMax = CMapData.entitiesExtentsMax;
			CEntityDef[] typedDataArray = MetaUtils.GetTypedDataArray<CEntityDef>(this.Meta, MetaName.CEntityDef);
			this.Entities = (((typedDataArray != null) ? typedDataArray.Select(delegate(CEntityDef e)
			{
				MCEntityDef mcentityDef = new MCEntityDef(this);
				mcentityDef.ParseWithoutExtensions(meta, e);
				return mcentityDef;
			}).ToList<MCEntityDef>() : null) ?? new List<MCEntityDef>());
			CMloInstanceDef[] typedDataArray2 = MetaUtils.GetTypedDataArray<CMloInstanceDef>(this.Meta, MetaName.CMloInstanceDef);
			this.MloInstances = (((typedDataArray2 != null) ? typedDataArray2.Select(delegate(CMloInstanceDef e)
			{
				MCMloInstanceDef mcmloInstanceDef = new MCMloInstanceDef();
				mcmloInstanceDef.Parse(meta, e);
				return mcmloInstanceDef;
			}).ToList<MCMloInstanceDef>() : null) ?? new List<MCMloInstanceDef>());
			this.Block = new MCBlockDesc();
			this.Block.Parse(meta, CMapData.block);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00031678 File Offset: 0x0002F878
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = (uint)this.Name;
			this.MetaStructure.parent = (uint)this.Parent;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.contentFlags = this.ContentFlags;
			this.MetaStructure.streamingExtentsMin = this.StreamingExtentsMin;
			this.MetaStructure.streamingExtentsMax = this.StreamingExtentsMax;
			this.MetaStructure.entitiesExtentsMin = this.EntitiesExtentsMin;
			this.MetaStructure.entitiesExtentsMax = this.EntitiesExtentsMax;
			List<MetaPOINTER> list = new List<MetaPOINTER>();
			base.AddMetaPointers<CEntityDef>(mb, list, MetaName.CEntityDef, this.Entities.Select(delegate(MCEntityDef e)
			{
				e.Build(mb, false);
				return e.MetaStructure;
			}));
			base.AddMetaPointers<CMloInstanceDef>(mb, list, MetaName.CMloInstanceDef, this.MloInstances.Select(delegate(MCMloInstanceDef e)
			{
				e.Build(mb, false);
				return e.MetaStructure;
			}));
			this.MetaStructure.entities = mb.AddPointerArray(list.ToArray());
			if (this.BoxOccluders != null)
			{
				this.MetaStructure.boxOccluders = mb.AddItemArrayPtr<Unk_975711773>(MetaName.BoxOccluder, (from e in this.BoxOccluders
				select e.MetaStructure).ToArray<Unk_975711773>());
			}
			MUnk_975711773.AddEnumAndStructureInfo(mb);
			if (this.OccludeModels != null)
			{
				this.MetaStructure.occludeModels = mb.AddItemArrayPtr<Unk_2741784237>(MetaName.OccludeModel, (from e in this.OccludeModels
				select e.MetaStructure).ToArray<Unk_2741784237>());
			}
			MUnk_2741784237.AddEnumAndStructureInfo(mb);
			this.MetaStructure.physicsDictionaries = this.PhysicsDictionaries;
			if (this.InstancedData != null)
			{
				this.InstancedData.Build(mb, false);
				this.MetaStructure.instancedData = this.InstancedData.MetaStructure;
			}
			Mrage__fwInstancedMapData.AddEnumAndStructureInfo(mb);
			if (this.TimeCycleModifiers != null)
			{
				this.MetaStructure.timeCycleModifiers = mb.AddItemArrayPtr<CTimeCycleModifier>(MetaName.CTimeCycleModifier, (from e in this.TimeCycleModifiers
				select e.MetaStructure).ToArray<CTimeCycleModifier>());
			}
			MCTimeCycleModifier.AddEnumAndStructureInfo(mb);
			if (this.CarGenerators != null)
			{
				this.MetaStructure.carGenerators = mb.AddItemArrayPtr<CCarGen>(MetaName.CCarGen, (from e in this.CarGenerators
				select e.MetaStructure).ToArray<CCarGen>());
			}
			MCCarGen.AddEnumAndStructureInfo(mb);
			if (this.LODLightsSOA != null)
			{
				this.LODLightsSOA.Build(mb, false);
				this.MetaStructure.LODLightsSOA = this.LODLightsSOA.MetaStructure;
			}
			MCLODLight.AddEnumAndStructureInfo(mb);
			if (this.DistantLODLightsSOA != null)
			{
				this.DistantLODLightsSOA.Build(mb, false);
				this.MetaStructure.DistantLODLightsSOA = this.DistantLODLightsSOA.MetaStructure;
			}
			MCDistantLODLight.AddEnumAndStructureInfo(mb);
			this.Block.Build(mb, false);
			this.MetaStructure.block = this.Block.MetaStructure;
			MCBlockDesc.AddEnumAndStructureInfo(mb);
			MCMapData.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CMapData>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00031A33 File Offset: 0x0002FC33
		public int AddEntity(MCEntityDef entity)
		{
			entity.Parent = this;
			this.Entities.Add(entity);
			return this.Entities.Count - 1;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00031A58 File Offset: 0x0002FC58
		public int[] AddEntities(IEnumerable<MCEntityDef> entities)
		{
			List<MCEntityDef> list = entities.ToList<MCEntityDef>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < list.Count; i++)
			{
				list2.Add(this.AddEntity(list[i]));
			}
			return list2.ToArray();
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00031A9C File Offset: 0x0002FC9C
		public void RemoveEntity(MCEntityDef entity)
		{
			entity.Parent = null;
			this.Entities.Remove(entity);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00031AB4 File Offset: 0x0002FCB4
		public void RemoveEntities(IEnumerable<MCEntityDef> entities)
		{
			List<MCEntityDef> list = entities.ToList<MCEntityDef>();
			for (int i = 0; i < list.Count; i++)
			{
				this.RemoveEntity(list[i]);
			}
		}

		// Token: 0x0400382E RID: 14382
		public static MetaName _MetaName = MetaName.CMapData;

		// Token: 0x0400382F RID: 14383
		public MetaFile Meta;

		// Token: 0x04003830 RID: 14384
		public MetaName Name;

		// Token: 0x04003831 RID: 14385
		public MetaName Parent;

		// Token: 0x04003832 RID: 14386
		public uint Flags;

		// Token: 0x04003833 RID: 14387
		public uint ContentFlags;

		// Token: 0x04003834 RID: 14388
		public Vector3 StreamingExtentsMin;

		// Token: 0x04003835 RID: 14389
		public Vector3 StreamingExtentsMax;

		// Token: 0x04003836 RID: 14390
		public Vector3 EntitiesExtentsMin;

		// Token: 0x04003837 RID: 14391
		public Vector3 EntitiesExtentsMax;

		// Token: 0x04003838 RID: 14392
		public List<MCEntityDef> Entities = new List<MCEntityDef>();

		// Token: 0x04003839 RID: 14393
		public List<MCMloInstanceDef> MloInstances = new List<MCMloInstanceDef>();

		// Token: 0x0400383A RID: 14394
		public Array_Structure ContainerLods;

		// Token: 0x0400383B RID: 14395
		public List<MUnk_975711773> BoxOccluders;

		// Token: 0x0400383C RID: 14396
		public List<MUnk_2741784237> OccludeModels;

		// Token: 0x0400383D RID: 14397
		public Array_uint PhysicsDictionaries;

		// Token: 0x0400383E RID: 14398
		public Mrage__fwInstancedMapData InstancedData;

		// Token: 0x0400383F RID: 14399
		public List<MCTimeCycleModifier> TimeCycleModifiers;

		// Token: 0x04003840 RID: 14400
		public List<MCCarGen> CarGenerators;

		// Token: 0x04003841 RID: 14401
		public MCLODLight LODLightsSOA;

		// Token: 0x04003842 RID: 14402
		public MCDistantLODLight DistantLODLightsSOA;

		// Token: 0x04003843 RID: 14403
		public MCBlockDesc Block = new MCBlockDesc();

		// Token: 0x04003844 RID: 14404
		public MCMapData _ParentMapData;

		// Token: 0x04003845 RID: 14405
		public static List<Unk_1264241711> LodLevels = new List<Unk_1264241711>
		{
			Unk_1264241711.LODTYPES_DEPTH_SLOD4,
			Unk_1264241711.LODTYPES_DEPTH_SLOD3,
			Unk_1264241711.LODTYPES_DEPTH_SLOD2,
			Unk_1264241711.LODTYPES_DEPTH_SLOD1,
			Unk_1264241711.LODTYPES_DEPTH_LOD,
			Unk_1264241711.LODTYPES_DEPTH_HD,
			Unk_1264241711.LODTYPES_DEPTH_ORPHANHD
		};
	}
}
