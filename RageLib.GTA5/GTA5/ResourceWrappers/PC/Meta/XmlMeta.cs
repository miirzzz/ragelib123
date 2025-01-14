using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Xml;
using RageLib.GTA5.Utilities;
using RageLib.Hash;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta
{
	// Token: 0x02000199 RID: 409
	public class XmlMeta
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x0002BBEC File Offset: 0x00029DEC
		public static MetaFile GetMeta(XmlDocument doc)
		{
			MetaBuilder metaBuilder = new MetaBuilder();
			XmlMeta.Traverse(doc.DocumentElement, metaBuilder, (MetaName)0, true);
			XmlNode namedItem = doc.DocumentElement.Attributes.GetNamedItem("name");
			if (namedItem != null)
			{
				return metaBuilder.GetMeta(namedItem.Value);
			}
			return metaBuilder.GetMeta("");
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0002BC40 File Offset: 0x00029E40
		private static byte[] Traverse(XmlNode node, MetaBuilder mb, MetaName type = (MetaName)0, bool isRoot = false)
		{
			if (type == (MetaName)0)
			{
				type = XmlMeta.GetHash(node.Name);
			}
			StructureInfo structureInfo = MetaInfo.GetStructureInfo(type);
			if (structureInfo != null)
			{
				byte[] array = new byte[structureInfo.StructureLength];
				ArrayResults results = default(ArrayResults);
				results.Structures = new Dictionary<int, Array_Structure>();
				results.StructurePointers = new Dictionary<int, Array_StructurePointer>();
				results.UInts = new Dictionary<int, Array_uint>();
				results.UShorts = new Dictionary<int, Array_ushort>();
				results.UBytes = new Dictionary<int, Array_byte>();
				results.Floats = new Dictionary<int, Array_float>();
				results.Float_XYZs = new Dictionary<int, Array_Vector3>();
				results.Hashes = new Dictionary<int, Array_uint>();
				Array.Clear(array, 0, structureInfo.StructureLength);
				StructureEntryInfo arrEntry = new StructureEntryInfo();
				if (isRoot)
				{
					mb.EnsureBlock(type);
				}
				for (int i = 0; i < structureInfo.Entries.Count; i++)
				{
					StructureEntryInfo structureEntryInfo = structureInfo.Entries[i];
					XmlNode entryNode = XmlMeta.GetEntryNode(node.ChildNodes, structureEntryInfo);
					if (structureEntryInfo.EntryNameHash == 256)
					{
						arrEntry = structureEntryInfo;
					}
					else if (entryNode != null)
					{
						StructureEntryDataType dataType = structureEntryInfo.DataType;
						if (dataType <= StructureEntryDataType.Float_XYZW)
						{
							if (dataType <= StructureEntryDataType.StructurePointer)
							{
								if (dataType != StructureEntryDataType.Boolean)
								{
									if (dataType != StructureEntryDataType.Structure)
									{
										if (dataType != StructureEntryDataType.StructurePointer)
										{
										}
									}
									else
									{
										byte[] array2 = XmlMeta.Traverse(entryNode, mb, (MetaName)structureEntryInfo.ReferenceKey, false);
										if (array2 != null)
										{
											Buffer.BlockCopy(array2, 0, array, structureEntryInfo.DataOffset, array2.Length);
										}
									}
								}
								else
								{
									byte b = (entryNode.Attributes["value"].Value == "false") ? 0 : 1;
									array[structureEntryInfo.DataOffset] = b;
								}
							}
							else if (dataType <= StructureEntryDataType.Float)
							{
								switch (dataType)
								{
								case StructureEntryDataType.SignedByte:
								{
									sbyte b2 = Convert.ToSByte(entryNode.Attributes["value"].Value);
									array[structureEntryInfo.DataOffset] = (byte)b2;
									break;
								}
								case StructureEntryDataType.UnsignedByte:
								{
									byte b3 = Convert.ToByte(entryNode.Attributes["value"].Value);
									array[structureEntryInfo.DataOffset] = b3;
									break;
								}
								case StructureEntryDataType.SignedShort:
									XmlMeta.Write(Convert.ToInt16(entryNode.Attributes["value"].Value), array, structureEntryInfo.DataOffset);
									break;
								case StructureEntryDataType.UnsignedShort:
									XmlMeta.Write(Convert.ToUInt16(entryNode.Attributes["value"].Value), array, structureEntryInfo.DataOffset);
									break;
								case StructureEntryDataType.SignedInt:
									XmlMeta.Write(Convert.ToInt32(entryNode.Attributes["value"].Value), array, structureEntryInfo.DataOffset);
									break;
								case StructureEntryDataType.UnsignedInt:
									if (structureEntryInfo.EntryNameHash == -380371671)
									{
										XmlMeta.Write(Convert.ToUInt32(entryNode.Attributes["value"].Value, 16), array, structureEntryInfo.DataOffset);
									}
									else
									{
										XmlMeta.Write(Convert.ToUInt32(entryNode.Attributes["value"].Value), array, structureEntryInfo.DataOffset);
									}
									break;
								default:
									if (dataType == StructureEntryDataType.Float)
									{
										XmlMeta.Write(FloatUtil.Parse(entryNode.Attributes["value"].Value), array, structureEntryInfo.DataOffset);
									}
									break;
								}
							}
							else if (dataType != StructureEntryDataType.Float_XYZ)
							{
								if (dataType == StructureEntryDataType.Float_XYZW)
								{
									float val = FloatUtil.Parse(entryNode.Attributes["x"].Value);
									float val2 = FloatUtil.Parse(entryNode.Attributes["y"].Value);
									float val3 = FloatUtil.Parse(entryNode.Attributes["z"].Value);
									float val4 = FloatUtil.Parse(entryNode.Attributes["w"].Value);
									XmlMeta.Write(val, array, structureEntryInfo.DataOffset);
									XmlMeta.Write(val2, array, structureEntryInfo.DataOffset + 4);
									XmlMeta.Write(val3, array, structureEntryInfo.DataOffset + 8);
									XmlMeta.Write(val4, array, structureEntryInfo.DataOffset + 12);
								}
							}
							else
							{
								float val5 = FloatUtil.Parse(entryNode.Attributes["x"].Value);
								float val6 = FloatUtil.Parse(entryNode.Attributes["y"].Value);
								float val7 = FloatUtil.Parse(entryNode.Attributes["z"].Value);
								XmlMeta.Write(val5, array, structureEntryInfo.DataOffset);
								XmlMeta.Write(val6, array, structureEntryInfo.DataOffset + 4);
								XmlMeta.Write(val7, array, structureEntryInfo.DataOffset + 8);
							}
						}
						else if (dataType <= StructureEntryDataType.Hash)
						{
							if (dataType != StructureEntryDataType.ArrayOfChars)
							{
								if (dataType != StructureEntryDataType.CharPointer)
								{
									if (dataType == StructureEntryDataType.Hash)
									{
										XmlMeta.Write((uint)XmlMeta.GetHash(entryNode.InnerText), array, structureEntryInfo.DataOffset);
									}
								}
								else if (!string.IsNullOrEmpty(entryNode.InnerText))
								{
									byte[] array3 = MetaUtils.ConvertToBytes<CharPointer>(mb.AddStringPtr(entryNode.InnerText));
									Buffer.BlockCopy(array3, 0, array, structureEntryInfo.DataOffset, array3.Length);
								}
							}
							else
							{
								int num = structureEntryInfo.DataOffset;
								string[] array4 = XmlMeta.Split(entryNode.InnerText, 2);
								for (int j = 0; j < array4.Length; j++)
								{
									byte b4 = Convert.ToByte(array4[j], 16);
									array[num] = b4;
									num++;
								}
							}
						}
						else if (dataType <= StructureEntryDataType.Array)
						{
							if (dataType != StructureEntryDataType.ArrayOfBytes)
							{
								if (dataType == StructureEntryDataType.Array)
								{
									XmlMeta.TraverseArray(entryNode, mb, arrEntry, structureEntryInfo.DataOffset, results);
								}
							}
							else
							{
								XmlMeta.GetParsedArrayOfBytes(entryNode, array, structureEntryInfo, arrEntry);
							}
						}
						else if (dataType != StructureEntryDataType.DataBlockPointer)
						{
							switch (dataType)
							{
							case StructureEntryDataType.ByteEnum:
							{
								byte b5 = Convert.ToByte(entryNode.Attributes["value"].Value);
								array[structureEntryInfo.DataOffset] = b5;
								break;
							}
							case StructureEntryDataType.IntEnum:
							case StructureEntryDataType.IntFlags1:
							case StructureEntryDataType.IntFlags2:
							{
								EnumInfo enumInfo = MetaInfo.GetEnumInfo((MetaName)structureEntryInfo.ReferenceKey);
								if (enumInfo != null)
								{
									mb.AddEnumInfo((MetaName)enumInfo.EnumNameHash);
								}
								XmlMeta.Write(XmlMeta.GetEnumInt((MetaName)structureEntryInfo.ReferenceKey, entryNode.InnerText, structureEntryInfo.DataType), array, structureEntryInfo.DataOffset);
								break;
							}
							case StructureEntryDataType.ShortFlags:
							{
								EnumInfo enumInfo2 = MetaInfo.GetEnumInfo((MetaName)structureEntryInfo.ReferenceKey);
								if (enumInfo2 != null)
								{
									mb.AddEnumInfo((MetaName)enumInfo2.EnumNameHash);
								}
								short val8;
								if (short.TryParse(entryNode.InnerText, out val8))
								{
									XmlMeta.Write(val8, array, structureEntryInfo.DataOffset);
								}
								break;
							}
							}
						}
					}
				}
				results.WriteArrays(array);
				mb.AddStructureInfo((MetaName)structureInfo.StructureNameHash);
				if (isRoot)
				{
					mb.AddItem(type, array);
				}
				return array;
			}
			return null;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0002C308 File Offset: 0x0002A508
		private static void GetParsedArrayOfBytes(XmlNode node, byte[] data, StructureEntryInfo entry, StructureEntryInfo arrEntry)
		{
			int num = entry.DataOffset;
			NumberStyles style = NumberStyles.Any;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			char[] separator = new char[]
			{
				' '
			};
			StringSplitOptions options = StringSplitOptions.RemoveEmptyEntries;
			string[] array = node.InnerText.Trim().Split(separator, options);
			StructureEntryDataType dataType = arrEntry.DataType;
			switch (dataType)
			{
			case StructureEntryDataType.SignedByte:
				for (int i = 0; i < array.Length; i++)
				{
					sbyte b;
					if (sbyte.TryParse(array[i].Trim(), style, invariantCulture, out b))
					{
						data[num] = (byte)b;
						num++;
					}
				}
				return;
			case StructureEntryDataType.UnsignedByte:
				for (int j = 0; j < array.Length; j++)
				{
					byte b2;
					if (byte.TryParse(array[j].Trim(), style, invariantCulture, out b2))
					{
						data[num] = b2;
						num++;
					}
				}
				return;
			case StructureEntryDataType.SignedShort:
				for (int k = 0; k < array.Length; k++)
				{
					short val;
					if (short.TryParse(array[k].Trim(), style, invariantCulture, out val))
					{
						XmlMeta.Write(val, data, num);
						num += 2;
					}
				}
				return;
			case StructureEntryDataType.UnsignedShort:
				for (int l = 0; l < array.Length; l++)
				{
					ushort val2;
					if (ushort.TryParse(array[l].Trim(), style, invariantCulture, out val2))
					{
						XmlMeta.Write(val2, data, num);
						num += 2;
					}
				}
				return;
			case StructureEntryDataType.SignedInt:
				for (int m = 0; m < array.Length; m++)
				{
					int val3;
					if (int.TryParse(array[m].Trim(), style, invariantCulture, out val3))
					{
						XmlMeta.Write(val3, data, num);
						num += 4;
					}
				}
				return;
			case StructureEntryDataType.UnsignedInt:
				for (int n = 0; n < array.Length; n++)
				{
					uint val4;
					if (uint.TryParse(array[n].Trim(), style, invariantCulture, out val4))
					{
						XmlMeta.Write(val4, data, num);
						num += 4;
					}
				}
				return;
			default:
				if (dataType != StructureEntryDataType.Float)
				{
					array = XmlMeta.Split(node.InnerText, 2);
					for (int num2 = 0; num2 < array.Length; num2++)
					{
						byte b3 = Convert.ToByte(array[num2], 16);
						data[num] = b3;
						num++;
					}
					return;
				}
				for (int num3 = 0; num3 < array.Length; num3++)
				{
					float val5;
					if (FloatUtil.TryParse(array[num3].Trim(), out val5))
					{
						XmlMeta.Write(val5, data, num);
						num += 4;
					}
				}
				return;
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0002C528 File Offset: 0x0002A728
		private static void TraverseArray(XmlNode node, MetaBuilder mb, StructureEntryInfo arrEntry, int offset, ArrayResults results)
		{
			StructureEntryDataType dataType = arrEntry.DataType;
			if (dataType <= StructureEntryDataType.Float)
			{
				if (dataType <= StructureEntryDataType.StructurePointer)
				{
					if (dataType == StructureEntryDataType.Structure)
					{
						results.Structures[offset] = XmlMeta.TraverseArrayStructure(node, mb, (MetaName)arrEntry.ReferenceKey);
						return;
					}
					if (dataType != StructureEntryDataType.StructurePointer)
					{
						return;
					}
					results.StructurePointers[offset] = XmlMeta.TraverseArrayStructurePointer(node, mb);
					return;
				}
				else
				{
					switch (dataType)
					{
					case StructureEntryDataType.UnsignedByte:
						results.UBytes[offset] = XmlMeta.TraverseRawUByteArray(node, mb);
						return;
					case StructureEntryDataType.SignedShort:
					case StructureEntryDataType.SignedInt:
						break;
					case StructureEntryDataType.UnsignedShort:
						results.UShorts[offset] = XmlMeta.TraverseRawUShortArray(node, mb);
						return;
					case StructureEntryDataType.UnsignedInt:
						results.UInts[offset] = XmlMeta.TraverseRawUIntArray(node, mb);
						return;
					default:
						if (dataType != StructureEntryDataType.Float)
						{
							return;
						}
						results.Floats[offset] = XmlMeta.TraverseRawFloatArray(node, mb);
						return;
					}
				}
			}
			else if (dataType <= StructureEntryDataType.CharPointer)
			{
				if (dataType != StructureEntryDataType.Float_XYZ)
				{
					return;
				}
				results.Float_XYZs[offset] = XmlMeta.TraverseRawVector3Array(node, mb);
				return;
			}
			else
			{
				if (dataType != StructureEntryDataType.Hash)
				{
					return;
				}
				results.Hashes[offset] = XmlMeta.TraverseHashArray(node, mb);
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0002C644 File Offset: 0x0002A844
		private static Array_Structure TraverseArrayStructure(XmlNode node, MetaBuilder mb, MetaName type)
		{
			List<byte[]> list = new List<byte[]>();
			foreach (object obj in node.ChildNodes)
			{
				byte[] array = XmlMeta.Traverse((XmlNode)obj, mb, type, false);
				if (array != null)
				{
					list.Add(array);
				}
			}
			return mb.AddItemArrayPtr(type, list.ToArray());
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0002C6BC File Offset: 0x0002A8BC
		private static Array_StructurePointer TraverseArrayStructurePointer(XmlNode node, MetaBuilder mb)
		{
			List<MetaPOINTER> list = new List<MetaPOINTER>();
			foreach (object obj in node.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				MetaName hash = XmlMeta.GetHash(xmlNode.Attributes["type"].Value);
				byte[] array = XmlMeta.Traverse(xmlNode, mb, hash, false);
				if (array != null)
				{
					MetaPOINTER item = mb.AddItemPtr(hash, array);
					list.Add(item);
				}
			}
			return mb.AddPointerArray(list.ToArray());
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0002C75C File Offset: 0x0002A95C
		private static Array_uint TraverseRawUIntArray(XmlNode node, MetaBuilder mb)
		{
			List<uint> list = new List<uint>();
			if (node.InnerText != "")
			{
				string[] array = Regex.Split(node.InnerText, "[\\s\\r\\n\\t]");
				for (int i = 0; i < array.Length; i++)
				{
					if (!string.IsNullOrEmpty(array[i]))
					{
						uint item = Convert.ToUInt32(array[i]);
						list.Add(item);
					}
				}
			}
			return mb.AddUintArrayPtr(list.ToArray());
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0002C7C8 File Offset: 0x0002A9C8
		private static Array_ushort TraverseRawUShortArray(XmlNode node, MetaBuilder mb)
		{
			List<ushort> list = new List<ushort>();
			if (node.InnerText != "")
			{
				string[] array = Regex.Split(node.InnerText, "[\\s\\r\\n\\t]");
				for (int i = 0; i < array.Length; i++)
				{
					if (!string.IsNullOrEmpty(array[i]))
					{
						ushort item = Convert.ToUInt16(array[i]);
						list.Add(item);
					}
				}
			}
			return mb.AddUshortArrayPtr(list.ToArray());
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0002C834 File Offset: 0x0002AA34
		private static Array_byte TraverseRawUByteArray(XmlNode node, MetaBuilder mb)
		{
			List<byte> list = new List<byte>();
			if (node.InnerText != "")
			{
				string[] array = Regex.Split(node.InnerText, "[\\s\\r\\n\\t]");
				for (int i = 0; i < array.Length; i++)
				{
					if (!string.IsNullOrEmpty(array[i]))
					{
						byte item = Convert.ToByte(array[i]);
						list.Add(item);
					}
				}
			}
			return mb.AddByteArrayPtr(list.ToArray());
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0002C8A0 File Offset: 0x0002AAA0
		private static Array_float TraverseRawFloatArray(XmlNode node, MetaBuilder mb)
		{
			List<float> list = new List<float>();
			if (node.InnerText != "")
			{
				foreach (string text in Regex.Split(node.InnerText, "[\\s\\r\\n\\t]"))
				{
					string text2 = (text != null) ? text.Trim() : null;
					if (!string.IsNullOrEmpty(text2))
					{
						float item = FloatUtil.Parse(text2);
						list.Add(item);
					}
				}
			}
			return mb.AddFloatArrayPtr(list.ToArray());
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0002C918 File Offset: 0x0002AB18
		private static Array_Vector3 TraverseRawVector3Array(XmlNode node, MetaBuilder mb)
		{
			List<Vector4> list = new List<Vector4>();
			float w = 0f;
			XmlNodeList xmlNodeList = node.SelectNodes("Item");
			if (xmlNodeList.Count > 0)
			{
				using (IEnumerator enumerator = xmlNodeList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						string[] array = ((XmlNode)obj).InnerText.Split(new char[]
						{
							','
						});
						if (array.Length >= 3)
						{
							float x = FloatUtil.Parse(array[0].Trim());
							float y = FloatUtil.Parse(array[1].Trim());
							float z = FloatUtil.Parse(array[2].Trim());
							if (array.Length >= 4)
							{
								w = FloatUtil.Parse(array[3].Trim());
							}
							Vector4 item = new Vector4(x, y, z, w);
							list.Add(item);
						}
					}
					goto IL_1DB;
				}
			}
			foreach (string text in node.InnerText.Split(new char[]
			{
				'\n'
			}))
			{
				string text2 = (text != null) ? text.Trim() : null;
				if (!string.IsNullOrEmpty(text2))
				{
					string[] array3 = Regex.Split(text2, "[\\s\\t]");
					int num = 0;
					float x = 0f;
					float y = 0f;
					float z = 0f;
					foreach (string text3 in array3)
					{
						string text4 = (text3 != null) ? text3.Trim() : null;
						if (!string.IsNullOrEmpty(text4))
						{
							float num2 = FloatUtil.Parse(text4);
							switch (num)
							{
							case 0:
								x = num2;
								break;
							case 1:
								y = num2;
								break;
							case 2:
								z = num2;
								break;
							}
							num++;
						}
					}
					if (num >= 3)
					{
						Vector4 item2 = new Vector4(x, y, z, w);
						list.Add(item2);
					}
				}
			}
			IL_1DB:
			return mb.AddPaddedVector3ArrayPtr(list.ToArray());
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0002CB1C File Offset: 0x0002AD1C
		private static Array_uint TraverseHashArray(XmlNode node, MetaBuilder mb)
		{
			List<MetaName> list = new List<MetaName>();
			foreach (object obj in node.ChildNodes)
			{
				MetaName hash = XmlMeta.GetHash(((XmlNode)obj).InnerText);
				list.Add(hash);
			}
			return mb.AddHashArrayPtr(list.ToArray());
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0002CB94 File Offset: 0x0002AD94
		private static void Write(int val, byte[] data, int offset)
		{
			Buffer.BlockCopy(BitConverter.GetBytes(val), 0, data, offset, 4);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0002CBA5 File Offset: 0x0002ADA5
		private static void Write(uint val, byte[] data, int offset)
		{
			Buffer.BlockCopy(BitConverter.GetBytes(val), 0, data, offset, 4);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0002CBB6 File Offset: 0x0002ADB6
		private static void Write(short val, byte[] data, int offset)
		{
			Buffer.BlockCopy(BitConverter.GetBytes(val), 0, data, offset, 2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0002CBC7 File Offset: 0x0002ADC7
		private static void Write(ushort val, byte[] data, int offset)
		{
			Buffer.BlockCopy(BitConverter.GetBytes(val), 0, data, offset, 2);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0002CBD8 File Offset: 0x0002ADD8
		private static void Write(float val, byte[] data, int offset)
		{
			Buffer.BlockCopy(BitConverter.GetBytes(val), 0, data, offset, 4);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0002CBE9 File Offset: 0x0002ADE9
		private static MetaName GetHash(string str)
		{
			if (str.StartsWith("hash_"))
			{
				return (MetaName)Convert.ToUInt32(str.Substring(5), 16);
			}
			return (MetaName)Jenkins.Hash(str);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0002CC10 File Offset: 0x0002AE10
		private static XmlNode GetEntryNode(XmlNodeList nodes, StructureEntryInfo entry)
		{
			foreach (object obj in nodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (XmlMeta.GetHash(xmlNode.Name) == (MetaName)entry.EntryNameHash)
				{
					return xmlNode;
				}
			}
			return null;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0002CC78 File Offset: 0x0002AE78
		private static string[] Split(string str, int maxChunkSize)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < str.Length; i += maxChunkSize)
			{
				list.Add(str.Substring(i, Math.Min(maxChunkSize, str.Length - i)));
			}
			return list.ToArray();
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0002CCC0 File Offset: 0x0002AEC0
		private static int GetEnumInt(MetaName type, string enumString, StructureEntryDataType dataType)
		{
			EnumInfo enumInfo = MetaInfo.GetEnumInfo(type);
			if (enumInfo == null)
			{
				return 0;
			}
			if (dataType == StructureEntryDataType.IntFlags1 || dataType == StructureEntryDataType.IntFlags2)
			{
				string[] array = enumString.Split(new char[]
				{
					','
				}, StringSplitOptions.RemoveEmptyEntries);
				int num = 0;
				for (int i = 0; i < array.Length; i++)
				{
					MetaName hash = XmlMeta.GetHash(array[i].Trim());
					for (int j = 0; j < enumInfo.Entries.Count; j++)
					{
						EnumEntryInfo enumEntryInfo = enumInfo.Entries[j];
						if (enumEntryInfo.EntryNameHash == (int)hash)
						{
							num += 1 << enumEntryInfo.EntryValue;
							break;
						}
					}
				}
				return num;
			}
			MetaName hash2 = XmlMeta.GetHash(enumString);
			for (int k = 0; k < enumInfo.Entries.Count; k++)
			{
				EnumEntryInfo enumEntryInfo2 = enumInfo.Entries[k];
				if (enumEntryInfo2.EntryNameHash == (int)hash2)
				{
					return enumEntryInfo2.EntryValue;
				}
			}
			return 0;
		}
	}
}
