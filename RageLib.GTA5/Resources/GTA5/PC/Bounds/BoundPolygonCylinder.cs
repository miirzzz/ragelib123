using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x02000178 RID: 376
	public class BoundPolygonCylinder : BoundPolygonBase
	{
		// Token: 0x060005D9 RID: 1497 RVA: 0x00027376 File Offset: 0x00025576
		public BoundPolygonCylinder()
		{
			base.Type = BoundPolygonType.Cylinder;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00027388 File Offset: 0x00025588
		public override void Read(byte[] bytes, int offset)
		{
			this.CylinderType = BitConverter.ToUInt16(bytes, offset);
			this.CylinderIndex1 = BitConverter.ToUInt16(bytes, offset + 2);
			this.CylinderRadius = BitConverter.ToSingle(bytes, offset + 4);
			this.CylinderIndex2 = BitConverter.ToUInt16(bytes, offset + 8);
			this.Unused0 = BitConverter.ToUInt16(bytes, offset + 10);
			this.Unused1 = BitConverter.ToUInt32(bytes, offset + 12);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000273F0 File Offset: 0x000255F0
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				base.ToString(),
				": ",
				this.CylinderIndex1.ToString(),
				", ",
				this.CylinderIndex2.ToString(),
				", ",
				this.CylinderRadius.ToString()
			});
		}

		// Token: 0x040036AF RID: 13999
		public ushort CylinderType;

		// Token: 0x040036B0 RID: 14000
		public ushort CylinderIndex1;

		// Token: 0x040036B1 RID: 14001
		public float CylinderRadius;

		// Token: 0x040036B2 RID: 14002
		public ushort CylinderIndex2;

		// Token: 0x040036B3 RID: 14003
		public ushort Unused0;

		// Token: 0x040036B4 RID: 14004
		public uint Unused1;
	}
}
