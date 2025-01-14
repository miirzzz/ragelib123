using System;
using System.IO;
using RageLib.Data;

namespace RageLib.GTA5.Cryptography.Helpers
{
	// Token: 0x020002A5 RID: 677
	public class CryptoIO
	{
		// Token: 0x06000BE3 RID: 3043 RVA: 0x00087FCC File Offset: 0x000861CC
		public static byte[][] ReadNgKeys(byte[] data)
		{
			MemoryStream memoryStream = new MemoryStream(data);
			DataReader dataReader = new DataReader(memoryStream, Endianess.LittleEndian);
			byte[][] array = new byte[101][];
			for (int i = 0; i < 101; i++)
			{
				array[i] = dataReader.ReadBytes(272);
			}
			memoryStream.Close();
			return array;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00088014 File Offset: 0x00086214
		public static byte[][] ReadNgKeys(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open);
			DataReader dataReader = new DataReader(fileStream, Endianess.LittleEndian);
			byte[][] array = new byte[101][];
			for (int i = 0; i < 101; i++)
			{
				array[i] = dataReader.ReadBytes(272);
			}
			fileStream.Close();
			return array;
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0008805C File Offset: 0x0008625C
		public static void WriteNgKeys(string fileName, byte[][] keys)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Create);
			DataWriter dataWriter = new DataWriter(fileStream, Endianess.LittleEndian);
			for (int i = 0; i < 101; i++)
			{
				dataWriter.Write(keys[i]);
			}
			fileStream.Close();
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00088098 File Offset: 0x00086298
		public static uint[][][] ReadNgTables(byte[] data)
		{
			MemoryStream memoryStream = new MemoryStream(data);
			DataReader dataReader = new DataReader(memoryStream, Endianess.LittleEndian);
			uint[][][] array = new uint[17][][];
			for (int i = 0; i < 17; i++)
			{
				array[i] = new uint[16][];
				for (int j = 0; j < 16; j++)
				{
					array[i][j] = new uint[256];
					for (int k = 0; k < 256; k++)
					{
						array[i][j][k] = dataReader.ReadUInt32();
					}
				}
			}
			memoryStream.Close();
			return array;
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00088120 File Offset: 0x00086320
		public static uint[][][] ReadNgTables(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open);
			DataReader dataReader = new DataReader(fileStream, Endianess.LittleEndian);
			uint[][][] array = new uint[17][][];
			for (int i = 0; i < 17; i++)
			{
				array[i] = new uint[16][];
				for (int j = 0; j < 16; j++)
				{
					array[i][j] = new uint[256];
					for (int k = 0; k < 256; k++)
					{
						array[i][j][k] = dataReader.ReadUInt32();
					}
				}
			}
			fileStream.Close();
			return array;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x000881A8 File Offset: 0x000863A8
		public static void WriteNgTables(string fileName, uint[][][] tableData)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Create);
			DataWriter dataWriter = new DataWriter(fileStream, Endianess.LittleEndian);
			for (int i = 0; i < 17; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 256; k++)
					{
						dataWriter.Write(tableData[i][j][k]);
					}
				}
			}
			fileStream.Close();
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00088208 File Offset: 0x00086408
		public static GTA5NGLUT[][] ReadNgLuts(byte[] data)
		{
			MemoryStream memoryStream = new MemoryStream(data);
			DataReader dataReader = new DataReader(memoryStream, Endianess.LittleEndian);
			GTA5NGLUT[][] array = new GTA5NGLUT[17][];
			for (int i = 0; i < 17; i++)
			{
				array[i] = new GTA5NGLUT[16];
				for (int j = 0; j < 16; j++)
				{
					array[i][j] = new GTA5NGLUT();
					array[i][j].LUT0 = new byte[256][];
					for (int k = 0; k < 256; k++)
					{
						array[i][j].LUT0[k] = dataReader.ReadBytes(256);
					}
					array[i][j].LUT1 = new byte[256][];
					for (int l = 0; l < 256; l++)
					{
						array[i][j].LUT1[l] = dataReader.ReadBytes(256);
					}
					array[i][j].Indices = dataReader.ReadBytes(65536);
				}
			}
			memoryStream.Close();
			return array;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0008830C File Offset: 0x0008650C
		public static GTA5NGLUT[][] ReadNgLuts(string fileName)
		{
			return CryptoIO.ReadNgLuts(File.ReadAllBytes(fileName));
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0008831C File Offset: 0x0008651C
		public static void WriteLuts(string fileName, GTA5NGLUT[][] lutData)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Create);
			DataWriter dataWriter = new DataWriter(fileStream, Endianess.LittleEndian);
			for (int i = 0; i < 17; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					GTA5NGLUT gta5NGLUT = lutData[i][j];
					for (int k = 0; k < 256; k++)
					{
						for (int l = 0; l < 256; l++)
						{
							dataWriter.Write(gta5NGLUT.LUT0[k][l]);
						}
					}
					for (int m = 0; m < 256; m++)
					{
						for (int n = 0; n < 256; n++)
						{
							dataWriter.Write(gta5NGLUT.LUT1[m][n]);
						}
					}
					for (int num = 0; num < 65536; num++)
					{
						dataWriter.Write(gta5NGLUT.Indices[num]);
					}
				}
			}
			fileStream.Close();
		}
	}
}
