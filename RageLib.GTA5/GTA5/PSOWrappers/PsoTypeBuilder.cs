using System;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Types;

namespace RageLib.GTA5.PSOWrappers
{
	// Token: 0x02000273 RID: 627
	public static class PsoTypeBuilder
	{
		// Token: 0x06000A8E RID: 2702 RVA: 0x00081EE8 File Offset: 0x000800E8
		public static IPsoValue Make(PsoFile pso, PsoStructureInfo structureInfo, PsoStructureEntryInfo entryInfo)
		{
			switch (entryInfo.Type)
			{
			case DataType.Bool:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoBoolean();
				}
				throw new Exception("Unsupported boolean type.");
			case DataType.SByte:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoXXByte();
				}
				throw new Exception("Unsupported PsoType1 type.");
			case DataType.UByte:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoByte();
				}
				throw new Exception("Unsupported PsoByte type.");
			case DataType.SShort:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoType3();
				}
				throw new Exception("Unsupported PsoType3 type.");
			case DataType.UShort:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoType4();
				}
				throw new Exception("Unsupported PsoType4 type.");
			case DataType.SInt:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoType5();
				}
				throw new Exception("Unsupported PsoType5 type.");
			case DataType.UInt:
			{
				byte unk_5h = entryInfo.Unk_5h;
				if (unk_5h == 0)
				{
					return new PsoIntSigned();
				}
				if (unk_5h != 1)
				{
					throw new Exception("Unsupported integer type.");
				}
				return new PsoIntUnsigned();
			}
			case DataType.Float:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoFloat();
				}
				throw new Exception("Unsupported float type.");
			case DataType.Float2:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoFloat2();
				}
				throw new Exception("Unsupported float2 type.");
			case DataType.Float3:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoFloat4A();
				}
				throw new Exception("Unsupported float3 type.");
			case DataType.Float4:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoFloat4B();
				}
				throw new Exception("Unsupported float4 type.");
			case DataType.String:
				switch (entryInfo.Unk_5h)
				{
				case 0:
					return new PsoString0(entryInfo.ReferenceKey >> 16 & 65535);
				case 1:
					return new PsoString1();
				case 2:
					return new PsoString2();
				case 3:
					return new PsoString3();
				case 7:
					return new PsoString7();
				case 8:
					return new PsoString8();
				}
				throw new Exception("Unsupported string type.");
			case DataType.Structure:
			{
				byte unk_5h = entryInfo.Unk_5h;
				if (unk_5h == 0)
				{
					PsoStructureInfo structureInfo2 = PsoTypeBuilder.GetStructureInfo(pso, entryInfo.ReferenceKey);
					PsoElementIndexInfo structureIndexInfo = PsoTypeBuilder.GetStructureIndexInfo(pso, entryInfo.ReferenceKey);
					return new PsoStructure(pso, structureInfo2, structureIndexInfo, entryInfo);
				}
				if (unk_5h != 3)
				{
					throw new Exception("Unsupported structure type.");
				}
				return new PsoStructure3(pso, structureInfo, entryInfo);
			}
			case DataType.Array:
				switch (entryInfo.Unk_5h)
				{
				case 0:
				{
					PsoStructureEntryInfo entryInfo2 = structureInfo.Entries[entryInfo.ReferenceKey & 65535];
					return new PsoArray0(pso, structureInfo, entryInfo2);
				}
				case 1:
				{
					int index = entryInfo.ReferenceKey & 65535;
					int numberOfEntries = entryInfo.ReferenceKey >> 16 & 65535;
					PsoStructureEntryInfo entryInfo3 = structureInfo.Entries[index];
					return new PsoArray1(pso, structureInfo, entryInfo3, numberOfEntries);
				}
				case 4:
				{
					int index2 = entryInfo.ReferenceKey & 65535;
					int numberOfEntries2 = entryInfo.ReferenceKey >> 16 & 65535;
					PsoStructureEntryInfo entryInfo4 = structureInfo.Entries[index2];
					return new PsoArray4(pso, structureInfo, entryInfo4, numberOfEntries2);
				}
				}
				throw new Exception("Unsupported array type.");
			case DataType.Enum:
			{
				byte unk_5h = entryInfo.Unk_5h;
				if (unk_5h == 0)
				{
					return new PsoEnumInt
					{
						TypeInfo = PsoTypeBuilder.GetEnumInfo(pso, entryInfo.ReferenceKey)
					};
				}
				if (unk_5h != 2)
				{
					throw new Exception("Unsupported enum type.");
				}
				return new PsoEnumByte
				{
					TypeInfo = PsoTypeBuilder.GetEnumInfo(pso, entryInfo.ReferenceKey)
				};
			}
			case DataType.Flags:
				switch (entryInfo.Unk_5h)
				{
				case 0:
				{
					PsoFlagsInt psoFlagsInt = new PsoFlagsInt();
					int num = entryInfo.ReferenceKey & 65535;
					if (num != 4095)
					{
						PsoStructureEntryInfo psoStructureEntryInfo = structureInfo.Entries[num];
						psoFlagsInt.TypeInfo = PsoTypeBuilder.GetEnumInfo(pso, psoStructureEntryInfo.ReferenceKey);
					}
					return psoFlagsInt;
				}
				case 1:
				{
					PsoFlagsShort psoFlagsShort = new PsoFlagsShort();
					int index3 = entryInfo.ReferenceKey & 65535;
					PsoStructureEntryInfo psoStructureEntryInfo2 = structureInfo.Entries[index3];
					psoFlagsShort.TypeInfo = PsoTypeBuilder.GetEnumInfo(pso, psoStructureEntryInfo2.ReferenceKey);
					return psoFlagsShort;
				}
				case 2:
				{
					PsoFlagsByte psoFlagsByte = new PsoFlagsByte();
					int index4 = entryInfo.ReferenceKey & 65535;
					PsoStructureEntryInfo psoStructureEntryInfo3 = structureInfo.Entries[index4];
					psoFlagsByte.TypeInfo = PsoTypeBuilder.GetEnumInfo(pso, psoStructureEntryInfo3.ReferenceKey);
					return psoFlagsByte;
				}
				default:
					throw new Exception("Unsupported flags type.");
				}
				break;
			case DataType.Map:
				if (entryInfo.Unk_5h == 1)
				{
					int index5 = entryInfo.ReferenceKey & 65535;
					int index6 = entryInfo.ReferenceKey >> 16 & 65535;
					PsoStructureEntryInfo keyEntryInfo = structureInfo.Entries[index6];
					PsoStructureEntryInfo valueEntryInfo = structureInfo.Entries[index5];
					return new PsoMap(pso, structureInfo, keyEntryInfo, valueEntryInfo);
				}
				throw new Exception("Unsupported PsoType5 type.");
			case DataType.Float3a:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoFloat3();
				}
				throw new Exception("Unsupported PsoType20 type.");
			case DataType.Float4a:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoType9();
				}
				throw new Exception("Unsupported PsoType9 type.");
			case DataType.HFloat:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoXXHalf();
				}
				throw new Exception("Unsupported PsoType30 type.");
			case DataType.Long:
				if (entryInfo.Unk_5h == 0)
				{
					return new PsoType32();
				}
				throw new Exception("Unsupported PsoType32 type.");
			}
			throw new Exception("Unsupported type.");
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0008242C File Offset: 0x0008062C
		public static PsoStructureInfo GetStructureInfo(PsoFile meta, int structureKey)
		{
			PsoStructureInfo result = null;
			int num = 0;
			while ((long)num < (long)((ulong)meta.DefinitionSection.Count))
			{
				if (meta.DefinitionSection.EntriesIdx[num].NameHash == structureKey)
				{
					result = (PsoStructureInfo)meta.DefinitionSection.Entries[num];
				}
				num++;
			}
			return result;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00082484 File Offset: 0x00080684
		public static PsoEnumInfo GetEnumInfo(PsoFile meta, int structureKey)
		{
			PsoEnumInfo result = null;
			int num = 0;
			while ((long)num < (long)((ulong)meta.DefinitionSection.Count))
			{
				if (meta.DefinitionSection.EntriesIdx[num].NameHash == structureKey)
				{
					result = (PsoEnumInfo)meta.DefinitionSection.Entries[num];
				}
				num++;
			}
			return result;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000824DC File Offset: 0x000806DC
		public static PsoElementIndexInfo GetStructureIndexInfo(PsoFile meta, int structureKey)
		{
			PsoElementIndexInfo result = null;
			int num = 0;
			while ((long)num < (long)((ulong)meta.DefinitionSection.Count))
			{
				if (meta.DefinitionSection.EntriesIdx[num].NameHash == structureKey)
				{
					result = meta.DefinitionSection.EntriesIdx[num];
				}
				num++;
			}
			return result;
		}
	}
}
