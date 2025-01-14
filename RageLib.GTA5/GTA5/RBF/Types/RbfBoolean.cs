using System;

namespace RageLib.GTA5.RBF.Types
{
	// Token: 0x020001FE RID: 510
	public class RbfBoolean : IRbfType
	{
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0003B109 File Offset: 0x00039309
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x0003B111 File Offset: 0x00039311
		public string Name { get; set; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0003B11A File Offset: 0x0003931A
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x0003B122 File Offset: 0x00039322
		public bool Value { get; set; }
	}
}
