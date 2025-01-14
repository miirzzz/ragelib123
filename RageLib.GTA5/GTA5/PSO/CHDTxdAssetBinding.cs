using System;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200026A RID: 618
	public struct CHDTxdAssetBinding : IPsoSwapEnd
	{
		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0008175E File Offset: 0x0007F95E
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00081766 File Offset: 0x0007F966
		public byte assetType { get; set; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0008176F File Offset: 0x0007F96F
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00081777 File Offset: 0x0007F977
		public byte Unused01 { get; set; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00081780 File Offset: 0x0007F980
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00081788 File Offset: 0x0007F988
		public ushort Unused02 { get; set; }

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00081791 File Offset: 0x0007F991
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00081799 File Offset: 0x0007F999
		public PsoChar64 targetAsset { get; set; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x000817A2 File Offset: 0x0007F9A2
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x000817AA File Offset: 0x0007F9AA
		public PsoChar64 HDTxd { get; set; }

		// Token: 0x06000A3A RID: 2618 RVA: 0x000817B4 File Offset: 0x0007F9B4
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.assetType.ToString(),
				": ",
				this.targetAsset.ToString(),
				": ",
				this.HDTxd.ToString()
			});
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00016F58 File Offset: 0x00015158
		public void SwapEnd()
		{
		}
	}
}
