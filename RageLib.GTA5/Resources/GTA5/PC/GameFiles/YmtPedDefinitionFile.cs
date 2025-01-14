using System;
using RageLib.GTA5.Resources.PC;
using RageLib.GTA5.ResourceWrappers.PC.Meta.Structures;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.Resources.GTA5.PC.GameFiles
{
	// Token: 0x020000EA RID: 234
	public class YmtPedDefinitionFile : GameFileBase_Resource<MetaFile>
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x00017079 File Offset: 0x00015279
		public YmtPedDefinitionFile()
		{
			this.Unk_376833625 = new MUnk_376833625();
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00017098 File Offset: 0x00015298
		public override void Parse(object[] parameters = null)
		{
			DataBlock[] array = this.ResourceFile.ResourceData.FindBlocks(MetaName.CPedVariationInfo);
			if (array.Length == 0)
			{
				throw new Exception("Unk_376833625 block not found !");
			}
			Unk_376833625 metaStructure = MetaUtils.ConvertData<Unk_376833625>(array[0], 0);
			this.Unk_376833625 = new MUnk_376833625();
			this.Unk_376833625.Parse(this.ResourceFile.ResourceData, metaStructure);
			this.metaYmtName = (string)this.ResourceFile.ResourceData.Name;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00017110 File Offset: 0x00015310
		public override void Build(object[] parameters = null)
		{
			MetaBuilder metaBuilder = new MetaBuilder();
			metaBuilder.EnsureBlock(MetaName.CPedVariationInfo);
			this.Unk_376833625.Build(metaBuilder, true);
			this.Unk_376833625.Meta.Name = (string_r)this.metaYmtName;
			this.ResourceFile.Version = ResourceFileTypes_GTA5_pc.Meta.Version;
			this.ResourceFile.ResourceData = this.Unk_376833625.Meta;
		}

		// Token: 0x04002EBA RID: 11962
		public MUnk_376833625 Unk_376833625;

		// Token: 0x04002EBB RID: 11963
		public string metaYmtName = "";
	}
}
