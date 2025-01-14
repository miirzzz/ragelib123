using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000213 RID: 531
	public struct PsoPOINTER : IPsoSwapEnd
	{
		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0003D6C8 File Offset: 0x0003B8C8
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0003D6D0 File Offset: 0x0003B8D0
		public uint Pointer { get; set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0003D6D9 File Offset: 0x0003B8D9
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x0003D6E1 File Offset: 0x0003B8E1
		public uint Unk2 { get; set; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0003D6EA File Offset: 0x0003B8EA
		public ushort BlockID
		{
			get
			{
				return (ushort)(this.Pointer & 4095U);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0003D6F9 File Offset: 0x0003B8F9
		public uint ItemOffset
		{
			get
			{
				return this.Pointer >> 12 & 1048575U;
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0003D70C File Offset: 0x0003B90C
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.BlockID.ToString(),
				", ",
				this.ItemOffset.ToString(),
				", ",
				this.Unk2.ToString()
			});
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0003D767 File Offset: 0x0003B967
		public void SwapEnd()
		{
			this.Pointer = MetaUtils.SwapBytes(this.Pointer);
			this.Unk2 = MetaUtils.SwapBytes(this.Unk2);
		}
	}
}
