using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001CB RID: 459
	public class MCStreamingRequestRecord : MetaStructureWrapper<CStreamingRequestRecord>
	{
		// Token: 0x060007AB RID: 1963 RVA: 0x00034CF5 File Offset: 0x00032EF5
		public MCStreamingRequestRecord()
		{
			this.MetaName = MetaName.CStreamingRequestRecord;
			this.MetaStructure = default(CStreamingRequestRecord);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00034D14 File Offset: 0x00032F14
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCStreamingRequestRecord._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCStreamingRequestRecord._MetaName);
			mb.AddStructureInfo(MetaName.CStreamingRequestFrame);
			mb.AddStructureInfo(MetaName.CStreamingRequestCommonSet);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00034D6C File Offset: 0x00032F6C
		public override void Parse(MetaFile meta, CStreamingRequestRecord CStreamingRequestRecord)
		{
			this.Meta = meta;
			this.MetaStructure = CStreamingRequestRecord;
			CStreamingRequestFrame[] array = MetaUtils.ConvertDataArray<CStreamingRequestFrame>(meta, CStreamingRequestRecord.Frames);
			this.Frames = ((array != null) ? array.Select(delegate(CStreamingRequestFrame e)
			{
				MCStreamingRequestFrame mcstreamingRequestFrame = new MCStreamingRequestFrame();
				mcstreamingRequestFrame.Parse(meta, e);
				return mcstreamingRequestFrame;
			}).ToList<MCStreamingRequestFrame>() : null);
			Unk_1358189812[] array2 = MetaUtils.ConvertDataArray<Unk_1358189812>(meta, CStreamingRequestRecord.CommonSets);
			this.CommonSets = ((array2 != null) ? array2.Select(delegate(Unk_1358189812 e)
			{
				MUnk_1358189812 munk_ = new MUnk_1358189812();
				munk_.Parse(meta, e);
				return munk_;
			}).ToList<MUnk_1358189812>() : null);
			this.NewStyle = CStreamingRequestRecord.NewStyle;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00034E10 File Offset: 0x00033010
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			if (this.Frames != null)
			{
				this.MetaStructure.Frames = mb.AddItemArrayPtr<CStreamingRequestFrame>(MetaName.CStreamingRequestFrame, this.Frames.Select(delegate(MCStreamingRequestFrame e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CStreamingRequestFrame>());
			}
			MCStreamingRequestFrame.AddEnumAndStructureInfo(mb);
			if (this.CommonSets != null)
			{
				this.MetaStructure.CommonSets = mb.AddItemArrayPtr<Unk_1358189812>(MetaName.CStreamingRequestCommonSet, this.CommonSets.Select(delegate(MUnk_1358189812 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<Unk_1358189812>());
			}
			MUnk_1358189812.AddEnumAndStructureInfo(mb);
			this.MetaStructure.NewStyle = this.NewStyle;
			MCStreamingRequestRecord.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CStreamingRequestRecord>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003914 RID: 14612
		public static MetaName _MetaName = MetaName.CStreamingRequestRecord;

		// Token: 0x04003915 RID: 14613
		public MetaFile Meta;

		// Token: 0x04003916 RID: 14614
		public List<MCStreamingRequestFrame> Frames;

		// Token: 0x04003917 RID: 14615
		public List<MUnk_1358189812> CommonSets;

		// Token: 0x04003918 RID: 14616
		public byte NewStyle;
	}
}
