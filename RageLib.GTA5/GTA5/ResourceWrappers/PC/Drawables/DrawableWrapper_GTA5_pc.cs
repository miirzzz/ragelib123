using System;
using RageLib.Resources.GTA5.PC.Drawables;
using RageLib.ResourceWrappers.Drawables;

namespace RageLib.GTA5.ResourceWrappers.PC.Drawables
{
	// Token: 0x02000196 RID: 406
	public class DrawableWrapper_GTA5_pc : IDrawable
	{
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0002ABEC File Offset: 0x00028DEC
		public IShaderGroup ShaderGroup
		{
			get
			{
				if (this.drawable.ShaderGroup != null)
				{
					return new ShaderGroupWrapper_GTA5_pc(this.drawable.ShaderGroup);
				}
				return null;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x0002AC0D File Offset: 0x00028E0D
		public string Name
		{
			get
			{
				return (string)this.drawable.Name;
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0002AC1F File Offset: 0x00028E1F
		public DrawableWrapper_GTA5_pc(GtaDrawable drawable)
		{
			this.drawable = drawable;
		}

		// Token: 0x040036E7 RID: 14055
		private GtaDrawable drawable;
	}
}
