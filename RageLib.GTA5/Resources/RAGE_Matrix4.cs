using System;

namespace RageLib.Resources
{
	// Token: 0x0200000A RID: 10
	public class RAGE_Matrix4 : ResourceSystemBlock
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000286D File Offset: 0x00000A6D
		public RAGE_Matrix4()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002B40 File Offset: 0x00000D40
		public RAGE_Matrix4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
		{
			this.m11 = m11;
			this.m12 = m12;
			this.m13 = m13;
			this.m14 = m14;
			this.m21 = m21;
			this.m22 = m22;
			this.m23 = m23;
			this.m24 = m24;
			this.m31 = m31;
			this.m32 = m32;
			this.m33 = m33;
			this.m34 = m34;
			this.m41 = m41;
			this.m42 = m42;
			this.m43 = m43;
			this.m44 = m44;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002BD0 File Offset: 0x00000DD0
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.m11 = reader.ReadSingle();
			this.m12 = reader.ReadSingle();
			this.m13 = reader.ReadSingle();
			this.m14 = reader.ReadSingle();
			this.m21 = reader.ReadSingle();
			this.m22 = reader.ReadSingle();
			this.m23 = reader.ReadSingle();
			this.m24 = reader.ReadSingle();
			this.m31 = reader.ReadSingle();
			this.m32 = reader.ReadSingle();
			this.m33 = reader.ReadSingle();
			this.m34 = reader.ReadSingle();
			this.m41 = reader.ReadSingle();
			this.m42 = reader.ReadSingle();
			this.m43 = reader.ReadSingle();
			this.m44 = reader.ReadSingle();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002CA0 File Offset: 0x00000EA0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.m11);
			writer.Write(this.m12);
			writer.Write(this.m13);
			writer.Write(this.m14);
			writer.Write(this.m21);
			writer.Write(this.m22);
			writer.Write(this.m23);
			writer.Write(this.m24);
			writer.Write(this.m31);
			writer.Write(this.m32);
			writer.Write(this.m33);
			writer.Write(this.m34);
			writer.Write(this.m41);
			writer.Write(this.m42);
			writer.Write(this.m43);
			writer.Write(this.m44);
		}

		// Token: 0x0400001E RID: 30
		public float m11;

		// Token: 0x0400001F RID: 31
		public float m12;

		// Token: 0x04000020 RID: 32
		public float m13;

		// Token: 0x04000021 RID: 33
		public float m14;

		// Token: 0x04000022 RID: 34
		public float m21;

		// Token: 0x04000023 RID: 35
		public float m22;

		// Token: 0x04000024 RID: 36
		public float m23;

		// Token: 0x04000025 RID: 37
		public float m24;

		// Token: 0x04000026 RID: 38
		public float m31;

		// Token: 0x04000027 RID: 39
		public float m32;

		// Token: 0x04000028 RID: 40
		public float m33;

		// Token: 0x04000029 RID: 41
		public float m34;

		// Token: 0x0400002A RID: 42
		public float m41;

		// Token: 0x0400002B RID: 43
		public float m42;

		// Token: 0x0400002C RID: 44
		public float m43;

		// Token: 0x0400002D RID: 45
		public float m44;
	}
}
