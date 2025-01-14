using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x02000175 RID: 373
	public class BoundPolygonSphere : BoundPolygonBase
	{
		// Token: 0x060005D0 RID: 1488 RVA: 0x000270F4 File Offset: 0x000252F4
		public BoundPolygonSphere()
		{
			base.Type = BoundPolygonType.Sphere;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00027104 File Offset: 0x00025304
		public override void Read(byte[] bytes, int offset)
		{
			this.SphereType = BitConverter.ToUInt16(bytes, offset);
			this.SphereIndex = BitConverter.ToUInt16(bytes, offset + 2);
			this.SphereRadius = BitConverter.ToSingle(bytes, offset + 4);
			this.Unused0 = BitConverter.ToUInt32(bytes, offset + 8);
			this.Unused1 = BitConverter.ToUInt32(bytes, offset + 12);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0002715C File Offset: 0x0002535C
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				base.ToString(),
				": ",
				this.SphereIndex.ToString(),
				", ",
				this.SphereRadius.ToString()
			});
		}

		// Token: 0x0400369E RID: 13982
		public ushort SphereType;

		// Token: 0x0400369F RID: 13983
		public ushort SphereIndex;

		// Token: 0x040036A0 RID: 13984
		public float SphereRadius;

		// Token: 0x040036A1 RID: 13985
		public uint Unused0;

		// Token: 0x040036A2 RID: 13986
		public uint Unused1;
	}
}
