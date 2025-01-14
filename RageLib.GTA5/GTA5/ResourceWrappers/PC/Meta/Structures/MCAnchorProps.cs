using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x0200019B RID: 411
	public class MCAnchorProps : MetaStructureWrapper<CAnchorProps>
	{
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0002D0AC File Offset: 0x0002B2AC
		public List<byte> Props
		{
			get
			{
				List<KeyValuePair<MUnk_94549140, byte>> list = this.PropsMap.ToList<KeyValuePair<MUnk_94549140, byte>>();
				list.Sort((KeyValuePair<MUnk_94549140, byte> a, KeyValuePair<MUnk_94549140, byte> b) => this.Parent.Unk_3902803273.IndexOf(a.Key) - this.Parent.Unk_3902803273.IndexOf(b.Key));
				return (from e in list
				select e.Value).ToList<byte>();
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0002D0FF File Offset: 0x0002B2FF
		public MCAnchorProps(MUnk_2858946626 parent)
		{
			this.MetaName = MetaName.CAnchorProps;
			this.MetaStructure = default(CAnchorProps);
			this.Parent = parent;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0002D130 File Offset: 0x0002B330
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCAnchorProps._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCAnchorProps._MetaName);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0002D170 File Offset: 0x0002B370
		public override void Parse(MetaFile meta, CAnchorProps CAnchorProps)
		{
			this.Meta = meta;
			this.MetaStructure = CAnchorProps;
			this.Anchor = CAnchorProps.anchor;
			byte[] array = MetaUtils.ConvertDataArray<byte>(meta, CAnchorProps.props.Pointer, (uint)CAnchorProps.props.Count1);
			List<byte> list = (array != null) ? array.ToList<byte>() : null;
			List<MUnk_94549140> list2 = (from e in this.Parent.Unk_3902803273
			where e.AnchorId == (byte)this.Anchor
			select e).ToList<MUnk_94549140>();
			for (int i = 0; i < list2.Count; i++)
			{
				this.PropsMap[list2[i]] = list[i];
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0002D210 File Offset: 0x0002B410
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.props = mb.AddByteArrayPtr(this.Props.ToArray());
			this.MetaStructure.anchor = this.Anchor;
			MCAnchorProps.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CAnchorProps>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040036F1 RID: 14065
		public static MetaName _MetaName = MetaName.CAnchorProps;

		// Token: 0x040036F2 RID: 14066
		public MetaFile Meta;

		// Token: 0x040036F3 RID: 14067
		public Unk_2834549053 Anchor;

		// Token: 0x040036F4 RID: 14068
		public MUnk_2858946626 Parent;

		// Token: 0x040036F5 RID: 14069
		public Dictionary<MUnk_94549140, byte> PropsMap = new Dictionary<MUnk_94549140, byte>();
	}
}
