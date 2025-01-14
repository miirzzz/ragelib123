using System;
using System.Collections.Generic;
using System.Text;
using RageLib.GTA5.PSO;
using RageLib.GTA5.Utilities;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.PSO
{
	// Token: 0x0200018C RID: 396
	public class PsoXml : MetaXmlBase
	{
		// Token: 0x06000645 RID: 1605 RVA: 0x00029148 File Offset: 0x00027348
		public static string GetXml(PsoFile pso)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
			if (pso != null && pso.DataSection != null && pso.DataMappingSection != null)
			{
				PsoXml.PsoCont cont = new PsoXml.PsoCont(pso);
				PsoXml.WriteNode(stringBuilder, 0, cont, pso.DataMappingSection.RootIndex, 0, MetaXmlBase.XmlTagMode.Structure, (MetaName)0);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x000291A0 File Offset: 0x000273A0
		private static void WriteNode(StringBuilder sb, int indent, PsoXml.PsoCont cont, int blockId, int offset, MetaXmlBase.XmlTagMode tagMode = MetaXmlBase.XmlTagMode.None, MetaName structName = (MetaName)0)
		{
			PsoDataMappingEntry block = cont.Pso.GetBlock(blockId);
			if (block == null)
			{
				MetaXmlBase.ErrorXml(sb, indent, "Couldn't find block " + blockId.ToString() + "!");
				return;
			}
			int num = offset + block.Offset;
			if (structName == (MetaName)0)
			{
				structName = (MetaName)block.NameHash;
			}
			string text = MetaXmlBase.HashString(structName);
			byte[] data = cont.Pso.DataSection.Data;
			PsoStructureInfo structureInfo = cont.GetStructureInfo(structName);
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
				MetaXmlBase.OpenTag(sb, indent, text, true, "");
				break;
			case MetaXmlBase.XmlTagMode.Item:
				MetaXmlBase.OpenTag(sb, indent, "Item", true, "");
				break;
			case MetaXmlBase.XmlTagMode.ItemAndType:
				MetaXmlBase.OpenTag(sb, indent, "Item type=\"" + text + "\"", true, "");
				break;
			}
			int indent2 = indent + 1;
			for (int i = 0; i < structureInfo.Entries.Count; i++)
			{
				PsoStructureEntryInfo psoStructureEntryInfo = structureInfo.Entries[i];
				if (psoStructureEntryInfo.EntryNameHash != 256)
				{
					string text2 = MetaXmlBase.HashString((MetaName)psoStructureEntryInfo.EntryNameHash);
					int num2 = num + (int)psoStructureEntryInfo.DataOffset;
					switch (psoStructureEntryInfo.Type)
					{
					case DataType.Bool:
					{
						bool flag = BitConverter.ToBoolean(data, num2);
						MetaXmlBase.ValueTag(sb, indent2, text2, flag ? "true" : "false");
						break;
					}
					case DataType.SByte:
						MetaXmlBase.ValueTag(sb, indent2, text2, ((sbyte)data[num2]).ToString());
						break;
					case DataType.UByte:
					{
						byte b = data[num2];
						MetaXmlBase.ValueTag(sb, indent2, text2, b.ToString());
						break;
					}
					case DataType.SShort:
						MetaXmlBase.ValueTag(sb, indent2, text2, ((short)MetaUtils.SwapBytes(BitConverter.ToUInt16(data, num2))).ToString());
						break;
					case DataType.UShort:
						MetaXmlBase.ValueTag(sb, indent2, text2, MetaUtils.SwapBytes(BitConverter.ToUInt16(data, num2)).ToString());
						break;
					case DataType.SInt:
						MetaXmlBase.ValueTag(sb, indent2, text2, MetaUtils.SwapBytes(BitConverter.ToInt32(data, num2)).ToString());
						break;
					case DataType.UInt:
					{
						byte unk_5h = psoStructureEntryInfo.Unk_5h;
						if (unk_5h != 0)
						{
							if (unk_5h != 1)
							{
								MetaXmlBase.ErrorXml(sb, indent2, text2 + ": Unexpected Integer subtype: " + psoStructureEntryInfo.Unk_5h.ToString());
							}
							else
							{
								MetaXmlBase.ValueTag(sb, indent2, text2, "0x" + MetaUtils.SwapBytes(BitConverter.ToUInt32(data, num2)).ToString("X").PadLeft(8, '0'));
							}
						}
						else
						{
							MetaXmlBase.ValueTag(sb, indent2, text2, MetaUtils.SwapBytes(BitConverter.ToInt32(data, num2)).ToString());
						}
						break;
					}
					case DataType.Float:
					{
						float f = MetaUtils.SwapBytes(BitConverter.ToSingle(data, num2));
						MetaXmlBase.ValueTag(sb, indent2, text2, FloatUtil.ToString(f));
						break;
					}
					case DataType.Float2:
					{
						Vector2 vector = MetaUtils.SwapBytes(MetaUtils.ConvertData<Vector2>(data, num2));
						MetaXmlBase.SelfClosingTag(sb, indent2, string.Concat(new string[]
						{
							text2,
							" x=\"",
							FloatUtil.ToString(vector.X),
							"\" y=\"",
							FloatUtil.ToString(vector.Y),
							"\""
						}));
						break;
					}
					case DataType.Float3:
					{
						Vector3 vector2 = MetaUtils.SwapBytes(MetaUtils.ConvertData<Vector3>(data, num2));
						MetaXmlBase.SelfClosingTag(sb, indent2, string.Concat(new string[]
						{
							text2,
							" x=\"",
							FloatUtil.ToString(vector2.X),
							"\" y=\"",
							FloatUtil.ToString(vector2.Y),
							"\" z=\"",
							FloatUtil.ToString(vector2.Z),
							"\""
						}));
						break;
					}
					case DataType.Float4:
					{
						Vector4 vector3 = MetaUtils.SwapBytes(MetaUtils.ConvertData<Vector4>(data, num2));
						MetaXmlBase.SelfClosingTag(sb, indent2, string.Concat(new string[]
						{
							text2,
							" x=\"",
							FloatUtil.ToString(vector3.X),
							"\" y=\"",
							FloatUtil.ToString(vector3.Y),
							"\" z=\"",
							FloatUtil.ToString(vector3.Z),
							"\" w=\"",
							FloatUtil.ToString(vector3.W),
							"\""
						}));
						break;
					}
					case DataType.String:
					{
						string stringValue = PsoXml.GetStringValue(cont.Pso, psoStructureEntryInfo, data, num2);
						if (stringValue == null)
						{
							MetaXmlBase.ErrorXml(sb, indent2, text2 + ": Unexpected String subtype: " + psoStructureEntryInfo.Unk_5h.ToString());
						}
						else
						{
							MetaXmlBase.StringTag(sb, indent2, text2, stringValue);
						}
						break;
					}
					case DataType.Structure:
					{
						byte unk_5h = psoStructureEntryInfo.Unk_5h;
						if (unk_5h != 0)
						{
							if (unk_5h - 3 > 1)
							{
								MetaXmlBase.ErrorXml(sb, indent2, text2 + ": Unexpected Structure subtype: " + psoStructureEntryInfo.Unk_5h.ToString());
							}
							else
							{
								PsoPOINTER psoPOINTER = MetaUtils.ConvertData<PsoPOINTER>(data, num2);
								psoPOINTER.SwapEnd();
								ushort blockID = psoPOINTER.BlockID;
								bool flag2 = true;
								if (blockID <= 0)
								{
									flag2 = false;
								}
								if (blockID > (ushort)cont.Pso.DataMappingSection.EntriesCount)
								{
									flag2 = false;
								}
								if (flag2)
								{
									PsoXml.WriteNode(sb, indent2, cont, (int)psoPOINTER.BlockID, (int)psoPOINTER.ItemOffset, MetaXmlBase.XmlTagMode.None, (MetaName)psoStructureEntryInfo.ReferenceKey);
								}
								else
								{
									MetaXmlBase.SelfClosingTag(sb, indent2, text2);
								}
							}
						}
						else
						{
							MetaXmlBase.OpenTag(sb, indent2, text2, true, "");
							PsoXml.WriteNode(sb, indent2, cont, blockId, offset + (int)psoStructureEntryInfo.DataOffset, MetaXmlBase.XmlTagMode.None, (MetaName)psoStructureEntryInfo.ReferenceKey);
							MetaXmlBase.CloseTag(sb, indent2, text2, true);
						}
						break;
					}
					case DataType.Array:
						PsoXml.WriteArrayNode(sb, indent2, cont, blockId, offset, psoStructureEntryInfo, structureInfo, text2);
						break;
					case DataType.Enum:
					{
						PsoEnumInfo enumInfo = cont.GetEnumInfo((MetaName)psoStructureEntryInfo.ReferenceKey);
						byte unk_5h = psoStructureEntryInfo.Unk_5h;
						if (unk_5h != 0)
						{
							if (unk_5h != 2)
							{
								MetaXmlBase.ErrorXml(sb, indent2, text2 + ": Unexpected Enum subtype: " + psoStructureEntryInfo.Unk_5h.ToString());
							}
							else
							{
								byte val = data[num2];
								PsoEnumEntryInfo psoEnumEntryInfo = enumInfo.FindEntry((int)val);
								MetaXmlBase.StringTag(sb, indent2, text2, MetaXmlBase.HashString((MetaName)((psoEnumEntryInfo != null) ? psoEnumEntryInfo.EntryNameHash : 0)));
							}
						}
						else
						{
							int val2 = MetaUtils.SwapBytes(BitConverter.ToInt32(data, num2));
							PsoEnumEntryInfo psoEnumEntryInfo2 = enumInfo.FindEntry(val2);
							MetaXmlBase.StringTag(sb, indent2, text2, MetaXmlBase.HashString((MetaName)((psoEnumEntryInfo2 != null) ? psoEnumEntryInfo2.EntryNameHash : 0)));
						}
						break;
					}
					case DataType.Flags:
					{
						int referenceKey = psoStructureEntryInfo.ReferenceKey;
						uint id = (uint)(psoStructureEntryInfo.ReferenceKey & 65535);
						PsoStructureEntryInfo entry = structureInfo.GetEntry((int)id);
						PsoEnumInfo psoEnumInfo = null;
						if (entry != null && entry.EntryNameHash == 256)
						{
							psoEnumInfo = cont.GetEnumInfo((MetaName)entry.ReferenceKey);
						}
						if (psoEnumInfo == null)
						{
							psoEnumInfo = cont.GetEnumInfo((MetaName)psoStructureEntryInfo.EntryNameHash);
						}
						uint? num3 = null;
						switch (psoStructureEntryInfo.Unk_5h)
						{
						case 0:
							num3 = new uint?(MetaUtils.SwapBytes(BitConverter.ToUInt32(data, num2)));
							break;
						case 1:
							num3 = new uint?((uint)MetaUtils.SwapBytes(BitConverter.ToUInt16(data, num2)));
							break;
						case 2:
							num3 = new uint?((uint)data[num2]);
							break;
						default:
							MetaXmlBase.ErrorXml(sb, indent2, text2 + ": Unexpected Flags subtype: " + psoStructureEntryInfo.Unk_5h.ToString());
							break;
						}
						if (num3 != null)
						{
							uint value = num3.Value;
							if (psoEnumInfo != null)
							{
								string text3 = "";
								for (int j = 0; j < psoEnumInfo.EntriesCount; j++)
								{
									PsoEnumEntryInfo psoEnumEntryInfo3 = psoEnumInfo.Entries[j];
									int num4 = 1 << psoEnumEntryInfo3.EntryKey;
									if (((ulong)value & (ulong)((long)num4)) > 0UL)
									{
										if (text3 != "")
										{
											text3 += " ";
										}
										text3 += MetaXmlBase.HashString((MetaName)psoEnumEntryInfo3.EntryNameHash);
									}
								}
								MetaXmlBase.StringTag(sb, indent2, text2, text3);
							}
							else if (value != 0U)
							{
								MetaXmlBase.ValueTag(sb, indent2, text2, value.ToString());
							}
							else
							{
								MetaXmlBase.SelfClosingTag(sb, indent2, text2);
							}
						}
						break;
					}
					case DataType.Map:
						PsoXml.WriteMapNode(sb, indent, cont, num2, psoStructureEntryInfo, structureInfo, text2);
						break;
					default:
						MetaXmlBase.ErrorXml(sb, indent2, text2 + ": Unexpected entry DataType: " + psoStructureEntryInfo.Type.ToString());
						break;
					case DataType.Float3a:
					{
						Vector3 vector4 = MetaUtils.SwapBytes(MetaUtils.ConvertData<Vector3>(data, num2));
						MetaXmlBase.SelfClosingTag(sb, indent2, string.Concat(new string[]
						{
							text2,
							" x=\"",
							FloatUtil.ToString(vector4.X),
							"\" y=\"",
							FloatUtil.ToString(vector4.Y),
							"\" z=\"",
							FloatUtil.ToString(vector4.Z),
							"\""
						}));
						break;
					}
					case DataType.Float4a:
					{
						Vector3 vector5 = MetaUtils.SwapBytes(MetaUtils.ConvertData<Vector3>(data, num2));
						MetaXmlBase.SelfClosingTag(sb, indent2, string.Concat(new string[]
						{
							text2,
							" x=\"",
							FloatUtil.ToString(vector5.X),
							"\" y=\"",
							FloatUtil.ToString(vector5.Y),
							"\" z=\"",
							FloatUtil.ToString(vector5.Z),
							"\""
						}));
						break;
					}
					case DataType.HFloat:
						MetaXmlBase.ValueTag(sb, indent2, text2, MetaUtils.SwapBytes(BitConverter.ToUInt16(data, num2)).ToString());
						break;
					case DataType.Long:
						MetaXmlBase.ValueTag(sb, indent2, text2, MetaUtils.SwapBytes(BitConverter.ToUInt64(data, num2)).ToString());
						break;
					}
				}
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

		// Token: 0x06000647 RID: 1607 RVA: 0x00029BCC File Offset: 0x00027DCC
		private static void WriteArrayNode(StringBuilder sb, int indent, PsoXml.PsoCont cont, int blockId, int offset, PsoStructureEntryInfo entry, PsoStructureInfo estruct, string ename)
		{
			PsoDataMappingEntry block = cont.Pso.GetBlock(blockId);
			int offset2 = offset + block.Offset + (int)entry.DataOffset;
			int num = offset + (int)entry.DataOffset;
			int num2 = blockId;
			uint num3 = (uint)entry.ReferenceKey >> 16 & 65535U;
			int indent2 = indent + 1;
			PsoStructureEntryInfo entry2 = estruct.GetEntry(entry.ReferenceKey & 65535);
			if (entry2 == null)
			{
				MetaXmlBase.ErrorXml(sb, indent, "ARRAYINFO not found for " + ename + "!");
				return;
			}
			byte[] data = cont.Pso.DataSection.Data;
			byte unk_5h = entry.Unk_5h;
			switch (unk_5h)
			{
			case 0:
			{
				Array_Structure array_Structure = MetaUtils.ConvertData<Array_Structure>(data, offset2);
				array_Structure.SwapEnd();
				num2 = (int)array_Structure.PointerDataId;
				num = (int)array_Structure.PointerDataOffset;
				num3 = (uint)array_Structure.Count1;
				goto IL_13D;
			}
			case 1:
			case 2:
				goto IL_13D;
			case 3:
				break;
			case 4:
				if (entry2.Unk_5h == 3)
				{
					Array_Structure array_Structure2 = MetaUtils.ConvertData<Array_Structure>(data, offset2);
					array_Structure2.SwapEnd();
					num2 = (int)array_Structure2.PointerDataId;
					num = (int)array_Structure2.PointerDataOffset;
					num3 = (uint)array_Structure2.Count1;
					goto IL_13D;
				}
				goto IL_13D;
			default:
				if (unk_5h == 129)
				{
					goto IL_13D;
				}
				break;
			}
			MetaXmlBase.ErrorXml(sb, indent, ename + ": WIP! Unsupported Array subtype: " + entry.Unk_5h.ToString());
			IL_13D:
			switch (entry2.Type)
			{
			case DataType.Bool:
			{
				byte[] array = new byte[num3];
				if (num3 > 0U)
				{
					int srcOffset = cont.Pso.GetBlock(num2).Offset + num;
					Buffer.BlockCopy(data, srcOffset, array, 0, (int)num3);
				}
				MetaXmlBase.WriteRawArray<byte>(sb, array, indent, ename, "boolean", null, 10);
				return;
			}
			default:
				MetaXmlBase.ErrorXml(sb, indent, ename + ": WIP! Unsupported array entry DataType: " + entry2.Type.ToString());
				return;
			case DataType.UByte:
			{
				byte[] array2 = new byte[num3];
				if (num3 > 0U)
				{
					int srcOffset2 = cont.Pso.GetBlock(num2).Offset + num;
					Buffer.BlockCopy(data, srcOffset2, array2, 0, (int)num3);
				}
				MetaXmlBase.WriteRawArray<byte>(sb, array2, indent, ename, "byte", null, 10);
				return;
			}
			case DataType.UShort:
			{
				Array_Structure arr = MetaUtils.ConvertData<Array_Structure>(data, offset2);
				arr.SwapEnd();
				ushort[] ushortArray = PsoUtils.GetUShortArray(cont.Pso, arr);
				MetaXmlBase.WriteRawArray<ushort>(sb, ushortArray, indent, ename, "ushort", null, 10);
				return;
			}
			case DataType.SInt:
			{
				Array_uint arr2 = MetaUtils.ConvertData<Array_uint>(data, offset2);
				arr2.SwapEnd();
				uint[] uintArray = PsoUtils.GetUintArray(cont.Pso, arr2);
				MetaXmlBase.WriteRawArray<uint>(sb, uintArray, indent, ename, "int", null, 10);
				return;
			}
			case DataType.UInt:
			{
				int[] arr3 = MetaUtils.ConvertDataArray<int>(data, offset2, (int)num3);
				MetaXmlBase.WriteRawArray<int>(sb, arr3, indent, ename, "int", null, 10);
				return;
			}
			case DataType.Float:
			{
				Array_float arr4 = MetaUtils.ConvertData<Array_float>(data, offset2);
				arr4.SwapEnd();
				float[] floatArray = PsoUtils.GetFloatArray(cont.Pso, arr4);
				MetaXmlBase.WriteRawArray<float>(sb, floatArray, indent, ename, "float", null, 10);
				return;
			}
			case DataType.Float2:
			{
				num3 = ((uint)entry.ReferenceKey >> 16 & 65535U);
				string text = ename + " itemType=\"Vector2\"";
				Vector2[] arr5 = MetaUtils.ConvertDataArray<Vector2>(data, offset2, (int)num3);
				MetaXmlBase.WriteRawArray<Vector2>(sb, arr5, indent, ename, "Vector2", new Func<Vector2, string>(MetaXmlBase.FormatVector2Swap), 1);
				return;
			}
			case DataType.Float3:
			{
				num3 = ((uint)entry.ReferenceKey >> 16 & 65535U);
				string text = ename + " itemType=\"Vector3\"";
				Vector4[] arr6 = MetaUtils.ConvertDataArray<Vector4>(data, offset2, (int)num3);
				MetaXmlBase.WriteRawArray<Vector4>(sb, arr6, indent, ename, "Vector3", new Func<Vector4, string>(MetaXmlBase.FormatVector4SwapXYZOnly), 1);
				return;
			}
			case DataType.String:
			{
				if (entry.Unk_5h != 0)
				{
					MetaXmlBase.ErrorXml(sb, indent, ename + ": Unexpected String array subtype: " + entry.Unk_5h.ToString());
					return;
				}
				Array_uint arr7 = MetaUtils.ConvertData<Array_uint>(data, offset2);
				arr7.SwapEnd();
				MetaName[] hashArray = PsoUtils.GetHashArray(cont.Pso, arr7);
				MetaXmlBase.WriteItemArray<MetaName>(sb, hashArray, indent, ename, "Hash", new Func<MetaName, string>(MetaXmlBase.HashString));
				return;
			}
			case DataType.Structure:
			{
				unk_5h = entry2.Unk_5h;
				if (unk_5h != 0 && unk_5h == 3)
				{
					Array_StructurePointer array3 = MetaUtils.ConvertData<Array_StructurePointer>(data, offset2);
					array3.SwapEnd();
					num2 = (int)array3.PointerDataId;
					num = (int)array3.PointerDataOffset;
					num3 = (uint)array3.Count1;
					if (num3 > 0U)
					{
						PsoPOINTER[] pointerArray = PsoUtils.GetPointerArray(cont.Pso, array3);
						MetaXmlBase.OpenTag(sb, indent, ename, true, "");
						int num4 = 0;
						while ((long)num4 < (long)((ulong)num3))
						{
							PsoPOINTER psoPOINTER = pointerArray[num4];
							PsoXml.WriteNode(sb, indent2, cont, (int)psoPOINTER.BlockID, (int)psoPOINTER.ItemOffset, MetaXmlBase.XmlTagMode.ItemAndType, (MetaName)0);
							num4++;
						}
						MetaXmlBase.CloseTag(sb, indent, ename, true);
					}
				}
				string text = ename + " itemType=\"" + MetaXmlBase.HashString((MetaName)entry2.ReferenceKey) + "\"";
				if (num3 <= 0U)
				{
					MetaXmlBase.SelfClosingTag(sb, indent, text);
					return;
				}
				PsoDataMappingEntry block2 = cont.Pso.GetBlock(num2);
				PsoStructureInfo structureInfo = cont.GetStructureInfo((MetaName)entry2.ReferenceKey);
				if (block2 == null)
				{
					MetaXmlBase.ErrorXml(sb, indent, ename + ": Array block not found: " + num2.ToString());
					return;
				}
				if (block2.NameHash != 12)
				{
					MetaXmlBase.OpenTag(sb, indent, text, true, "");
					if (structureInfo == null)
					{
						MetaXmlBase.ErrorXml(sb, indent, ename + ": Array type not found: " + MetaXmlBase.HashString((MetaName)entry2.ReferenceKey));
					}
					else
					{
						int num5 = 0;
						while ((long)num5 < (long)((ulong)num3))
						{
							PsoXml.WriteNode(sb, indent2, cont, num2, num, MetaXmlBase.XmlTagMode.Item, (MetaName)entry2.ReferenceKey);
							num += structureInfo.StructureLength;
							if ((long)num5 < (long)((ulong)(num3 - 1U)) && block2 != null && num >= block2.Length)
							{
								break;
							}
							num5++;
						}
					}
					MetaXmlBase.CloseTag(sb, indent, ename, true);
					return;
				}
				break;
			}
			case DataType.Array:
			{
				int num6 = entry.ReferenceKey >> 16 & 65535;
				if (num6 > 0)
				{
					num = offset + (int)entry.DataOffset;
					MetaXmlBase.OpenTag(sb, indent, ename, true, "");
					for (int i = 0; i < num6; i++)
					{
						PsoXml.WriteArrayNode(sb, indent2, cont, blockId, num, entry2, estruct, "Item");
						num += 16;
					}
					MetaXmlBase.CloseTag(sb, indent, ename, true);
					return;
				}
				MetaXmlBase.SelfClosingTag(sb, indent, ename);
				return;
			}
			case DataType.Enum:
			{
				Array_uint arr8 = MetaUtils.ConvertData<Array_uint>(data, offset2);
				arr8.SwapEnd();
				uint[] uintArray2 = PsoUtils.GetUintArray(cont.Pso, arr8);
				PsoEnumInfo enumDef = cont.GetEnumInfo((MetaName)entry2.ReferenceKey);
				MetaXmlBase.WriteItemArray<uint>(sb, uintArray2, indent, ename, "enum", delegate(uint ie)
				{
					PsoEnumInfo enumDef = enumDef;
					PsoEnumEntryInfo psoEnumEntryInfo = (enumDef != null) ? enumDef.FindEntry((int)ie) : null;
					return MetaXmlBase.HashString((MetaName)((psoEnumEntryInfo != null) ? psoEnumEntryInfo.EntryNameHash : 0));
				});
				break;
			}
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0002A23C File Offset: 0x0002843C
		private static void WriteMapNode(StringBuilder sb, int indent, PsoXml.PsoCont cont, int eoffset, PsoStructureEntryInfo entry, PsoStructureInfo structInfo, string ename)
		{
			int indent2 = indent + 1;
			byte[] data = cont.Pso.DataSection.Data;
			if (entry.Unk_5h != 1)
			{
				MetaXmlBase.ErrorXml(sb, indent2, ename + ": Unexpected Map subtype: " + entry.Unk_5h.ToString());
				return;
			}
			int index = entry.ReferenceKey & 65535;
			int index2 = entry.ReferenceKey >> 16 & 65535;
			PsoStructureEntryInfo psoStructureEntryInfo = structInfo.Entries[index2];
			PsoStructureEntryInfo psoStructureEntryInfo2 = structInfo.Entries[index];
			int num = MetaUtils.SwapBytes(BitConverter.ToInt32(data, eoffset));
			int num2 = MetaUtils.SwapBytes(BitConverter.ToInt32(data, eoffset + 4));
			int num3 = MetaUtils.SwapBytes(BitConverter.ToInt32(data, eoffset + 8));
			int num4 = MetaUtils.SwapBytes(BitConverter.ToInt32(data, eoffset + 12));
			int num5 = MetaUtils.SwapBytes(BitConverter.ToInt32(data, eoffset + 16));
			MetaUtils.SwapBytes(BitConverter.ToInt32(data, eoffset + 20));
			int id = num3 & 4095;
			int num6 = num3 >> 12 & 1048575;
			int num7 = num5 & 65535;
			int num8 = num5 >> 16 & 65535;
			PsoDataMappingEntry block = cont.Pso.GetBlock(id);
			if (block == null && num7 > 0)
			{
				MetaXmlBase.ErrorXml(sb, indent2, ename + ": Couldn't find Map xBlock: " + id.ToString());
				return;
			}
			if (num7 <= 0)
			{
				MetaXmlBase.SelfClosingTag(sb, indent2, ename);
				return;
			}
			PsoStructureInfo structureInfo = cont.GetStructureInfo((MetaName)block.NameHash);
			int num9 = num6;
			int indent3 = indent + 1;
			int indent4 = indent + 2;
			PsoStructureEntryInfo psoStructureEntryInfo3 = (structureInfo != null) ? structureInfo.FindEntry(MetaName.Key) : null;
			PsoStructureEntryInfo psoStructureEntryInfo4 = (structureInfo != null) ? structureInfo.FindEntry(MetaName.Item) : null;
			if (structureInfo == null && block.NameHash == 0)
			{
				MetaXmlBase.SelfClosingTag(sb, indent2, ename);
				return;
			}
			if (structureInfo == null)
			{
				MetaXmlBase.ErrorXml(sb, indent4, ename + ": Map struct type not found: " + MetaXmlBase.HashString((MetaName)block.NameHash));
				return;
			}
			if (structureInfo.IndexInfo == null)
			{
				MetaXmlBase.ErrorXml(sb, indent4, ename + ": Map struct was missing IndexInfo! " + ((structureInfo == null) ? "" : structureInfo.ToString()));
				return;
			}
			if (psoStructureEntryInfo3 == null || psoStructureEntryInfo4 == null)
			{
				MetaXmlBase.ErrorXml(sb, indent4, ename + ": Map Key/Item entries not found!");
				return;
			}
			if (psoStructureEntryInfo3.Type != DataType.String)
			{
				MetaXmlBase.ErrorXml(sb, indent4, ename + ": Map Key was not a string!");
				return;
			}
			if (psoStructureEntryInfo4.Type != DataType.Structure)
			{
				MetaXmlBase.ErrorXml(sb, indent4, ename + ": Map Item was not a structure!");
				return;
			}
			if (psoStructureEntryInfo4.Unk_5h != 3)
			{
				MetaXmlBase.ErrorXml(sb, indent4, ename + ": Map Item was not a structure pointer - TODO!");
				return;
			}
			MetaXmlBase.OpenTag(sb, indent3, ename, true, "");
			int num10 = num9;
			int num11 = num7;
			for (int i = 0; i < num11; i++)
			{
				int num12 = num10 + block.Offset;
				int eoffset2 = num12 + (int)psoStructureEntryInfo3.DataOffset;
				int offset = num12 + (int)psoStructureEntryInfo4.DataOffset;
				string stringValue = PsoXml.GetStringValue(cont.Pso, psoStructureEntryInfo3, data, eoffset2);
				PsoPOINTER psoPOINTER = MetaUtils.ConvertData<PsoPOINTER>(data, offset);
				psoPOINTER.SwapEnd();
				PsoDataMappingEntry block2 = cont.Pso.GetBlock((int)psoPOINTER.BlockID);
				if (block2 == null)
				{
					MetaXmlBase.OpenTag(sb, indent4, string.Concat(new string[]
					{
						"Item type=\"",
						MetaXmlBase.HashString((MetaName)entry.ReferenceKey),
						"\" key=\"",
						stringValue,
						"\""
					}), true, "");
					PsoXml.WriteNode(sb, indent4, cont, (int)psoPOINTER.BlockID, (int)psoPOINTER.ItemOffset, MetaXmlBase.XmlTagMode.None, (MetaName)entry.ReferenceKey);
					MetaXmlBase.CloseTag(sb, indent4, "Item", true);
				}
				else
				{
					string name = string.Concat(new string[]
					{
						"Item type=\"",
						MetaXmlBase.HashString((MetaName)block2.NameHash),
						"\" key=\"",
						stringValue,
						"\""
					});
					PsoStructureInfo structureInfo2 = cont.GetStructureInfo((MetaName)block2.NameHash);
					short? num13 = (structureInfo2 != null) ? new short?(structureInfo2.EntriesCount) : null;
					int? num14 = (num13 != null) ? new int?((int)num13.GetValueOrDefault()) : null;
					int num15 = 0;
					if (num14.GetValueOrDefault() == num15 & num14 != null)
					{
						MetaXmlBase.OpenTag(sb, indent4, name, true, "");
						MetaXmlBase.CloseTag(sb, indent4, "Item", true);
					}
					else
					{
						MetaXmlBase.OpenTag(sb, indent4, name, true, "");
						PsoXml.WriteNode(sb, indent4, cont, (int)psoPOINTER.BlockID, (int)psoPOINTER.ItemOffset, MetaXmlBase.XmlTagMode.None, (MetaName)0);
						MetaXmlBase.CloseTag(sb, indent4, "Item", true);
					}
				}
				num10 += structureInfo.StructureLength;
				if (i < num11 - 1 && block != null && num6 >= block.Length)
				{
					MetaXmlBase.ErrorXml(sb, indent4, "Offset out of range! Count is " + num11.ToString());
					break;
				}
			}
			MetaXmlBase.CloseTag(sb, indent3, ename, true);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0002A714 File Offset: 0x00028914
		private static string GetStringValue(PsoFile pso, PsoStructureEntryInfo entry, byte[] data, int eoffset)
		{
			switch (entry.Unk_5h)
			{
			case 0:
			{
				int count = entry.ReferenceKey >> 16 & 65535;
				return Encoding.ASCII.GetString(data, eoffset, count).Replace("\0", "");
			}
			case 1:
			case 2:
			{
				DataBlockPointer ptr = MetaUtils.ConvertData<DataBlockPointer>(data, eoffset);
				ptr.SwapEnd();
				return PsoUtils.GetString(pso, ptr);
			}
			case 3:
			{
				CharPointer ptr2 = MetaUtils.ConvertData<CharPointer>(data, eoffset);
				ptr2.SwapEnd();
				return PsoUtils.GetString(pso, ptr2) ?? "";
			}
			default:
				return null;
			case 7:
			case 8:
				return MetaXmlBase.HashString((MetaName)MetaUtils.SwapBytes(MetaUtils.ConvertData<uint>(data, eoffset)));
			}
		}

		// Token: 0x020002C1 RID: 705
		public class PsoCont
		{
			// Token: 0x170002DB RID: 731
			// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0008A8E0 File Offset: 0x00088AE0
			// (set) Token: 0x06000C8B RID: 3211 RVA: 0x0008A8E8 File Offset: 0x00088AE8
			public PsoFile Pso { get; set; }

			// Token: 0x06000C8C RID: 3212 RVA: 0x0008A8F4 File Offset: 0x00088AF4
			public PsoCont(PsoFile pso)
			{
				this.Pso = pso;
				if (pso.DefinitionSection == null || pso.DefinitionSection.Entries == null || pso.DefinitionSection.EntriesIdx == null)
				{
					return;
				}
				for (int i = 0; i < pso.DefinitionSection.Entries.Count; i++)
				{
					PsoElementInfo psoElementInfo = pso.DefinitionSection.Entries[i];
					PsoEnumInfo psoEnumInfo = psoElementInfo as PsoEnumInfo;
					PsoStructureInfo psoStructureInfo = psoElementInfo as PsoStructureInfo;
					if (psoEnumInfo != null)
					{
						if (!this.EnumDict.ContainsKey((MetaName)psoEnumInfo.IndexInfo.NameHash))
						{
							this.EnumDict.Add((MetaName)psoEnumInfo.IndexInfo.NameHash, psoEnumInfo);
						}
					}
					else if (psoStructureInfo != null && !this.StructDict.ContainsKey((MetaName)psoStructureInfo.IndexInfo.NameHash))
					{
						this.StructDict.Add((MetaName)psoStructureInfo.IndexInfo.NameHash, psoStructureInfo);
					}
				}
			}

			// Token: 0x06000C8D RID: 3213 RVA: 0x0008A9EC File Offset: 0x00088BEC
			public PsoStructureInfo GetStructureInfo(MetaName name)
			{
				PsoStructureInfo result = null;
				this.StructDict.TryGetValue(name, out result);
				return result;
			}

			// Token: 0x06000C8E RID: 3214 RVA: 0x0008AA0C File Offset: 0x00088C0C
			public PsoEnumInfo GetEnumInfo(MetaName name)
			{
				PsoEnumInfo result = null;
				this.EnumDict.TryGetValue(name, out result);
				return result;
			}

			// Token: 0x04004101 RID: 16641
			public Dictionary<MetaName, PsoEnumInfo> EnumDict = new Dictionary<MetaName, PsoEnumInfo>();

			// Token: 0x04004102 RID: 16642
			public Dictionary<MetaName, PsoStructureInfo> StructDict = new Dictionary<MetaName, PsoStructureInfo>();
		}
	}
}
