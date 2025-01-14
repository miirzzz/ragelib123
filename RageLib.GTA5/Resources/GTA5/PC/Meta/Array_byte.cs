using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000070 RID: 112
	public struct Array_byte
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0000DD67 File Offset: 0x0000BF67
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0000DD6F File Offset: 0x0000BF6F
		public uint Pointer { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0000DD78 File Offset: 0x0000BF78
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0000DD80 File Offset: 0x0000BF80
		public uint Unk0 { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000DD89 File Offset: 0x0000BF89
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0000DD91 File Offset: 0x0000BF91
		public ushort Count1 { get; set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0000DD9A File Offset: 0x0000BF9A
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0000DDA2 File Offset: 0x0000BFA2
		public ushort Count2 { get; set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0000DDAB File Offset: 0x0000BFAB
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0000DDB3 File Offset: 0x0000BFB3
		public uint Unk1 { get; set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0000DDBC File Offset: 0x0000BFBC
		public uint PointerDataId
		{
			get
			{
				return this.Pointer & 4095U;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000DDCA File Offset: 0x0000BFCA
		public uint PointerDataIndex
		{
			get
			{
				return (this.Pointer & 4095U) - 1U;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000DDDA File Offset: 0x0000BFDA
		public uint PointerDataOffset
		{
			get
			{
				return this.Pointer >> 12 & 1048575U;
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000DDEB File Offset: 0x0000BFEB
		public Array_byte(uint ptr, int cnt)
		{
			this.Pointer = ptr;
			this.Unk0 = 0U;
			this.Count1 = (ushort)cnt;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000DE16 File Offset: 0x0000C016
		public Array_byte(MetaBuilderPointer ptr)
		{
			this.Pointer = ptr.Pointer;
			this.Unk0 = 0U;
			this.Count1 = (ushort)ptr.Length;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000DE50 File Offset: 0x0000C050
		public void SwapEnd()
		{
			this.Pointer = MetaUtils.SwapBytes(this.Pointer);
			this.Unk0 = MetaUtils.SwapBytes(this.Unk0);
			this.Count1 = MetaUtils.SwapBytes(this.Count1);
			this.Count2 = MetaUtils.SwapBytes(this.Count2);
			this.Unk1 = MetaUtils.SwapBytes(this.Unk1);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000DEB4 File Offset: 0x0000C0B4
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Array_byte: ",
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
