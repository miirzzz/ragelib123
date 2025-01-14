using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000268 RID: 616
	public struct CPackFileMetaData : IPsoSwapEnd
	{
		// Token: 0x06000A1B RID: 2587 RVA: 0x00081568 File Offset: 0x0007F768
		public void SwapEnd()
		{
			this.MapDataGroups.SwapEnd();
			this.HDTxdBindingArray.SwapEnd();
			this.imapDependencies.SwapEnd();
			this.imapDependencies_2.SwapEnd();
			this.itypDependencies_2.SwapEnd();
			this.Interiors.SwapEnd();
		}

		// Token: 0x04003F65 RID: 16229
		public Array_Structure MapDataGroups;

		// Token: 0x04003F66 RID: 16230
		public Array_Structure HDTxdBindingArray;

		// Token: 0x04003F67 RID: 16231
		public Array_Structure imapDependencies;

		// Token: 0x04003F68 RID: 16232
		public Array_Structure imapDependencies_2;

		// Token: 0x04003F69 RID: 16233
		public Array_Structure itypDependencies_2;

		// Token: 0x04003F6A RID: 16234
		public Array_Structure Interiors;
	}
}
