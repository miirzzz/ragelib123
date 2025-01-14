using System;
using System.IO;
using System.Reflection;
using RageLib.GTA5.Cryptography.Helpers;
using RageLib.GTA5.Helpers;
using RageLib.Helpers;

namespace RageLib.GTA5.Cryptography
{
	// Token: 0x020002A1 RID: 673
	public static class GTA5Constants
	{
		// Token: 0x06000BC7 RID: 3015 RVA: 0x00086A54 File Offset: 0x00084C54
		public static void Generate(byte[] exeData)
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			MemoryStream stream = new MemoryStream(exeData);
			GTA5Constants.PC_AES_KEY = HashSearch.SearchHash(stream, GTA5HashConstants.PC_AES_KEY_HASH, 32);
			Console.WriteLine("aes key found");
			File.WriteAllBytes(directoryName + "\\gtav_aes_key.dat", GTA5Constants.PC_AES_KEY);
			GTA5Constants.PC_NG_KEYS = HashSearch.SearchHashes(stream, GTA5HashConstants.PC_NG_KEY_HASHES, 272);
			Console.WriteLine("ng keys found");
			CryptoIO.WriteNgKeys(directoryName + "\\gtav_ng_key.dat", GTA5Constants.PC_NG_KEYS);
			byte[][] array = HashSearch.SearchHashes(stream, GTA5HashConstants.PC_NG_DECRYPT_TABLE_HASHES, 1024);
			Console.WriteLine("ng decrypt tables found");
			GTA5Constants.PC_NG_DECRYPT_TABLES = new uint[17][][];
			for (int i = 0; i < 17; i++)
			{
				GTA5Constants.PC_NG_DECRYPT_TABLES[i] = new uint[16][];
				for (int j = 0; j < 16; j++)
				{
					Array src = array[j + 16 * i];
					GTA5Constants.PC_NG_DECRYPT_TABLES[i][j] = new uint[256];
					Buffer.BlockCopy(src, 0, GTA5Constants.PC_NG_DECRYPT_TABLES[i][j], 0, 1024);
				}
			}
			CryptoIO.WriteNgTables(directoryName + "\\gtav_ng_decrypt_tables.dat", GTA5Constants.PC_NG_DECRYPT_TABLES);
			GTA5Constants.PC_LUT = HashSearch.SearchHash(stream, GTA5HashConstants.PC_LUT_HASH, 256);
			Console.WriteLine("ng hash LUTs found");
			File.WriteAllBytes(directoryName + "\\gtav_hash_lut.dat", GTA5Constants.PC_LUT);
			GTA5Constants.PC_NG_ENCRYPT_TABLES = new uint[17][][];
			for (int k = 0; k < 17; k++)
			{
				GTA5Constants.PC_NG_ENCRYPT_TABLES[k] = new uint[16][];
				for (int l = 0; l < 16; l++)
				{
					GTA5Constants.PC_NG_ENCRYPT_TABLES[k][l] = new uint[256];
					for (int m = 0; m < 256; m++)
					{
						GTA5Constants.PC_NG_ENCRYPT_TABLES[k][l][m] = 0U;
					}
				}
			}
			GTA5Constants.PC_NG_ENCRYPT_LUTs = new GTA5NGLUT[17][];
			for (int n = 0; n < 17; n++)
			{
				GTA5Constants.PC_NG_ENCRYPT_LUTs[n] = new GTA5NGLUT[16];
				for (int num = 0; num < 16; num++)
				{
					GTA5Constants.PC_NG_ENCRYPT_LUTs[n][num] = new GTA5NGLUT();
				}
			}
			GTA5Constants.PC_NG_ENCRYPT_TABLES[0] = RandomGauss.Solve(GTA5Constants.PC_NG_DECRYPT_TABLES[0]);
			Console.WriteLine("ng encrypt table 1 of 17 calculated");
			GTA5Constants.PC_NG_ENCRYPT_TABLES[1] = RandomGauss.Solve(GTA5Constants.PC_NG_DECRYPT_TABLES[1]);
			Console.WriteLine("ng encrypt table 2 of 17 calculated");
			GTA5Constants.PC_NG_ENCRYPT_TABLES[16] = RandomGauss.Solve(GTA5Constants.PC_NG_DECRYPT_TABLES[16]);
			Console.WriteLine("ng encrypt table 17 of 17 calculated");
			CryptoIO.WriteNgTables(directoryName + "\\gtav_ng_encrypt_tables.dat", GTA5Constants.PC_NG_ENCRYPT_TABLES);
			for (int num2 = 2; num2 <= 15; num2++)
			{
				GTA5Constants.PC_NG_ENCRYPT_LUTs[num2] = LookUpTableGenerator.BuildLUTs2(GTA5Constants.PC_NG_DECRYPT_TABLES[num2]);
				Console.WriteLine("ng encrypt table " + (num2 + 1).ToString() + " of 17 calculated");
			}
			CryptoIO.WriteLuts(directoryName + "\\gtav_ng_encrypt_luts.dat", GTA5Constants.PC_NG_ENCRYPT_LUTs);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00086D38 File Offset: 0x00084F38
		public static void LoadFromPath(string path)
		{
			GTA5Constants.PC_AES_KEY = File.ReadAllBytes(path + "\\gtav_aes_key.dat");
			GTA5Constants.PC_NG_KEYS = CryptoIO.ReadNgKeys(path + "\\gtav_ng_key.dat");
			GTA5Constants.PC_NG_DECRYPT_TABLES = CryptoIO.ReadNgTables(path + "\\gtav_ng_decrypt_tables.dat");
			GTA5Constants.PC_NG_ENCRYPT_TABLES = CryptoIO.ReadNgTables(path + "\\gtav_ng_encrypt_tables.dat");
			GTA5Constants.PC_NG_ENCRYPT_LUTs = CryptoIO.ReadNgLuts(path + "\\gtav_ng_encrypt_luts.dat");
			GTA5Constants.PC_LUT = File.ReadAllBytes(path + "\\gtav_hash_lut.dat");
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00086DC4 File Offset: 0x00084FC4
		public static void SaveToPath(string path)
		{
			File.WriteAllBytes(path + "\\gtav_aes_key.dat", GTA5Constants.PC_AES_KEY);
			CryptoIO.WriteNgKeys(path + "\\gtav_ng_key.dat", GTA5Constants.PC_NG_KEYS);
			CryptoIO.WriteNgTables(path + "\\gtav_ng_decrypt_tables.dat", GTA5Constants.PC_NG_DECRYPT_TABLES);
			CryptoIO.WriteNgTables(path + "\\gtav_ng_encrypt_tables.dat", GTA5Constants.PC_NG_ENCRYPT_TABLES);
			CryptoIO.WriteLuts(path + "\\gtav_ng_encrypt_luts.dat", GTA5Constants.PC_NG_ENCRYPT_LUTs);
			File.WriteAllBytes(path + "\\gtav_hash_lut.dat", GTA5Constants.PC_LUT);
		}

		// Token: 0x04003FFB RID: 16379
		public static byte[] PC_AES_KEY;

		// Token: 0x04003FFC RID: 16380
		public static byte[][] PC_NG_KEYS;

		// Token: 0x04003FFD RID: 16381
		public static uint[][][] PC_NG_DECRYPT_TABLES;

		// Token: 0x04003FFE RID: 16382
		public static uint[][][] PC_NG_ENCRYPT_TABLES;

		// Token: 0x04003FFF RID: 16383
		public static byte[] PC_LUT;

		// Token: 0x04004000 RID: 16384
		public static GTA5NGLUT[][] PC_NG_ENCRYPT_LUTs;
	}
}
