using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200026D RID: 621
	public struct CItypDependencies : IPsoSwapEnd
	{
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x000819E4 File Offset: 0x0007FBE4
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x000819EC File Offset: 0x0007FBEC
		public MetaName itypName { get; set; }

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x000819F5 File Offset: 0x0007FBF5
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x000819FD File Offset: 0x0007FBFD
		public ushort manifestFlags { get; set; }

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x00081A06 File Offset: 0x0007FC06
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00081A0E File Offset: 0x0007FC0E
		public ushort Unused0 { get; set; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00081A17 File Offset: 0x0007FC17
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00081A1F File Offset: 0x0007FC1F
		public Array_uint itypDepArray { get; set; }

		// Token: 0x06000A56 RID: 2646 RVA: 0x00081A28 File Offset: 0x0007FC28
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.itypName.ToString(),
				": ",
				this.manifestFlags.ToString(),
				": ",
				this.itypDepArray.ToString()
			});
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00081A90 File Offset: 0x0007FC90
		public void SwapEnd()
		{
			this.itypName = (MetaName)MetaUtils.SwapBytes((uint)this.itypName);
			this.manifestFlags = MetaUtils.SwapBytes(this.manifestFlags);
			Array_uint itypDepArray = this.itypDepArray;
			itypDepArray.SwapEnd();
			this.itypDepArray = itypDepArray;
		}
	}
}
