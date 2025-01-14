using System;
using RageLib.GTA5.Resources.PC;
using RageLib.Resources.GTA5.PC.Drawables;

namespace RageLib.Resources.GTA5.PC.GameFiles
{
	// Token: 0x020000E7 RID: 231
	public class YddFile : GameFileBase_Resource<GtaDrawableDictionary>
	{
		// Token: 0x060003B8 RID: 952 RVA: 0x00016FB8 File Offset: 0x000151B8
		public override void Parse(object[] parameters = null)
		{
			this.DrawableDictionary = this.ResourceFile.ResourceData;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00016FCB File Offset: 0x000151CB
		public override void Build(object[] parameters = null)
		{
			this.ResourceFile.Version = ResourceFileTypes_GTA5_pc.DrawableDictionary.Version;
			this.ResourceFile.ResourceData = this.DrawableDictionary;
		}

		// Token: 0x04002EB7 RID: 11959
		public GtaDrawableDictionary DrawableDictionary;
	}
}
