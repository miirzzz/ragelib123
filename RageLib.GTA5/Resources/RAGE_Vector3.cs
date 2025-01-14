using System;
using SharpDX;

namespace RageLib.Resources
{
	// Token: 0x0200000B RID: 11
	public class RAGE_Vector3 : ResourceSystemBlock
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002D6D File Offset: 0x00000F6D
		public override long Length
		{
			get
			{
				return 12L;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000286D File Offset: 0x00000A6D
		public RAGE_Vector3()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002D72 File Offset: 0x00000F72
		public RAGE_Vector3(float x1, float x2, float x3)
		{
			this.x1 = x1;
			this.x2 = x2;
			this.x3 = x3;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002D8F File Offset: 0x00000F8F
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.x1 = reader.ReadSingle();
			this.x2 = reader.ReadSingle();
			this.x3 = reader.ReadSingle();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002DB5 File Offset: 0x00000FB5
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.x1);
			writer.Write(this.x2);
			writer.Write(this.x3);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002DDB File Offset: 0x00000FDB
		public static explicit operator Vector3(RAGE_Vector3 v)
		{
			return new Vector3(v.x1, v.x2, v.x3);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002DF4 File Offset: 0x00000FF4
		public static explicit operator RAGE_Vector3(Vector3 v)
		{
			return new RAGE_Vector3
			{
				x1 = v.X,
				x2 = v.Y,
				x3 = v.Z
			};
		}

		// Token: 0x0400002E RID: 46
		public float x1;

		// Token: 0x0400002F RID: 47
		public float x2;

		// Token: 0x04000030 RID: 48
		public float x3;
	}
}
