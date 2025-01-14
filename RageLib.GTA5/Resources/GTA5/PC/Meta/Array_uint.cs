using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000074 RID: 116
	public struct Array_uint
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000E3D3 File Offset: 0x0000C5D3
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0000E3DB File Offset: 0x0000C5DB
		public uint Pointer { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000E3E4 File Offset: 0x0000C5E4
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0000E3EC File Offset: 0x0000C5EC
		public uint Unk0 { get; set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000E3F5 File Offset: 0x0000C5F5
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000E3FD File Offset: 0x0000C5FD
		public ushort Count1 { get; set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0000E406 File Offset: 0x0000C606
		// (set) Token: 0x06000281 RID: 641 RVA: 0x0000E40E File Offset: 0x0000C60E
		public ushort Count2 { get; set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000E417 File Offset: 0x0000C617
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0000E41F File Offset: 0x0000C61F
		public uint Unk1 { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000E428 File Offset: 0x0000C628
		public uint PointerDataId
		{
			get
			{
				return this.Pointer & 4095U;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000E436 File Offset: 0x0000C636
		public uint PointerDataIndex
		{
			get
			{
				return (this.Pointer & 4095U) - 1U;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000E446 File Offset: 0x0000C646
		public uint PointerDataOffset
		{
			get
			{
				return this.Pointer >> 12 & 1048575U;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000E457 File Offset: 0x0000C657
		public Array_uint(uint ptr, int cnt)
		{
			this.Pointer = ptr;
			this.Unk0 = 0U;
			this.Count1 = (ushort)cnt;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000E482 File Offset: 0x0000C682
		public Array_uint(MetaBuilderPointer ptr)
		{
			this.Pointer = ptr.Pointer;
			this.Unk0 = 0U;
			this.Count1 = (ushort)ptr.Length;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000E4BC File Offset: 0x0000C6BC
		public void SwapEnd()
		{
			this.Pointer = MetaUtils.SwapBytes(this.Pointer);
			this.Unk0 = MetaUtils.SwapBytes(this.Unk0);
			this.Count1 = MetaUtils.SwapBytes(this.Count1);
			this.Count2 = MetaUtils.SwapBytes(this.Count2);
			this.Unk1 = MetaUtils.SwapBytes(this.Unk1);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000E520 File Offset: 0x0000C720
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Array_uint: ",
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
