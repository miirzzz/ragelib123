using System;
using System.Collections.Generic;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x0200019C RID: 412
	public class MCBaseArchetypeDef : MetaStructureWrapper<CBaseArchetypeDef>
	{
		// Token: 0x060006AA RID: 1706 RVA: 0x0002D2C8 File Offset: 0x0002B4C8
		public MCBaseArchetypeDef()
		{
			this.MetaName = MetaName.CBaseArchetypeDef;
			this.MetaStructure = default(CBaseArchetypeDef);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0002D320 File Offset: 0x0002B520
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCBaseArchetypeDef._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCBaseArchetypeDef._MetaName);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0002D360 File Offset: 0x0002B560
		public override void Parse(MetaFile meta, CBaseArchetypeDef CBaseArchetypeDef)
		{
			this.Meta = meta;
			this.MetaStructure = CBaseArchetypeDef;
			this.LodDist = CBaseArchetypeDef.lodDist;
			this.Flags = CBaseArchetypeDef.flags;
			this.SpecialAttribute = CBaseArchetypeDef.specialAttribute;
			this.BbMin = CBaseArchetypeDef.bbMin;
			this.BbMax = CBaseArchetypeDef.bbMax;
			this.BsCentre = CBaseArchetypeDef.bsCentre;
			this.BsRadius = CBaseArchetypeDef.bsRadius;
			this.HdTextureDist = CBaseArchetypeDef.hdTextureDist;
			this.Name = (MetaName)CBaseArchetypeDef.name;
			this.TextureDictionary = (MetaName)CBaseArchetypeDef.textureDictionary;
			this.ClipDictionary = (MetaName)CBaseArchetypeDef.clipDictionary;
			this.DrawableDictionary = (MetaName)CBaseArchetypeDef.drawableDictionary;
			this.PhysicsDictionary = (MetaName)CBaseArchetypeDef.physicsDictionary;
			this.AssetType = CBaseArchetypeDef.assetType;
			this.AssetName = (MetaName)CBaseArchetypeDef.assetName;
			MetaPOINTER[] pointerArray = MetaUtils.GetPointerArray(meta, CBaseArchetypeDef.extensions);
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
								this.ExtensionDefLightEffects.Add(mcextensionDefLightEffect);
							}
						}
						else
						{
							CExtensionDefSpawnPointOverride data2 = MetaUtils.GetData<CExtensionDefSpawnPointOverride>(meta, ptr);
							MCExtensionDefSpawnPointOverride mcextensionDefSpawnPointOverride = new MCExtensionDefSpawnPointOverride();
							mcextensionDefSpawnPointOverride.Parse(meta, data2);
							this.ExtensionDefSpawnPointOverrides.Add(mcextensionDefSpawnPointOverride);
						}
					}
					else if (structureNameHash != MetaName.rage__phVerletClothCustomBounds)
					{
						if (structureNameHash == MetaName.CExtensionDefDoor)
						{
							CExtensionDefDoor data3 = MetaUtils.GetData<CExtensionDefDoor>(meta, ptr);
							MCExtensionDefDoor mcextensionDefDoor = new MCExtensionDefDoor();
							mcextensionDefDoor.Parse(meta, data3);
							this.ExtensionDefDoors.Add(mcextensionDefDoor);
						}
					}
					else
					{
						rage__phVerletClothCustomBounds data4 = MetaUtils.GetData<rage__phVerletClothCustomBounds>(meta, ptr);
						Mrage__phVerletClothCustomBounds mrage__phVerletClothCustomBounds = new Mrage__phVerletClothCustomBounds();
						mrage__phVerletClothCustomBounds.Parse(meta, data4);
						this.rage__PhVerletClothCustomBounds.Add(mrage__phVerletClothCustomBounds);
					}
				}
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0002D548 File Offset: 0x0002B748
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
			this.MetaStructure.name = (uint)this.Name;
			this.MetaStructure.textureDictionary = (uint)this.TextureDictionary;
			this.MetaStructure.clipDictionary = (uint)this.ClipDictionary;
			this.MetaStructure.drawableDictionary = (uint)this.DrawableDictionary;
			this.MetaStructure.physicsDictionary = (uint)this.PhysicsDictionary;
			this.MetaStructure.assetType = this.AssetType;
			this.MetaStructure.assetName = (uint)this.AssetName;
			List<MetaPOINTER> list = new List<MetaPOINTER>();
			this.MetaStructure.extensions = mb.AddPointerArray(list.ToArray());
			MCBaseArchetypeDef.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CBaseArchetypeDef>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040036F6 RID: 14070
		public static MetaName _MetaName = MetaName.CBaseArchetypeDef;

		// Token: 0x040036F7 RID: 14071
		public MetaFile Meta;

		// Token: 0x040036F8 RID: 14072
		public float LodDist;

		// Token: 0x040036F9 RID: 14073
		public uint Flags;

		// Token: 0x040036FA RID: 14074
		public uint SpecialAttribute;

		// Token: 0x040036FB RID: 14075
		public Vector3 BbMin;

		// Token: 0x040036FC RID: 14076
		public Vector3 BbMax;

		// Token: 0x040036FD RID: 14077
		public Vector3 BsCentre;

		// Token: 0x040036FE RID: 14078
		public float BsRadius;

		// Token: 0x040036FF RID: 14079
		public float HdTextureDist;

		// Token: 0x04003700 RID: 14080
		public MetaName Name;

		// Token: 0x04003701 RID: 14081
		public MetaName TextureDictionary;

		// Token: 0x04003702 RID: 14082
		public MetaName ClipDictionary;

		// Token: 0x04003703 RID: 14083
		public MetaName DrawableDictionary;

		// Token: 0x04003704 RID: 14084
		public MetaName PhysicsDictionary;

		// Token: 0x04003705 RID: 14085
		public Unk_1991964615 AssetType;

		// Token: 0x04003706 RID: 14086
		public MetaName AssetName;

		// Token: 0x04003707 RID: 14087
		public List<MCExtensionDefLightEffect> ExtensionDefLightEffects = new List<MCExtensionDefLightEffect>();

		// Token: 0x04003708 RID: 14088
		public List<MCExtensionDefSpawnPointOverride> ExtensionDefSpawnPointOverrides = new List<MCExtensionDefSpawnPointOverride>();

		// Token: 0x04003709 RID: 14089
		public List<MCExtensionDefDoor> ExtensionDefDoors = new List<MCExtensionDefDoor>();

		// Token: 0x0400370A RID: 14090
		public List<Mrage__phVerletClothCustomBounds> rage__PhVerletClothCustomBounds = new List<Mrage__phVerletClothCustomBounds>();
	}
}
