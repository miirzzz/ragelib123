using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001D8 RID: 472
	public class MUnk_1535046754 : MetaStructureWrapper<Unk_1535046754>
	{
		// Token: 0x060007EB RID: 2027 RVA: 0x00035FC2 File Offset: 0x000341C2
		public MUnk_1535046754()
		{
			this.MetaName = MetaName.CPVDrawblData;
			this.MetaStructure = default(Unk_1535046754);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00036000 File Offset: 0x00034200
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_1535046754._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_1535046754._MetaName);
			mb.AddStructureInfo(MetaName.CPVTextureData);
			mb.AddStructureInfo((MetaName)(-2057986829));
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00036058 File Offset: 0x00034258
		public override void Parse(MetaFile meta, Unk_1535046754 Unk_1535046754)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_1535046754;
			this.PropMask = Unk_1535046754.propMask;
			this.Unk_2806194106 = Unk_1535046754.Unk_2806194106;
			Unk_1036962405[] array = MetaUtils.ConvertDataArray<Unk_1036962405>(meta, Unk_1535046754.aTexData);
			this.ATexData = ((array != null) ? array.Select(delegate(Unk_1036962405 e)
			{
				MUnk_1036962405 munk_ = new MUnk_1036962405();
				munk_.Parse(meta, e);
				return munk_;
			}).ToList<MUnk_1036962405>() : null);
			this.ClothData = new MUnk_2236980467();
			this.ClothData.Parse(meta, Unk_1535046754.clothData);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000360F4 File Offset: 0x000342F4
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.propMask = this.PropMask;
			this.MetaStructure.Unk_2806194106 = this.Unk_2806194106;
			if (this.ATexData != null)
			{
				this.MetaStructure.aTexData = mb.AddItemArrayPtr<Unk_1036962405>(MetaName.CPVTextureData, this.ATexData.Select(delegate(MUnk_1036962405 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<Unk_1036962405>());
			}
			MUnk_1036962405.AddEnumAndStructureInfo(mb);
			this.ClothData.Build(mb, false);
			this.MetaStructure.clothData = this.ClothData.MetaStructure;
			MUnk_2236980467.AddEnumAndStructureInfo(mb);
			MUnk_1535046754.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_1535046754>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003969 RID: 14697
		public static MetaName _MetaName = MetaName.CPVDrawblData;

		// Token: 0x0400396A RID: 14698
		public MetaFile Meta;

		// Token: 0x0400396B RID: 14699
		public byte PropMask = 1;

		// Token: 0x0400396C RID: 14700
		public byte Unk_2806194106;

		// Token: 0x0400396D RID: 14701
		public List<MUnk_1036962405> ATexData = new List<MUnk_1036962405>();

		// Token: 0x0400396E RID: 14702
		public MUnk_2236980467 ClothData = new MUnk_2236980467();
	}
}
