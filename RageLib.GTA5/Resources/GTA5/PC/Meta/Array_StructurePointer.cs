using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000073 RID: 115
	public struct Array_StructurePointer
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000E28F File Offset: 0x0000C48F
		// (set) Token: 0x0600026C RID: 620 RVA: 0x0000E297 File Offset: 0x0000C497
		public uint Pointer { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000E2A0 File Offset: 0x0000C4A0
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0000E2A8 File Offset: 0x0000C4A8
		public uint Unk0 { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000E2B1 File Offset: 0x0000C4B1
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0000E2B9 File Offset: 0x0000C4B9
		public ushort Count1 { get; set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000E2C2 File Offset: 0x0000C4C2
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0000E2CA File Offset: 0x0000C4CA
		public ushort Count2 { get; set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000E2D3 File Offset: 0x0000C4D3
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0000E2DB File Offset: 0x0000C4DB
		public uint Unk1 { get; set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000E2E4 File Offset: 0x0000C4E4
		public uint PointerDataId
		{
			get
			{
				return this.Pointer & 4095U;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0000E2F2 File Offset: 0x0000C4F2
		public uint PointerDataIndex
		{
			get
			{
				return (this.Pointer & 4095U) - 1U;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000E302 File Offset: 0x0000C502
		public uint PointerDataOffset
		{
			get
			{
				return this.Pointer >> 12 & 1048575U;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000E314 File Offset: 0x0000C514
		public void SwapEnd()
		{
			this.Pointer = MetaUtils.SwapBytes(this.Pointer);
			this.Count1 = MetaUtils.SwapBytes(this.Count1);
			this.Count2 = MetaUtils.SwapBytes(this.Count2);
			this.Unk1 = MetaUtils.SwapBytes(this.Unk1);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000E368 File Offset: 0x0000C568
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Array_StructurePointer: ",
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
