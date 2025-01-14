using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200026C RID: 620
	public struct CImapDependencies : IPsoSwapEnd
	{
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x000818F2 File Offset: 0x0007FAF2
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x000818FA File Offset: 0x0007FAFA
		public MetaName imapName { get; set; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00081903 File Offset: 0x0007FB03
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x0008190B File Offset: 0x0007FB0B
		public ushort manifestFlags { get; set; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00081914 File Offset: 0x0007FB14
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x0008191C File Offset: 0x0007FB1C
		public ushort Unused0 { get; set; }

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00081925 File Offset: 0x0007FB25
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x0008192D File Offset: 0x0007FB2D
		public Array_uint itypDepArray { get; set; }

		// Token: 0x06000A4C RID: 2636 RVA: 0x00081938 File Offset: 0x0007FB38
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.imapName.ToString(),
				": ",
				this.manifestFlags.ToString(),
				": ",
				this.itypDepArray.ToString()
			});
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000819A0 File Offset: 0x0007FBA0
		public void SwapEnd()
		{
			this.imapName = (MetaName)MetaUtils.SwapBytes((uint)this.imapName);
			this.manifestFlags = MetaUtils.SwapBytes(this.manifestFlags);
			Array_uint itypDepArray = this.itypDepArray;
			itypDepArray.SwapEnd();
			this.itypDepArray = itypDepArray;
		}
	}
}
