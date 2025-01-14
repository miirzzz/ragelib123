using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000078 RID: 120
	public struct DataBlockPointer
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000EA29 File Offset: 0x0000CC29
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000EA31 File Offset: 0x0000CC31
		public uint Ptr0 { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000EA3A File Offset: 0x0000CC3A
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000EA42 File Offset: 0x0000CC42
		public uint Ptr1 { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000EA4B File Offset: 0x0000CC4B
		public uint PointerDataId
		{
			get
			{
				return this.Ptr0 & 4095U;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0000EA59 File Offset: 0x0000CC59
		public uint PointerDataIndex
		{
			get
			{
				return (this.Ptr0 & 4095U) - 1U;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000EA69 File Offset: 0x0000CC69
		public uint PointerDataOffset
		{
			get
			{
				return this.Ptr0 >> 12 & 1048575U;
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000EA7C File Offset: 0x0000CC7C
		public override string ToString()
		{
			return "DataBlockPointer: " + this.Ptr0.ToString() + ", " + this.Ptr1.ToString();
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000EAB4 File Offset: 0x0000CCB4
		public void SwapEnd()
		{
			this.Ptr0 = MetaUtils.SwapBytes(this.Ptr0);
			this.Ptr1 = MetaUtils.SwapBytes(this.Ptr1);
		}
	}
}
