using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000075 RID: 117
	public struct Array_ushort
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000E58B File Offset: 0x0000C78B
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0000E593 File Offset: 0x0000C793
		public uint Pointer { get; set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000E59C File Offset: 0x0000C79C
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0000E5A4 File Offset: 0x0000C7A4
		public uint Unk0 { get; set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000E5AD File Offset: 0x0000C7AD
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0000E5B5 File Offset: 0x0000C7B5
		public ushort Count1 { get; set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0000E5BE File Offset: 0x0000C7BE
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0000E5C6 File Offset: 0x0000C7C6
		public ushort Count2 { get; set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000E5CF File Offset: 0x0000C7CF
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000E5D7 File Offset: 0x0000C7D7
		public uint Unk1 { get; set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		public uint PointerDataId
		{
			get
			{
				return this.Pointer & 4095U;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000E5EE File Offset: 0x0000C7EE
		public uint PointerDataIndex
		{
			get
			{
				return (this.Pointer & 4095U) - 1U;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000E5FE File Offset: 0x0000C7FE
		public uint PointerDataOffset
		{
			get
			{
				return this.Pointer >> 12 & 1048575U;
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000E60F File Offset: 0x0000C80F
		public Array_ushort(uint ptr, int cnt)
		{
			this.Pointer = ptr;
			this.Unk0 = 0U;
			this.Count1 = (ushort)cnt;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000E63A File Offset: 0x0000C83A
		public Array_ushort(MetaBuilderPointer ptr)
		{
			this.Pointer = ptr.Pointer;
			this.Unk0 = 0U;
			this.Count1 = (ushort)ptr.Length;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000E674 File Offset: 0x0000C874
		public void SwapEnd()
		{
			this.Pointer = MetaUtils.SwapBytes(this.Pointer);
			this.Unk0 = MetaUtils.SwapBytes(this.Unk0);
			this.Count1 = MetaUtils.SwapBytes(this.Count1);
			this.Count2 = MetaUtils.SwapBytes(this.Count2);
			this.Unk1 = MetaUtils.SwapBytes(this.Unk1);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000E6D8 File Offset: 0x0000C8D8
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Array_ushort: ",
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
