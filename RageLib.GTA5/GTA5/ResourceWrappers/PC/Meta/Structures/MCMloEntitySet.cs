using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001B9 RID: 441
	public class MCMloEntitySet : MetaStructureWrapper<CMloEntitySet>
	{
		// Token: 0x0600074D RID: 1869 RVA: 0x00032CF1 File Offset: 0x00030EF1
		public MCMloEntitySet()
		{
			this.MetaName = MetaName.CMloEntitySet;
			this.MetaStructure = default(CMloEntitySet);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00032D1C File Offset: 0x00030F1C
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCMloEntitySet._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCMloEntitySet._MetaName);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00032D5C File Offset: 0x00030F5C
		public override void Parse(MetaFile meta, CMloEntitySet CMloEntitySet)
		{
			this.Meta = meta;
			this.MetaStructure = CMloEntitySet;
			this.Name = CMloEntitySet.name;
			uint[] array = MetaUtils.ConvertDataArray<uint>(meta, CMloEntitySet.locations.Pointer, (uint)CMloEntitySet.locations.Count1);
			this.Locations = ((array != null) ? array.ToList<uint>() : null);
			CEntityDef[] array2 = MetaUtils.ConvertDataArray<CEntityDef>(this.Meta, CMloEntitySet.entities);
			this.Entities = (((array2 != null) ? array2.Select(delegate(CEntityDef e)
			{
				MCEntityDef mcentityDef = new MCEntityDef(null);
				mcentityDef.Parse(meta, e);
				return mcentityDef;
			}).ToList<MCEntityDef>() : null) ?? new List<MCEntityDef>());
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00032E08 File Offset: 0x00031008
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.locations = mb.AddUintArrayPtr(this.Locations.ToArray());
			List<MetaPOINTER> list = new List<MetaPOINTER>();
			base.AddMetaPointers<CEntityDef>(mb, list, MetaName.CEntityDef, this.Entities.Select(delegate(MCEntityDef e)
			{
				e.Build(mb, false);
				return e.MetaStructure;
			}));
			this.MetaStructure.entities = mb.AddPointerArray(list.ToArray());
			MCMloEntitySet.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CMloEntitySet>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00032EDB File Offset: 0x000310DB
		public int AddEntity(MCEntityDef entity, int room)
		{
			this.Entities.Add(entity);
			return this.Entities.IndexOf(entity);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00032EF8 File Offset: 0x000310F8
		public void RemoveEntity(MCEntityDef entity)
		{
			int num = this.Entities.IndexOf(entity);
			if (num == -1)
			{
				return;
			}
			this.Entities.RemoveAt(num);
			this.Locations.RemoveAt(num);
		}

		// Token: 0x04003871 RID: 14449
		public static MetaName _MetaName = MetaName.CMloEntitySet;

		// Token: 0x04003872 RID: 14450
		public MetaFile Meta;

		// Token: 0x04003873 RID: 14451
		public uint Name;

		// Token: 0x04003874 RID: 14452
		public List<uint> Locations = new List<uint>();

		// Token: 0x04003875 RID: 14453
		public List<MCEntityDef> Entities;
	}
}
