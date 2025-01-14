using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001BB RID: 443
	public class MCMloPortalDef : MetaStructureWrapper<CMloPortalDef>
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x0003327C File Offset: 0x0003147C
		public MCMloPortalDef()
		{
			this.MetaName = MetaName.CMloPortalDef;
			this.MetaStructure = default(CMloPortalDef);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000332B4 File Offset: 0x000314B4
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCMloPortalDef._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCMloPortalDef._MetaName);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000332F4 File Offset: 0x000314F4
		public override void Parse(MetaFile meta, CMloPortalDef CMloPortalDef)
		{
			this.Meta = meta;
			this.MetaStructure = CMloPortalDef;
			this.RoomFrom = CMloPortalDef.roomFrom;
			this.RoomTo = CMloPortalDef.roomTo;
			this.Flags = CMloPortalDef.flags;
			this.MirrorPriority = CMloPortalDef.mirrorPriority;
			this.Opacity = CMloPortalDef.opacity;
			this.AudioOcclusion = CMloPortalDef.audioOcclusion;
			Vector4[] array = MetaUtils.ConvertDataArray<Vector4>(meta, CMloPortalDef.corners.Pointer, (uint)CMloPortalDef.corners.Count1);
			List<Vector3> corners;
			if (array == null)
			{
				corners = null;
			}
			else
			{
				corners = (from e in array
				select (Vector3)e).ToList<Vector3>();
			}
			this.Corners = corners;
			uint[] array2 = MetaUtils.ConvertDataArray<uint>(meta, CMloPortalDef.attachedObjects.Pointer, (uint)CMloPortalDef.attachedObjects.Count1);
			this.AttachedObjects = ((array2 != null) ? array2.ToList<uint>() : null);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000333DC File Offset: 0x000315DC
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.roomFrom = this.RoomFrom;
			this.MetaStructure.roomTo = this.RoomTo;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.mirrorPriority = this.MirrorPriority;
			this.MetaStructure.opacity = this.Opacity;
			this.MetaStructure.audioOcclusion = this.AudioOcclusion;
			this.MetaStructure.corners = mb.AddPaddedVector3ArrayPtr((from e in this.Corners
			select (Vector4)e).ToArray<Vector4>());
			this.MetaStructure.attachedObjects = mb.AddUintArrayPtr(this.AttachedObjects.ToArray());
			MCMloPortalDef.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CMloPortalDef>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400388E RID: 14478
		public static MetaName _MetaName = MetaName.CMloPortalDef;

		// Token: 0x0400388F RID: 14479
		public MetaFile Meta;

		// Token: 0x04003890 RID: 14480
		public uint RoomFrom;

		// Token: 0x04003891 RID: 14481
		public uint RoomTo;

		// Token: 0x04003892 RID: 14482
		public uint Flags;

		// Token: 0x04003893 RID: 14483
		public uint MirrorPriority;

		// Token: 0x04003894 RID: 14484
		public uint Opacity;

		// Token: 0x04003895 RID: 14485
		public uint AudioOcclusion;

		// Token: 0x04003896 RID: 14486
		public List<Vector3> Corners = new List<Vector3>();

		// Token: 0x04003897 RID: 14487
		public List<uint> AttachedObjects = new List<uint>();
	}
}
