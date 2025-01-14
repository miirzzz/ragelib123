using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000271 RID: 625
	public struct CScenarioPointGroup : IPsoSwapEnd
	{
		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00081D3B File Offset: 0x0007FF3B
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x00081D43 File Offset: 0x0007FF43
		public MetaName Name { get; set; }

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x00081D4C File Offset: 0x0007FF4C
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x00081D54 File Offset: 0x0007FF54
		public byte EnabledByDefault { get; set; }

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x00081D5D File Offset: 0x0007FF5D
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x00081D65 File Offset: 0x0007FF65
		public byte Unused0 { get; set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x00081D6E File Offset: 0x0007FF6E
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x00081D76 File Offset: 0x0007FF76
		public ushort Unused1 { get; set; }

		// Token: 0x06000A88 RID: 2696 RVA: 0x00081D80 File Offset: 0x0007FF80
		public override string ToString()
		{
			return this.Name.ToString();
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00081DA1 File Offset: 0x0007FFA1
		public void SwapEnd()
		{
			this.Name = (MetaName)MetaUtils.SwapBytes((uint)this.Name);
		}
	}
}
