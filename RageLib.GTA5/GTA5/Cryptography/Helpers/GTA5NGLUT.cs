using System;

namespace RageLib.GTA5.Cryptography.Helpers
{
	// Token: 0x020002A6 RID: 678
	public class GTA5NGLUT
	{
		// Token: 0x06000BED RID: 3053 RVA: 0x00088408 File Offset: 0x00086608
		public GTA5NGLUT()
		{
			this.LUT0 = new byte[256][];
			for (int i = 0; i < 256; i++)
			{
				this.LUT0[i] = new byte[256];
			}
			this.LUT1 = new byte[256][];
			for (int j = 0; j < 256; j++)
			{
				this.LUT1[j] = new byte[256];
			}
			this.Indices = new byte[65536];
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00088490 File Offset: 0x00086690
		public byte LookUp(uint value)
		{
			uint num = (value & 4294901760U) >> 16;
			uint num2 = (value & 65280U) >> 8;
			uint num3 = value & 255U;
			return this.LUT0[(int)this.LUT1[(int)this.Indices[(int)num]][(int)num2]][(int)num3];
		}

		// Token: 0x04004003 RID: 16387
		public byte[][] LUT0;

		// Token: 0x04004004 RID: 16388
		public byte[][] LUT1;

		// Token: 0x04004005 RID: 16389
		public byte[] Indices;
	}
}
