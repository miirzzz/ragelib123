using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001D1 RID: 465
	public class Mrage__fwInstancedMapData : MetaStructureWrapper<rage__fwInstancedMapData>
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x000357A5 File Offset: 0x000339A5
		public Mrage__fwInstancedMapData()
		{
			this.MetaName = MetaName.rage__fwInstancedMapData;
			this.MetaStructure = default(rage__fwInstancedMapData);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x000357D0 File Offset: 0x000339D0
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(Mrage__fwInstancedMapData._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(Mrage__fwInstancedMapData._MetaName);
			mb.AddStructureInfo(MetaName.rage__fwGrassInstanceListDef);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0003581C File Offset: 0x00033A1C
		public override void Parse(MetaFile meta, rage__fwInstancedMapData rage__fwInstancedMapData)
		{
			this.Meta = meta;
			this.MetaStructure = rage__fwInstancedMapData;
			this.ImapLink = rage__fwInstancedMapData.ImapLink;
			rage__fwGrassInstanceListDef[] array = MetaUtils.ConvertDataArray<rage__fwGrassInstanceListDef>(meta, rage__fwInstancedMapData.GrassInstanceList);
			this.GrassInstanceList = ((array != null) ? array.Select(delegate(rage__fwGrassInstanceListDef e)
			{
				Mrage__fwGrassInstanceListDef mrage__fwGrassInstanceListDef = new Mrage__fwGrassInstanceListDef();
				mrage__fwGrassInstanceListDef.Parse(meta, e);
				return mrage__fwGrassInstanceListDef;
			}).ToList<Mrage__fwGrassInstanceListDef>() : null);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0003588C File Offset: 0x00033A8C
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.ImapLink = this.ImapLink;
			this.MetaStructure.PropInstanceList = default(Array_Structure);
			if (this.GrassInstanceList != null)
			{
				this.MetaStructure.GrassInstanceList = mb.AddItemArrayPtr<rage__fwGrassInstanceListDef>(MetaName.rage__fwGrassInstanceListDef, this.GrassInstanceList.Select(delegate(Mrage__fwGrassInstanceListDef e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<rage__fwGrassInstanceListDef>());
			}
			Mrage__fwGrassInstanceListDef.AddEnumAndStructureInfo(mb);
			Mrage__fwInstancedMapData.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<rage__fwInstancedMapData>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400394A RID: 14666
		public static MetaName _MetaName = MetaName.rage__fwInstancedMapData;

		// Token: 0x0400394B RID: 14667
		public MetaFile Meta;

		// Token: 0x0400394C RID: 14668
		public uint ImapLink;

		// Token: 0x0400394D RID: 14669
		public Array_Structure PropInstanceList;

		// Token: 0x0400394E RID: 14670
		public List<Mrage__fwGrassInstanceListDef> GrassInstanceList = new List<Mrage__fwGrassInstanceListDef>();
	}
}
