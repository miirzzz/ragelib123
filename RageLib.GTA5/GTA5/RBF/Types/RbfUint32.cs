using System;

namespace RageLib.GTA5.RBF.Types
{
	// Token: 0x020001FD RID: 509
	public class RbfUint32 : IRbfType
	{
		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0003B0E7 File Offset: 0x000392E7
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x0003B0EF File Offset: 0x000392EF
		public string Name { get; set; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0003B0F8 File Offset: 0x000392F8
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x0003B100 File Offset: 0x00039300
		public uint Value { get; set; }
	}
}
