using System;
using RageLib.GTA5.Resources.PC;
using RageLib.GTA5.ResourceWrappers.PC.Meta.Structures;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.Resources.GTA5.PC.GameFiles
{
	// Token: 0x020000EC RID: 236
	public class YmapFile : GameFileBase_Resource<MetaFile>
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x0001724B File Offset: 0x0001544B
		public YmapFile()
		{
			this.CMapData = new MCMapData(null);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00017260 File Offset: 0x00015460
		public override void Parse(object[] parameters = null)
		{
			bool flag = false;
			if (parameters != null && parameters.Length != 0)
			{
				flag = (bool)parameters[0];
			}
			DataBlock[] array = this.ResourceFile.ResourceData.FindBlocks(MetaName.CMapData);
			if (array.Length == 0)
			{
				throw new Exception("CMapData block not found !");
			}
			CMapData cmapData = MetaUtils.ConvertData<CMapData>(array[0], 0);
			this.CMapData = new MCMapData(null);
			if (flag)
			{
				this.CMapData.ParseFast(this.ResourceFile.ResourceData, cmapData);
			}
			else
			{
				this.CMapData.Parse(this.ResourceFile.ResourceData, cmapData);
			}
			for (int i = 0; i < this.CMapData.Entities.Count; i++)
			{
				this.CMapData.Entities[i].ParentIndex = this.CMapData.Entities[i].ParentIndex;
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00017334 File Offset: 0x00015534
		public override void Build(object[] parameters = null)
		{
			for (int i = 0; i < this.CMapData.Entities.Count; i++)
			{
				this.CMapData.Entities[i].ParentEntity = this.CMapData.Entities[i].ParentEntity;
			}
			MetaBuilder metaBuilder = new MetaBuilder();
			metaBuilder.EnsureBlock(MetaName.CMapData);
			this.CMapData.Build(metaBuilder, true);
			this.ResourceFile.Version = ResourceFileTypes_GTA5_pc.Maps.Version;
			this.ResourceFile.ResourceData = this.CMapData.Meta;
		}

		// Token: 0x04002EBD RID: 11965
		public MCMapData CMapData;
	}
}
