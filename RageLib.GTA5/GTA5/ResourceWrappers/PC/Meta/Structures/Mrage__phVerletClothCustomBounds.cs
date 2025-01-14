using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001D2 RID: 466
	public class Mrage__phVerletClothCustomBounds : MetaStructureWrapper<rage__phVerletClothCustomBounds>
	{
		// Token: 0x060007CD RID: 1997 RVA: 0x0003595A File Offset: 0x00033B5A
		public Mrage__phVerletClothCustomBounds()
		{
			this.MetaName = MetaName.rage__phVerletClothCustomBounds;
			this.MetaStructure = default(rage__phVerletClothCustomBounds);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0003597C File Offset: 0x00033B7C
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(Mrage__phVerletClothCustomBounds._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(Mrage__phVerletClothCustomBounds._MetaName);
			mb.AddStructureInfo((MetaName)1701774085);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x000359C8 File Offset: 0x00033BC8
		public override void Parse(MetaFile meta, rage__phVerletClothCustomBounds rage__phVerletClothCustomBounds)
		{
			this.Meta = meta;
			this.MetaStructure = rage__phVerletClothCustomBounds;
			this.Name = rage__phVerletClothCustomBounds.name;
			Unk_1701774085[] array = MetaUtils.ConvertDataArray<Unk_1701774085>(meta, rage__phVerletClothCustomBounds.CollisionData);
			this.CollisionData = ((array != null) ? array.Select(delegate(Unk_1701774085 e)
			{
				MUnk_1701774085 munk_ = new MUnk_1701774085();
				munk_.Parse(meta, e);
				return munk_;
			}).ToList<MUnk_1701774085>() : null);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00035A38 File Offset: 0x00033C38
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			if (this.CollisionData != null)
			{
				this.MetaStructure.CollisionData = mb.AddItemArrayPtr<Unk_1701774085>((MetaName)1701774085, this.CollisionData.Select(delegate(MUnk_1701774085 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<Unk_1701774085>());
			}
			MUnk_1701774085.AddEnumAndStructureInfo(mb);
			Mrage__phVerletClothCustomBounds.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<rage__phVerletClothCustomBounds>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400394F RID: 14671
		public static MetaName _MetaName = MetaName.rage__phVerletClothCustomBounds;

		// Token: 0x04003950 RID: 14672
		public MetaFile Meta;

		// Token: 0x04003951 RID: 14673
		public uint Name;

		// Token: 0x04003952 RID: 14674
		public List<MUnk_1701774085> CollisionData;
	}
}
