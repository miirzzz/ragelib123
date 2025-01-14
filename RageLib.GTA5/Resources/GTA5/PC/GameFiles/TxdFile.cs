using System;
using RageLib.GTA5.Resources.PC;
using RageLib.Resources.GTA5.PC.Textures;

namespace RageLib.Resources.GTA5.PC.GameFiles
{
	// Token: 0x020000E8 RID: 232
	public class TxdFile : GameFileBase_Resource<TextureDictionary>
	{
		// Token: 0x060003BB RID: 955 RVA: 0x00016FFB File Offset: 0x000151FB
		public override void Parse(object[] parameters = null)
		{
			this.TextureDictionary = this.ResourceFile.ResourceData;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0001700E File Offset: 0x0001520E
		public override void Build(object[] parameters = null)
		{
			this.ResourceFile.Version = ResourceFileTypes_GTA5_pc.TextureDictionary.Version;
			this.ResourceFile.ResourceData = this.TextureDictionary;
		}

		// Token: 0x04002EB8 RID: 11960
		public TextureDictionary TextureDictionary;
	}
}
