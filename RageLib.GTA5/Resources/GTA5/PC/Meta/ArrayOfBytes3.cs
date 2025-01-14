using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x0200006D RID: 109
	public struct ArrayOfBytes3
	{
		// Token: 0x06000225 RID: 549 RVA: 0x0000DB0C File Offset: 0x0000BD0C
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.b0.ToString(),
				", ",
				this.b1.ToString(),
				", ",
				this.b2.ToString()
			});
		}

		// Token: 0x04000553 RID: 1363
		public byte b0;

		// Token: 0x04000554 RID: 1364
		public byte b1;

		// Token: 0x04000555 RID: 1365
		public byte b2;
	}
}
