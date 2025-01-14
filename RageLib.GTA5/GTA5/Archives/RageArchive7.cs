using System;
using System.Collections.Generic;
using System.IO;
using RageLib.Cryptography;
using RageLib.Data;
using RageLib.GTA5.Cryptography;

namespace RageLib.GTA5.Archives
{
	// Token: 0x020002AF RID: 687
	public class RageArchive7 : IDisposable
	{
		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x00089416 File Offset: 0x00087616
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x0008941E File Offset: 0x0008761E
		public RageArchiveEncryption7 Encryption { get; set; }

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00089427 File Offset: 0x00087627
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x0008942F File Offset: 0x0008762F
		public Stream BaseStream { get; private set; }

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000C3A RID: 3130 RVA: 0x00089438 File Offset: 0x00087638
		// (set) Token: 0x06000C3B RID: 3131 RVA: 0x00089440 File Offset: 0x00087640
		public RageArchiveDirectory7 Root { get; set; }

		// Token: 0x06000C3C RID: 3132 RVA: 0x00089449 File Offset: 0x00087649
		public RageArchive7(Stream fileStream, bool leaveOpen = false)
		{
			this.BaseStream = fileStream;
			this.LeaveOpen = leaveOpen;
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00089460 File Offset: 0x00087660
		public void ReadHeader(byte[] aesKey = null, byte[] ngKey = null)
		{
			DataReader dataReader = new DataReader(this.BaseStream, Endianess.LittleEndian);
			long position = dataReader.Position;
			dataReader.Position = 0L;
			uint num = dataReader.ReadUInt32();
			if (num != 1380992567U)
			{
				throw new Exception("The identifier " + num.ToString("X8") + " did not match the expected value of 0x52504637");
			}
			uint num2 = dataReader.ReadUInt32();
			uint count = dataReader.ReadUInt32();
			uint num3 = dataReader.ReadUInt32();
			byte[] buffer;
			byte[] buffer2;
			if (num3 == 1313165391U)
			{
				this.Encryption = RageArchiveEncryption7.None;
				buffer = dataReader.ReadBytes((int)(16U * num2));
				buffer2 = dataReader.ReadBytes((int)count);
			}
			else if (num3 == 268435449U)
			{
				this.Encryption = RageArchiveEncryption7.AES;
				buffer = AesEncryption.DecryptData(dataReader.ReadBytes((int)(16U * num2)), aesKey, 1);
				buffer2 = AesEncryption.DecryptData(dataReader.ReadBytes((int)count), aesKey, 1);
			}
			else
			{
				this.Encryption = RageArchiveEncryption7.MIRZ;
				buffer = GTA5Crypto.Decrypt(dataReader.ReadBytes((int)(16U * num2)), ngKey);
				buffer2 = GTA5Crypto.Decrypt(dataReader.ReadBytes((int)count), ngKey);
			}
			DataReader dataReader2 = new DataReader(new MemoryStream(buffer), Endianess.LittleEndian);
			DataReader dataReader3 = new DataReader(new MemoryStream(buffer2), Endianess.LittleEndian);
			List<IRageArchiveEntry7> list = new List<IRageArchiveEntry7>();
			int num4 = 0;
			while ((long)num4 < (long)((ulong)num2))
			{
				dataReader2.Position += 4L;
				int num5 = dataReader2.ReadInt32();
				dataReader2.Position -= 8L;
				if (num5 == 2147483392)
				{
					RageArchiveDirectory7 rageArchiveDirectory = new RageArchiveDirectory7();
					rageArchiveDirectory.Read(dataReader2);
					dataReader3.Position = (long)((ulong)rageArchiveDirectory.NameOffset);
					rageArchiveDirectory.Name = dataReader3.ReadString();
					list.Add(rageArchiveDirectory);
				}
				else if (((long)num5 & (long)((ulong)-2147483648)) == 0L)
				{
					RageArchiveBinaryFile7 rageArchiveBinaryFile = new RageArchiveBinaryFile7();
					rageArchiveBinaryFile.Read(dataReader2);
					dataReader3.Position = (long)((ulong)rageArchiveBinaryFile.NameOffset);
					rageArchiveBinaryFile.Name = dataReader3.ReadString();
					list.Add(rageArchiveBinaryFile);
				}
				else
				{
					RageArchiveResourceFile7 rageArchiveResourceFile = new RageArchiveResourceFile7();
					rageArchiveResourceFile.Read(dataReader2);
					if (rageArchiveResourceFile.FileSize == 16777215U)
					{
						dataReader.Position = (long)((ulong)(512U * rageArchiveResourceFile.FileOffset));
						byte[] array = dataReader.ReadBytes(16);
						rageArchiveResourceFile.FileSize = (uint)((int)array[7] | (int)array[14] << 8 | (int)array[5] << 16 | (int)array[2] << 24);
					}
					dataReader3.Position = (long)((ulong)rageArchiveResourceFile.NameOffset);
					rageArchiveResourceFile.Name = dataReader3.ReadString();
					list.Add(rageArchiveResourceFile);
				}
				num4++;
			}
			Stack<RageArchiveDirectory7> stack = new Stack<RageArchiveDirectory7>();
			stack.Push((RageArchiveDirectory7)list[0]);
			this.Root = (RageArchiveDirectory7)list[0];
			while (stack.Count > 0)
			{
				RageArchiveDirectory7 rageArchiveDirectory2 = stack.Pop();
				int num6 = (int)rageArchiveDirectory2.EntriesIndex;
				while ((long)num6 < (long)((ulong)(rageArchiveDirectory2.EntriesIndex + rageArchiveDirectory2.EntriesCount)))
				{
					if (list[num6] is RageArchiveDirectory7)
					{
						rageArchiveDirectory2.Directories.Add(list[num6] as RageArchiveDirectory7);
						stack.Push(list[num6] as RageArchiveDirectory7);
					}
					else
					{
						rageArchiveDirectory2.Files.Add(list[num6]);
					}
					num6++;
				}
			}
			dataReader.Position = position;
		}

		// Token: 0x06000C3E RID: 3134
		public void WriteHeader(byte[] aesKey = null, byte[] ngKey = null)
		{
			long position = this.BaseStream.Position;
			DataWriter dataWriter = new DataWriter(this.BaseStream, Endianess.LittleEndian);
			List<IRageArchiveEntry7> list = new List<IRageArchiveEntry7>();
			Stack<RageArchiveDirectory7> stack = new Stack<RageArchiveDirectory7>();
			int num = 1;
			list.Add(this.Root);
			stack.Push(this.Root);
			Dictionary<string, uint> dictionary = new Dictionary<string, uint>();
			dictionary.Add("", 0U);
			while (stack.Count > 0)
			{
				RageArchiveDirectory7 rageArchiveDirectory = stack.Pop();
				rageArchiveDirectory.EntriesIndex = (uint)list.Count;
				rageArchiveDirectory.EntriesCount = (uint)(rageArchiveDirectory.Directories.Count + rageArchiveDirectory.Files.Count);
				List<IRageArchiveEntry7> list2 = new List<IRageArchiveEntry7>();
				foreach (RageArchiveDirectory7 rageArchiveDirectory2 in rageArchiveDirectory.Directories)
				{
					if (!dictionary.ContainsKey(rageArchiveDirectory2.Name))
					{
						dictionary.Add(rageArchiveDirectory2.Name, (uint)num);
						num += rageArchiveDirectory2.Name.Length + 1;
					}
					rageArchiveDirectory2.NameOffset = dictionary[rageArchiveDirectory2.Name];
					list2.Add(rageArchiveDirectory2);
				}
				foreach (IRageArchiveEntry7 rageArchiveEntry in rageArchiveDirectory.Files)
				{
					if (!dictionary.ContainsKey(rageArchiveEntry.Name))
					{
						dictionary.Add(rageArchiveEntry.Name, (uint)num);
						num += rageArchiveEntry.Name.Length + 1;
					}
					rageArchiveEntry.NameOffset = dictionary[rageArchiveEntry.Name];
					list2.Add(rageArchiveEntry);
				}
				list2.Sort((IRageArchiveEntry7 a, IRageArchiveEntry7 b) => string.CompareOrdinal(a.Name, b.Name));
				foreach (IRageArchiveEntry7 item in list2)
				{
					list.Add(item);
				}
				list2.Reverse();
				foreach (IRageArchiveEntry7 rageArchiveEntry2 in list2)
				{
					if (rageArchiveEntry2 is RageArchiveDirectory7)
					{
						stack.Push((RageArchiveDirectory7)rageArchiveEntry2);
					}
				}
			}
			foreach (IRageArchiveEntry7 rageArchiveEntry3 in list)
			{
				if (rageArchiveEntry3 is RageArchiveResourceFile7)
				{
					RageArchiveResourceFile7 rageArchiveResourceFile = rageArchiveEntry3 as RageArchiveResourceFile7;
					if (rageArchiveResourceFile.FileSize > 16777215U)
					{
						byte[] array = new byte[16];
						array[7] = (byte)(rageArchiveResourceFile.FileSize & 255U);
						array[14] = (byte)(rageArchiveResourceFile.FileSize >> 8 & 255U);
						array[5] = (byte)(rageArchiveResourceFile.FileSize >> 16 & 255U);
						array[2] = (byte)(rageArchiveResourceFile.FileSize >> 24 & 255U);
						if (dataWriter.Length > (long)((ulong)(512U * rageArchiveResourceFile.FileOffset)))
						{
							dataWriter.Position = (long)((ulong)(512U * rageArchiveResourceFile.FileOffset));
							dataWriter.Write(array);
						}
						rageArchiveResourceFile.FileSize = 16777215U;
					}
				}
			}
			MemoryStream memoryStream = new MemoryStream();
			DataWriter writer = new DataWriter(memoryStream, Endianess.LittleEndian);
			foreach (IRageArchiveEntry7 rageArchiveEntry4 in list)
			{
				rageArchiveEntry4.Write(writer);
			}
			memoryStream.Flush();
			byte[] array2 = new byte[memoryStream.Length];
			memoryStream.Position = 0L;
			memoryStream.Read(array2, 0, array2.Length);
			if (this.Encryption == RageArchiveEncryption7.AES)
			{
				array2 = AesEncryption.EncryptData(array2, aesKey, 1);
			}
			if (this.Encryption == RageArchiveEncryption7.MIRZ)
			{
				array2 = GTA5Crypto.Encrypt(array2, ngKey);
			}
			MemoryStream memoryStream2 = new MemoryStream();
			DataWriter dataWriter2 = new DataWriter(memoryStream2, Endianess.LittleEndian);
			foreach (KeyValuePair<string, uint> keyValuePair in dictionary)
			{
				dataWriter2.Write(keyValuePair.Key);
			}
			byte[] value = new byte[16L - dataWriter2.Length % 16L];
			dataWriter2.Write(value);
			memoryStream2.Flush();
			byte[] array3 = new byte[memoryStream2.Length];
			memoryStream2.Position = 0L;
			memoryStream2.Read(array3, 0, array3.Length);
			if (this.Encryption == RageArchiveEncryption7.AES)
			{
				array3 = AesEncryption.EncryptData(array3, aesKey, 1);
			}
			if (this.Encryption == RageArchiveEncryption7.MIRZ)
			{
				array3 = GTA5Crypto.Encrypt(array3, ngKey);
			}
			dataWriter.Position = 0L;
			dataWriter.Write(1380992567);
			dataWriter.Write((uint)list.Count);
			dataWriter.Write((uint)array3.Length);
			switch (this.Encryption)
			{
			case RageArchiveEncryption7.None:
				dataWriter.Write(1313165391);
				break;
			case RageArchiveEncryption7.AES:
				dataWriter.Write(268435449);
				break;
			case RageArchiveEncryption7.MIRZ:
				dataWriter.Write(1337);
				break;
			}
			dataWriter.Write(array2);
			dataWriter.Write(array3);
			this.BaseStream.Position = position;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00089D1C File Offset: 0x00087F1C
		public void Dispose()
		{
			if (this.BaseStream != null)
			{
				this.BaseStream.Dispose();
			}
			this.BaseStream = null;
			this.Root = null;
		}

		// Token: 0x04004013 RID: 16403
		private const uint IDENT = 1380992567U;

		// Token: 0x04004015 RID: 16405
		private bool LeaveOpen;
	}
}
