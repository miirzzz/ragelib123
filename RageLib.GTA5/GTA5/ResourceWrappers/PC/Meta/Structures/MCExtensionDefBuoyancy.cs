using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001A7 RID: 423
	public class MCExtensionDefBuoyancy : MetaStructureWrapper<CExtensionDefBuoyancy>
	{
		// Token: 0x060006E3 RID: 1763 RVA: 0x0002EF9A File Offset: 0x0002D19A
		public MCExtensionDefBuoyancy()
		{
			this.MetaName = MetaName.CExtensionDefBuoyancy;
			this.MetaStructure = default(CExtensionDefBuoyancy);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0002EFBC File Offset: 0x0002D1BC
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefBuoyancy._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefBuoyancy._MetaName);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0002EFFB File Offset: 0x0002D1FB
		public override void Parse(MetaFile meta, CExtensionDefBuoyancy CExtensionDefBuoyancy)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefBuoyancy;
			this.Name = CExtensionDefBuoyancy.name;
			this.OffsetPosition = CExtensionDefBuoyancy.offsetPosition;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0002F024 File Offset: 0x0002D224
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			MCExtensionDefBuoyancy.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefBuoyancy>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400376E RID: 14190
		public static MetaName _MetaName = MetaName.CExtensionDefBuoyancy;

		// Token: 0x0400376F RID: 14191
		public MetaFile Meta;

		// Token: 0x04003770 RID: 14192
		public uint Name;

		// Token: 0x04003771 RID: 14193
		public Vector3 OffsetPosition;
	}
}
