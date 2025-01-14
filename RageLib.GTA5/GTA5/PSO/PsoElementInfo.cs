using System;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200020C RID: 524
	public abstract class PsoElementInfo
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0003CD9B File Offset: 0x0003AF9B
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x0003CDA3 File Offset: 0x0003AFA3
		public PsoElementIndexInfo IndexInfo { get; set; }

		// Token: 0x060009A2 RID: 2466
		public abstract void Read(DataReader reader);

		// Token: 0x060009A3 RID: 2467
		public abstract void Write(DataWriter writer);
	}
}
