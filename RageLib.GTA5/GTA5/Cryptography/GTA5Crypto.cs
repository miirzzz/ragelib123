using System;
using System.Security.Cryptography;
using RageLib.Cryptography;
using RageLib.GTA5.Cryptography.Helpers;

namespace RageLib.GTA5.Cryptography
{
	// Token: 0x020002A2 RID: 674
	public class GTA5Crypto : IEncryptionAlgorithm
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00086E4F File Offset: 0x0008504F
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x00086E57 File Offset: 0x00085057
		public byte[] Key { get; set; }

		// Token: 0x06000BCC RID: 3020 RVA: 0x00086E60 File Offset: 0x00085060
		public byte[] Decrypt(byte[] data)
		{
			return GTA5Crypto.Decrypt(data, this.Key);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00086E70 File Offset: 0x00085070
		public static byte[] Decrypt(byte[] data, byte[] key)
		{
			byte[] array = new byte[data.Length];
			uint[] array2 = new uint[key.Length / 4];
			Buffer.BlockCopy(key, 0, array2, 0, key.Length);
			for (int i = 0; i < data.Length / 16; i++)
			{
				byte[] array3 = new byte[16];
				Array.Copy(data, 16 * i, array3, 0, 16);
				Array.Copy(GTA5Crypto.DecryptBlock(array3, array2), 0, array, 16 * i, 16);
			}
			if (data.Length % 16 != 0)
			{
				int num = data.Length % 16;
				Buffer.BlockCopy(data, data.Length - num, array, data.Length - num, num);
			}
			return array;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00086F00 File Offset: 0x00085100
		public static byte[] DecryptBlock(byte[] data, uint[] key)
		{
			uint[][] array = new uint[17][];
			for (int i = 0; i < 17; i++)
			{
				array[i] = new uint[4];
				array[i][0] = key[4 * i];
				array[i][1] = key[4 * i + 1];
				array[i][2] = key[4 * i + 2];
				array[i][3] = key[4 * i + 3];
			}
			byte[] data2 = GTA5Crypto.DecryptRoundA(data, array[0], GTA5Constants.PC_NG_DECRYPT_TABLES[0]);
			data2 = GTA5Crypto.DecryptRoundA(data2, array[1], GTA5Constants.PC_NG_DECRYPT_TABLES[1]);
			for (int j = 2; j <= 15; j++)
			{
				data2 = GTA5Crypto.DecryptRoundB(data2, array[j], GTA5Constants.PC_NG_DECRYPT_TABLES[j]);
			}
			return GTA5Crypto.DecryptRoundA(data2, array[16], GTA5Constants.PC_NG_DECRYPT_TABLES[16]);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00086FAC File Offset: 0x000851AC
		public static byte[] DecryptRoundA(byte[] data, uint[] key, uint[][] table)
		{
			uint value = table[0][(int)data[0]] ^ table[1][(int)data[1]] ^ table[2][(int)data[2]] ^ table[3][(int)data[3]] ^ key[0];
			uint value2 = table[4][(int)data[4]] ^ table[5][(int)data[5]] ^ table[6][(int)data[6]] ^ table[7][(int)data[7]] ^ key[1];
			uint value3 = table[8][(int)data[8]] ^ table[9][(int)data[9]] ^ table[10][(int)data[10]] ^ table[11][(int)data[11]] ^ key[2];
			uint value4 = table[12][(int)data[12]] ^ table[13][(int)data[13]] ^ table[14][(int)data[14]] ^ table[15][(int)data[15]] ^ key[3];
			byte[] array = new byte[16];
			Array.Copy(BitConverter.GetBytes(value), 0, array, 0, 4);
			Array.Copy(BitConverter.GetBytes(value2), 0, array, 4, 4);
			Array.Copy(BitConverter.GetBytes(value3), 0, array, 8, 4);
			Array.Copy(BitConverter.GetBytes(value4), 0, array, 12, 4);
			return array;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0008709C File Offset: 0x0008529C
		public static byte[] DecryptRoundB(byte[] data, uint[] key, uint[][] table)
		{
			uint num = table[0][(int)data[0]] ^ table[7][(int)data[7]] ^ table[10][(int)data[10]] ^ table[13][(int)data[13]] ^ key[0];
			uint num2 = table[1][(int)data[1]] ^ table[4][(int)data[4]] ^ table[11][(int)data[11]] ^ table[14][(int)data[14]] ^ key[1];
			uint num3 = table[2][(int)data[2]] ^ table[5][(int)data[5]] ^ table[8][(int)data[8]] ^ table[15][(int)data[15]] ^ key[2];
			uint num4 = table[3][(int)data[3]] ^ table[6][(int)data[6]] ^ table[9][(int)data[9]] ^ table[12][(int)data[12]] ^ key[3];
			return new byte[]
			{
				(byte)(num & 255U),
				(byte)(num >> 8 & 255U),
				(byte)(num >> 16 & 255U),
				(byte)(num >> 24 & 255U),
				(byte)(num2 & 255U),
				(byte)(num2 >> 8 & 255U),
				(byte)(num2 >> 16 & 255U),
				(byte)(num2 >> 24 & 255U),
				(byte)(num3 & 255U),
				(byte)(num3 >> 8 & 255U),
				(byte)(num3 >> 16 & 255U),
				(byte)(num3 >> 24 & 255U),
				(byte)(num4 & 255U),
				(byte)(num4 >> 8 & 255U),
				(byte)(num4 >> 16 & 255U),
				(byte)(num4 >> 24 & 255U)
			};
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00087225 File Offset: 0x00085425
		public byte[] Encrypt(byte[] data)
		{
			return GTA5Crypto.Encrypt(data, this.Key);
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00087234 File Offset: 0x00085434
		public static byte[] Encrypt(byte[] data, byte[] key)
		{
			byte[] array = new byte[data.Length];
			uint[] array2 = new uint[key.Length / 4];
			Buffer.BlockCopy(key, 0, array2, 0, key.Length);
			for (int i = 0; i < data.Length / 16; i++)
			{
				byte[] array3 = new byte[16];
				Array.Copy(data, 16 * i, array3, 0, 16);
				Array.Copy(GTA5Crypto.EncryptBlock(array3, array2), 0, array, 16 * i, 16);
			}
			if (data.Length % 16 != 0)
			{
				int num = data.Length % 16;
				Buffer.BlockCopy(data, data.Length - num, array, data.Length - num, num);
			}
			return array;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000872C4 File Offset: 0x000854C4
		public static byte[] EncryptBlock(byte[] data, uint[] key)
		{
			uint[][] array = new uint[17][];
			for (int i = 0; i < 17; i++)
			{
				array[i] = new uint[4];
				array[i][0] = key[4 * i];
				array[i][1] = key[4 * i + 1];
				array[i][2] = key[4 * i + 2];
				array[i][3] = key[4 * i + 3];
			}
			byte[] array2 = GTA5Crypto.EncryptRoundA(data, array[16], GTA5Constants.PC_NG_ENCRYPT_TABLES[16]);
			for (int j = 15; j >= 2; j--)
			{
				array2 = GTA5Crypto.EncryptRoundB_LUT(array2, array[j], GTA5Constants.PC_NG_ENCRYPT_LUTs[j]);
			}
			array2 = GTA5Crypto.EncryptRoundA(array2, array[1], GTA5Constants.PC_NG_ENCRYPT_TABLES[1]);
			return GTA5Crypto.EncryptRoundA(array2, array[0], GTA5Constants.PC_NG_ENCRYPT_TABLES[0]);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00087370 File Offset: 0x00085570
		public static byte[] EncryptRoundA(byte[] data, uint[] key, uint[][] table)
		{
			byte[] array = new byte[16];
			Buffer.BlockCopy(key, 0, array, 0, 16);
			uint value = table[0][(int)(data[0] ^ array[0])] ^ table[1][(int)(data[1] ^ array[1])] ^ table[2][(int)(data[2] ^ array[2])] ^ table[3][(int)(data[3] ^ array[3])];
			uint value2 = table[4][(int)(data[4] ^ array[4])] ^ table[5][(int)(data[5] ^ array[5])] ^ table[6][(int)(data[6] ^ array[6])] ^ table[7][(int)(data[7] ^ array[7])];
			uint value3 = table[8][(int)(data[8] ^ array[8])] ^ table[9][(int)(data[9] ^ array[9])] ^ table[10][(int)(data[10] ^ array[10])] ^ table[11][(int)(data[11] ^ array[11])];
			uint value4 = table[12][(int)(data[12] ^ array[12])] ^ table[13][(int)(data[13] ^ array[13])] ^ table[14][(int)(data[14] ^ array[14])] ^ table[15][(int)(data[15] ^ array[15])];
			byte[] array2 = new byte[16];
			Array.Copy(BitConverter.GetBytes(value), 0, array2, 0, 4);
			Array.Copy(BitConverter.GetBytes(value2), 0, array2, 4, 4);
			Array.Copy(BitConverter.GetBytes(value3), 0, array2, 8, 4);
			Array.Copy(BitConverter.GetBytes(value4), 0, array2, 12, 4);
			return array2;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000874B0 File Offset: 0x000856B0
		public static byte[] EncryptRoundA_LUT(byte[] dataOld, uint[] key, GTA5NGLUT[] lut)
		{
			byte[] array = (byte[])dataOld.Clone();
			byte[] array2 = new byte[16];
			Buffer.BlockCopy(key, 0, array2, 0, 16);
			for (int i = 0; i < 16; i++)
			{
				byte[] array3 = array;
				int num = i;
				int num2 = num;
				array3[num2] ^= array2[i];
			}
			return new byte[]
			{
				lut[0].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[0],
					array[1],
					array[2],
					array[3]
				}, 0)),
				lut[1].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[0],
					array[1],
					array[2],
					array[3]
				}, 0)),
				lut[2].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[0],
					array[1],
					array[2],
					array[3]
				}, 0)),
				lut[3].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[0],
					array[1],
					array[2],
					array[3]
				}, 0)),
				lut[4].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[4],
					array[5],
					array[6],
					array[7]
				}, 0)),
				lut[5].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[4],
					array[5],
					array[6],
					array[7]
				}, 0)),
				lut[6].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[4],
					array[5],
					array[6],
					array[7]
				}, 0)),
				lut[7].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[4],
					array[5],
					array[6],
					array[7]
				}, 0)),
				lut[8].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[8],
					array[9],
					array[10],
					array[11]
				}, 0)),
				lut[9].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[8],
					array[9],
					array[10],
					array[11]
				}, 0)),
				lut[10].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[8],
					array[9],
					array[10],
					array[11]
				}, 0)),
				lut[11].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[8],
					array[9],
					array[10],
					array[11]
				}, 0)),
				lut[12].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[12],
					array[13],
					array[14],
					array[15]
				}, 0)),
				lut[13].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[12],
					array[13],
					array[14],
					array[15]
				}, 0)),
				lut[14].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[12],
					array[13],
					array[14],
					array[15]
				}, 0)),
				lut[15].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[12],
					array[13],
					array[14],
					array[15]
				}, 0))
			};
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0008781C File Offset: 0x00085A1C
		public static byte[] EncryptRoundB_LUT(byte[] dataOld, uint[] key, GTA5NGLUT[] lut)
		{
			byte[] array = (byte[])dataOld.Clone();
			byte[] array2 = new byte[16];
			Buffer.BlockCopy(key, 0, array2, 0, 16);
			for (int i = 0; i < 16; i++)
			{
				byte[] array3 = array;
				int num = i;
				int num2 = num;
				array3[num2] ^= array2[i];
			}
			return new byte[]
			{
				lut[0].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[0],
					array[1],
					array[2],
					array[3]
				}, 0)),
				lut[1].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[4],
					array[5],
					array[6],
					array[7]
				}, 0)),
				lut[2].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[8],
					array[9],
					array[10],
					array[11]
				}, 0)),
				lut[3].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[12],
					array[13],
					array[14],
					array[15]
				}, 0)),
				lut[4].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[4],
					array[5],
					array[6],
					array[7]
				}, 0)),
				lut[5].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[8],
					array[9],
					array[10],
					array[11]
				}, 0)),
				lut[6].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[12],
					array[13],
					array[14],
					array[15]
				}, 0)),
				lut[7].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[0],
					array[1],
					array[2],
					array[3]
				}, 0)),
				lut[8].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[8],
					array[9],
					array[10],
					array[11]
				}, 0)),
				lut[9].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[12],
					array[13],
					array[14],
					array[15]
				}, 0)),
				lut[10].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[0],
					array[1],
					array[2],
					array[3]
				}, 0)),
				lut[11].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[4],
					array[5],
					array[6],
					array[7]
				}, 0)),
				lut[12].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[12],
					array[13],
					array[14],
					array[15]
				}, 0)),
				lut[13].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[0],
					array[1],
					array[2],
					array[3]
				}, 0)),
				lut[14].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[4],
					array[5],
					array[6],
					array[7]
				}, 0)),
				lut[15].LookUp(BitConverter.ToUInt32(new byte[]
				{
					array[8],
					array[9],
					array[10],
					array[11]
				}, 0))
			};
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00087B87 File Offset: 0x00085D87
		public static byte[] DecryptAES(byte[] data)
		{
			return GTA5Crypto.DecryptAESData(data, GTA5Constants.PC_AES_KEY, 1);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00087B95 File Offset: 0x00085D95
		public static byte[] EncryptAES(byte[] data)
		{
			return GTA5Crypto.EncryptAESData(data, GTA5Constants.PC_AES_KEY, 1);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00087BA4 File Offset: 0x00085DA4
		public static byte[] DecryptAESData(byte[] data, byte[] key, int rounds = 1)
		{
			Rijndael rijndael = Rijndael.Create();
			rijndael.KeySize = 256;
			rijndael.Key = key;
			rijndael.BlockSize = 128;
			rijndael.Mode = CipherMode.ECB;
			rijndael.Padding = PaddingMode.None;
			byte[] array = (byte[])data.Clone();
			int num = data.Length - data.Length % 16;
			if (num > 0)
			{
				ICryptoTransform cryptoTransform = rijndael.CreateDecryptor();
				for (int i = 0; i < rounds; i++)
				{
					cryptoTransform.TransformBlock(array, 0, num, array, 0);
				}
			}
			return array;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00087C24 File Offset: 0x00085E24
		public static byte[] EncryptAESData(byte[] data, byte[] key, int rounds = 1)
		{
			Rijndael rijndael = Rijndael.Create();
			rijndael.KeySize = 256;
			rijndael.Key = key;
			rijndael.BlockSize = 128;
			rijndael.Mode = CipherMode.ECB;
			rijndael.Padding = PaddingMode.None;
			byte[] array = (byte[])data.Clone();
			int num = data.Length - data.Length % 16;
			if (num > 0)
			{
				ICryptoTransform cryptoTransform = rijndael.CreateEncryptor();
				for (int i = 0; i < rounds; i++)
				{
					cryptoTransform.TransformBlock(array, 0, num, array, 0);
				}
			}
			return array;
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00087CA4 File Offset: 0x00085EA4
		public static byte[] GetNGKey(string name, uint length)
		{
			uint num = (GTA5Hash.CalculateHash(name) + length + 61U) % 101U;
			return GTA5Constants.PC_NG_KEYS[(int)num];
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00087CC8 File Offset: 0x00085EC8
		public static byte[] DecryptNG(byte[] data, string name, uint length)
		{
			byte[] ngkey = GTA5Crypto.GetNGKey(name, length);
			return GTA5Crypto.Decrypt(data, ngkey);
		}
	}
}
