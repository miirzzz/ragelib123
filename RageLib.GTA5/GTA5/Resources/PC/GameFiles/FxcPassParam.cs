using System;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001F4 RID: 500
	public class FxcPassParam
	{
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x0003AA9D File Offset: 0x00038C9D
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x0003AAA5 File Offset: 0x00038CA5
		public uint u0 { get; set; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x0003AAAE File Offset: 0x00038CAE
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x0003AAB6 File Offset: 0x00038CB6
		public uint u1 { get; set; }

		// Token: 0x0600090D RID: 2317 RVA: 0x0003AAC0 File Offset: 0x00038CC0
		public override string ToString()
		{
			return this.u0.ToString() + ", " + this.u1.ToString();
		}
	}
}
