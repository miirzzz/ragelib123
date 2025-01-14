using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x02000171 RID: 369
	public class BoundPolygon : ResourceSystemBlock
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00026EBD File Offset: 0x000250BD
		public BoundPolygonBase Polygon
		{
			get
			{
				return this.GetPolygon();
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00026EC5 File Offset: 0x000250C5
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.data = reader.ReadBytes(16);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00026ED5 File Offset: 0x000250D5
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.data);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00026EE4 File Offset: 0x000250E4
		public BoundPolygonBase GetPolygon()
		{
			BoundPolygonType boundPolygonType = (BoundPolygonType)(this.data[0] & 7);
			BoundPolygonBase boundPolygonBase = this._Polygon;
			if (boundPolygonBase == null)
			{
				switch (boundPolygonType)
				{
				case BoundPolygonType.Triangle:
					boundPolygonBase = new BoundPolygonTriangle();
					break;
				case BoundPolygonType.Sphere:
					boundPolygonBase = new BoundPolygonSphere();
					break;
				case BoundPolygonType.Capsule:
					boundPolygonBase = new BoundPolygonCapsule();
					break;
				case BoundPolygonType.Box:
					boundPolygonBase = new BoundPolygonBox();
					break;
				case BoundPolygonType.Cylinder:
					boundPolygonBase = new BoundPolygonCylinder();
					break;
				}
			}
			if (boundPolygonBase != null)
			{
				boundPolygonBase.Read(this.data, 0);
			}
			return boundPolygonBase;
		}

		// Token: 0x0400368E RID: 13966
		public byte[] data = new byte[16];

		// Token: 0x0400368F RID: 13967
		private BoundPolygonBase _Polygon;
	}
}
