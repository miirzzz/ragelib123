using System;

namespace RageLib.GTA5.Cryptography
{
	// Token: 0x020002A3 RID: 675
	public class GTA5Hash
	{
		// Token: 0x06000BDF RID: 3039 RVA: 0x00087CF0 File Offset: 0x00085EF0
		public static uint CalculateHash(string text)
		{
			uint num = 0U;
			for (int i = 0; i < text.Length; i++)
			{
				uint num2 = 1025U * ((uint)GTA5Hash.LUT[(int)text[i]] + num);
				num = (num2 >> 6 ^ num2);
			}
			return 32769U * (9U * num >> 11 ^ 9U * num);
		}

		// Token: 0x04004002 RID: 16386
		public static byte[] LUT = GTA5Constants.PC_LUT;
	}
}
