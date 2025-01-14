using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x0200019D RID: 413
	public class MCBlockDesc : MetaStructureWrapper<CBlockDesc>
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x0002D6AC File Offset: 0x0002B8AC
		public MCBlockDesc()
		{
			this.MetaName = MetaName.CBlockDesc;
			this.MetaStructure = default(CBlockDesc);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0002D710 File Offset: 0x0002B910
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCBlockDesc._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCBlockDesc._MetaName);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0002D750 File Offset: 0x0002B950
		public override void Parse(MetaFile meta, CBlockDesc CBlockDesc)
		{
			this.Meta = meta;
			this.MetaStructure = CBlockDesc;
			this.Version = CBlockDesc.version;
			this.Flags = CBlockDesc.flags;
			this.Name = (MetaUtils.GetString(this.Meta, CBlockDesc.name) ?? "GTAUtil");
			this.ExportedBy = (MetaUtils.GetString(this.Meta, CBlockDesc.exportedBy) ?? "GTAUtil");
			this.Owner = (MetaUtils.GetString(this.Meta, CBlockDesc.owner) ?? "GTAUtil");
			this.Time = (MetaUtils.GetString(this.Meta, CBlockDesc.time) ?? DateTime.UtcNow.ToString("dd MMMM yyyy HH:mm"));
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0002D810 File Offset: 0x0002BA10
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.version = this.Version;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.name = mb.AddStringPtr(this.Name);
			this.MetaStructure.exportedBy = mb.AddStringPtr("GTAUtil");
			this.MetaStructure.owner = mb.AddStringPtr(this.Owner);
			this.MetaStructure.time = mb.AddStringPtr(this.Time);
			MCBlockDesc.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CBlockDesc>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400370B RID: 14091
		public static MetaName _MetaName = MetaName.CBlockDesc;

		// Token: 0x0400370C RID: 14092
		public MetaFile Meta;

		// Token: 0x0400370D RID: 14093
		public uint Version;

		// Token: 0x0400370E RID: 14094
		public uint Flags;

		// Token: 0x0400370F RID: 14095
		public string Name = "GTAUtil";

		// Token: 0x04003710 RID: 14096
		public string ExportedBy = "GTAUtil";

		// Token: 0x04003711 RID: 14097
		public string Owner = "GTAUtil";

		// Token: 0x04003712 RID: 14098
		public string Time = DateTime.UtcNow.ToString("dd MMMM yyyy HH:mm");
	}
}
