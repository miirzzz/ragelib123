using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000202 RID: 514
	public static class PsoUtils
	{
		// Token: 0x06000946 RID: 2374 RVA: 0x0003B5EC File Offset: 0x000397EC
		public static void Clear()
		{
			PsoUtils.StructDict.Clear();
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0003B5F8 File Offset: 0x000397F8
		public static string GetTypesString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder.AppendLine("//Enum infos");
			stringBuilder2.AppendLine("//Struct infos");
			foreach (KeyValuePair<MetaName, PsoEnumInfo> keyValuePair in PsoUtils.EnumDict)
			{
				PsoEnumInfo value = keyValuePair.Value;
				string safeName = PsoUtils.GetSafeName((MetaName)value.IndexInfo.NameHash, (uint)value.Type);
				stringBuilder.AppendLine("public enum " + safeName + " //Type:" + value.Type.ToString());
				stringBuilder.AppendLine("{");
				foreach (PsoEnumEntryInfo psoEnumEntryInfo in value.Entries)
				{
					string safeName2 = PsoUtils.GetSafeName((MetaName)psoEnumEntryInfo.EntryNameHash, (uint)psoEnumEntryInfo.EntryKey);
					stringBuilder.AppendFormat("   {0} = {1},", safeName2, psoEnumEntryInfo.EntryKey);
					stringBuilder.AppendLine();
				}
				stringBuilder.AppendLine("}");
				stringBuilder.AppendLine();
			}
			foreach (KeyValuePair<MetaName, PsoStructureInfo> keyValuePair2 in PsoUtils.StructDict)
			{
				PsoStructureInfo value2 = keyValuePair2.Value;
				string safeName3 = PsoUtils.GetSafeName((MetaName)value2.IndexInfo.NameHash, (uint)value2.Type);
				stringBuilder2.AppendLine(string.Concat(new string[]
				{
					"public struct ",
					safeName3,
					" //",
					value2.StructureLength.ToString(),
					" bytes, Type:",
					value2.Type.ToString()
				}));
				stringBuilder2.AppendLine("{");
				for (int i = 0; i < value2.Entries.Count; i++)
				{
					PsoStructureEntryInfo psoStructureEntryInfo = value2.Entries[i];
					if (psoStructureEntryInfo.DataOffset != 0 || psoStructureEntryInfo.EntryNameHash != 256)
					{
						string safeName4 = PsoUtils.GetSafeName((MetaName)psoStructureEntryInfo.EntryNameHash, (uint)psoStructureEntryInfo.ReferenceKey);
						string format = "   public {0} {1}; //{2}   {3}";
						if (psoStructureEntryInfo.Type == DataType.Array)
						{
							if (psoStructureEntryInfo.ReferenceKey >= value2.Entries.Count)
							{
								stringBuilder2.AppendFormat(format, new object[]
								{
									psoStructureEntryInfo.Type.ToString(),
									safeName4,
									psoStructureEntryInfo.DataOffset,
									psoStructureEntryInfo.ToString() + "  { unexpected key! " + psoStructureEntryInfo.ReferenceKey.ToString() + "}"
								});
								stringBuilder2.AppendLine();
							}
							else
							{
								PsoStructureEntryInfo psoStructureEntryInfo2 = value2.Entries[psoStructureEntryInfo.ReferenceKey];
								string text = "Array_" + PsoUtils.GetCSharpTypeName(psoStructureEntryInfo2.Type);
								stringBuilder2.AppendFormat(format, new object[]
								{
									text,
									safeName4,
									psoStructureEntryInfo.DataOffset,
									psoStructureEntryInfo.ToString() + "  {" + psoStructureEntryInfo2.ToString() + "}"
								});
								stringBuilder2.AppendLine();
							}
						}
						else if (psoStructureEntryInfo.Type == DataType.Structure)
						{
							string safeName5 = PsoUtils.GetSafeName((MetaName)psoStructureEntryInfo.ReferenceKey, (uint)psoStructureEntryInfo.ReferenceKey);
							stringBuilder2.AppendFormat(format, new object[]
							{
								safeName5,
								safeName4,
								psoStructureEntryInfo.DataOffset,
								psoStructureEntryInfo.ToString()
							});
							stringBuilder2.AppendLine();
						}
						else
						{
							string csharpTypeName = PsoUtils.GetCSharpTypeName(psoStructureEntryInfo.Type);
							stringBuilder2.AppendFormat(format, new object[]
							{
								csharpTypeName,
								safeName4,
								psoStructureEntryInfo.DataOffset,
								psoStructureEntryInfo
							});
							stringBuilder2.AppendLine();
						}
					}
				}
				stringBuilder2.AppendLine("}");
				stringBuilder2.AppendLine();
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.Append(stringBuilder2.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0003BA90 File Offset: 0x00039C90
		private static string GetSafeName(MetaName namehash, uint key)
		{
			string text = namehash.ToString();
			if (string.IsNullOrEmpty(text))
			{
				text = "Unk_" + key.ToString();
			}
			if (!char.IsLetter(text[0]))
			{
				text = "Unk_" + text;
			}
			return text;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0003BAE0 File Offset: 0x00039CE0
		public static T ConvertDataRaw<T>(byte[] data) where T : struct
		{
			GCHandle gchandle = GCHandle.Alloc(data, GCHandleType.Pinned);
			T result = Marshal.PtrToStructure<T>(gchandle.AddrOfPinnedObject());
			gchandle.Free();
			return result;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0003BB08 File Offset: 0x00039D08
		public static T ConvertDataRaw<T>(byte[] data, int offset) where T : struct
		{
			GCHandle gchandle = GCHandle.Alloc(data, GCHandleType.Pinned);
			T result = Marshal.PtrToStructure<T>(gchandle.AddrOfPinnedObject() + offset);
			gchandle.Free();
			return result;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0003BB38 File Offset: 0x00039D38
		public static T ConvertData<T>(byte[] data, int offset) where T : struct, IPsoSwapEnd
		{
			GCHandle gchandle = GCHandle.Alloc(data, GCHandleType.Pinned);
			T result = Marshal.PtrToStructure<T>(gchandle.AddrOfPinnedObject() + offset);
			gchandle.Free();
			result.SwapEnd();
			return result;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0003BB78 File Offset: 0x00039D78
		public static T[] ConvertDataArrayRaw<T>(byte[] data, int offset, int count) where T : struct
		{
			T[] array = new T[count];
			int num = Marshal.SizeOf(typeof(T));
			for (int i = 0; i < count; i++)
			{
				int offset2 = offset + i * num;
				array[i] = PsoUtils.ConvertDataRaw<T>(data, offset2);
			}
			return array;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0003BBBD File Offset: 0x00039DBD
		public static T GetItem<T>(PsoFile pso, int offset) where T : struct, IPsoSwapEnd
		{
			return PsoUtils.ConvertData<T>(pso.DataSection.Data, offset);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0003BBD0 File Offset: 0x00039DD0
		public static T GetRootItem<T>(PsoFile pso) where T : struct, IPsoSwapEnd
		{
			int index = pso.DataMappingSection.RootIndex - 1;
			PsoDataMappingEntry psoDataMappingEntry = pso.DataMappingSection.Entries[index];
			return PsoUtils.GetItem<T>(pso, psoDataMappingEntry.Offset);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0003BC0C File Offset: 0x00039E0C
		public static PsoDataMappingEntry GetRootEntry(PsoFile pso)
		{
			int index = pso.DataMappingSection.RootIndex - 1;
			return pso.DataMappingSection.Entries[index];
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0003BC38 File Offset: 0x00039E38
		public static T[] GetItemArrayRaw<T>(PsoFile pso, Array_Structure arr) where T : struct
		{
			if (arr.Count1 > 0 && arr.Pointer > 0U)
			{
				PsoDataMappingEntry psoDataMappingEntry = pso.DataMappingSection.Entries[(int)arr.PointerDataIndex];
				return PsoUtils.ConvertDataArrayRaw<T>(pso.DataSection.Data, psoDataMappingEntry.Offset, (int)arr.Count1);
			}
			return null;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0003BC90 File Offset: 0x00039E90
		public static T[] GetItemArray<T>(PsoFile pso, Array_Structure arr) where T : struct, IPsoSwapEnd
		{
			if (arr.Count1 > 0 && arr.Pointer > 0U)
			{
				PsoDataMappingEntry psoDataMappingEntry = pso.DataMappingSection.Entries[(int)arr.PointerDataIndex];
				T[] array = PsoUtils.ConvertDataArrayRaw<T>(pso.DataSection.Data, psoDataMappingEntry.Offset, (int)arr.Count1);
				if (array != null)
				{
					for (int i = 0; i < array.Length; i++)
					{
						array[i].SwapEnd();
					}
				}
				return array;
			}
			return null;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0003BD10 File Offset: 0x00039F10
		public static uint[] GetUintArrayRaw(PsoFile pso, Array_uint arr)
		{
			byte[] data = pso.DataSection.Data;
			uint num = arr.Pointer & 4095U;
			if (num == 0U || (ulong)num > (ulong)((long)pso.DataMappingSection.EntriesCount))
			{
				return null;
			}
			uint num2 = (arr.Pointer & 16777215U) >> 12;
			int offset = pso.DataMappingSection.Entries[(int)(num - 1U)].Offset + (int)num2;
			return PsoUtils.ConvertDataArrayRaw<uint>(data, offset, (int)arr.Count1);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0003BD88 File Offset: 0x00039F88
		public static uint[] GetUintArray(PsoFile pso, Array_uint arr)
		{
			uint[] uintArrayRaw = PsoUtils.GetUintArrayRaw(pso, arr);
			if (uintArrayRaw == null)
			{
				return null;
			}
			for (int i = 0; i < uintArrayRaw.Length; i++)
			{
				uintArrayRaw[i] = MetaUtils.SwapBytes(uintArrayRaw[i]);
			}
			return uintArrayRaw;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0003BDBC File Offset: 0x00039FBC
		public static MetaName[] GetHashArray(PsoFile pso, Array_uint arr)
		{
			uint[] uintArrayRaw = PsoUtils.GetUintArrayRaw(pso, arr);
			if (uintArrayRaw == null)
			{
				return null;
			}
			MetaName[] array = new MetaName[uintArrayRaw.Length];
			for (int i = 0; i < uintArrayRaw.Length; i++)
			{
				array[i] = (MetaName)MetaUtils.SwapBytes(uintArrayRaw[i]);
			}
			return array;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0003BDFC File Offset: 0x00039FFC
		public static float[] GetFloatArrayRaw(PsoFile pso, Array_float arr)
		{
			byte[] data = pso.DataSection.Data;
			uint num = arr.Pointer & 4095U;
			if (num == 0U || (ulong)num > (ulong)((long)pso.DataMappingSection.EntriesCount))
			{
				return null;
			}
			uint num2 = (arr.Pointer & 16777215U) >> 12;
			int offset = pso.DataMappingSection.Entries[(int)(num - 1U)].Offset + (int)num2;
			return PsoUtils.ConvertDataArrayRaw<float>(data, offset, (int)arr.Count1);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0003BE74 File Offset: 0x0003A074
		public static float[] GetFloatArray(PsoFile pso, Array_float arr)
		{
			float[] floatArrayRaw = PsoUtils.GetFloatArrayRaw(pso, arr);
			if (floatArrayRaw == null)
			{
				return null;
			}
			for (int i = 0; i < floatArrayRaw.Length; i++)
			{
				floatArrayRaw[i] = MetaUtils.SwapBytes(floatArrayRaw[i]);
			}
			return floatArrayRaw;
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0003BEA8 File Offset: 0x0003A0A8
		public static ushort[] GetUShortArrayRaw(PsoFile pso, Array_Structure arr)
		{
			byte[] data = pso.DataSection.Data;
			uint num = arr.Pointer & 4095U;
			if (num == 0U || (ulong)num > (ulong)((long)pso.DataMappingSection.EntriesCount))
			{
				return null;
			}
			uint num2 = (arr.Pointer & 16777215U) >> 12;
			int offset = pso.DataMappingSection.Entries[(int)(num - 1U)].Offset + (int)num2;
			return PsoUtils.ConvertDataArrayRaw<ushort>(data, offset, (int)arr.Count1);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0003BF20 File Offset: 0x0003A120
		public static ushort[] GetUShortArray(PsoFile pso, Array_Structure arr)
		{
			ushort[] ushortArrayRaw = PsoUtils.GetUShortArrayRaw(pso, arr);
			if (ushortArrayRaw == null)
			{
				return null;
			}
			for (int i = 0; i < ushortArrayRaw.Length; i++)
			{
				ushortArrayRaw[i] = MetaUtils.SwapBytes(ushortArrayRaw[i]);
			}
			return ushortArrayRaw;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0003BF54 File Offset: 0x0003A154
		public static T[] GetObjectArray<T, U>(PsoFile pso, Array_Structure arr) where T : PsoClass<U>, new() where U : struct, IPsoSwapEnd
		{
			U[] itemArray = PsoUtils.GetItemArray<U>(pso, arr);
			if (itemArray == null)
			{
				return null;
			}
			if (itemArray.Length == 0)
			{
				return null;
			}
			T[] array = new T[itemArray.Length];
			for (int i = 0; i < itemArray.Length; i++)
			{
				T t = Activator.CreateInstance<T>();
				t.Init(pso, ref itemArray[i]);
				array[i] = t;
			}
			return array;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x0003BFB0 File Offset: 0x0003A1B0
		public static byte[] GetByteArray(PsoFile pso, PsoStructureEntryInfo entry, int offset)
		{
			int referenceKey = entry.ReferenceKey;
			int id = entry.ReferenceKey & 65535;
			pso.GetBlock(id);
			return null;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0003BFDC File Offset: 0x0003A1DC
		public static PsoPOINTER[] GetPointerArray(PsoFile pso, Array_StructurePointer array)
		{
			uint count = (uint)array.Count1;
			if (count == 0U)
			{
				return null;
			}
			Marshal.SizeOf(typeof(MetaPOINTER));
			uint pointer = array.Pointer;
			int num = (int)((pointer & 4095U) - 1U);
			int num2 = (int)(pointer >> 12 & 1048575U);
			PsoDataMappingEntry psoDataMappingEntry = (num < (int)pso.DataMappingSection.EntriesCount) ? pso.DataMappingSection.Entries[num] : null;
			if (psoDataMappingEntry == null || psoDataMappingEntry.NameHash != 12)
			{
				return null;
			}
			int offset = psoDataMappingEntry.Offset + num2;
			PsoPOINTER[] array2 = PsoUtils.ConvertDataArrayRaw<PsoPOINTER>(pso.DataSection.Data, offset, (int)count);
			if (array2 != null)
			{
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].SwapEnd();
				}
			}
			return array2;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0003C09C File Offset: 0x0003A29C
		public static T[] ConvertDataArray<T>(PsoFile pso, Array_StructurePointer array) where T : struct, IPsoSwapEnd
		{
			uint count = (uint)array.Count1;
			if (count == 0U)
			{
				return null;
			}
			PsoPOINTER[] pointerArray = PsoUtils.GetPointerArray(pso, array);
			if (pointerArray == null)
			{
				return null;
			}
			if ((long)pointerArray.Length < (long)((ulong)count))
			{
				return null;
			}
			T[] array2 = new T[count];
			Marshal.SizeOf(typeof(T));
			int num = 0;
			while ((long)num < (long)((ulong)count))
			{
				PsoPOINTER psoPOINTER = pointerArray[num];
				int num2 = (int)(psoPOINTER.BlockID - 1);
				int itemOffset = (int)psoPOINTER.ItemOffset;
				if (num2 < (int)pso.DataMappingSection.EntriesCount)
				{
					PsoDataMappingEntry psoDataMappingEntry = pso.DataMappingSection.Entries[num2];
					if (itemOffset >= 0 && itemOffset < psoDataMappingEntry.Length)
					{
						int offset = psoDataMappingEntry.Offset + itemOffset;
						array2[num] = PsoUtils.ConvertData<T>(pso.DataSection.Data, offset);
					}
				}
				num++;
			}
			return array2;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x0003C168 File Offset: 0x0003A368
		public static string GetString(PsoFile pso, CharPointer ptr)
		{
			if (ptr.Count1 == 0)
			{
				return null;
			}
			int pointerDataId = (int)ptr.PointerDataId;
			int pointerDataOffset = (int)ptr.PointerDataOffset;
			PsoDataMappingEntry block = pso.GetBlock(pointerDataId);
			if (block == null)
			{
				return null;
			}
			ushort count = ptr.Count1;
			if (pointerDataOffset + (int)count >= block.Length)
			{
				return null;
			}
			PsoDataSection dataSection = pso.DataSection;
			byte[] array = (dataSection != null) ? dataSection.Data : null;
			if (array == null)
			{
				return null;
			}
			int index = block.Offset + pointerDataOffset;
			return Encoding.ASCII.GetString(array, index, (int)count);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0003C1E8 File Offset: 0x0003A3E8
		public static string GetString(PsoFile pso, DataBlockPointer ptr)
		{
			int pointerDataId = (int)ptr.PointerDataId;
			int pointerDataOffset = (int)ptr.PointerDataOffset;
			PsoDataMappingEntry block = pso.GetBlock(pointerDataId);
			if (block == null)
			{
				return null;
			}
			PsoDataSection dataSection = pso.DataSection;
			byte[] array = (dataSection != null) ? dataSection.Data : null;
			if (array == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = block.Offset + pointerDataOffset;
			for (char value = (char)array[num]; value != '\0'; value = (char)array[num])
			{
				stringBuilder.Append(value);
				num++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0003C264 File Offset: 0x0003A464
		public static string GetCSharpTypeName(DataType t)
		{
			switch (t)
			{
			case DataType.Bool:
				return "bool";
			case DataType.SByte:
				return "sbyte";
			case DataType.UByte:
				return "byte";
			case DataType.SShort:
				return "short";
			case DataType.UShort:
				return "ushort";
			case DataType.SInt:
				return "int";
			case DataType.UInt:
				return "int";
			case DataType.Float:
				return "float";
			case DataType.Float2:
				return "long";
			case DataType.String:
				return "uint";
			case DataType.Enum:
				return "byte";
			case DataType.Flags:
				return "short";
			case DataType.HFloat:
				return "short";
			case DataType.Long:
				return "long";
			}
			return t.ToString();
		}

		// Token: 0x04003A5E RID: 14942
		public static Dictionary<MetaName, PsoEnumInfo> EnumDict = new Dictionary<MetaName, PsoEnumInfo>();

		// Token: 0x04003A5F RID: 14943
		public static Dictionary<MetaName, PsoStructureInfo> StructDict = new Dictionary<MetaName, PsoStructureInfo>();
	}
}
