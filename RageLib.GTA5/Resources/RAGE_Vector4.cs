using System;
using SharpDX;

namespace RageLib.Resources
{
	// Token: 0x0200000C RID: 12
	public class RAGE_Vector4 : ResourceSystemBlock
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000286D File Offset: 0x00000A6D
		public RAGE_Vector4()
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002E1F File Offset: 0x0000101F
		public RAGE_Vector4(float x1, float x2, float x3, float x4)
		{
			this.x1 = x1;
			this.x2 = x2;
			this.x3 = x3;
			this.x4 = x4;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002E44 File Offset: 0x00001044
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.x1 = reader.ReadSingle();
			this.x2 = reader.ReadSingle();
			this.x3 = reader.ReadSingle();
			this.x4 = reader.ReadSingle();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002E76 File Offset: 0x00001076
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.x1);
			writer.Write(this.x2);
			writer.Write(this.x3);
			writer.Write(this.x4);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002EA8 File Offset: 0x000010A8
		public static explicit operator Vector4(RAGE_Vector4 v)
		{
			return new Vector4(v.x1, v.x2, v.x3, v.x4);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002EC7 File Offset: 0x000010C7
		public static explicit operator RAGE_Vector4(Vector4 v)
		{
			return new RAGE_Vector4
			{
				x1 = v.X,
				x2 = v.Y,
				x3 = v.Z,
				x4 = v.W
			};
		}

		// Token: 0x04000031 RID: 49
		public float x1;

		// Token: 0x04000032 RID: 50
		public float x2;

		// Token: 0x04000033 RID: 51
		public float x3;

		// Token: 0x04000034 RID: 52
		public float x4;
	}
}
