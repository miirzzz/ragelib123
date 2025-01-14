using System;
using System.Collections.Generic;
using System.Text;
using RageLib.Resources.Common;
using SharpDX;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x0200007C RID: 124
	public class MetaBuilder
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x0000ECFC File Offset: 0x0000CEFC
		public MetaBuilderBlock EnsureBlock(MetaName type)
		{
			foreach (MetaBuilderBlock metaBuilderBlock in this.Blocks)
			{
				if (metaBuilderBlock.StructureNameHash == type && metaBuilderBlock.TotalSize < this.MaxBlockLength)
				{
					return metaBuilderBlock;
				}
			}
			MetaBuilderBlock metaBuilderBlock2 = new MetaBuilderBlock();
			metaBuilderBlock2.StructureNameHash = type;
			metaBuilderBlock2.Index = this.Blocks.Count;
			this.Blocks.Add(metaBuilderBlock2);
			return metaBuilderBlock2;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000ED90 File Offset: 0x0000CF90
		public MetaBuilderPointer AddItem<T>(MetaName type, T item) where T : struct
		{
			byte[] data = MetaUtils.ConvertToBytes<T>(item);
			return this.AddItem(type, data);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000EDAC File Offset: 0x0000CFAC
		public MetaBuilderPointer AddItem(MetaName type, byte[] data)
		{
			MetaBuilderBlock metaBuilderBlock = this.EnsureBlock(type);
			int num = data.Length % 16;
			if (num > 0)
			{
				byte[] array = new byte[data.Length - num + 16];
				Buffer.BlockCopy(data, 0, array, 0, data.Length);
				data = array;
			}
			int num2 = metaBuilderBlock.AddItem(data);
			return new MetaBuilderPointer
			{
				BlockID = metaBuilderBlock.Index + 1,
				Offset = num2 * data.Length,
				Length = data.Length
			};
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000EE24 File Offset: 0x0000D024
		public MetaBuilderPointer AddItemArray<T>(MetaName type, T[] items) where T : struct
		{
			byte[] data = MetaUtils.ConvertArrayToBytes<T>(items);
			return this.AddItemArray(type, data, items.Length);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000EE44 File Offset: 0x0000D044
		public MetaBuilderPointer AddItemArray(MetaName type, byte[] data, int length)
		{
			MetaBuilderBlock metaBuilderBlock = this.EnsureBlock(type);
			int num = data.Length;
			int num2 = num;
			int num3 = num2 % 16;
			if (num3 != 0)
			{
				num2 += 16 - num3;
			}
			byte[] array = new byte[num2];
			Buffer.BlockCopy(data, 0, array, 0, num);
			int totalSize = metaBuilderBlock.TotalSize;
			metaBuilderBlock.AddItem(array);
			return new MetaBuilderPointer
			{
				BlockID = metaBuilderBlock.Index + 1,
				Offset = totalSize,
				Length = length
			};
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000EEBC File Offset: 0x0000D0BC
		public MetaBuilderPointer AddString(string str)
		{
			str = (str ?? "");
			MetaBuilderBlock metaBuilderBlock = this.EnsureBlock(MetaName.STRING);
			byte[] bytes = Encoding.ASCII.GetBytes(str);
			int num = bytes.Length;
			int num2 = num;
			int num3 = num2 % 16;
			if (num3 != 0)
			{
				num2 += 16 - num3;
			}
			byte[] array = new byte[num2];
			Buffer.BlockCopy(bytes, 0, array, 0, num);
			int totalSize = metaBuilderBlock.TotalSize;
			metaBuilderBlock.AddItem(array);
			return new MetaBuilderPointer
			{
				BlockID = metaBuilderBlock.Index + 1,
				Offset = totalSize,
				Length = num
			};
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000EF4C File Offset: 0x0000D14C
		public MetaPOINTER AddItemPtr<T>(MetaName type, T item) where T : struct
		{
			MetaBuilderPointer metaBuilderPointer = this.AddItem<T>(type, item);
			return new MetaPOINTER(metaBuilderPointer.BlockID, metaBuilderPointer.Offset, 0U);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000EF78 File Offset: 0x0000D178
		public MetaPOINTER AddItemPtr(MetaName type, byte[] data)
		{
			MetaBuilderPointer metaBuilderPointer = this.AddItem(type, data);
			return new MetaPOINTER(metaBuilderPointer.BlockID, metaBuilderPointer.Offset, 0U);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000EFA4 File Offset: 0x0000D1A4
		public Array_Structure AddItemArrayPtr<T>(MetaName type, T[] items) where T : struct
		{
			if (items == null || items.Length == 0)
			{
				return default(Array_Structure);
			}
			return new Array_Structure(this.AddItemArray<T>(type, items));
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		public Array_Structure AddItemArrayPtr(MetaName type, byte[][] data)
		{
			if (data == null || data.Length == 0)
			{
				return default(Array_Structure);
			}
			int num = 0;
			for (int i = 0; i < data.Length; i++)
			{
				num += data[i].Length;
			}
			byte[] array = new byte[num];
			int num2 = 0;
			for (int j = 0; j < data.Length; j++)
			{
				Buffer.BlockCopy(data[j], 0, array, num2, data[j].Length);
				num2 += data[j].Length;
			}
			return new Array_Structure(this.AddItemArray(type, array, data.Length));
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000F054 File Offset: 0x0000D254
		public Array_Vector3 AddPaddedVector3ArrayPtr(Vector4[] items)
		{
			if (items == null || items.Length == 0)
			{
				return default(Array_Vector3);
			}
			return new Array_Vector3(this.AddItemArray<Vector4>(MetaName.VECTOR4, items));
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000F080 File Offset: 0x0000D280
		public Array_uint AddHashArrayPtr(MetaName[] items)
		{
			if (items == null || items.Length == 0)
			{
				return default(Array_uint);
			}
			uint[] items2 = Array.ConvertAll<MetaName, uint>(items, (MetaName e) => (uint)e);
			return new Array_uint(this.AddItemArray<uint>(MetaName.HASH, items2));
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		public Array_uint AddUintArrayPtr(uint[] items)
		{
			if (items == null || items.Length == 0)
			{
				return default(Array_uint);
			}
			return new Array_uint(this.AddItemArray<uint>(MetaName.UINT, items));
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000F100 File Offset: 0x0000D300
		public Array_ushort AddUshortArrayPtr(ushort[] items)
		{
			if (items == null || items.Length == 0)
			{
				return default(Array_ushort);
			}
			return new Array_ushort(this.AddItemArray<ushort>(MetaName.USHORT, items));
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000F12C File Offset: 0x0000D32C
		public Array_byte AddByteArrayPtr(byte[] items)
		{
			if (items == null || items.Length == 0)
			{
				return default(Array_byte);
			}
			return new Array_byte(this.AddItemArray<byte>(MetaName.BYTE, items));
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000F158 File Offset: 0x0000D358
		public Array_float AddFloatArrayPtr(float[] items)
		{
			if (items == null || items.Length == 0)
			{
				return default(Array_float);
			}
			return new Array_float(this.AddItemArray<float>(MetaName.FLOAT, items));
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000F184 File Offset: 0x0000D384
		public CharPointer AddStringPtr(string str)
		{
			return new CharPointer(this.AddString(str));
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000F194 File Offset: 0x0000D394
		public Array_StructurePointer AddPointerArray(MetaPOINTER[] arr)
		{
			if (arr == null || arr.Length == 0)
			{
				return default(Array_StructurePointer);
			}
			MetaBuilderPointer metaBuilderPointer = this.AddItemArray<MetaPOINTER>(MetaName.POINTER, arr);
			Array_StructurePointer result = default(Array_StructurePointer);
			result.Count1 = (ushort)arr.Length;
			result.Count2 = result.Count1;
			result.Pointer = metaBuilderPointer.Pointer;
			return result;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000F1EC File Offset: 0x0000D3EC
		public Array_StructurePointer AddItemPointerArrayPtr<T>(MetaName type, T[] items) where T : struct
		{
			if (items == null || items.Length == 0)
			{
				return default(Array_StructurePointer);
			}
			MetaPOINTER[] array = new MetaPOINTER[items.Length];
			for (int i = 0; i < items.Length; i++)
			{
				array[i] = this.AddItemPtr<T>(type, items[i]);
			}
			return this.AddPointerArray(array);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000F240 File Offset: 0x0000D440
		public Array_StructurePointer AddWrapperArrayPtr(MetaWrapper[] items)
		{
			if (items == null || items.Length == 0)
			{
				return default(Array_StructurePointer);
			}
			MetaPOINTER[] array = new MetaPOINTER[items.Length];
			for (int i = 0; i < items.Length; i++)
			{
				array[i] = items[i].Save(this);
			}
			return this.AddPointerArray(array);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000F28C File Offset: 0x0000D48C
		public Array_Structure AddWrapperArray(MetaWrapper[] items)
		{
			if (items == null || items.Length == 0)
			{
				return default(Array_Structure);
			}
			Array_Structure result = default(Array_Structure);
			result.Count1 = (ushort)items.Length;
			result.Count2 = result.Count1;
			for (int i = 0; i < items.Length; i++)
			{
				MetaPOINTER metaPOINTER = items[i].Save(this);
				if (i == 0)
				{
					MetaBuilderPointer metaBuilderPointer = default(MetaBuilderPointer);
					metaBuilderPointer.BlockID = metaPOINTER.BlockID;
					metaBuilderPointer.Offset = metaPOINTER.Offset;
					result.Pointer = metaBuilderPointer.Pointer;
				}
			}
			return result;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000F31C File Offset: 0x0000D51C
		public byte[] GetData()
		{
			int num = 0;
			for (int i = 0; i < this.Blocks.Count; i++)
			{
				num += this.Blocks[i].TotalSize;
			}
			byte[] array = new byte[num];
			int num2 = 0;
			for (int j = 0; j < this.Blocks.Count; j++)
			{
				MetaBuilderBlock metaBuilderBlock = this.Blocks[j];
				for (int k = 0; k < metaBuilderBlock.Items.Count; k++)
				{
					byte[] array2 = metaBuilderBlock.Items[k];
					Buffer.BlockCopy(array2, 0, array, num2, array2.Length);
					num2 += array2.Length;
				}
			}
			int num3 = array.Length;
			return array;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000F3D0 File Offset: 0x0000D5D0
		public void AddStructureInfo(MetaName name)
		{
			if (!this.StructureInfos.ContainsKey(name))
			{
				StructureInfo structureInfo = MetaInfo.GetStructureInfo(name);
				if (structureInfo != null)
				{
					this.StructureInfos[name] = structureInfo;
				}
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000F404 File Offset: 0x0000D604
		public void AddEnumInfo(MetaName name)
		{
			if (!this.EnumInfos.ContainsKey(name))
			{
				EnumInfo enumInfo = MetaInfo.GetEnumInfo(name);
				if (enumInfo != null)
				{
					this.EnumInfos[name] = enumInfo;
				}
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000F438 File Offset: 0x0000D638
		public MetaFile GetMeta(string metaName = "")
		{
			MetaFile metaFile = new MetaFile();
			metaFile.Unknown_10h = 1347568688;
			metaFile.Unknown_14h = 121;
			metaFile.RootBlockIndex = 1;
			metaFile.StructureInfos = new ResourceSimpleArray<StructureInfo>();
			foreach (StructureInfo item in this.StructureInfos.Values)
			{
				metaFile.StructureInfos.Add(item);
			}
			metaFile.StructureInfosCount = (short)metaFile.StructureInfos.Count;
			metaFile.EnumInfos = new ResourceSimpleArray<EnumInfo>();
			foreach (EnumInfo item2 in this.EnumInfos.Values)
			{
				metaFile.EnumInfos.Add(item2);
			}
			metaFile.EnumInfosCount = (short)metaFile.EnumInfos.Count;
			metaFile.DataBlocks = new ResourceSimpleArray<DataBlock>();
			foreach (MetaBuilderBlock metaBuilderBlock in this.Blocks)
			{
				metaFile.DataBlocks.Add(metaBuilderBlock.GetMetaDataBlock());
			}
			metaFile.DataBlocksCount = (short)metaFile.DataBlocks.Count;
			metaFile.Name = (string_r)metaName;
			return metaFile;
		}

		// Token: 0x0400058F RID: 1423
		private List<MetaBuilderBlock> Blocks = new List<MetaBuilderBlock>();

		// Token: 0x04000590 RID: 1424
		private int MaxBlockLength = 16384;

		// Token: 0x04000591 RID: 1425
		private Dictionary<MetaName, StructureInfo> StructureInfos = new Dictionary<MetaName, StructureInfo>();

		// Token: 0x04000592 RID: 1426
		private Dictionary<MetaName, EnumInfo> EnumInfos = new Dictionary<MetaName, EnumInfo>();
	}
}
