using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000068 RID: 104
	public struct ArrayOfBytes12
	{
		// Token: 0x06000221 RID: 545 RVA: 0x0000D720 File Offset: 0x0000B920
		public void SetByte(int num, byte val)
		{
			switch (num)
			{
			case 0:
				this.b00 = val;
				return;
			case 1:
				this.b01 = val;
				return;
			case 2:
				this.b02 = val;
				return;
			case 3:
				this.b03 = val;
				return;
			case 4:
				this.b04 = val;
				return;
			case 5:
				this.b05 = val;
				return;
			case 6:
				this.b06 = val;
				return;
			case 7:
				this.b07 = val;
				return;
			case 8:
				this.b08 = val;
				return;
			case 9:
				this.b09 = val;
				return;
			case 10:
				this.b10 = val;
				return;
			case 11:
				this.b11 = val;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000D7C4 File Offset: 0x0000B9C4
		public void SetBytes(byte[] vals)
		{
			for (int i = 0; i < vals.Length; i++)
			{
				this.SetByte(i, vals[i]);
			}
		}

		// Token: 0x040004F8 RID: 1272
		public byte b00;

		// Token: 0x040004F9 RID: 1273
		public byte b01;

		// Token: 0x040004FA RID: 1274
		public byte b02;

		// Token: 0x040004FB RID: 1275
		public byte b03;

		// Token: 0x040004FC RID: 1276
		public byte b04;

		// Token: 0x040004FD RID: 1277
		public byte b05;

		// Token: 0x040004FE RID: 1278
		public byte b06;

		// Token: 0x040004FF RID: 1279
		public byte b07;

		// Token: 0x04000500 RID: 1280
		public byte b08;

		// Token: 0x04000501 RID: 1281
		public byte b09;

		// Token: 0x04000502 RID: 1282
		public byte b10;

		// Token: 0x04000503 RID: 1283
		public byte b11;
	}
}
