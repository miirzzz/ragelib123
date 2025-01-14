using System;
using System.Threading.Tasks;
using RageLib.GTA5.Cryptography.Helpers;

namespace RageLib.GTA5.Cryptography
{
	// Token: 0x020002A4 RID: 676
	public class LookUpTableGenerator
	{
		// Token: 0x06000BE1 RID: 3041 RVA: 0x00087D40 File Offset: 0x00085F40
		public static GTA5NGLUT[] BuildLUTs2(uint[][] tables)
		{
			byte[][] temp = new byte[16][];
			for (int i = 0; i < 16; i++)
			{
				temp[i] = new byte[65536];
			}
			GTA5NGLUT[] array = new GTA5NGLUT[16];
			for (int j = 0; j < 16; j++)
			{
				array[j] = new GTA5NGLUT();
			}
			byte[][] tempLUTS = new byte[16][];
			for (int k = 0; k < 16; k++)
			{
				tempLUTS[k] = new byte[6553600];
			}
			uint[] t0 = tables[0];
			uint[] t1 = tables[1];
			uint[] t2 = tables[2];
			uint[] t3 = tables[3];
			uint[] t4 = tables[4];
			uint[] t5 = tables[5];
			uint[] t6 = tables[6];
			uint[] t7 = tables[7];
			uint[] t8 = tables[8];
			uint[] t9 = tables[9];
			uint[] t10 = tables[10];
			uint[] t11 = tables[11];
			uint[] t12 = tables[12];
			uint[] t13 = tables[13];
			uint[] t14 = tables[14];
			uint[] t15 = tables[15];
			Parallel.For(0L, 256L, delegate(long k1)
			{
				for (long num5 = 0L; num5 < 6553600L; num5 += 1L)
				{
					long num6 = k1 * 6553600L + num5;
					byte b = (byte)(num6 & 255L);
					byte b2 = (byte)(num6 >> 8 & 255L);
					byte b3 = (byte)(num6 >> 16 & 255L);
					byte b4 = (byte)(num6 >> 24 & 255L);
					uint num7 = t0[(int)b] ^ t7[(int)b2] ^ t10[(int)b3] ^ t13[(int)b4];
					uint num8 = t1[(int)b] ^ t4[(int)b2] ^ t11[(int)b3] ^ t14[(int)b4];
					uint num9 = t2[(int)b] ^ t5[(int)b2] ^ t8[(int)b3] ^ t15[(int)b4];
					uint num10 = t3[(int)b] ^ t6[(int)b2] ^ t9[(int)b3] ^ t12[(int)b4];
					if (num7 < 65536U)
					{
						temp[0][(int)num7] = b;
						temp[7][(int)num7] = b2;
						temp[10][(int)num7] = b3;
						temp[13][(int)num7] = b4;
					}
					if (num8 < 65536U)
					{
						temp[1][(int)num8] = b;
						temp[4][(int)num8] = b2;
						temp[11][(int)num8] = b3;
						temp[14][(int)num8] = b4;
					}
					if (num9 < 65536U)
					{
						temp[2][(int)num9] = b;
						temp[5][(int)num9] = b2;
						temp[8][(int)num9] = b3;
						temp[15][(int)num9] = b4;
					}
					if (num10 < 65536U)
					{
						temp[3][(int)num10] = b;
						temp[6][(int)num10] = b2;
						temp[9][(int)num10] = b3;
						temp[12][(int)num10] = b4;
					}
					if ((num7 & 255U) == 0U)
					{
						tempLUTS[0][(int)(num7 >> 8)] = b;
						tempLUTS[7][(int)(num7 >> 8)] = b2;
						tempLUTS[10][(int)(num7 >> 8)] = b3;
						tempLUTS[13][(int)(num7 >> 8)] = b4;
					}
					if ((num8 & 255U) == 0U)
					{
						tempLUTS[1][(int)(num8 >> 8)] = b;
						tempLUTS[4][(int)(num8 >> 8)] = b2;
						tempLUTS[11][(int)(num8 >> 8)] = b3;
						tempLUTS[14][(int)(num8 >> 8)] = b4;
					}
					if ((num9 & 255U) == 0U)
					{
						tempLUTS[2][(int)(num9 >> 8)] = b;
						tempLUTS[5][(int)(num9 >> 8)] = b2;
						tempLUTS[8][(int)(num9 >> 8)] = b3;
						tempLUTS[15][(int)(num9 >> 8)] = b4;
					}
					if ((num10 & 255U) == 0U)
					{
						tempLUTS[3][(int)(num10 >> 8)] = b;
						tempLUTS[6][(int)(num10 >> 8)] = b2;
						tempLUTS[9][(int)(num10 >> 8)] = b3;
						tempLUTS[12][(int)(num10 >> 8)] = b4;
					}
				}
			});
			for (int l = 0; l < 16; l++)
			{
				array[l].LUT0 = new byte[256][];
				for (int m = 0; m < 256; m++)
				{
					byte[] array2 = new byte[256];
					for (int n = 0; n < 256; n++)
					{
						array2[n] = temp[l][256 * m + n];
					}
					array[l].LUT0[(int)array2[0]] = array2;
				}
			}
			for (int num = 0; num < 16; num++)
			{
				GTA5NGLUT gta5NGLUT = array[num];
				gta5NGLUT.LUT1 = new byte[256][];
				gta5NGLUT.Indices = new byte[65536];
				for (int num2 = 0; num2 < 256; num2++)
				{
					byte[] array3 = new byte[256];
					for (int num3 = 0; num3 < 256; num3++)
					{
						array3[num3] = tempLUTS[num][256 * num2 + num3];
					}
					gta5NGLUT.LUT1[(int)array3[0]] = array3;
				}
				for (int num4 = 0; num4 < 65536; num4++)
				{
					gta5NGLUT.Indices[num4] = tempLUTS[num][256 * num4];
				}
			}
			return array;
		}
	}
}
