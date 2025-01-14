using System;
using RageLib.Resources.GTA5.PC.Fragments;
using RageLib.ResourceWrappers.Fragments;

namespace RageLib.GTA5.ResourceWrappers.PC.Fragments
{
	// Token: 0x02000191 RID: 401
	public class FragTypeWrapper_GTA5_pc : IFragType
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0002A9DE File Offset: 0x00028BDE
		public IFragDrawable Drawable1
		{
			get
			{
				if (this.fragType.Drawable != null)
				{
					return new FragDrawableWrapper_GTA5_pc(this.fragType.Drawable);
				}
				return null;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0002A9FF File Offset: 0x00028BFF
		public IFragDrawable Drawable2
		{
			get
			{
				if (this.fragType.Unknown_F8h_Data != null)
				{
					return new FragDrawableWrapper_GTA5_pc(this.fragType.Unknown_F8h_Data);
				}
				return null;
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0002AA20 File Offset: 0x00028C20
		public FragTypeWrapper_GTA5_pc(FragType fragType)
		{
			this.fragType = fragType;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00016F58 File Offset: 0x00015158
		public void UpdateClass()
		{
		}

		// Token: 0x040036E2 RID: 14050
		private FragType fragType;
	}
}
