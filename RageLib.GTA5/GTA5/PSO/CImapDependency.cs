using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200026B RID: 619
	public struct CImapDependency : IPsoSwapEnd
	{
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0008181B File Offset: 0x0007FA1B
		// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00081823 File Offset: 0x0007FA23
		public MetaName imapName { get; set; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0008182C File Offset: 0x0007FA2C
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00081834 File Offset: 0x0007FA34
		public MetaName itypName { get; set; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0008183D File Offset: 0x0007FA3D
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00081845 File Offset: 0x0007FA45
		public MetaName packFileName { get; set; }

		// Token: 0x06000A42 RID: 2626 RVA: 0x00081850 File Offset: 0x0007FA50
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.imapName.ToString(),
				", ",
				this.itypName.ToString(),
				", ",
				this.packFileName.ToString()
			});
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000818BD File Offset: 0x0007FABD
		public void SwapEnd()
		{
			this.imapName = (MetaName)MetaUtils.SwapBytes((uint)this.imapName);
			this.itypName = (MetaName)MetaUtils.SwapBytes((uint)this.itypName);
			this.packFileName = (MetaName)MetaUtils.SwapBytes((uint)this.packFileName);
		}
	}
}
