using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001AF RID: 431
	public class MCExtensionDefProcObject : MetaStructureWrapper<CExtensionDefProcObject>
	{
		// Token: 0x0600070B RID: 1803 RVA: 0x0002FE56 File Offset: 0x0002E056
		public MCExtensionDefProcObject()
		{
			this.MetaName = MetaName.CExtensionDefProcObject;
			this.MetaStructure = default(CExtensionDefProcObject);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0002FE78 File Offset: 0x0002E078
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefProcObject._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefProcObject._MetaName);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0002FEB8 File Offset: 0x0002E0B8
		public override void Parse(MetaFile meta, CExtensionDefProcObject CExtensionDefProcObject)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefProcObject;
			this.Name = CExtensionDefProcObject.name;
			this.OffsetPosition = CExtensionDefProcObject.offsetPosition;
			this.RadiusInner = CExtensionDefProcObject.radiusInner;
			this.RadiusOuter = CExtensionDefProcObject.radiusOuter;
			this.Spacing = CExtensionDefProcObject.spacing;
			this.MinScale = CExtensionDefProcObject.minScale;
			this.MaxScale = CExtensionDefProcObject.maxScale;
			this.Unk_3913056845 = CExtensionDefProcObject.Unk_3913056845;
			this.Unk_147400493 = CExtensionDefProcObject.Unk_147400493;
			this.Unk_2591582364 = CExtensionDefProcObject.Unk_2591582364;
			this.Unk_3889902555 = CExtensionDefProcObject.Unk_3889902555;
			this.ObjectHash = CExtensionDefProcObject.objectHash;
			this.Flags = CExtensionDefProcObject.flags;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0002FF70 File Offset: 0x0002E170
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.radiusInner = this.RadiusInner;
			this.MetaStructure.radiusOuter = this.RadiusOuter;
			this.MetaStructure.spacing = this.Spacing;
			this.MetaStructure.minScale = this.MinScale;
			this.MetaStructure.maxScale = this.MaxScale;
			this.MetaStructure.Unk_3913056845 = this.Unk_3913056845;
			this.MetaStructure.Unk_147400493 = this.Unk_147400493;
			this.MetaStructure.Unk_2591582364 = this.Unk_2591582364;
			this.MetaStructure.Unk_3889902555 = this.Unk_3889902555;
			this.MetaStructure.objectHash = this.ObjectHash;
			this.MetaStructure.flags = this.Flags;
			MCExtensionDefProcObject.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefProcObject>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040037C3 RID: 14275
		public static MetaName _MetaName = MetaName.CExtensionDefProcObject;

		// Token: 0x040037C4 RID: 14276
		public MetaFile Meta;

		// Token: 0x040037C5 RID: 14277
		public uint Name;

		// Token: 0x040037C6 RID: 14278
		public Vector3 OffsetPosition;

		// Token: 0x040037C7 RID: 14279
		public float RadiusInner;

		// Token: 0x040037C8 RID: 14280
		public float RadiusOuter;

		// Token: 0x040037C9 RID: 14281
		public float Spacing;

		// Token: 0x040037CA RID: 14282
		public float MinScale;

		// Token: 0x040037CB RID: 14283
		public float MaxScale;

		// Token: 0x040037CC RID: 14284
		public float Unk_3913056845;

		// Token: 0x040037CD RID: 14285
		public float Unk_147400493;

		// Token: 0x040037CE RID: 14286
		public float Unk_2591582364;

		// Token: 0x040037CF RID: 14287
		public float Unk_3889902555;

		// Token: 0x040037D0 RID: 14288
		public uint ObjectHash;

		// Token: 0x040037D1 RID: 14289
		public uint Flags;
	}
}
