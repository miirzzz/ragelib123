using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200026E RID: 622
	public struct Unk_741495440 : IPsoSwapEnd
	{
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00081AD4 File Offset: 0x0007FCD4
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x00081ADC File Offset: 0x0007FCDC
		public MetaName Name { get; set; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00081AE5 File Offset: 0x0007FCE5
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00081AED File Offset: 0x0007FCED
		public uint Unused0 { get; set; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00081AF6 File Offset: 0x0007FCF6
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00081AFE File Offset: 0x0007FCFE
		public Array_uint Bounds { get; set; }

		// Token: 0x06000A5E RID: 2654 RVA: 0x00081B08 File Offset: 0x0007FD08
		public override string ToString()
		{
			return this.Name.ToString();
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00081B2C File Offset: 0x0007FD2C
		public void SwapEnd()
		{
			this.Name = (MetaName)MetaUtils.SwapBytes((uint)this.Name);
			Array_uint bounds = this.Bounds;
			bounds.SwapEnd();
			this.Bounds = bounds;
		}
	}
}
