using System;
using RageLib.GTA5.Resources.PC;
using RageLib.Resources.GTA5.PC.Drawables;

namespace RageLib.Resources.GTA5.PC.GameFiles
{
	// Token: 0x020000E9 RID: 233
	public class YdrFile : GameFileBase_Resource<GtaDrawable>
	{
		// Token: 0x060003BE RID: 958 RVA: 0x0001703E File Offset: 0x0001523E
		public override void Parse(object[] parameters = null)
		{
			this.Drawable = this.ResourceFile.ResourceData;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00017051 File Offset: 0x00015251
		public override void Build(object[] parameters = null)
		{
			this.ResourceFile.Version = ResourceFileTypes_GTA5_pc.Drawable.Version;
			this.ResourceFile.ResourceData = this.Drawable;
		}

		// Token: 0x04002EB9 RID: 11961
		public GtaDrawable Drawable;
	}
}
