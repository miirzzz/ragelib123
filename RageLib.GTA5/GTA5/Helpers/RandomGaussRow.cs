using System;

namespace RageLib.GTA5.Helpers
{
	// Token: 0x0200029F RID: 671
	public class RandomGaussRow
	{
		// Token: 0x06000BC0 RID: 3008 RVA: 0x00084780 File Offset: 0x00082980
		public bool GetA(int idx)
		{
			int num = idx / 64;
			int num2 = idx % 64;
			return (this.A[num] >> num2 & 1UL) > 0UL;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x000847AC File Offset: 0x000829AC
		public void SetA(int idx)
		{
			int num = idx / 64;
			int num2 = idx % 64;
			this.A[num] |= 1UL << (num2 & 31);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x000847DA File Offset: 0x000829DA
		public bool GetB()
		{
			return this.B;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000847E2 File Offset: 0x000829E2
		public void SetB()
		{
			this.B = true;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000847EC File Offset: 0x000829EC
		public static RandomGaussRow operator ^(RandomGaussRow r1, RandomGaussRow r2)
		{
			RandomGaussRow randomGaussRow = new RandomGaussRow();
			for (int i = 0; i < 16; i++)
			{
				randomGaussRow.A[i] = (r1.A[i] ^ r2.A[i]);
			}
			randomGaussRow.B = (r1.B ^ r2.B);
			return randomGaussRow;
		}

		// Token: 0x04003FF5 RID: 16373
		private ulong[] A = new ulong[16];

		// Token: 0x04003FF6 RID: 16374
		public bool B;
	}
}
