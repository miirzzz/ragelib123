using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001E4 RID: 484
	public class MUnk_94549140 : MetaStructureWrapper<Unk_94549140>
	{
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00037E64 File Offset: 0x00036064
		public byte PropId
		{
			get
			{
				return (byte)this.Parent.Props[(Unk_2834549053)this.AnchorId].IndexOf(this);
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00037E83 File Offset: 0x00036083
		public MUnk_94549140(MUnk_2858946626 parent)
		{
			this.MetaName = MetaName.CPedPropMetaData;
			this.MetaStructure = default(Unk_94549140);
			this.Parent = parent;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00037EB4 File Offset: 0x000360B4
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_94549140._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_94549140._MetaName);
			mb.AddStructureInfo(MetaName.CPedPropTexData);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00037F00 File Offset: 0x00036100
		public override void Parse(MetaFile meta, Unk_94549140 Unk_94549140)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_94549140;
			this.AudioId = Unk_94549140.audioId;
			this.ExpressionMods = Unk_94549140.expressionMods;
			Unk_254518642[] array = MetaUtils.ConvertDataArray<Unk_254518642>(meta, Unk_94549140.texData);
			this.TexData = ((array != null) ? array.Select(delegate(Unk_254518642 e)
			{
				MUnk_254518642 munk_ = new MUnk_254518642();
				munk_.Parse(meta, e);
				return munk_;
			}).ToList<MUnk_254518642>() : null);
			this.RenderFlags = Unk_94549140.renderFlags;
			this.PropFlags = Unk_94549140.propFlags;
			this.Flags = Unk_94549140.flags;
			this.AnchorId = Unk_94549140.anchorId;
			this.Unk_2894625425 = Unk_94549140.Unk_2894625425;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00037FB8 File Offset: 0x000361B8
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.audioId = this.AudioId;
			this.MetaStructure.expressionMods = this.ExpressionMods;
			if (this.TexData != null)
			{
				this.MetaStructure.texData = mb.AddItemArrayPtr<Unk_254518642>(MetaName.CPedPropTexData, this.TexData.Select(delegate(MUnk_254518642 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<Unk_254518642>());
			}
			MUnk_254518642.AddEnumAndStructureInfo(mb);
			this.MetaStructure.renderFlags = this.RenderFlags;
			this.MetaStructure.propFlags = this.PropFlags;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.anchorId = this.AnchorId;
			this.MetaStructure.propId = this.PropId;
			this.MetaStructure.Unk_2894625425 = this.Unk_2894625425;
			MUnk_94549140.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_94549140>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040039C6 RID: 14790
		public static MetaName _MetaName = MetaName.CPedPropMetaData;

		// Token: 0x040039C7 RID: 14791
		public MetaFile Meta;

		// Token: 0x040039C8 RID: 14792
		public uint AudioId;

		// Token: 0x040039C9 RID: 14793
		public ArrayOfBytes5 ExpressionMods;

		// Token: 0x040039CA RID: 14794
		public List<MUnk_254518642> TexData = new List<MUnk_254518642>();

		// Token: 0x040039CB RID: 14795
		public Unk_4212977111 RenderFlags;

		// Token: 0x040039CC RID: 14796
		public uint PropFlags;

		// Token: 0x040039CD RID: 14797
		public ushort Flags;

		// Token: 0x040039CE RID: 14798
		public byte AnchorId;

		// Token: 0x040039CF RID: 14799
		public byte Unk_2894625425;

		// Token: 0x040039D0 RID: 14800
		private MUnk_2858946626 Parent;
	}
}
