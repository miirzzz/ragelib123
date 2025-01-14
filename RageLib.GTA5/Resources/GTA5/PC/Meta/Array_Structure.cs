using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000072 RID: 114
	public struct Array_Structure
	{
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0000E0D7 File Offset: 0x0000C2D7
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0000E0DF File Offset: 0x0000C2DF
		public uint Pointer { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0000E0F0 File Offset: 0x0000C2F0
		public uint Unk0 { get; set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000E0F9 File Offset: 0x0000C2F9
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000E101 File Offset: 0x0000C301
		public ushort Count1 { get; set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000E10A File Offset: 0x0000C30A
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000E112 File Offset: 0x0000C312
		public ushort Count2 { get; set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000E11B File Offset: 0x0000C31B
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0000E123 File Offset: 0x0000C323
		public uint Unk1 { get; set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000E12C File Offset: 0x0000C32C
		public uint PointerDataId
		{
			get
			{
				return this.Pointer & 4095U;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000E13A File Offset: 0x0000C33A
		public uint PointerDataIndex
		{
			get
			{
				return (this.Pointer & 4095U) - 1U;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000E14A File Offset: 0x0000C34A
		public uint PointerDataOffset
		{
			get
			{
				return this.Pointer >> 12 & 1048575U;
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000E15B File Offset: 0x0000C35B
		public Array_Structure(uint ptr, int cnt)
		{
			this.Pointer = ptr;
			this.Unk0 = 0U;
			this.Count1 = (ushort)cnt;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000E186 File Offset: 0x0000C386
		public Array_Structure(MetaBuilderPointer ptr)
		{
			this.Pointer = ptr.Pointer;
			this.Unk0 = 0U;
			this.Count1 = (ushort)ptr.Length;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		public void SwapEnd()
		{
			this.Pointer = MetaUtils.SwapBytes(this.Pointer);
			this.Unk0 = MetaUtils.SwapBytes(this.Unk0);
			this.Count1 = MetaUtils.SwapBytes(this.Count1);
			this.Count2 = MetaUtils.SwapBytes(this.Count2);
			this.Unk1 = MetaUtils.SwapBytes(this.Unk1);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000E224 File Offset: 0x0000C424
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Array_Structure: ",
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
