using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001E2 RID: 482
	public class MUnk_376833625 : MetaStructureWrapper<Unk_376833625>
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00037398 File Offset: 0x00035598
		public ArrayOfBytes12 Unk_2996560424
		{
			get
			{
				ArrayOfBytes12 result = default(ArrayOfBytes12);
				Unk_884254308[] array = (Unk_884254308[])Enum.GetValues(typeof(Unk_884254308));
				int num = 0;
				byte b = 0;
				foreach (Unk_884254308 unk_ in array)
				{
					if (unk_ != Unk_884254308.PV_COMP_INVALID && unk_ != Unk_884254308.PV_COMP_MAX)
					{
						if (this.Components[unk_] == null)
						{
							result.SetByte(num, byte.MaxValue);
						}
						else
						{
							int num2 = num;
							byte b2 = b;
							b = b2 + 1;
							result.SetByte(num2, b2);
						}
						num++;
					}
				}
				return result;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0003741C File Offset: 0x0003561C
		public List<MUnk_3538495220> Unk_3796409423
		{
			get
			{
				List<MUnk_3538495220> list = new List<MUnk_3538495220>();
				foreach (KeyValuePair<Unk_884254308, MUnk_3538495220> keyValuePair in this.Components)
				{
					if (keyValuePair.Value != null)
					{
						list.Add(keyValuePair.Value);
					}
				}
				return list;
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00037488 File Offset: 0x00035688
		public MUnk_376833625()
		{
			this.MetaName = MetaName.CPedVariationInfo;
			this.MetaStructure = default(Unk_376833625);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00037544 File Offset: 0x00035744
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_376833625._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_376833625._MetaName);
			mb.AddStructureInfo(MetaName.CPVComponentData);
			mb.AddStructureInfo(MetaName.CPedSelectionSet);
			mb.AddStructureInfo(MetaName.CComponentInfo);
			mb.AddStructureInfo(MetaName.CPedPropInfo);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000375B0 File Offset: 0x000357B0
		public override void Parse(MetaFile meta, Unk_376833625 Unk_376833625)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_376833625;
			this.Unk_1235281004 = Unk_376833625.Unk_1235281004;
			this.Unk_4086467184 = Unk_376833625.Unk_4086467184;
			this.Unk_911147899 = Unk_376833625.Unk_911147899;
			this.Unk_315291935 = Unk_376833625.Unk_315291935;
			Unk_3538495220[] array = MetaUtils.ConvertDataArray<Unk_3538495220>(meta, Unk_376833625.Unk_3796409423);
			int num = 0;
			if (Unk_376833625.Unk_2996560424.b00 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_HEAD] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_HEAD].Parse(meta, array[num++]);
			}
			if (Unk_376833625.Unk_2996560424.b01 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_BERD] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_BERD].Parse(meta, array[num++]);
			}
			if (Unk_376833625.Unk_2996560424.b02 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_HAIR] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_HAIR].Parse(meta, array[num++]);
			}
			if (Unk_376833625.Unk_2996560424.b03 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_UPPR] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_UPPR].Parse(meta, array[num++]);
			}
			if (Unk_376833625.Unk_2996560424.b04 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_LOWR] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_LOWR].Parse(meta, array[num++]);
			}
			if (Unk_376833625.Unk_2996560424.b05 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_HAND] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_HAND].Parse(meta, array[num++]);
			}
			if (Unk_376833625.Unk_2996560424.b06 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_FEET] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_FEET].Parse(meta, array[num++]);
			}
			if (Unk_376833625.Unk_2996560424.b07 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_TEEF] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_TEEF].Parse(meta, array[num++]);
			}
			if (Unk_376833625.Unk_2996560424.b08 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_ACCS] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_ACCS].Parse(meta, array[num++]);
			}
			if (Unk_376833625.Unk_2996560424.b09 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_TASK] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_TASK].Parse(meta, array[num++]);
			}
			if (Unk_376833625.Unk_2996560424.b10 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_DECL] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_DECL].Parse(meta, array[num++]);
			}
			if (Unk_376833625.Unk_2996560424.b11 != 255)
			{
				this.Components[Unk_884254308.PV_COMP_JBIB] = new MUnk_3538495220();
				this.Components[Unk_884254308.PV_COMP_JBIB].Parse(meta, array[num++]);
			}
			Unk_253191135[] array2 = MetaUtils.ConvertDataArray<Unk_253191135>(meta, Unk_376833625.Unk_2131007641);
			this.Unk_2131007641 = ((array2 != null) ? array2.Select(delegate(Unk_253191135 e)
			{
				MUnk_253191135 munk_ = new MUnk_253191135();
				munk_.Parse(meta, e);
				return munk_;
			}).ToList<MUnk_253191135>() : null);
			CComponentInfo[] array3 = MetaUtils.ConvertDataArray<CComponentInfo>(meta, Unk_376833625.compInfos);
			this.CompInfos = ((array3 != null) ? array3.Select(delegate(CComponentInfo e)
			{
				MCComponentInfo mccomponentInfo = new MCComponentInfo();
				mccomponentInfo.Parse(meta, e);
				return mccomponentInfo;
			}).ToList<MCComponentInfo>() : null);
			this.PropInfo = new MUnk_2858946626();
			this.PropInfo.Parse(meta, Unk_376833625.propInfo);
			this.DlcName = Unk_376833625.dlcName;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00037A00 File Offset: 0x00035C00
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.Unk_1235281004 = this.Unk_1235281004;
			this.MetaStructure.Unk_4086467184 = this.Unk_4086467184;
			this.MetaStructure.Unk_911147899 = this.Unk_911147899;
			this.MetaStructure.Unk_315291935 = this.Unk_315291935;
			this.MetaStructure.Unk_2996560424 = this.Unk_2996560424;
			if (this.Unk_3796409423 != null)
			{
				this.MetaStructure.Unk_3796409423 = mb.AddItemArrayPtr<Unk_3538495220>(MetaName.CPVComponentData, this.Unk_3796409423.Select(delegate(MUnk_3538495220 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<Unk_3538495220>());
			}
			MUnk_3538495220.AddEnumAndStructureInfo(mb);
			if (this.Unk_2131007641 != null)
			{
				this.MetaStructure.Unk_2131007641 = mb.AddItemArrayPtr<Unk_253191135>(MetaName.CPedSelectionSet, this.Unk_2131007641.Select(delegate(MUnk_253191135 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<Unk_253191135>());
			}
			MUnk_253191135.AddEnumAndStructureInfo(mb);
			if (this.CompInfos != null)
			{
				this.MetaStructure.compInfos = mb.AddItemArrayPtr<CComponentInfo>(MetaName.CComponentInfo, this.CompInfos.Select(delegate(MCComponentInfo e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CComponentInfo>());
			}
			MCComponentInfo.AddEnumAndStructureInfo(mb);
			this.PropInfo.Build(mb, false);
			this.MetaStructure.propInfo = this.PropInfo.MetaStructure;
			MUnk_2858946626.AddEnumAndStructureInfo(mb);
			this.MetaStructure.dlcName = this.DlcName;
			MUnk_376833625.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_376833625>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040039B6 RID: 14774
		public static MetaName _MetaName = MetaName.CPedVariationInfo;

		// Token: 0x040039B7 RID: 14775
		public MetaFile Meta;

		// Token: 0x040039B8 RID: 14776
		public byte Unk_1235281004;

		// Token: 0x040039B9 RID: 14777
		public byte Unk_4086467184;

		// Token: 0x040039BA RID: 14778
		public byte Unk_911147899;

		// Token: 0x040039BB RID: 14779
		public byte Unk_315291935;

		// Token: 0x040039BC RID: 14780
		public List<MUnk_253191135> Unk_2131007641 = new List<MUnk_253191135>();

		// Token: 0x040039BD RID: 14781
		public List<MCComponentInfo> CompInfos = new List<MCComponentInfo>();

		// Token: 0x040039BE RID: 14782
		public MUnk_2858946626 PropInfo = new MUnk_2858946626();

		// Token: 0x040039BF RID: 14783
		public uint DlcName;

		// Token: 0x040039C0 RID: 14784
		public Dictionary<Unk_884254308, MUnk_3538495220> Components = new Dictionary<Unk_884254308, MUnk_3538495220>
		{
			{
				Unk_884254308.PV_COMP_HEAD,
				null
			},
			{
				Unk_884254308.PV_COMP_BERD,
				null
			},
			{
				Unk_884254308.PV_COMP_HAIR,
				null
			},
			{
				Unk_884254308.PV_COMP_UPPR,
				null
			},
			{
				Unk_884254308.PV_COMP_LOWR,
				null
			},
			{
				Unk_884254308.PV_COMP_HAND,
				null
			},
			{
				Unk_884254308.PV_COMP_FEET,
				null
			},
			{
				Unk_884254308.PV_COMP_TEEF,
				null
			},
			{
				Unk_884254308.PV_COMP_ACCS,
				null
			},
			{
				Unk_884254308.PV_COMP_TASK,
				null
			},
			{
				Unk_884254308.PV_COMP_DECL,
				null
			},
			{
				Unk_884254308.PV_COMP_JBIB,
				null
			}
		};
	}
}
