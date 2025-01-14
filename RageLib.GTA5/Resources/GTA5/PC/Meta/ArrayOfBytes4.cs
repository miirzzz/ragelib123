using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000069 RID: 105
	public struct ArrayOfBytes4
	{
		// Token: 0x06000223 RID: 547 RVA: 0x0000D7EC File Offset: 0x0000B9EC
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.b0.ToString(),
				", ",
				this.b1.ToString(),
				", ",
				this.b2.ToString(),
				", ",
				this.b3.ToString()
			});
		}

		// Token: 0x04000504 RID: 1284
		public byte b0;

		// Token: 0x04000505 RID: 1285
		public byte b1;

		// Token: 0x04000506 RID: 1286
		public byte b2;

		// Token: 0x04000507 RID: 1287
		public byte b3;
	}
}
