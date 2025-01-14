using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x0200007D RID: 125
	public class MetaBuilderBlock
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000F5EC File Offset: 0x0000D7EC
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
		public MetaName StructureNameHash { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0000F5FD File Offset: 0x0000D7FD
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0000F605 File Offset: 0x0000D805
		public List<byte[]> Items { get; set; } = new List<byte[]>();

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000F60E File Offset: 0x0000D80E
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0000F616 File Offset: 0x0000D816
		public int TotalSize { get; set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000F61F File Offset: 0x0000D81F
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0000F627 File Offset: 0x0000D827
		public int Index { get; set; }

		// Token: 0x06000302 RID: 770 RVA: 0x0000F630 File Offset: 0x0000D830
		public int AddItem(byte[] item)
		{
			int count = this.Items.Count;
			this.Items.Add(item);
			this.TotalSize += item.Length;
			return count;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000F659 File Offset: 0x0000D859
		public uint BasePointer
		{
			get
			{
				return (uint)(this.Index + 1 & 4095);
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000F66C File Offset: 0x0000D86C
		public DataBlock GetMetaDataBlock()
		{
			if (this.TotalSize <= 0)
			{
				return null;
			}
			byte[] array = new byte[this.TotalSize];
			int num = 0;
			for (int i = 0; i < this.Items.Count; i++)
			{
				byte[] array2 = this.Items[i];
				Buffer.BlockCopy(array2, 0, array, num, array2.Length);
				num += array2.Length;
			}
			DataBlock dataBlock = new DataBlock();
			dataBlock.StructureNameHash = this.StructureNameHash;
			dataBlock.DataLength = this.TotalSize;
			dataBlock.Data = new ResourceSimpleArray<byte_r>();
			dataBlock.Data.Data.AddRange(Array.ConvertAll<byte, byte_r>(array, (byte e) => (byte_r)e));
			return dataBlock;
		}
	}
}
