using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000076 RID: 118
	public struct CharPointer
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000E743 File Offset: 0x0000C943
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0000E74B File Offset: 0x0000C94B
		public uint Pointer { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000E754 File Offset: 0x0000C954
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0000E75C File Offset: 0x0000C95C
		public uint Unk0 { get; set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000E765 File Offset: 0x0000C965
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0000E76D File Offset: 0x0000C96D
		public ushort Count1 { get; set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000E776 File Offset: 0x0000C976
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0000E77E File Offset: 0x0000C97E
		public ushort Count2 { get; set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000E787 File Offset: 0x0000C987
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x0000E78F File Offset: 0x0000C98F
		public uint Unk1 { get; set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000E798 File Offset: 0x0000C998
		public uint PointerDataId
		{
			get
			{
				return this.Pointer & 4095U;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000E7A6 File Offset: 0x0000C9A6
		public uint PointerDataIndex
		{
			get
			{
				return (this.Pointer & 4095U) - 1U;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000E7B6 File Offset: 0x0000C9B6
		public uint PointerDataOffset
		{
			get
			{
				return this.Pointer >> 12 & 1048575U;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000E7C7 File Offset: 0x0000C9C7
		public CharPointer(uint ptr, int len)
		{
			this.Pointer = ptr;
			this.Unk0 = 0U;
			this.Count1 = (ushort)len;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000E7F2 File Offset: 0x0000C9F2
		public CharPointer(MetaBuilderPointer ptr)
		{
			this.Pointer = ptr.Pointer;
			this.Unk0 = 0U;
			this.Count1 = (ushort)ptr.Length;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000E82C File Offset: 0x0000CA2C
		public void SwapEnd()
		{
			this.Pointer = MetaUtils.SwapBytes(this.Pointer);
			this.Unk0 = MetaUtils.SwapBytes(this.Unk0);
			this.Count1 = MetaUtils.SwapBytes(this.Count1);
			this.Count2 = MetaUtils.SwapBytes(this.Count2);
			this.Unk1 = MetaUtils.SwapBytes(this.Unk1);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000E890 File Offset: 0x0000CA90
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"CharPointer: ",
				this.Pointer.ToString(),
				" (",
				this.Count1.ToString(),
				"/",
				this.Count2.ToString(),
				")"
			});
		}
	}
}
