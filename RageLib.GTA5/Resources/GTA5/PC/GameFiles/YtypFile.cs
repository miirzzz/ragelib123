using System;
using RageLib.GTA5.Resources.PC;
using RageLib.GTA5.ResourceWrappers.PC.Meta.Structures;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.Resources.GTA5.PC.GameFiles
{
	// Token: 0x020000EB RID: 235
	public class YtypFile : GameFileBase_Resource<MetaFile>
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x00017182 File Offset: 0x00015382
		public YtypFile()
		{
			this.CMapTypes = new MCMapTypes();
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00017198 File Offset: 0x00015398
		public override void Parse(object[] parameters = null)
		{
			DataBlock[] array = this.ResourceFile.ResourceData.FindBlocks(MetaName.CMapTypes);
			if (array.Length == 0)
			{
				throw new Exception("CMapTypes block not found !");
			}
			CMapTypes metaStructure = MetaUtils.ConvertData<CMapTypes>(array[0], 0);
			this.CMapTypes = new MCMapTypes();
			this.CMapTypes.Parse(this.ResourceFile.ResourceData, metaStructure);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000171F4 File Offset: 0x000153F4
		public override void Build(object[] parameters = null)
		{
			MetaBuilder metaBuilder = new MetaBuilder();
			metaBuilder.EnsureBlock(MetaName.CMapTypes);
			this.CMapTypes.Build(metaBuilder, true);
			this.ResourceFile.Version = ResourceFileTypes_GTA5_pc.Types.Version;
			this.ResourceFile.ResourceData = this.CMapTypes.Meta;
		}

		// Token: 0x04002EBC RID: 11964
		public MCMapTypes CMapTypes;
	}
}
