using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.GTA5.PSO;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001B7 RID: 439
	public class MCMapTypes : MetaStructureWrapper<CMapTypes>
	{
		// Token: 0x0600073D RID: 1853 RVA: 0x00031B3C File Offset: 0x0002FD3C
		public MCMapTypes()
		{
			this.MetaName = MetaName.CMapTypes;
			this.MetaStructure = default(CMapTypes);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00031BA0 File Offset: 0x0002FDA0
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCMapTypes._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCMapTypes._MetaName);
			mb.AddStructureInfo(MetaName.CCompositeEntityType);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00031BEC File Offset: 0x0002FDEC
		public override void Parse(MetaFile meta, CMapTypes CMapTypes)
		{
			this.Meta = meta;
			this.MetaStructure = CMapTypes;
			MetaPOINTER[] pointerArray = MetaUtils.GetPointerArray(this.Meta, this.MetaStructure.archetypes);
			if (pointerArray != null)
			{
				foreach (MetaPOINTER metaPOINTER in pointerArray)
				{
					DataBlock block = this.Meta.GetBlock(metaPOINTER.BlockID);
					if (block != null && metaPOINTER.Offset >= 0 && block.Data != null && (long)metaPOINTER.Offset < block.Data.Length)
					{
						byte[] data = Array.ConvertAll<byte_r, byte>(block.Data.ToArray<byte_r>(), (byte_r e) => (byte)e);
						MetaName structureNameHash = block.StructureNameHash;
						if (structureNameHash != MetaName.CBaseArchetypeDef)
						{
							if (structureNameHash != MetaName.CMloArchetypeDef)
							{
								if (structureNameHash == MetaName.CTimeArchetypeDef)
								{
									CTimeArchetypeDef metaStructure = PsoUtils.ConvertDataRaw<CTimeArchetypeDef>(data, metaPOINTER.Offset);
									MCTimeArchetypeDef mctimeArchetypeDef = new MCTimeArchetypeDef();
									mctimeArchetypeDef.Parse(meta, metaStructure);
									this.TimeArchetypes.Add(mctimeArchetypeDef);
								}
							}
							else
							{
								CMloArchetypeDef metaStructure2 = PsoUtils.ConvertDataRaw<CMloArchetypeDef>(data, metaPOINTER.Offset);
								MCMloArchetypeDef mcmloArchetypeDef = new MCMloArchetypeDef();
								mcmloArchetypeDef.Parse(meta, metaStructure2);
								this.MloArchetypes.Add(mcmloArchetypeDef);
							}
						}
						else
						{
							CBaseArchetypeDef metaStructure3 = PsoUtils.ConvertDataRaw<CBaseArchetypeDef>(data, metaPOINTER.Offset);
							MCBaseArchetypeDef mcbaseArchetypeDef = new MCBaseArchetypeDef();
							mcbaseArchetypeDef.Parse(meta, metaStructure3);
							this.Archetypes.Add(mcbaseArchetypeDef);
						}
					}
				}
			}
			this.Name = (MetaName)CMapTypes.name;
			CCompositeEntityType[] array = MetaUtils.ConvertDataArray<CCompositeEntityType>(meta, CMapTypes.compositeEntityTypes);
			this.CompositeEntityTypes = ((array != null) ? array.Select(delegate(CCompositeEntityType e)
			{
				MCCompositeEntityType mccompositeEntityType = new MCCompositeEntityType();
				mccompositeEntityType.Parse(meta, e);
				return mccompositeEntityType;
			}).ToList<MCCompositeEntityType>() : null);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00031DDC File Offset: 0x0002FFDC
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.extensions = default(Array_StructurePointer);
			List<MetaPOINTER> list = new List<MetaPOINTER>();
			base.AddMetaPointers<CBaseArchetypeDef>(mb, list, MetaName.CBaseArchetypeDef, this.Archetypes.Select(delegate(MCBaseArchetypeDef e)
			{
				e.Build(mb, false);
				return e.MetaStructure;
			}));
			base.AddMetaPointers<CMloArchetypeDef>(mb, list, MetaName.CMloArchetypeDef, this.MloArchetypes.Select(delegate(MCMloArchetypeDef e)
			{
				e.Build(mb, false);
				return e.MetaStructure;
			}));
			base.AddMetaPointers<CTimeArchetypeDef>(mb, list, MetaName.CTimeArchetypeDef, this.TimeArchetypes.Select(delegate(MCTimeArchetypeDef e)
			{
				e.Build(mb, false);
				return e.MetaStructure;
			}));
			this.MetaStructure.archetypes = mb.AddPointerArray(list.ToArray());
			this.MetaStructure.name = (uint)this.Name;
			this.MetaStructure.dependencies = mb.AddUintArrayPtr(this.Dependencies.ToArray());
			this.MetaStructure.compositeEntityTypes = mb.AddItemArrayPtr<CCompositeEntityType>(MetaName.CCompositeEntityType, (from e in this.CompositeEntityTypes
			select e.MetaStructure).ToArray<CCompositeEntityType>());
			MCCompositeEntityType.AddEnumAndStructureInfo(mb);
			MCMapTypes.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CMapTypes>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003846 RID: 14406
		public static MetaName _MetaName = MetaName.CMapTypes;

		// Token: 0x04003847 RID: 14407
		public MetaFile Meta;

		// Token: 0x04003848 RID: 14408
		public Array_StructurePointer Extensions;

		// Token: 0x04003849 RID: 14409
		public List<MCBaseArchetypeDef> Archetypes = new List<MCBaseArchetypeDef>();

		// Token: 0x0400384A RID: 14410
		public List<MCMloArchetypeDef> MloArchetypes = new List<MCMloArchetypeDef>();

		// Token: 0x0400384B RID: 14411
		public List<MCTimeArchetypeDef> TimeArchetypes = new List<MCTimeArchetypeDef>();

		// Token: 0x0400384C RID: 14412
		public MetaName Name;

		// Token: 0x0400384D RID: 14413
		public List<uint> Dependencies = new List<uint>();

		// Token: 0x0400384E RID: 14414
		public List<MCCompositeEntityType> CompositeEntityTypes = new List<MCCompositeEntityType>();
	}
}
