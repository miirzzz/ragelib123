using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x0200006E RID: 110
	public struct ArrayOfUshorts3
	{
		// Token: 0x06000226 RID: 550 RVA: 0x0000DB60 File Offset: 0x0000BD60
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.u0.ToString(),
				", ",
				this.u1.ToString(),
				", ",
				this.u2.ToString()
			});
		}

		// Token: 0x04000556 RID: 1366
		public ushort u0;

		// Token: 0x04000557 RID: 1367
		public ushort u1;

		// Token: 0x04000558 RID: 1368
		public ushort u2;
	}
}
