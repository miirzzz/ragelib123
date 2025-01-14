using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001BC RID: 444
	public class MCMloRoomDef : MetaStructureWrapper<CMloRoomDef>
	{
		// Token: 0x0600075E RID: 1886 RVA: 0x000334E4 File Offset: 0x000316E4
		public MCMloRoomDef(MCMloArchetypeDef parent)
		{
			this.MetaName = MetaName.CMloRoomDef;
			this.MetaStructure = default(CMloRoomDef);
			this.Parent = parent;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00033520 File Offset: 0x00031720
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCMloRoomDef._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCMloRoomDef._MetaName);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00033560 File Offset: 0x00031760
		public override void Parse(MetaFile meta, CMloRoomDef CMloRoomDef)
		{
			this.Meta = meta;
			this.MetaStructure = CMloRoomDef;
			this.Name = MetaUtils.GetString(this.Meta, CMloRoomDef.name);
			this.BbMin = CMloRoomDef.bbMin;
			this.BbMax = CMloRoomDef.bbMax;
			this.Blend = CMloRoomDef.blend;
			this.TimecycleName = CMloRoomDef.timecycleName;
			this.SecondaryTimecycleName = CMloRoomDef.secondaryTimecycleName;
			this.Flags = CMloRoomDef.flags;
			this.PortalCount = CMloRoomDef.portalCount;
			this.FloorId = CMloRoomDef.floorId;
			this.ExteriorVisibiltyDepth = CMloRoomDef.exteriorVisibiltyDepth;
			uint[] array = MetaUtils.ConvertDataArray<uint>(meta, CMloRoomDef.attachedObjects.Pointer, (uint)CMloRoomDef.attachedObjects.Count1);
			this.AttachedObjects = ((array != null) ? array.ToList<uint>() : null);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00033630 File Offset: 0x00031830
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = mb.AddStringPtr(this.Name);
			this.MetaStructure.bbMin = this.BbMin;
			this.MetaStructure.bbMax = this.BbMax;
			this.MetaStructure.blend = this.Blend;
			this.MetaStructure.timecycleName = this.TimecycleName;
			this.MetaStructure.secondaryTimecycleName = this.SecondaryTimecycleName;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.portalCount = this.PortalCount;
			this.MetaStructure.floorId = this.FloorId;
			this.MetaStructure.exteriorVisibiltyDepth = this.ExteriorVisibiltyDepth;
			this.MetaStructure.attachedObjects = mb.AddUintArrayPtr(this.AttachedObjects.ToArray());
			MCMloRoomDef.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CMloRoomDef>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00033738 File Offset: 0x00031938
		public void AddEntity(MCEntityDef entity)
		{
			int num = this.AttachedObjects.IndexOf((uint)this.Parent.Entities.IndexOf(entity));
			if (num != -1)
			{
				return;
			}
			this.AttachedObjects.Add((uint)num);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00033774 File Offset: 0x00031974
		public void RemoveEntity(MCEntityDef entity)
		{
			int num = this.AttachedObjects.IndexOf((uint)this.Parent.Entities.IndexOf(entity));
			if (num == -1)
			{
				return;
			}
			this.AttachedObjects.RemoveAt(num);
		}

		// Token: 0x04003898 RID: 14488
		public static MetaName _MetaName = MetaName.CMloRoomDef;

		// Token: 0x04003899 RID: 14489
		public MetaFile Meta;

		// Token: 0x0400389A RID: 14490
		public string Name = "";

		// Token: 0x0400389B RID: 14491
		public Vector3 BbMin;

		// Token: 0x0400389C RID: 14492
		public Vector3 BbMax;

		// Token: 0x0400389D RID: 14493
		public float Blend;

		// Token: 0x0400389E RID: 14494
		public uint TimecycleName;

		// Token: 0x0400389F RID: 14495
		public uint SecondaryTimecycleName;

		// Token: 0x040038A0 RID: 14496
		public uint Flags;

		// Token: 0x040038A1 RID: 14497
		public uint PortalCount;

		// Token: 0x040038A2 RID: 14498
		public int FloorId;

		// Token: 0x040038A3 RID: 14499
		public int ExteriorVisibiltyDepth;

		// Token: 0x040038A4 RID: 14500
		public List<uint> AttachedObjects = new List<uint>();

		// Token: 0x040038A5 RID: 14501
		public MCMloArchetypeDef Parent;
	}
}
