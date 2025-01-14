using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000081 RID: 129
	public struct MetaPOINTER
	{
		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0000FE87 File Offset: 0x0000E087
		// (set) Token: 0x06000346 RID: 838 RVA: 0x0000FE8F File Offset: 0x0000E08F
		public uint Pointer { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0000FE98 File Offset: 0x0000E098
		// (set) Token: 0x06000348 RID: 840 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		public uint ExtraOffset { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000349 RID: 841 RVA: 0x0000FEA9 File Offset: 0x0000E0A9
		public int BlockIndex
		{
			get
			{
				return this.BlockID - 1;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000FEB3 File Offset: 0x0000E0B3
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0000FEC1 File Offset: 0x0000E0C1
		public int BlockID
		{
			get
			{
				return (int)(this.Pointer & 4095U);
			}
			set
			{
				this.Pointer = (this.Pointer & 4294963200U) + (uint)(value & 4095);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000FEDD File Offset: 0x0000E0DD
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0000FEEE File Offset: 0x0000E0EE
		public int Offset
		{
			get
			{
				return (int)(this.Pointer >> 12 & 1048575U);
			}
			set
			{
				this.Pointer = (this.Pointer & 4095U) + (uint)(value << 12 & -4096);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000FF0D File Offset: 0x0000E10D
		public MetaPOINTER(int blockID, int itemOffset, uint extra)
		{
			this.Pointer = (uint)((itemOffset << 12 & -4096) + (blockID & 4095));
			this.ExtraOffset = extra;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000FF30 File Offset: 0x0000E130
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.BlockID.ToString(),
				", ",
				this.Offset.ToString(),
				", ",
				this.ExtraOffset.ToString()
			});
		}
	}
}
