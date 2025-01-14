using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x02000174 RID: 372
	public class BoundPolygonTriangle : BoundPolygonBase
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00026FA1 File Offset: 0x000251A1
		public int VertIndex1
		{
			get
			{
				return (int)(this.TriIndex1 & 32767);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00026FAF File Offset: 0x000251AF
		public int VertIndex2
		{
			get
			{
				return (int)(this.TriIndex2 & 32767);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00026FBD File Offset: 0x000251BD
		public int VertIndex3
		{
			get
			{
				return (int)(this.TriIndex3 & 32767);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00026FCB File Offset: 0x000251CB
		public bool VertFlag1
		{
			get
			{
				return (this.TriIndex1 & 32768) > 0;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00026FDC File Offset: 0x000251DC
		public bool VertFlag2
		{
			get
			{
				return (this.TriIndex2 & 32768) > 0;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x00026FED File Offset: 0x000251ED
		public bool VertFlag3
		{
			get
			{
				return (this.TriIndex3 & 32768) > 0;
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00026FFE File Offset: 0x000251FE
		public BoundPolygonTriangle()
		{
			base.Type = BoundPolygonType.Triangle;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00027010 File Offset: 0x00025210
		public override void Read(byte[] bytes, int offset)
		{
			this.TriArea = BitConverter.ToSingle(bytes, offset);
			this.TriIndex1 = BitConverter.ToUInt16(bytes, offset + 4);
			this.TriIndex2 = BitConverter.ToUInt16(bytes, offset + 6);
			this.TriIndex3 = BitConverter.ToUInt16(bytes, offset + 8);
			this.EdgeIndex1 = BitConverter.ToInt16(bytes, offset + 10);
			this.EdgeIndex2 = BitConverter.ToInt16(bytes, offset + 12);
			this.EdgeIndex3 = BitConverter.ToInt16(bytes, offset + 14);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00027088 File Offset: 0x00025288
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				base.ToString(),
				": ",
				this.VertIndex1.ToString(),
				", ",
				this.VertIndex2.ToString(),
				", ",
				this.VertIndex3.ToString()
			});
		}

		// Token: 0x04003697 RID: 13975
		public float TriArea;

		// Token: 0x04003698 RID: 13976
		public ushort TriIndex1;

		// Token: 0x04003699 RID: 13977
		public ushort TriIndex2;

		// Token: 0x0400369A RID: 13978
		public ushort TriIndex3;

		// Token: 0x0400369B RID: 13979
		public short EdgeIndex1;

		// Token: 0x0400369C RID: 13980
		public short EdgeIndex2;

		// Token: 0x0400369D RID: 13981
		public short EdgeIndex3;
	}
}
