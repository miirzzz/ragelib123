using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001DF RID: 479
	public class MUnk_2858946626 : MetaStructureWrapper<Unk_2858946626>
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00036B25 File Offset: 0x00034D25
		public byte Unk_2598445407
		{
			get
			{
				return (byte)this.Unk_3902803273.Count;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00036B34 File Offset: 0x00034D34
		public List<MUnk_94549140> Unk_3902803273
		{
			get
			{
				List<MUnk_94549140> list = new List<MUnk_94549140>();
				foreach (object obj in Enum.GetValues(typeof(Unk_2834549053)))
				{
					Unk_2834549053 unk_2834549053 = (Unk_2834549053)obj;
					if (unk_2834549053 != Unk_2834549053.NUM_ANCHORS)
					{
						list.AddRange(this.Props[unk_2834549053]);
					}
				}
				return list;
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00036BB0 File Offset: 0x00034DB0
		public MUnk_2858946626()
		{
			this.MetaName = MetaName.CPedPropInfo;
			this.MetaStructure = default(Unk_2858946626);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00036C90 File Offset: 0x00034E90
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_2858946626._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_2858946626._MetaName);
			mb.AddStructureInfo(MetaName.CPedPropMetaData);
			mb.AddStructureInfo(MetaName.CAnchorProps);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00036CE8 File Offset: 0x00034EE8
		public override void Parse(MetaFile meta, Unk_2858946626 Unk_2858946626)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_2858946626;
			Unk_94549140[] array = MetaUtils.ConvertDataArray<Unk_94549140>(meta, Unk_2858946626.Unk_3902803273);
			using (IEnumerator enumerator = Enum.GetValues(typeof(Unk_2834549053)).GetEnumerator())
			{
				Func<Unk_94549140, MUnk_94549140> <>9__2;
				while (enumerator.MoveNext())
				{
					Unk_2834549053 value = (Unk_2834549053)enumerator.Current;
					if (value != Unk_2834549053.NUM_ANCHORS)
					{
						Dictionary<Unk_2834549053, List<MUnk_94549140>> props = this.Props;
						Unk_2834549053 value2 = value;
						List<MUnk_94549140> list;
						if (array == null)
						{
							list = null;
						}
						else
						{
							IEnumerable<Unk_94549140> source = from e in array
							where e.anchorId == (byte)value
							select e;
							Func<Unk_94549140, MUnk_94549140> selector;
							if ((selector = <>9__2) == null)
							{
								selector = (<>9__2 = delegate(Unk_94549140 e)
								{
									MUnk_94549140 munk_ = new MUnk_94549140(this);
									munk_.Parse(meta, e);
									return munk_;
								});
							}
							list = source.Select(selector).ToList<MUnk_94549140>();
						}
						props[value2] = (list ?? new List<MUnk_94549140>());
					}
				}
			}
			CAnchorProps[] array2 = MetaUtils.ConvertDataArray<CAnchorProps>(meta, Unk_2858946626.aAnchors);
			this.AAnchors = (((array2 != null) ? array2.Select(delegate(CAnchorProps e)
			{
				MCAnchorProps mcanchorProps = new MCAnchorProps(this);
				mcanchorProps.Parse(meta, e);
				return mcanchorProps;
			}).ToList<MCAnchorProps>() : null) ?? new List<MCAnchorProps>());
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00036E3C File Offset: 0x0003503C
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.Unk_2598445407 = this.Unk_2598445407;
			if (this.Unk_3902803273 != null)
			{
				this.MetaStructure.Unk_3902803273 = mb.AddItemArrayPtr<Unk_94549140>(MetaName.CPedPropMetaData, this.Unk_3902803273.Select(delegate(MUnk_94549140 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<Unk_94549140>());
			}
			MUnk_94549140.AddEnumAndStructureInfo(mb);
			if (this.AAnchors != null)
			{
				this.MetaStructure.aAnchors = mb.AddItemArrayPtr<CAnchorProps>(MetaName.CAnchorProps, this.AAnchors.Select(delegate(MCAnchorProps e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CAnchorProps>());
			}
			MCAnchorProps.AddEnumAndStructureInfo(mb);
			MUnk_2858946626.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_2858946626>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400399E RID: 14750
		public static MetaName _MetaName = MetaName.CPedPropInfo;

		// Token: 0x0400399F RID: 14751
		public MetaFile Meta;

		// Token: 0x040039A0 RID: 14752
		public List<MCAnchorProps> AAnchors = new List<MCAnchorProps>();

		// Token: 0x040039A1 RID: 14753
		public Dictionary<Unk_2834549053, List<MUnk_94549140>> Props = new Dictionary<Unk_2834549053, List<MUnk_94549140>>
		{
			{
				Unk_2834549053.ANCHOR_HEAD,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.ANCHOR_EYES,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.ANCHOR_EARS,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.ANCHOR_MOUTH,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.ANCHOR_LEFT_HAND,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.ANCHOR_RIGHT_HAND,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.ANCHOR_LEFT_WRIST,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.ANCHOR_RIGHT_WRIST,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.ANCHOR_HIP,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.ANCHOR_LEFT_FOOT,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.ANCHOR_RIGHT_FOOT,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.Unk_604819740,
				new List<MUnk_94549140>()
			},
			{
				Unk_2834549053.Unk_2358626934,
				new List<MUnk_94549140>()
			}
		};
	}
}
