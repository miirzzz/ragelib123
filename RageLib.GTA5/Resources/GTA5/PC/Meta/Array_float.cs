using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000071 RID: 113
	public struct Array_float
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000DF1F File Offset: 0x0000C11F
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0000DF27 File Offset: 0x0000C127
		public uint Pointer { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000DF30 File Offset: 0x0000C130
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0000DF38 File Offset: 0x0000C138
		public uint Unk0 { get; set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000DF41 File Offset: 0x0000C141
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000DF49 File Offset: 0x0000C149
		public ushort Count1 { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000DF52 File Offset: 0x0000C152
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0000DF5A File Offset: 0x0000C15A
		public ushort Count2 { get; set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000DF63 File Offset: 0x0000C163
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0000DF6B File Offset: 0x0000C16B
		public uint Unk1 { get; set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000DF74 File Offset: 0x0000C174
		public uint PointerDataId
		{
			get
			{
				return this.Pointer & 4095U;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000DF82 File Offset: 0x0000C182
		public uint PointerDataIndex
		{
			get
			{
				return (this.Pointer & 4095U) - 1U;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000DF92 File Offset: 0x0000C192
		public uint PointerDataOffset
		{
			get
			{
				return this.Pointer >> 12 & 1048575U;
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000DFA3 File Offset: 0x0000C1A3
		public Array_float(uint ptr, int cnt)
		{
			this.Pointer = ptr;
			this.Unk0 = 0U;
			this.Count1 = (ushort)cnt;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000DFCE File Offset: 0x0000C1CE
		public Array_float(MetaBuilderPointer ptr)
		{
			this.Pointer = ptr.Pointer;
			this.Unk0 = 0U;
			this.Count1 = (ushort)ptr.Length;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000E008 File Offset: 0x0000C208
		public void SwapEnd()
		{
			this.Pointer = MetaUtils.SwapBytes(this.Pointer);
			this.Unk0 = MetaUtils.SwapBytes(this.Unk0);
			this.Count1 = MetaUtils.SwapBytes(this.Count1);
			this.Count2 = MetaUtils.SwapBytes(this.Count2);
			this.Unk1 = MetaUtils.SwapBytes(this.Unk1);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000E06C File Offset: 0x0000C26C
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Array_float: ",
				this.PointerDataIndex.ToString(),
				" (",
				this.Count1.ToString(),
				"/",
				this.Count2.ToString(),
				")"
			});
		}
	}
}
