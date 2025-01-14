using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001B2 RID: 434
	public class MCExtensionDefWindDisturbance : MetaStructureWrapper<CExtensionDefWindDisturbance>
	{
		// Token: 0x0600071A RID: 1818 RVA: 0x00030561 File Offset: 0x0002E761
		public MCExtensionDefWindDisturbance()
		{
			this.MetaName = MetaName.CExtensionDefWindDisturbance;
			this.MetaStructure = default(CExtensionDefWindDisturbance);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00030580 File Offset: 0x0002E780
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefWindDisturbance._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefWindDisturbance._MetaName);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000305C0 File Offset: 0x0002E7C0
		public override void Parse(MetaFile meta, CExtensionDefWindDisturbance CExtensionDefWindDisturbance)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefWindDisturbance;
			this.Name = CExtensionDefWindDisturbance.name;
			this.OffsetPosition = CExtensionDefWindDisturbance.offsetPosition;
			this.OffsetRotation = CExtensionDefWindDisturbance.offsetRotation;
			this.DisturbanceType = CExtensionDefWindDisturbance.disturbanceType;
			this.BoneTag = CExtensionDefWindDisturbance.boneTag;
			this.Size = CExtensionDefWindDisturbance.size;
			this.Strength = CExtensionDefWindDisturbance.strength;
			this.Flags = CExtensionDefWindDisturbance.flags;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0003063C File Offset: 0x0002E83C
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.offsetRotation = this.OffsetRotation;
			this.MetaStructure.disturbanceType = this.DisturbanceType;
			this.MetaStructure.boneTag = this.BoneTag;
			this.MetaStructure.size = this.Size;
			this.MetaStructure.strength = this.Strength;
			this.MetaStructure.flags = this.Flags;
			MCExtensionDefWindDisturbance.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefWindDisturbance>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040037F3 RID: 14323
		public static MetaName _MetaName = MetaName.CExtensionDefWindDisturbance;

		// Token: 0x040037F4 RID: 14324
		public MetaFile Meta;

		// Token: 0x040037F5 RID: 14325
		public uint Name;

		// Token: 0x040037F6 RID: 14326
		public Vector3 OffsetPosition;

		// Token: 0x040037F7 RID: 14327
		public Vector4 OffsetRotation;

		// Token: 0x040037F8 RID: 14328
		public int DisturbanceType;

		// Token: 0x040037F9 RID: 14329
		public int BoneTag;

		// Token: 0x040037FA RID: 14330
		public Vector4 Size;

		// Token: 0x040037FB RID: 14331
		public float Strength;

		// Token: 0x040037FC RID: 14332
		public int Flags;
	}
}
