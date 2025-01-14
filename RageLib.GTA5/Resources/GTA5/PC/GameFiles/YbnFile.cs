using System;
using RageLib.GTA5.Resources.PC;
using RageLib.Resources.GTA5.PC.Bounds;

namespace RageLib.Resources.GTA5.PC.GameFiles
{
	// Token: 0x020000E6 RID: 230
	public class YbnFile : GameFileBase_Resource<Bound>
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x00016F75 File Offset: 0x00015175
		public override void Parse(object[] parameters = null)
		{
			this.Bound = this.ResourceFile.ResourceData;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00016F88 File Offset: 0x00015188
		public override void Build(object[] parameters = null)
		{
			this.ResourceFile.Version = ResourceFileTypes_GTA5_pc.Bound.Version;
			this.ResourceFile.ResourceData = this.Bound;
		}

		// Token: 0x04002EB6 RID: 11958
		public Bound Bound;
	}
}
