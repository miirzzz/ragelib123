using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001DB RID: 475
	public class MUnk_2236980467 : MetaStructureWrapper<Unk_2236980467>
	{
		// Token: 0x060007FA RID: 2042 RVA: 0x000365E5 File Offset: 0x000347E5
		public MUnk_2236980467()
		{
			this.MetaName = (MetaName)(-2057986829);
			this.MetaStructure = default(Unk_2236980467);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00036604 File Offset: 0x00034804
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_2236980467._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_2236980467._MetaName);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00036643 File Offset: 0x00034843
		public override void Parse(MetaFile meta, Unk_2236980467 Unk_2236980467)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_2236980467;
			this.Unk_2828247905 = Unk_2236980467.Unk_2828247905;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0003665F File Offset: 0x0003485F
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.Unk_2828247905 = this.Unk_2828247905;
			MUnk_2236980467.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_2236980467>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003982 RID: 14722
		public static MetaName _MetaName = (MetaName)(-2057986829);

		// Token: 0x04003983 RID: 14723
		public MetaFile Meta;

		// Token: 0x04003984 RID: 14724
		public byte Unk_2828247905;
	}
}
