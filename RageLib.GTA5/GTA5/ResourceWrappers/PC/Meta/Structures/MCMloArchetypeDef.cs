using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001B8 RID: 440
	public class MCMloArchetypeDef : MetaStructureWrapper<CMloArchetypeDef>
	{
		// Token: 0x06000742 RID: 1858 RVA: 0x00031F74 File Offset: 0x00030174
		public MCMloArchetypeDef()
		{
			this.MetaName = MetaName.CMloArchetypeDef;
			this.MetaStructure = default(CMloArchetypeDef);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00032050 File Offset: 0x00030250
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCMloArchetypeDef._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCMloArchetypeDef._MetaName);
			mb.AddStructureInfo(MetaName.CMloRoomDef);
			mb.AddStructureInfo(MetaName.CMloPortalDef);
			mb.AddStructureInfo(MetaName.CMloEntitySet);
			mb.AddStructureInfo(MetaName.CMloTimeCycleModifier);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000320BC File Offset: 0x000302BC
		public override void Parse(MetaFile meta, CMloArchetypeDef CMloArchetypeDef)
		{
			this.Meta = meta;
			this.MetaStructure = CMloArchetypeDef;
			this.LodDist = CMloArchetypeDef.lodDist;
			this.Flags = CMloArchetypeDef.flags;
			this.SpecialAttribute = CMloArchetypeDef.specialAttribute;
			this.BbMin = CMloArchetypeDef.bbMin;
			this.BbMax = CMloArchetypeDef.bbMax;
			this.BsCentre = CMloArchetypeDef.bsCentre;
			this.BsRadius = CMloArchetypeDef.bsRadius;
			this.HdTextureDist = CMloArchetypeDef.hdTextureDist;
			this.Name = CMloArchetypeDef.name;
			this.TextureDictionary = CMloArchetypeDef.textureDictionary;
			this.ClipDictionary = CMloArchetypeDef.clipDictionary;
			this.DrawableDictionary = CMloArchetypeDef.drawableDictionary;
			this.PhysicsDictionary = CMloArchetypeDef.physicsDictionary;
			this.AssetType = CMloArchetypeDef.assetType;
			this.AssetName = CMloArchetypeDef.assetName;
			MetaPOINTER[] pointerArray = MetaUtils.GetPointerArray(meta, CMloArchetypeDef.extensions);
			if (pointerArray != null)
			{
				foreach (MetaPOINTER ptr in pointerArray)
				{
					MetaName structureNameHash = meta.GetBlock(ptr.BlockID).StructureNameHash;
					if (structureNameHash <= MetaName.CExtensionDefExpression)
					{
						if (structureNameHash <= MetaName.CExtensionDefProcObject)
						{
							if (structureNameHash != MetaName.CExtensionDefLadder)
							{
								if (structureNameHash == MetaName.CExtensionDefProcObject)
								{
									CExtensionDefProcObject data = MetaUtils.GetData<CExtensionDefProcObject>(meta, ptr);
									MCExtensionDefProcObject mcextensionDefProcObject = new MCExtensionDefProcObject();
									mcextensionDefProcObject.Parse(meta, data);
									this.ExtensionDefProcObjects.Add(mcextensionDefProcObject);
								}
							}
							else
							{
								CExtensionDefLadder data2 = MetaUtils.GetData<CExtensionDefLadder>(meta, ptr);
								MCExtensionDefLadder mcextensionDefLadder = new MCExtensionDefLadder();
								mcextensionDefLadder.Parse(meta, data2);
								this.ExtensionDefLadders.Add(mcextensionDefLadder);
							}
						}
						else if (structureNameHash != MetaName.CExtensionDefLightShaft)
						{
							if (structureNameHash != MetaName.CExtensionDefSpawnPoint)
							{
								if (structureNameHash == MetaName.CExtensionDefExpression)
								{
									CExtensionDefExpression data3 = MetaUtils.GetData<CExtensionDefExpression>(meta, ptr);
									MCExtensionDefExpression mcextensionDefExpression = new MCExtensionDefExpression();
									mcextensionDefExpression.Parse(meta, data3);
									this.ExtensionDefExpressions.Add(mcextensionDefExpression);
								}
							}
							else
							{
								CExtensionDefSpawnPoint data4 = MetaUtils.GetData<CExtensionDefSpawnPoint>(meta, ptr);
								MCExtensionDefSpawnPoint mcextensionDefSpawnPoint = new MCExtensionDefSpawnPoint();
								mcextensionDefSpawnPoint.Parse(meta, data4);
								this.ExtensionDefSpawnPoints.Add(mcextensionDefSpawnPoint);
							}
						}
						else
						{
							CExtensionDefLightShaft data5 = MetaUtils.GetData<CExtensionDefLightShaft>(meta, ptr);
							MCExtensionDefLightShaft mcextensionDefLightShaft = new MCExtensionDefLightShaft();
							mcextensionDefLightShaft.Parse(meta, data5);
							this.ExtensionDefLightShafts.Add(mcextensionDefLightShaft);
						}
					}
					else if (structureNameHash <= MetaName.CExtensionDefWindDisturbance)
					{
						if (structureNameHash != MetaName.CExtensionDefExplosionEffect)
						{
							if (structureNameHash != MetaName.CExtensionDefAudioCollisionSettings)
							{
								if (structureNameHash == MetaName.CExtensionDefWindDisturbance)
								{
									CExtensionDefWindDisturbance data6 = MetaUtils.GetData<CExtensionDefWindDisturbance>(meta, ptr);
									MCExtensionDefWindDisturbance mcextensionDefWindDisturbance = new MCExtensionDefWindDisturbance();
									mcextensionDefWindDisturbance.Parse(meta, data6);
									this.ExtensionDefWindDisturbances.Add(mcextensionDefWindDisturbance);
								}
							}
							else
							{
								CExtensionDefAudioCollisionSettings data7 = MetaUtils.GetData<CExtensionDefAudioCollisionSettings>(meta, ptr);
								MCExtensionDefAudioCollisionSettings mcextensionDefAudioCollisionSettings = new MCExtensionDefAudioCollisionSettings();
								mcextensionDefAudioCollisionSettings.Parse(meta, data7);
								this.ExtensionDefAudioCollisionSettings.Add(mcextensionDefAudioCollisionSettings);
							}
						}
						else
						{
							CExtensionDefExplosionEffect data8 = MetaUtils.GetData<CExtensionDefExplosionEffect>(meta, ptr);
							MCExtensionDefExplosionEffect mcextensionDefExplosionEffect = new MCExtensionDefExplosionEffect();
							mcextensionDefExplosionEffect.Parse(meta, data8);
							this.ExtensionDefExplosionEffects.Add(mcextensionDefExplosionEffect);
						}
					}
					else if (structureNameHash != MetaName.CExtensionDefAudioEmitter)
					{
						if (structureNameHash != MetaName.CExtensionDefBuoyancy)
						{
							if (structureNameHash == MetaName.CExtensionDefParticleEffect)
							{
								CExtensionDefParticleEffect data9 = MetaUtils.GetData<CExtensionDefParticleEffect>(meta, ptr);
								MCExtensionDefParticleEffect mcextensionDefParticleEffect = new MCExtensionDefParticleEffect();
								mcextensionDefParticleEffect.Parse(meta, data9);
								this.ExtensionDefParticleEffects.Add(mcextensionDefParticleEffect);
							}
						}
						else
						{
							CExtensionDefBuoyancy data10 = MetaUtils.GetData<CExtensionDefBuoyancy>(meta, ptr);
							MCExtensionDefBuoyancy mcextensionDefBuoyancy = new MCExtensionDefBuoyancy();
							mcextensionDefBuoyancy.Parse(meta, data10);
							this.ExtensionDefBuoyancies.Add(mcextensionDefBuoyancy);
						}
					}
					else
					{
						CExtensionDefAudioEmitter data11 = MetaUtils.GetData<CExtensionDefAudioEmitter>(meta, ptr);
						MCExtensionDefAudioEmitter mcextensionDefAudioEmitter = new MCExtensionDefAudioEmitter();
						mcextensionDefAudioEmitter.Parse(meta, data11);
						this.ExtensionDefAudioEmitters.Add(mcextensionDefAudioEmitter);
					}
				}
			}
			this.MloFlags = CMloArchetypeDef.mloFlags;
			CEntityDef[] array = MetaUtils.ConvertDataArray<CEntityDef>(this.Meta, CMloArchetypeDef.entities);
			this.Entities = (((array != null) ? array.Select(delegate(CEntityDef e)
			{
				MCEntityDef mcentityDef = new MCEntityDef(null);
				mcentityDef.Parse(meta, e);
				return mcentityDef;
			}).ToList<MCEntityDef>() : null) ?? new List<MCEntityDef>());
			CMloRoomDef[] array2 = MetaUtils.ConvertDataArray<CMloRoomDef>(meta, CMloArchetypeDef.rooms);
			this.Rooms = ((array2 != null) ? array2.Select(delegate(CMloRoomDef e)
			{
				MCMloRoomDef mcmloRoomDef = new MCMloRoomDef(this);
				mcmloRoomDef.Parse(meta, e);
				return mcmloRoomDef;
			}).ToList<MCMloRoomDef>() : null);
			CMloPortalDef[] array3 = MetaUtils.ConvertDataArray<CMloPortalDef>(meta, CMloArchetypeDef.portals);
			this.Portals = ((array3 != null) ? array3.Select(delegate(CMloPortalDef e)
			{
				MCMloPortalDef mcmloPortalDef = new MCMloPortalDef();
				mcmloPortalDef.Parse(meta, e);
				return mcmloPortalDef;
			}).ToList<MCMloPortalDef>() : null);
			CMloEntitySet[] array4 = MetaUtils.ConvertDataArray<CMloEntitySet>(meta, CMloArchetypeDef.entitySets);
			this.EntitySets = ((array4 != null) ? array4.Select(delegate(CMloEntitySet e)
			{
				MCMloEntitySet mcmloEntitySet = new MCMloEntitySet();
				mcmloEntitySet.Parse(meta, e);
				return mcmloEntitySet;
			}).ToList<MCMloEntitySet>() : null);
			CMloTimeCycleModifier[] array5 = MetaUtils.ConvertDataArray<CMloTimeCycleModifier>(meta, CMloArchetypeDef.timeCycleModifiers);
			this.TimeCycleModifiers = ((array5 != null) ? array5.Select(delegate(CMloTimeCycleModifier e)
			{
				MCMloTimeCycleModifier mcmloTimeCycleModifier = new MCMloTimeCycleModifier();
				mcmloTimeCycleModifier.Parse(meta, e);
				return mcmloTimeCycleModifier;
			}).ToList<MCMloTimeCycleModifier>() : null);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00032618 File Offset: 0x00030818
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.lodDist = this.LodDist;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.specialAttribute = this.SpecialAttribute;
			this.MetaStructure.bbMin = this.BbMin;
			this.MetaStructure.bbMax = this.BbMax;
			this.MetaStructure.bsCentre = this.BsCentre;
			this.MetaStructure.bsRadius = this.BsRadius;
			this.MetaStructure.hdTextureDist = this.HdTextureDist;
			this.MetaStructure.name = this.Name;
			this.MetaStructure.textureDictionary = this.TextureDictionary;
			this.MetaStructure.clipDictionary = this.ClipDictionary;
			this.MetaStructure.drawableDictionary = this.DrawableDictionary;
			this.MetaStructure.physicsDictionary = this.PhysicsDictionary;
			this.MetaStructure.assetType = this.AssetType;
			this.MetaStructure.assetName = this.AssetName;
			List<MetaPOINTER> list = new List<MetaPOINTER>();
			base.AddMetaPointers<CEntityDef>(mb, list, MetaName.CEntityDef, this.Entities.Select(delegate(MCEntityDef e)
			{
				e.Build(mb, false);
				return e.MetaStructure;
			}));
			this.MetaStructure.entities = mb.AddPointerArray(list.ToArray());
			if (this.Rooms != null)
			{
				this.MetaStructure.rooms = mb.AddItemArrayPtr<CMloRoomDef>(MetaName.CMloRoomDef, this.Rooms.Select(delegate(MCMloRoomDef e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CMloRoomDef>());
			}
			MCMloRoomDef.AddEnumAndStructureInfo(mb);
			if (this.Portals != null)
			{
				this.MetaStructure.portals = mb.AddItemArrayPtr<CMloPortalDef>(MetaName.CMloPortalDef, this.Portals.Select(delegate(MCMloPortalDef e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CMloPortalDef>());
			}
			MCMloPortalDef.AddEnumAndStructureInfo(mb);
			if (this.EntitySets != null)
			{
				this.MetaStructure.entitySets = mb.AddItemArrayPtr<CMloEntitySet>(MetaName.CMloEntitySet, this.EntitySets.Select(delegate(MCMloEntitySet e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CMloEntitySet>());
			}
			MCMloEntitySet.AddEnumAndStructureInfo(mb);
			if (this.TimeCycleModifiers != null)
			{
				this.MetaStructure.timeCycleModifiers = mb.AddItemArrayPtr<CMloTimeCycleModifier>(MetaName.CMloTimeCycleModifier, this.TimeCycleModifiers.Select(delegate(MCMloTimeCycleModifier e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CMloTimeCycleModifier>());
			}
			MCMloTimeCycleModifier.AddEnumAndStructureInfo(mb);
			this.MetaStructure.mloFlags = this.MloFlags;
			List<MetaPOINTER> list2 = new List<MetaPOINTER>();
			if (this.ExtensionDefAudioCollisionSettings != null)
			{
				base.AddMetaPointers<CExtensionDefAudioCollisionSettings>(mb, list2, MetaName.CExtensionDefAudioCollisionSettings, this.ExtensionDefAudioCollisionSettings.Select(delegate(MCExtensionDefAudioCollisionSettings e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefAudioEmitters != null)
			{
				base.AddMetaPointers<CExtensionDefAudioEmitter>(mb, list2, MetaName.CExtensionDefAudioEmitter, this.ExtensionDefAudioEmitters.Select(delegate(MCExtensionDefAudioEmitter e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefBuoyancies != null)
			{
				base.AddMetaPointers<CExtensionDefBuoyancy>(mb, list2, MetaName.CExtensionDefBuoyancy, this.ExtensionDefBuoyancies.Select(delegate(MCExtensionDefBuoyancy e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefExplosionEffects != null)
			{
				base.AddMetaPointers<CExtensionDefExplosionEffect>(mb, list2, MetaName.CExtensionDefExplosionEffect, this.ExtensionDefExplosionEffects.Select(delegate(MCExtensionDefExplosionEffect e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefExpressions != null)
			{
				base.AddMetaPointers<CExtensionDefExpression>(mb, list2, MetaName.CExtensionDefExpression, this.ExtensionDefExpressions.Select(delegate(MCExtensionDefExpression e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefLadders != null)
			{
				base.AddMetaPointers<CExtensionDefLadder>(mb, list2, MetaName.CExtensionDefLadder, this.ExtensionDefLadders.Select(delegate(MCExtensionDefLadder e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefLightShafts != null)
			{
				base.AddMetaPointers<CExtensionDefLightShaft>(mb, list2, MetaName.CExtensionDefLightShaft, this.ExtensionDefLightShafts.Select(delegate(MCExtensionDefLightShaft e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefParticleEffects != null)
			{
				base.AddMetaPointers<CExtensionDefParticleEffect>(mb, list2, MetaName.CExtensionDefParticleEffect, this.ExtensionDefParticleEffects.Select(delegate(MCExtensionDefParticleEffect e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefProcObjects != null)
			{
				base.AddMetaPointers<CExtensionDefProcObject>(mb, list2, MetaName.CExtensionDefProcObject, this.ExtensionDefProcObjects.Select(delegate(MCExtensionDefProcObject e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefSpawnPoints != null)
			{
				base.AddMetaPointers<CExtensionDefSpawnPoint>(mb, list2, MetaName.CExtensionDefSpawnPoint, this.ExtensionDefSpawnPoints.Select(delegate(MCExtensionDefSpawnPoint e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			if (this.ExtensionDefWindDisturbances != null)
			{
				base.AddMetaPointers<CExtensionDefWindDisturbance>(mb, list2, MetaName.CExtensionDefWindDisturbance, this.ExtensionDefWindDisturbances.Select(delegate(MCExtensionDefWindDisturbance e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}));
			}
			this.MetaStructure.extensions = mb.AddPointerArray(list2.ToArray());
			MCMloArchetypeDef.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CMloArchetypeDef>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00032B30 File Offset: 0x00030D30
		public int AddEntity(MCEntityDef entity, int idx = -1)
		{
			if (idx == -1)
			{
				this.Entities.Add(entity);
				idx = this.Entities.IndexOf(entity);
			}
			else
			{
				Dictionary<MCMloRoomDef, List<MCEntityDef>> dictionary = new Dictionary<MCMloRoomDef, List<MCEntityDef>>();
				for (int i = 0; i < this.Rooms.Count; i++)
				{
					MCMloRoomDef mcmloRoomDef = this.Rooms[i];
					dictionary[mcmloRoomDef] = (from e in mcmloRoomDef.AttachedObjects
					select this.Entities[(int)e]).ToList<MCEntityDef>();
				}
				this.Entities.Insert(idx, entity);
				for (int j = 0; j < this.Rooms.Count; j++)
				{
					MCMloRoomDef mcmloRoomDef2 = this.Rooms[j];
					mcmloRoomDef2.AttachedObjects = (from e in dictionary[mcmloRoomDef2]
					select (uint)this.Entities.IndexOf(e)).ToList<uint>();
				}
			}
			return idx;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00032C04 File Offset: 0x00030E04
		public void RemoveEntity(MCEntityDef entity)
		{
			int num = this.Entities.IndexOf(entity);
			if (num == -1)
			{
				return;
			}
			Dictionary<MCMloRoomDef, List<MCEntityDef>> dictionary = new Dictionary<MCMloRoomDef, List<MCEntityDef>>();
			for (int i = 0; i < this.Rooms.Count; i++)
			{
				MCMloRoomDef mcmloRoomDef = this.Rooms[i];
				dictionary[mcmloRoomDef] = (from e in mcmloRoomDef.AttachedObjects
				select this.Entities[(int)e]).ToList<MCEntityDef>();
			}
			this.Entities.RemoveAt(num);
			for (int j = 0; j < this.Rooms.Count; j++)
			{
				MCMloRoomDef mcmloRoomDef2 = this.Rooms[j];
				mcmloRoomDef2.AttachedObjects = (from e in dictionary[mcmloRoomDef2]
				select (uint)this.Entities.IndexOf(e)).ToList<uint>();
			}
		}

		// Token: 0x0400384F RID: 14415
		public static MetaName _MetaName = MetaName.CMloArchetypeDef;

		// Token: 0x04003850 RID: 14416
		public MetaFile Meta;

		// Token: 0x04003851 RID: 14417
		public float LodDist;

		// Token: 0x04003852 RID: 14418
		public uint Flags;

		// Token: 0x04003853 RID: 14419
		public uint SpecialAttribute;

		// Token: 0x04003854 RID: 14420
		public Vector3 BbMin;

		// Token: 0x04003855 RID: 14421
		public Vector3 BbMax;

		// Token: 0x04003856 RID: 14422
		public Vector3 BsCentre;

		// Token: 0x04003857 RID: 14423
		public float BsRadius;

		// Token: 0x04003858 RID: 14424
		public float HdTextureDist;

		// Token: 0x04003859 RID: 14425
		public uint Name;

		// Token: 0x0400385A RID: 14426
		public uint TextureDictionary;

		// Token: 0x0400385B RID: 14427
		public uint ClipDictionary;

		// Token: 0x0400385C RID: 14428
		public uint DrawableDictionary;

		// Token: 0x0400385D RID: 14429
		public uint PhysicsDictionary;

		// Token: 0x0400385E RID: 14430
		public Unk_1991964615 AssetType;

		// Token: 0x0400385F RID: 14431
		public uint AssetName;

		// Token: 0x04003860 RID: 14432
		public List<MCExtensionDefAudioCollisionSettings> ExtensionDefAudioCollisionSettings = new List<MCExtensionDefAudioCollisionSettings>();

		// Token: 0x04003861 RID: 14433
		public List<MCExtensionDefAudioEmitter> ExtensionDefAudioEmitters = new List<MCExtensionDefAudioEmitter>();

		// Token: 0x04003862 RID: 14434
		public List<MCExtensionDefBuoyancy> ExtensionDefBuoyancies = new List<MCExtensionDefBuoyancy>();

		// Token: 0x04003863 RID: 14435
		public List<MCExtensionDefExplosionEffect> ExtensionDefExplosionEffects = new List<MCExtensionDefExplosionEffect>();

		// Token: 0x04003864 RID: 14436
		public List<MCExtensionDefExpression> ExtensionDefExpressions = new List<MCExtensionDefExpression>();

		// Token: 0x04003865 RID: 14437
		public List<MCExtensionDefLadder> ExtensionDefLadders = new List<MCExtensionDefLadder>();

		// Token: 0x04003866 RID: 14438
		public List<MCExtensionDefLightShaft> ExtensionDefLightShafts = new List<MCExtensionDefLightShaft>();

		// Token: 0x04003867 RID: 14439
		public List<MCExtensionDefParticleEffect> ExtensionDefParticleEffects = new List<MCExtensionDefParticleEffect>();

		// Token: 0x04003868 RID: 14440
		public List<MCExtensionDefProcObject> ExtensionDefProcObjects = new List<MCExtensionDefProcObject>();

		// Token: 0x04003869 RID: 14441
		public List<MCExtensionDefSpawnPoint> ExtensionDefSpawnPoints = new List<MCExtensionDefSpawnPoint>();

		// Token: 0x0400386A RID: 14442
		public List<MCExtensionDefWindDisturbance> ExtensionDefWindDisturbances = new List<MCExtensionDefWindDisturbance>();

		// Token: 0x0400386B RID: 14443
		public uint MloFlags;

		// Token: 0x0400386C RID: 14444
		public List<MCEntityDef> Entities = new List<MCEntityDef>();

		// Token: 0x0400386D RID: 14445
		public List<MCMloRoomDef> Rooms = new List<MCMloRoomDef>();

		// Token: 0x0400386E RID: 14446
		public List<MCMloPortalDef> Portals = new List<MCMloPortalDef>();

		// Token: 0x0400386F RID: 14447
		public List<MCMloEntitySet> EntitySets = new List<MCMloEntitySet>();

		// Token: 0x04003870 RID: 14448
		public List<MCMloTimeCycleModifier> TimeCycleModifiers = new List<MCMloTimeCycleModifier>();
	}
}
