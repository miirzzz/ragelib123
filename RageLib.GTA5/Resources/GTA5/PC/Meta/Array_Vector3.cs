using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x0200006F RID: 111
	public struct Array_Vector3
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0000DBB2 File Offset: 0x0000BDB2
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0000DBBA File Offset: 0x0000BDBA
		public uint Pointer { get; set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0000DBC3 File Offset: 0x0000BDC3
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000DBCB File Offset: 0x0000BDCB
		public uint Unk0 { get; set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0000DBDC File Offset: 0x0000BDDC
		public ushort Count1 { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000DBE5 File Offset: 0x0000BDE5
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0000DBED File Offset: 0x0000BDED
		public ushort Count2 { get; set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0000DBF6 File Offset: 0x0000BDF6
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0000DBFE File Offset: 0x0000BDFE
		public uint Unk1 { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000DC07 File Offset: 0x0000BE07
		public uint PointerDataId
		{
			get
			{
				return this.Pointer & 4095U;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000DC15 File Offset: 0x0000BE15
		public uint PointerDataIndex
		{
			get
			{
				return (this.Pointer & 4095U) - 1U;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000DC25 File Offset: 0x0000BE25
		public uint PointerDataOffset
		{
			get
			{
				return this.Pointer >> 12 & 1048575U;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000DC36 File Offset: 0x0000BE36
		public Array_Vector3(uint ptr, int cnt)
		{
			this.Pointer = ptr;
			this.Unk0 = 0U;
			this.Count1 = (ushort)cnt;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000DC61 File Offset: 0x0000BE61
		public Array_Vector3(MetaBuilderPointer ptr)
		{
			this.Pointer = ptr.Pointer;
			this.Unk0 = 0U;
			this.Count1 = (ushort)ptr.Length;
			this.Count2 = this.Count1;
			this.Unk1 = 0U;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000DC98 File Offset: 0x0000BE98
		public void SwapEnd()
		{
			this.Pointer = MetaUtils.SwapBytes(this.Pointer);
			this.Unk0 = MetaUtils.SwapBytes(this.Unk0);
			this.Count1 = MetaUtils.SwapBytes(this.Count1);
			this.Count2 = MetaUtils.SwapBytes(this.Count2);
			this.Unk1 = MetaUtils.SwapBytes(this.Unk1);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000DCFC File Offset: 0x0000BEFC
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Array_Vector3: ",
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
