using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001E1 RID: 481
	public class MUnk_3538495220 : MetaStructureWrapper<Unk_3538495220>
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x000371BC File Offset: 0x000353BC
		public byte Unk_3371516811
		{
			get
			{
				int num = 0;
				for (int i = 0; i < this.Unk_1756136273.Count; i++)
				{
					num += this.Unk_1756136273[i].ATexData.Count;
				}
				return (byte)num;
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x000371FC File Offset: 0x000353FC
		public MUnk_3538495220()
		{
			this.MetaName = MetaName.CPVComponentData;
			this.MetaStructure = default(Unk_3538495220);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00037228 File Offset: 0x00035428
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_3538495220._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_3538495220._MetaName);
			mb.AddStructureInfo(MetaName.CPVDrawblData);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00037274 File Offset: 0x00035474
		public override void Parse(MetaFile meta, Unk_3538495220 Unk_3538495220)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_3538495220;
			Unk_1535046754[] array = MetaUtils.ConvertDataArray<Unk_1535046754>(meta, Unk_3538495220.Unk_1756136273);
			this.Unk_1756136273 = ((array != null) ? array.Select(delegate(Unk_1535046754 e)
			{
				MUnk_1535046754 munk_ = new MUnk_1535046754();
				munk_.Parse(meta, e);
				return munk_;
			}).ToList<MUnk_1535046754>() : null);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000372D8 File Offset: 0x000354D8
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.Unk_3371516811 = this.Unk_3371516811;
			if (this.Unk_1756136273 != null)
			{
				this.MetaStructure.Unk_1756136273 = mb.AddItemArrayPtr<Unk_1535046754>(MetaName.CPVDrawblData, this.Unk_1756136273.Select(delegate(MUnk_1535046754 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<Unk_1535046754>());
			}
			MUnk_1535046754.AddEnumAndStructureInfo(mb);
			MUnk_3538495220.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_3538495220>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040039B3 RID: 14771
		public static MetaName _MetaName = MetaName.CPVComponentData;

		// Token: 0x040039B4 RID: 14772
		public MetaFile Meta;

		// Token: 0x040039B5 RID: 14773
		public List<MUnk_1535046754> Unk_1756136273 = new List<MUnk_1535046754>();
	}
}
