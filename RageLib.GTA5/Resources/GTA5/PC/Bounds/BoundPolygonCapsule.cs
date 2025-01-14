using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x02000176 RID: 374
	public class BoundPolygonCapsule : BoundPolygonBase
	{
		// Token: 0x060005D3 RID: 1491 RVA: 0x000271A9 File Offset: 0x000253A9
		public BoundPolygonCapsule()
		{
			base.Type = BoundPolygonType.Capsule;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000271B8 File Offset: 0x000253B8
		public override void Read(byte[] bytes, int offset)
		{
			this.CapsuleType = BitConverter.ToUInt16(bytes, offset);
			this.CapsuleIndex1 = BitConverter.ToUInt16(bytes, offset + 2);
			this.CapsuleRadius = BitConverter.ToSingle(bytes, offset + 4);
			this.CapsuleIndex2 = BitConverter.ToUInt16(bytes, offset + 8);
			this.Unused0 = BitConverter.ToUInt16(bytes, offset + 10);
			this.Unused1 = BitConverter.ToUInt32(bytes, offset + 12);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00027220 File Offset: 0x00025420
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				base.ToString(),
				": ",
				this.CapsuleIndex1.ToString(),
				", ",
				this.CapsuleIndex2.ToString(),
				", ",
				this.CapsuleRadius.ToString()
			});
		}

		// Token: 0x040036A3 RID: 13987
		public ushort CapsuleType;

		// Token: 0x040036A4 RID: 13988
		public ushort CapsuleIndex1;

		// Token: 0x040036A5 RID: 13989
		public float CapsuleRadius;

		// Token: 0x040036A6 RID: 13990
		public ushort CapsuleIndex2;

		// Token: 0x040036A7 RID: 13991
		public ushort Unused0;

		// Token: 0x040036A8 RID: 13992
		public uint Unused1;
	}
}
