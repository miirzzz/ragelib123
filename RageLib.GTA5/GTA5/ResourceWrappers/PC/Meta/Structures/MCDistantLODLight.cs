using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001A2 RID: 418
	public class MCDistantLODLight : MetaStructureWrapper<CDistantLODLight>
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0002E258 File Offset: 0x0002C458
		public List<MVECTOR3> Position
		{
			get
			{
				return (from e in this.Entries
				select e.Position).ToList<MVECTOR3>();
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0002E289 File Offset: 0x0002C489
		public List<uint> RGBI
		{
			get
			{
				return (from e in this.Entries
				select e.RGBI).ToList<uint>();
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0002E2BA File Offset: 0x0002C4BA
		public MCDistantLODLight()
		{
			this.MetaName = MetaName.CDistantLODLight;
			this.MetaStructure = default(CDistantLODLight);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0002E2E4 File Offset: 0x0002C4E4
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCDistantLODLight._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCDistantLODLight._MetaName);
			mb.AddStructureInfo(MetaName.VECTOR3);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0002E330 File Offset: 0x0002C530
		public override void Parse(MetaFile meta, CDistantLODLight CDistantLODLight)
		{
			this.Meta = meta;
			this.MetaStructure = CDistantLODLight;
			VECTOR3[] array = MetaUtils.ConvertDataArray<VECTOR3>(meta, CDistantLODLight.position);
			List<MVECTOR3> list = (array != null) ? array.Select(delegate(VECTOR3 e)
			{
				MVECTOR3 mvector = new MVECTOR3();
				mvector.Parse(meta, e);
				return mvector;
			}).ToList<MVECTOR3>() : null;
			uint[] array2 = MetaUtils.ConvertDataArray<uint>(meta, CDistantLODLight.RGBI.Pointer, (uint)CDistantLODLight.RGBI.Count1).ToArray<uint>();
			this.Entries.Clear();
			for (int i = 0; i < list.Count; i++)
			{
				this.Entries.Add(new DistantLODLightEntry
				{
					Position = list[i],
					RGBI = array2[i]
				});
			}
			this.NumStreetLights = CDistantLODLight.numStreetLights;
			this.Category = CDistantLODLight.category;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0002E418 File Offset: 0x0002C618
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			if (this.Position != null)
			{
				this.MetaStructure.position = mb.AddItemArrayPtr<VECTOR3>(MetaName.VECTOR3, this.Position.Select(delegate(MVECTOR3 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<VECTOR3>());
			}
			MVECTOR3.AddEnumAndStructureInfo(mb);
			this.MetaStructure.RGBI = mb.AddUintArrayPtr(this.RGBI.ToArray());
			this.MetaStructure.numStreetLights = this.NumStreetLights;
			this.MetaStructure.category = this.Category;
			MCDistantLODLight.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CDistantLODLight>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003742 RID: 14146
		public static MetaName _MetaName = MetaName.CDistantLODLight;

		// Token: 0x04003743 RID: 14147
		public MetaFile Meta;

		// Token: 0x04003744 RID: 14148
		public ushort NumStreetLights;

		// Token: 0x04003745 RID: 14149
		public ushort Category;

		// Token: 0x04003746 RID: 14150
		public List<DistantLODLightEntry> Entries = new List<DistantLODLightEntry>();
	}
}
