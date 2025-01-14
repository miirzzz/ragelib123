using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001E5 RID: 485
	public class MUnk_975711773 : MetaStructureWrapper<Unk_975711773>
	{
		// Token: 0x06000832 RID: 2098 RVA: 0x000380EC File Offset: 0x000362EC
		public MUnk_975711773()
		{
			this.MetaName = MetaName.BoxOccluder;
			this.MetaStructure = default(Unk_975711773);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0003810C File Offset: 0x0003630C
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_975711773._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_975711773._MetaName);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0003814C File Offset: 0x0003634C
		public override void Parse(MetaFile meta, Unk_975711773 Unk_975711773)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_975711773;
			this.ICenterX = Unk_975711773.iCenterX;
			this.ICenterY = Unk_975711773.iCenterY;
			this.ICenterZ = Unk_975711773.iCenterZ;
			this.ICosZ = Unk_975711773.iCosZ;
			this.ILength = Unk_975711773.iLength;
			this.IWidth = Unk_975711773.iWidth;
			this.IHeight = Unk_975711773.iHeight;
			this.ISinZ = Unk_975711773.iSinZ;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000381C8 File Offset: 0x000363C8
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.iCenterX = this.ICenterX;
			this.MetaStructure.iCenterY = this.ICenterY;
			this.MetaStructure.iCenterZ = this.ICenterZ;
			this.MetaStructure.iCosZ = this.ICosZ;
			this.MetaStructure.iLength = this.ILength;
			this.MetaStructure.iWidth = this.IWidth;
			this.MetaStructure.iHeight = this.IHeight;
			this.MetaStructure.iSinZ = this.ISinZ;
			MUnk_975711773.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_975711773>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040039D1 RID: 14801
		public static MetaName _MetaName = MetaName.BoxOccluder;

		// Token: 0x040039D2 RID: 14802
		public MetaFile Meta;

		// Token: 0x040039D3 RID: 14803
		public short ICenterX;

		// Token: 0x040039D4 RID: 14804
		public short ICenterY;

		// Token: 0x040039D5 RID: 14805
		public short ICenterZ;

		// Token: 0x040039D6 RID: 14806
		public short ICosZ;

		// Token: 0x040039D7 RID: 14807
		public short ILength;

		// Token: 0x040039D8 RID: 14808
		public short IWidth;

		// Token: 0x040039D9 RID: 14809
		public short IHeight;

		// Token: 0x040039DA RID: 14810
		public short ISinZ;
	}
}
