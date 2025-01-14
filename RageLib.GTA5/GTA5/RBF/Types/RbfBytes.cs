using System;

namespace RageLib.GTA5.RBF.Types
{
	// Token: 0x020001FC RID: 508
	public class RbfBytes : IRbfType
	{
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0003B0C5 File Offset: 0x000392C5
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0003B0CD File Offset: 0x000392CD
		public string Name { get; set; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0003B0D6 File Offset: 0x000392D6
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x0003B0DE File Offset: 0x000392DE
		public byte[] Value { get; set; }
	}
}
