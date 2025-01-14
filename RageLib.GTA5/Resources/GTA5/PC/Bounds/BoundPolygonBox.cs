using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x02000177 RID: 375
	public class BoundPolygonBox : BoundPolygonBase
	{
		// Token: 0x060005D6 RID: 1494 RVA: 0x00027283 File Offset: 0x00025483
		public BoundPolygonBox()
		{
			base.Type = BoundPolygonType.Box;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00027294 File Offset: 0x00025494
		public override void Read(byte[] bytes, int offset)
		{
			this.BoxType = BitConverter.ToUInt32(bytes, offset);
			this.BoxIndex1 = BitConverter.ToInt16(bytes, offset + 4);
			this.BoxIndex2 = BitConverter.ToInt16(bytes, offset + 6);
			this.BoxIndex3 = BitConverter.ToInt16(bytes, offset + 8);
			this.BoxIndex4 = BitConverter.ToInt16(bytes, offset + 10);
			this.Unused0 = BitConverter.ToUInt32(bytes, offset + 12);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000272FC File Offset: 0x000254FC
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				base.ToString(),
				": ",
				this.BoxIndex1.ToString(),
				", ",
				this.BoxIndex2.ToString(),
				", ",
				this.BoxIndex3.ToString(),
				", ",
				this.BoxIndex4.ToString()
			});
		}

		// Token: 0x040036A9 RID: 13993
		public uint BoxType;

		// Token: 0x040036AA RID: 13994
		public short BoxIndex1;

		// Token: 0x040036AB RID: 13995
		public short BoxIndex2;

		// Token: 0x040036AC RID: 13996
		public short BoxIndex3;

		// Token: 0x040036AD RID: 13997
		public short BoxIndex4;

		// Token: 0x040036AE RID: 13998
		public uint Unused0;
	}
}
