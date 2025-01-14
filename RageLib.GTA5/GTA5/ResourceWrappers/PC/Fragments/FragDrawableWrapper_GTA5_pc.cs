using System;
using RageLib.GTA5.ResourceWrappers.PC.Drawables;
using RageLib.Resources.GTA5.PC.Fragments;
using RageLib.ResourceWrappers.Drawables;
using RageLib.ResourceWrappers.Fragments;

namespace RageLib.GTA5.ResourceWrappers.PC.Fragments
{
	// Token: 0x0200018F RID: 399
	public class FragDrawableWrapper_GTA5_pc : IFragDrawable, IDrawable
	{
		// Token: 0x06000653 RID: 1619 RVA: 0x0002A8AC File Offset: 0x00028AAC
		public FragDrawableWrapper_GTA5_pc(FragDrawable fragDrawable)
		{
			this.fragDrawable = fragDrawable;
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0002A8BB File Offset: 0x00028ABB
		public string Name
		{
			get
			{
				return (string)this.fragDrawable.Name;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0002A8CD File Offset: 0x00028ACD
		public IShaderGroup ShaderGroup
		{
			get
			{
				if (this.fragDrawable.ShaderGroup != null)
				{
					return new ShaderGroupWrapper_GTA5_pc(this.fragDrawable.ShaderGroup);
				}
				return null;
			}
		}

		// Token: 0x040036E0 RID: 14048
		private FragDrawable fragDrawable;
	}
}
