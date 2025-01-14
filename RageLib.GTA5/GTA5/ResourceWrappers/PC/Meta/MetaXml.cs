using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using RageLib.GTA5.Utilities;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta
{
	// Token: 0x02000198 RID: 408
	public class MetaXml : MetaXmlBase
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x0002AC60 File Offset: 0x00028E60
		public static string GetXml(MetaFile meta)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
			if (meta != null)
			{
				MetaXml.MetaCont cont = new MetaXml.MetaCont(meta);
				MetaXml.WriteNode(stringBuilder, 0, cont, meta.RootBlockIndex, 0, MetaXmlBase.XmlTagMode.Structure, (MetaName)0, (meta.Name == null) ? "" : ((string)meta.Name));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0002ACBC File Offset: 0x00028EBC
		private static void WriteNode(StringBuilder sb, int indent, MetaXml.MetaCont cont, int blockId, int offset, MetaXmlBase.XmlTagMode tagMode = MetaXmlBase.XmlTagMode.None, MetaName structName = (MetaName)0, string metaName = "")
		{
			DataBlock block = cont.Meta.GetBlock(blockId);
			if (block == null)
			{
				MetaXmlBase.ErrorXml(sb, indent, "Couldn't find block " + blockId.ToString() + "!");
				return;
			}
			if (structName == (MetaName)0)
			{
				structName = block.StructureNameHash;
			}
			string text = MetaXmlBase.HashString(structName);
			byte[] array = Array.ConvertAll<byte_r, byte>(block.Data.Data.ToArray(), (byte_r e) => (byte)e);
			StructureInfo structureInfo = cont.GetStructureInfo(structName);
			if (structureInfo == null)
			{
				MetaXmlBase.ErrorXml(sb, indent, "Couldn't find structure info " + text + "!");
				return;
			}
			if (structureInfo.Entries == null)
			{
				MetaXmlBase.ErrorXml(sb, indent, "Couldn't find structure info entries for " + text + "!");
				return;
			}
			switch (tagMode)
			{
			case MetaXmlBase.XmlTagMode.Structure:
				MetaXmlBase.OpenTag(sb, indent, text, true, metaName);
				break;
			case MetaXmlBase.XmlTagMode.Item:
				MetaXmlBase.OpenTag(sb, indent, "Item", true, metaName);
				break;
			case MetaXmlBase.XmlTagMode.ItemAndType:
				MetaXmlBase.OpenTag(sb, indent, "Item type=\"" + text + "\"", true, metaName);
				break;
			}
			int num = indent + 1;
			StructureEntryInfo arrEntry = new StructureEntryInfo();
			for (int i = 0; i < structureInfo.Entries.Count; i++)
			{
				StructureEntryInfo structureEntryInfo = structureInfo.Entries[i];
				if (structureEntryInfo.EntryNameHash == 256)
				{
					arrEntry = structureEntryInfo;
				}
				else
				{
					string text2 = MetaXmlBase.HashString((MetaName)structureEntryInfo.EntryNameHash);
					int num2 = offset + structureEntryInfo.DataOffset;
					StructureEntryDataType dataType = structureEntryInfo.DataType;
					if (dataType <= StructureEntryDataType.Float_XYZW)
					{
						if (dataType <= StructureEntryDataType.StructurePointer)
						{
							if (dataType == StructureEntryDataType.Boolean)
							{
								bool flag = BitConverter.ToBoolean(array, num2);
								MetaXmlBase.ValueTag(sb, num, text2, flag ? "true" : "false");
								goto IL_6EA;
							}
							if (dataType == StructureEntryDataType.Structure)
							{
								MetaXmlBase.OpenTag(sb, num, text2, true, "");
								MetaXml.WriteNode(sb, num, cont, blockId, num2, MetaXmlBase.XmlTagMode.None, (MetaName)structureEntryInfo.ReferenceKey, "");
								MetaXmlBase.CloseTag(sb, num, text2, true);
								goto IL_6EA;
							}
							if (dataType == StructureEntryDataType.StructurePointer)
							{
								MetaXmlBase.OpenTag(sb, num, text2, true, "");
								MetaXmlBase.ErrorXml(sb, num + 1, "StructurePointer not supported here! Tell dexy!");
								MetaXmlBase.CloseTag(sb, num, text2, true);
								goto IL_6EA;
							}
						}
						else if (dataType <= StructureEntryDataType.Float)
						{
							switch (dataType)
							{
							case StructureEntryDataType.SignedByte:
								MetaXmlBase.ValueTag(sb, num, text2, ((sbyte)array[num2]).ToString());
								goto IL_6EA;
							case StructureEntryDataType.UnsignedByte:
							{
								byte b = array[num2];
								MetaXmlBase.ValueTag(sb, num, text2, b.ToString());
								goto IL_6EA;
							}
							case StructureEntryDataType.SignedShort:
								MetaXmlBase.ValueTag(sb, num, text2, BitConverter.ToInt16(array, num2).ToString());
								goto IL_6EA;
							case StructureEntryDataType.UnsignedShort:
								MetaXmlBase.ValueTag(sb, num, text2, BitConverter.ToUInt16(array, num2).ToString());
								goto IL_6EA;
							case StructureEntryDataType.SignedInt:
								MetaXmlBase.ValueTag(sb, num, text2, BitConverter.ToInt32(array, num2).ToString());
								goto IL_6EA;
							case StructureEntryDataType.UnsignedInt:
							{
								uint num3 = BitConverter.ToUInt32(array, num2);
								if (structureEntryInfo.EntryNameHash != -380371671)
								{
									MetaXmlBase.ValueTag(sb, num, text2, num3.ToString());
									goto IL_6EA;
								}
								MetaXmlBase.ValueTag(sb, num, text2, "0x" + num3.ToString("X").PadLeft(8, '0'));
								goto IL_6EA;
							}
							default:
								if (dataType == StructureEntryDataType.Float)
								{
									MetaXmlBase.ValueTag(sb, num, text2, BitConverter.ToSingle(array, num2).ToString(CultureInfo.InvariantCulture));
									goto IL_6EA;
								}
								break;
							}
						}
						else
						{
							if (dataType == StructureEntryDataType.Float_XYZ)
							{
								Vector3 vector = MetaUtils.ConvertData<Vector3>(array, num2);
								MetaXmlBase.SelfClosingTag(sb, num, string.Concat(new string[]
								{
									text2,
									" x=\"",
									vector.X.ToString(CultureInfo.InvariantCulture),
									"\" y=\"",
									vector.Y.ToString(CultureInfo.InvariantCulture),
									"\" z=\"",
									vector.Z.ToString(CultureInfo.InvariantCulture),
									"\""
								}));
								goto IL_6EA;
							}
							if (dataType == StructureEntryDataType.Float_XYZW)
							{
								Vector4 vector2 = MetaUtils.ConvertData<Vector4>(array, num2);
								MetaXmlBase.SelfClosingTag(sb, num, string.Concat(new string[]
								{
									text2,
									" x=\"",
									vector2.X.ToString(CultureInfo.InvariantCulture),
									"\" y=\"",
									vector2.Y.ToString(CultureInfo.InvariantCulture),
									"\" z=\"",
									vector2.Z.ToString(CultureInfo.InvariantCulture),
									"\" w=\"",
									vector2.W.ToString(CultureInfo.InvariantCulture),
									"\""
								}));
								goto IL_6EA;
							}
						}
					}
					else if (dataType <= StructureEntryDataType.Hash)
					{
						if (dataType == StructureEntryDataType.ArrayOfChars)
						{
							MetaXmlBase.OpenTag(sb, num, text2, false, "");
							uint referenceKey = (uint)structureEntryInfo.ReferenceKey;
							int num4 = 0;
							while ((long)num4 < (long)((ulong)referenceKey))
							{
								int num5 = num2 + num4;
								if (num5 >= 0 && num5 < array.Length)
								{
									byte b2 = array[num5];
									if (b2 == 0)
									{
										break;
									}
									sb.Append((char)b2);
								}
								num4++;
							}
							MetaXmlBase.CloseTag(sb, 0, text2, true);
							goto IL_6EA;
						}
						if (dataType == StructureEntryDataType.CharPointer)
						{
							CharPointer ptr = MetaUtils.ConvertData<CharPointer>(array, num2);
							string @string = MetaUtils.GetString(cont.Meta, ptr);
							MetaXmlBase.OneLineTag(sb, num, text2, @string);
							goto IL_6EA;
						}
						if (dataType == StructureEntryDataType.Hash)
						{
							string text3 = MetaXmlBase.HashString((MetaName)MetaUtils.ConvertData<uint>(array, num2));
							MetaXmlBase.StringTag(sb, num, text2, text3);
							goto IL_6EA;
						}
					}
					else if (dataType <= StructureEntryDataType.Array)
					{
						if (dataType == StructureEntryDataType.ArrayOfBytes)
						{
							MetaXml.WriteParsedArrayOfBytesNode(sb, num, array, text2, num2, structureEntryInfo, arrEntry);
							goto IL_6EA;
						}
						if (dataType == StructureEntryDataType.Array)
						{
							MetaXml.WriteArrayNode(sb, num, cont, array, arrEntry, text2, num2);
							goto IL_6EA;
						}
					}
					else
					{
						if (dataType == StructureEntryDataType.DataBlockPointer)
						{
							MetaXmlBase.OpenTag(sb, num, text2, true, "");
							MetaUtils.ConvertData<DataBlockPointer>(array, num2);
							MetaXmlBase.ErrorXml(sb, num + 1, "DataBlockPointer not currently supported here!");
							MetaXmlBase.CloseTag(sb, num, text2, true);
							goto IL_6EA;
						}
						switch (dataType)
						{
						case StructureEntryDataType.ByteEnum:
						{
							byte b3 = array[num2];
							MetaXmlBase.ValueTag(sb, num, text2, b3.ToString());
							goto IL_6EA;
						}
						case StructureEntryDataType.IntEnum:
						{
							int value = BitConverter.ToInt32(array, num2);
							string enumString = MetaXml.GetEnumString(cont, structureEntryInfo, value);
							MetaXmlBase.StringTag(sb, num, text2, enumString);
							goto IL_6EA;
						}
						case StructureEntryDataType.IntFlags1:
						{
							int value2 = BitConverter.ToInt32(array, num2);
							string enumString2 = MetaXml.GetEnumString(cont, structureEntryInfo, value2);
							MetaXmlBase.StringTag(sb, num, text2, enumString2);
							goto IL_6EA;
						}
						case StructureEntryDataType.ShortFlags:
						{
							string text4 = BitConverter.ToInt16(array, num2).ToString();
							MetaXmlBase.StringTag(sb, num, text2, text4);
							goto IL_6EA;
						}
						case StructureEntryDataType.IntFlags2:
						{
							int value3 = BitConverter.ToInt32(array, num2);
							string enumString3 = MetaXml.GetEnumString(cont, structureEntryInfo, value3);
							MetaXmlBase.StringTag(sb, num, text2, enumString3);
							goto IL_6EA;
						}
						}
					}
					MetaXmlBase.ErrorXml(sb, num, text2 + ": Unexpected entry DataType: " + structureEntryInfo.DataType.ToString());
				}
				IL_6EA:;
			}
			if (tagMode == MetaXmlBase.XmlTagMode.Structure)
			{
				MetaXmlBase.CloseTag(sb, indent, text, true);
				return;
			}
			if (tagMode - MetaXmlBase.XmlTagMode.Item > 1)
			{
				return;
			}
			MetaXmlBase.CloseTag(sb, indent, "Item", true);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0002B3F0 File Offset: 0x000295F0
		private static void WriteArrayNode(StringBuilder sb, int indent, MetaXml.MetaCont cont, byte[] data, StructureEntryInfo arrEntry, string ename, int eoffset)
		{
			int indent2 = indent + 1;
			StructureEntryDataType dataType = arrEntry.DataType;
			if (dataType <= StructureEntryDataType.Float)
			{
				if (dataType <= StructureEntryDataType.StructurePointer)
				{
					if (dataType != StructureEntryDataType.Structure)
					{
						if (dataType == StructureEntryDataType.StructurePointer)
						{
							Array_StructurePointer array = MetaUtils.ConvertData<Array_StructurePointer>(data, eoffset);
							MetaPOINTER[] pointerArray = MetaUtils.GetPointerArray(cont.Meta, array);
							int num = (pointerArray != null) ? pointerArray.Length : 0;
							if (num > 0)
							{
								MetaXmlBase.OpenTag(sb, indent, ename, true, "");
								for (int i = 0; i < num; i++)
								{
									MetaPOINTER metaPOINTER = pointerArray[i];
									int offset = metaPOINTER.Offset;
									MetaXml.WriteNode(sb, indent2, cont, metaPOINTER.BlockID, offset, MetaXmlBase.XmlTagMode.ItemAndType, (MetaName)0, "");
								}
								MetaXmlBase.CloseTag(sb, indent, ename, true);
								return;
							}
							MetaXmlBase.SelfClosingTag(sb, indent, ename);
							return;
						}
					}
					else
					{
						Array_Structure array_Structure = MetaUtils.ConvertData<Array_Structure>(data, eoffset);
						int num2 = (int)array_Structure.PointerDataId;
						int num3 = (int)array_Structure.PointerDataOffset;
						int num = (int)array_Structure.Count1;
						string text = ename + " itemType=\"" + MetaXmlBase.HashString((MetaName)arrEntry.ReferenceKey) + "\"";
						if (num > 0)
						{
							MetaXmlBase.OpenTag(sb, indent, text, true, "");
							StructureInfo structureInfo = cont.GetStructureInfo((MetaName)arrEntry.ReferenceKey);
							DataBlock block = cont.Meta.GetBlock(num2);
							for (int j = 0; j < num; j++)
							{
								MetaXml.WriteNode(sb, indent2, cont, num2, num3, MetaXmlBase.XmlTagMode.Item, (MetaName)arrEntry.ReferenceKey, "");
								num3 += structureInfo.StructureLength;
								if (j < num - 1 && block != null && num3 >= block.DataLength)
								{
									num3 = 0;
									num2++;
									block = cont.Meta.GetBlock(num2);
								}
							}
							MetaXmlBase.CloseTag(sb, indent, ename, true);
							return;
						}
						MetaXmlBase.SelfClosingTag(sb, indent, text);
						return;
					}
				}
				else
				{
					switch (dataType)
					{
					case StructureEntryDataType.UnsignedByte:
					{
						Array_byte array_byte = MetaUtils.ConvertData<Array_byte>(data, eoffset);
						byte[] arr = MetaUtils.ConvertDataArray<byte>(cont.Meta, array_byte.Pointer, (uint)array_byte.Count1);
						MetaXmlBase.WriteRawArray<byte>(sb, arr, indent, ename, "byte", null, 10);
						return;
					}
					case StructureEntryDataType.SignedShort:
					case StructureEntryDataType.SignedInt:
						break;
					case StructureEntryDataType.UnsignedShort:
					{
						Array_ushort array_ushort = MetaUtils.ConvertData<Array_ushort>(data, eoffset);
						ushort[] arr2 = MetaUtils.ConvertDataArray<ushort>(cont.Meta, array_ushort.Pointer, (uint)array_ushort.Count1);
						MetaXmlBase.WriteRawArray<ushort>(sb, arr2, indent, ename, "ushort", null, 10);
						return;
					}
					case StructureEntryDataType.UnsignedInt:
					{
						Array_uint array_uint = MetaUtils.ConvertData<Array_uint>(data, eoffset);
						uint[] arr3 = MetaUtils.ConvertDataArray<uint>(cont.Meta, array_uint.Pointer, (uint)array_uint.Count1);
						MetaXmlBase.WriteRawArray<uint>(sb, arr3, indent, ename, "uint", null, 10);
						return;
					}
					default:
						if (dataType == StructureEntryDataType.Float)
						{
							Array_float array_float = MetaUtils.ConvertData<Array_float>(data, eoffset);
							float[] arr4 = MetaUtils.ConvertDataArray<float>(cont.Meta, array_float.Pointer, (uint)array_float.Count1);
							MetaXmlBase.WriteRawArray<float>(sb, arr4, indent, ename, "float", null, 10);
							return;
						}
						break;
					}
				}
			}
			else if (dataType <= StructureEntryDataType.CharPointer)
			{
				if (dataType == StructureEntryDataType.Float_XYZ)
				{
					Array_Vector3 array_Vector = MetaUtils.ConvertData<Array_Vector3>(data, eoffset);
					Vector4[] arr5 = MetaUtils.ConvertDataArray<Vector4>(cont.Meta, array_Vector.Pointer, (uint)array_Vector.Count1);
					MetaXmlBase.WriteItemArray<Vector4>(sb, arr5, indent, ename, "Vector3/4", new Func<Vector4, string>(MetaXmlBase.FormatVector4));
					return;
				}
				if (dataType == StructureEntryDataType.CharPointer)
				{
					MetaXmlBase.ErrorXml(sb, indent, "CharPointer ARRAY not supported here!");
					return;
				}
			}
			else
			{
				if (dataType == StructureEntryDataType.Hash)
				{
					Array_uint array_uint2 = MetaUtils.ConvertData<Array_uint>(data, eoffset);
					MetaName[] arr6 = Array.ConvertAll<uint, MetaName>(MetaUtils.ConvertDataArray<uint>(cont.Meta, array_uint2.Pointer, (uint)array_uint2.Count1), (uint e) => (MetaName)e);
					MetaXmlBase.WriteItemArray<MetaName>(sb, arr6, indent, ename, "Hash", new Func<MetaName, string>(MetaXmlBase.FormatHash));
					return;
				}
				if (dataType == StructureEntryDataType.DataBlockPointer)
				{
					MetaXmlBase.ErrorXml(sb, indent, "DataBlockPointer ARRAY not supported here!");
					return;
				}
			}
			MetaXmlBase.ErrorXml(sb, indent, ename + ": Unexpected array entry DataType: " + arrEntry.DataType.ToString());
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0002B7C4 File Offset: 0x000299C4
		private static void WriteParsedArrayOfBytesNode(StringBuilder sb, int indent, byte[] data, string ename, int eoffset, StructureEntryInfo entry, StructureEntryInfo arrEntry)
		{
			MetaXmlBase.OpenTag(sb, indent, ename, false, "");
			int referenceKey = entry.ReferenceKey;
			StructureEntryDataType dataType = arrEntry.DataType;
			switch (dataType)
			{
			case StructureEntryDataType.SignedByte:
				for (int i = 0; i < referenceKey; i++)
				{
					int num = eoffset + i;
					sb.Append(((num >= 0 && num < data.Length) ? ((sbyte)data[num]) : 0).ToString());
					if (i < referenceKey - 1)
					{
						sb.Append(" ");
					}
				}
				break;
			case StructureEntryDataType.UnsignedByte:
				for (int j = 0; j < referenceKey; j++)
				{
					int num2 = eoffset + j;
					sb.Append(((num2 >= 0 && num2 < data.Length) ? data[num2] : 0).ToString());
					if (j < referenceKey - 1)
					{
						sb.Append(" ");
					}
				}
				break;
			case StructureEntryDataType.SignedShort:
				for (int k = 0; k < referenceKey; k++)
				{
					int num3 = eoffset + k * 2;
					sb.Append(((num3 >= 0 && num3 < data.Length) ? BitConverter.ToInt16(data, num3) : 0).ToString());
					if (k < referenceKey - 1)
					{
						sb.Append(" ");
					}
				}
				break;
			case StructureEntryDataType.UnsignedShort:
				for (int l = 0; l < referenceKey; l++)
				{
					int num4 = eoffset + l * 2;
					sb.Append(((num4 >= 0 && num4 < data.Length) ? BitConverter.ToUInt16(data, num4) : 0).ToString());
					if (l < referenceKey - 1)
					{
						sb.Append(" ");
					}
				}
				break;
			case StructureEntryDataType.SignedInt:
				for (int m = 0; m < referenceKey; m++)
				{
					int num5 = eoffset + m * 4;
					sb.Append(((num5 >= 0 && num5 < data.Length) ? BitConverter.ToInt32(data, num5) : 0).ToString());
					if (m < referenceKey - 1)
					{
						sb.Append(" ");
					}
				}
				break;
			case StructureEntryDataType.UnsignedInt:
				for (int n = 0; n < referenceKey; n++)
				{
					int num6 = eoffset + n * 4;
					sb.Append(((num6 >= 0 && num6 < data.Length) ? BitConverter.ToUInt32(data, num6) : 0U).ToString());
					if (n < referenceKey - 1)
					{
						sb.Append(" ");
					}
				}
				break;
			default:
				if (dataType != StructureEntryDataType.Float)
				{
					for (int num7 = 0; num7 < referenceKey; num7++)
					{
						int num8 = eoffset + num7;
						sb.Append(((num8 >= 0 && num8 < data.Length) ? data[num8] : 0).ToString("X").PadLeft(2, '0'));
					}
				}
				else
				{
					for (int num9 = 0; num9 < referenceKey; num9++)
					{
						int num10 = eoffset + num9 * 4;
						float f = (num10 >= 0 && num10 < data.Length) ? BitConverter.ToSingle(data, num10) : 0f;
						sb.Append(FloatUtil.ToString(f));
						if (num9 < referenceKey - 1)
						{
							sb.Append(" ");
						}
					}
				}
				break;
			}
			MetaXmlBase.CloseTag(sb, 0, ename, true);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0002BAC0 File Offset: 0x00029CC0
		private static string GetEnumString(MetaXml.MetaCont cont, StructureEntryInfo entry, int value)
		{
			MetaName referenceKey = (MetaName)entry.ReferenceKey;
			EnumInfo enumInfo = cont.GetEnumInfo(referenceKey);
			if (enumInfo == null || enumInfo.Entries == null)
			{
				return value.ToString();
			}
			if (entry.DataType == StructureEntryDataType.IntFlags1 || entry.DataType == StructureEntryDataType.IntFlags2)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (EnumEntryInfo enumEntryInfo in enumInfo.Entries)
				{
					int entryValue = enumEntryInfo.EntryValue;
					int num = 1 << entryValue;
					if ((value & num) > 0)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append(", ");
						}
						stringBuilder.Append(MetaXmlBase.HashString((MetaName)enumEntryInfo.EntryNameHash));
					}
				}
				return stringBuilder.ToString();
			}
			foreach (EnumEntryInfo enumEntryInfo2 in enumInfo.Entries)
			{
				if (enumEntryInfo2.EntryValue == value)
				{
					return MetaXmlBase.HashString((MetaName)enumEntryInfo2.EntryNameHash);
				}
			}
			return value.ToString();
		}

		// Token: 0x020002C4 RID: 708
		private class MetaCont
		{
			// Token: 0x170002DE RID: 734
			// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0008AB68 File Offset: 0x00088D68
			// (set) Token: 0x06000C99 RID: 3225 RVA: 0x0008AB70 File Offset: 0x00088D70
			public MetaFile Meta { get; set; }

			// Token: 0x06000C9A RID: 3226 RVA: 0x0008AB7C File Offset: 0x00088D7C
			public MetaCont(MetaFile meta)
			{
				this.Meta = meta;
				if (meta.StructureInfos != null)
				{
					foreach (StructureInfo structureInfo in meta.StructureInfos)
					{
						this.structInfos[(MetaName)structureInfo.StructureNameHash] = structureInfo;
					}
				}
				if (meta.EnumInfos != null)
				{
					foreach (EnumInfo enumInfo in meta.EnumInfos)
					{
						this.enumInfos[(MetaName)enumInfo.EnumNameHash] = enumInfo;
					}
				}
			}

			// Token: 0x06000C9B RID: 3227 RVA: 0x0008AC50 File Offset: 0x00088E50
			public StructureInfo GetStructureInfo(MetaName name)
			{
				StructureInfo result = null;
				this.structInfos.TryGetValue(name, out result);
				return result;
			}

			// Token: 0x06000C9C RID: 3228 RVA: 0x0008AC70 File Offset: 0x00088E70
			public EnumInfo GetEnumInfo(MetaName name)
			{
				EnumInfo result = null;
				this.enumInfos.TryGetValue(name, out result);
				return result;
			}

			// Token: 0x04004109 RID: 16649
			private Dictionary<MetaName, StructureInfo> structInfos = new Dictionary<MetaName, StructureInfo>();

			// Token: 0x0400410A RID: 16650
			private Dictionary<MetaName, EnumInfo> enumInfos = new Dictionary<MetaName, EnumInfo>();
		}
	}
}
