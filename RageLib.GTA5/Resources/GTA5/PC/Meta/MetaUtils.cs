using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using RageLib.Resources.Common;
using SharpDX;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x020000DD RID: 221
	public class MetaUtils
	{
		// Token: 0x06000355 RID: 853 RVA: 0x00015EA4 File Offset: 0x000140A4
		public static ushort SwapBytes(ushort x)
		{
			return (ushort)((x & 65280) >> 8 | (int)(x & 255) << 8);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00015EBA File Offset: 0x000140BA
		public static uint SwapBytes(uint x)
		{
			x = (x >> 16 | x << 16);
			return (x & 4278255360U) >> 8 | (x & 16711935U) << 8;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00015EDA File Offset: 0x000140DA
		public static int SwapBytes(int x)
		{
			return (int)MetaUtils.SwapBytes((uint)x);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00015EE4 File Offset: 0x000140E4
		public static ulong SwapBytes(ulong x)
		{
			x = (x >> 32 | x << 32);
			x = ((x & 18446462603027742720UL) >> 16 | (x & 281470681808895UL) << 16);
			return (x & 18374966859414961920UL) >> 8 | (x & 71777214294589695UL) << 8;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00015F36 File Offset: 0x00014136
		public static float SwapBytes(float f)
		{
			byte[] bytes = BitConverter.GetBytes(f);
			Array.Reverse(bytes);
			return BitConverter.ToSingle(bytes, 0);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00015F4C File Offset: 0x0001414C
		public static Vector2 SwapBytes(Vector2 v)
		{
			float x = MetaUtils.SwapBytes(v.X);
			float y = MetaUtils.SwapBytes(v.Y);
			return new Vector2(x, y);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00015F78 File Offset: 0x00014178
		public static Vector3 SwapBytes(Vector3 v)
		{
			float x = MetaUtils.SwapBytes(v.X);
			float y = MetaUtils.SwapBytes(v.Y);
			float z = MetaUtils.SwapBytes(v.Z);
			return new Vector3(x, y, z);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00015FB0 File Offset: 0x000141B0
		public static Vector4 SwapBytes(Vector4 v)
		{
			float x = MetaUtils.SwapBytes(v.X);
			float y = MetaUtils.SwapBytes(v.Y);
			float z = MetaUtils.SwapBytes(v.Z);
			float w = MetaUtils.SwapBytes(v.W);
			return new Vector4(x, y, z, w);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00015FF4 File Offset: 0x000141F4
		public static byte[] ConvertToBytes<T>(T item) where T : struct
		{
			int num = Marshal.SizeOf(typeof(T));
			byte[] array = new byte[num];
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr<T>(item, intPtr, true);
			Marshal.Copy(intPtr, array, 0, num);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0001603C File Offset: 0x0001423C
		public static byte[] ConvertArrayToBytes<T>(params T[] items) where T : struct
		{
			if (items == null)
			{
				return null;
			}
			int num = Marshal.SizeOf(typeof(T));
			byte[] array = new byte[num * items.Length];
			int num2 = 0;
			for (int i = 0; i < items.Length; i++)
			{
				byte[] array2 = new byte[num];
				IntPtr intPtr = Marshal.AllocHGlobal(num);
				Marshal.StructureToPtr<T>(items[i], intPtr, true);
				Marshal.Copy(intPtr, array2, 0, num);
				Marshal.FreeHGlobal(intPtr);
				Buffer.BlockCopy(array2, 0, array, num2, num);
				num2 += num;
			}
			return array;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000160BC File Offset: 0x000142BC
		public static T ConvertData<T>(byte[] data, int offset = 0) where T : struct
		{
			GCHandle gchandle = GCHandle.Alloc(data, GCHandleType.Pinned);
			T result = Marshal.PtrToStructure<T>(gchandle.AddrOfPinnedObject() + offset);
			gchandle.Free();
			return result;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000160EA File Offset: 0x000142EA
		public static T ConvertData<T>(ResourceSimpleArray<byte_r> byteRArray, int offset = 0) where T : struct
		{
			return MetaUtils.ConvertData<T>(Array.ConvertAll<byte_r, byte>(byteRArray.Data.ToArray(), (byte_r e) => (byte)e), offset);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00016121 File Offset: 0x00014321
		public static T ConvertData<T>(DataBlock block, int offset = 0) where T : struct
		{
			return MetaUtils.ConvertData<T>(block.Data, offset);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0001612F File Offset: 0x0001432F
		public static T[] ConvertDataArray<T>(MetaFile meta, Array_Structure array) where T : struct
		{
			return MetaUtils.ConvertDataArray<T>(meta, array.Pointer, (uint)array.Count1);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00016148 File Offset: 0x00014348
		public static T[] ConvertDataArray<T>(MetaFile meta, uint pointer, uint count) where T : struct
		{
			T[] array = new T[count];
			int num = Marshal.SizeOf(typeof(T));
			int i = (int)count;
			uint num2 = (pointer & 4095U) - 1U;
			uint num3 = pointer >> 12 & 1048575U;
			DataBlock dataBlock = ((ulong)num2 < (ulong)((long)meta.DataBlocks.Count)) ? meta.DataBlocks[(int)num2] : null;
			if (dataBlock == null)
			{
				return array;
			}
			uint num4 = num3;
			int num5 = (int)(num4 / (uint)num);
			int num6 = (int)(num4 % (uint)num);
			int num7 = 0;
			while (i > 0)
			{
				int num8 = dataBlock.DataLength / num - num5;
				if (num8 > i)
				{
					num8 = i;
				}
				for (int j = 0; j < num8; j++)
				{
					int offset = (num5 + j) * num + num6 % 4;
					int num9 = num7 + j;
					array[num9] = MetaUtils.ConvertData<T>(dataBlock, offset);
				}
				num5 = 0;
				num7 += num8;
				i -= num8;
				if (i <= 0)
				{
					return array;
				}
				num2 += 1U;
				dataBlock = (((ulong)num2 < (ulong)((long)meta.DataBlocks.Count)) ? meta.DataBlocks[(int)num2] : null);
				if (dataBlock == null)
				{
					return array;
				}
			}
			return array;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00016254 File Offset: 0x00014454
		public static T[] ConvertDataArray<T>(MetaFile meta, Array_StructurePointer array) where T : struct
		{
			uint count = (uint)array.Count1;
			if (count == 0U)
			{
				return null;
			}
			MetaPOINTER[] pointerArray = MetaUtils.GetPointerArray(meta, array);
			if (pointerArray == null)
			{
				return null;
			}
			T[] array2 = new T[count];
			Marshal.SizeOf(typeof(T));
			int num = 0;
			while ((long)num < (long)((ulong)count))
			{
				MetaPOINTER metaPOINTER = pointerArray[num];
				int offset = metaPOINTER.Offset;
				DataBlock block = meta.GetBlock(metaPOINTER.BlockID);
				if (block != null && offset >= 0 && block.Data != null && offset < block.Data.Count)
				{
					array2[num] = MetaUtils.ConvertData<T>(block.Data, offset);
				}
				num++;
			}
			return array2;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000162FC File Offset: 0x000144FC
		public static T[] ConvertDataArray<T>(byte[] data, int offset, int count) where T : struct
		{
			T[] array = new T[count];
			int num = Marshal.SizeOf(typeof(T));
			for (int i = 0; i < count; i++)
			{
				int offset2 = offset + i * num;
				array[i] = MetaUtils.ConvertData<T>(data, offset2);
			}
			return array;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00016344 File Offset: 0x00014544
		public static T GetTypedData<T>(MetaFile meta, MetaName name) where T : struct
		{
			foreach (DataBlock dataBlock in meta.DataBlocks)
			{
				if (dataBlock.StructureNameHash == name)
				{
					return MetaUtils.ConvertData<T>(dataBlock.Data, 0);
				}
			}
			throw new Exception("Couldn't find " + name.ToString() + " block.");
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000163C8 File Offset: 0x000145C8
		public static T[] GetTypedDataArray<T>(MetaFile meta, MetaName name) where T : struct
		{
			if (meta == null || meta.DataBlocks == null)
			{
				return null;
			}
			List<DataBlock> data = meta.DataBlocks.Data;
			DataBlock dataBlock = null;
			int num = -1;
			for (int i = 0; i < data.Count; i++)
			{
				DataBlock dataBlock2 = data[i];
				if (dataBlock2.StructureNameHash == name)
				{
					dataBlock = dataBlock2;
					num = i;
					break;
				}
			}
			if (dataBlock == null)
			{
				return null;
			}
			int num2 = 0;
			int num3 = Marshal.SizeOf(typeof(T));
			DataBlock dataBlock3 = dataBlock;
			int num4 = num;
			while (dataBlock3 != null)
			{
				int num5 = dataBlock3.DataLength / num3;
				num2 += num5;
				num4++;
				if (num4 >= data.Count)
				{
					break;
				}
				dataBlock3 = data[num4];
				if (dataBlock3.StructureNameHash != name)
				{
					break;
				}
			}
			if (num2 <= 0)
			{
				return null;
			}
			return MetaUtils.ConvertDataArray<T>(meta, (uint)(num + 1), (uint)num2);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0001648C File Offset: 0x0001468C
		public static string GetString(MetaFile meta, CharPointer ptr)
		{
			int pointerDataIndex = (int)ptr.PointerDataIndex;
			int pointerDataOffset = (int)ptr.PointerDataOffset;
			if (pointerDataIndex < 0 || (long)pointerDataIndex >= meta.DataBlocks.Length)
			{
				return null;
			}
			DataBlock dataBlock = meta.DataBlocks[pointerDataIndex];
			if (dataBlock.StructureNameHash != MetaName.STRING)
			{
				return null;
			}
			ushort count = ptr.Count1;
			if (pointerDataOffset + (int)count >= dataBlock.DataLength)
			{
				return null;
			}
			byte[] bytes = Array.ConvertAll<byte_r, byte>(dataBlock.Data.Data.ToArray(), (byte_r e) => (byte)e);
			return Encoding.ASCII.GetString(bytes, pointerDataOffset, (int)count);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00016530 File Offset: 0x00014730
		public static MetaPOINTER[] GetPointerArray(MetaFile meta, Array_StructurePointer array)
		{
			uint count = (uint)array.Count1;
			if (count == 0U)
			{
				return null;
			}
			MetaPOINTER[] array2 = new MetaPOINTER[count];
			int num = Marshal.SizeOf(typeof(MetaPOINTER));
			int pointerDataOffset = (int)array.PointerDataOffset;
			DataBlock block = meta.GetBlock((int)array.PointerDataId);
			if (block == null || block.Data == null || block.StructureNameHash != MetaName.POINTER)
			{
				return null;
			}
			int num2 = 0;
			while ((long)num2 < (long)((ulong)count))
			{
				int num3 = pointerDataOffset + num2 * num;
				if (num3 >= block.Data.Count)
				{
					break;
				}
				array2[num2] = MetaUtils.ConvertData<MetaPOINTER>(block.Data, num3);
				num2++;
			}
			return array2;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000165D4 File Offset: 0x000147D4
		public static int GetDataOffset(DataBlock block, MetaPOINTER ptr)
		{
			if (block == null)
			{
				return -1;
			}
			int offset = ptr.Offset;
			uint extraOffset = ptr.ExtraOffset;
			if (offset < 0 || block.Data == null || (long)offset >= block.Data.Length)
			{
				return -1;
			}
			return offset;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00016614 File Offset: 0x00014814
		public static T GetData<T>(MetaFile meta, MetaPOINTER ptr) where T : struct
		{
			DataBlock block = meta.GetBlock(ptr.BlockID);
			int dataOffset = MetaUtils.GetDataOffset(block, ptr);
			if (dataOffset < 0)
			{
				return Activator.CreateInstance<T>();
			}
			return MetaUtils.ConvertData<T>(block.Data, dataOffset);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00016650 File Offset: 0x00014850
		public static string GetCSharpTypeName(StructureEntryDataType t)
		{
			if (t <= StructureEntryDataType.Float_XYZW)
			{
				if (t <= StructureEntryDataType.StructurePointer)
				{
					if (t == StructureEntryDataType.Boolean)
					{
						return "bool";
					}
					if (t != StructureEntryDataType.Structure && t != StructureEntryDataType.StructurePointer)
					{
					}
				}
				else if (t <= StructureEntryDataType.Float)
				{
					switch (t)
					{
					case StructureEntryDataType.SignedByte:
						return "sbyte";
					case StructureEntryDataType.UnsignedByte:
						return "byte";
					case StructureEntryDataType.SignedShort:
						return "short";
					case StructureEntryDataType.UnsignedShort:
						return "ushort";
					case StructureEntryDataType.SignedInt:
						return "int";
					case StructureEntryDataType.UnsignedInt:
						return "uint";
					default:
						if (t == StructureEntryDataType.Float)
						{
							return "float";
						}
						break;
					}
				}
				else
				{
					if (t == StructureEntryDataType.Float_XYZ)
					{
						return "Vector3";
					}
					if (t == StructureEntryDataType.Float_XYZW)
					{
						return "Vector4";
					}
				}
			}
			else if (t <= StructureEntryDataType.Hash)
			{
				if (t == StructureEntryDataType.ArrayOfChars)
				{
					return "ArrayOfChars64";
				}
				if (t != StructureEntryDataType.CharPointer)
				{
					if (t == StructureEntryDataType.Hash)
					{
						return "uint";
					}
				}
			}
			else if (t <= StructureEntryDataType.Array)
			{
				if (t != StructureEntryDataType.ArrayOfBytes && t != StructureEntryDataType.Array)
				{
				}
			}
			else if (t != StructureEntryDataType.DataBlockPointer)
			{
				switch (t)
				{
				case StructureEntryDataType.ByteEnum:
					return "byte";
				case StructureEntryDataType.IntEnum:
					return "int";
				case StructureEntryDataType.IntFlags1:
					return "int";
				case StructureEntryDataType.ShortFlags:
					return "short";
				case StructureEntryDataType.IntFlags2:
					return "int";
				}
			}
			return t.ToString();
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000167A4 File Offset: 0x000149A4
		public static long GetCSharpTypeSize(StructureEntryDataType t, long size)
		{
			if (t <= StructureEntryDataType.Float_XYZW)
			{
				if (t <= StructureEntryDataType.StructurePointer)
				{
					if (t == StructureEntryDataType.Boolean)
					{
						return 1L;
					}
					if (t != StructureEntryDataType.Structure && t != StructureEntryDataType.StructurePointer)
					{
					}
				}
				else if (t <= StructureEntryDataType.Float)
				{
					switch (t)
					{
					case StructureEntryDataType.SignedByte:
						return 1L;
					case StructureEntryDataType.UnsignedByte:
						return 1L;
					case StructureEntryDataType.SignedShort:
						return 2L;
					case StructureEntryDataType.UnsignedShort:
						return 2L;
					case StructureEntryDataType.SignedInt:
						return 4L;
					case StructureEntryDataType.UnsignedInt:
						return 4L;
					default:
						if (t == StructureEntryDataType.Float)
						{
							return 4L;
						}
						break;
					}
				}
				else
				{
					if (t == StructureEntryDataType.Float_XYZ)
					{
						return 12L;
					}
					if (t == StructureEntryDataType.Float_XYZW)
					{
						return 16L;
					}
				}
			}
			else if (t <= StructureEntryDataType.Hash)
			{
				if (t == StructureEntryDataType.ArrayOfChars)
				{
					return 64L;
				}
				if (t != StructureEntryDataType.CharPointer)
				{
					if (t == StructureEntryDataType.Hash)
					{
						return 4L;
					}
				}
			}
			else if (t <= StructureEntryDataType.Array)
			{
				if (t != StructureEntryDataType.ArrayOfBytes && t != StructureEntryDataType.Array)
				{
				}
			}
			else if (t != StructureEntryDataType.DataBlockPointer)
			{
				switch (t)
				{
				case StructureEntryDataType.ByteEnum:
					return 1L;
				case StructureEntryDataType.IntEnum:
					return 4L;
				case StructureEntryDataType.IntFlags1:
					return 4L;
				case StructureEntryDataType.ShortFlags:
					return 2L;
				case StructureEntryDataType.IntFlags2:
					return 4L;
				}
			}
			return size;
		}
	}
}
