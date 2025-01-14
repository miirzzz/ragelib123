using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000120 RID: 288
	public struct VertexTypePNCTTTX_3
	{
		// Token: 0x060004AD RID: 1197 RVA: 0x0001FA84 File Offset: 0x0001DC84
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 28, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 36, 0),
				new InputElement("TEXCOORD", 2, Format.R32G32_Float, 44, 0),
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 52, 0)
			};
		}

		// Token: 0x0400330C RID: 13068
		public Vector3 Position;

		// Token: 0x0400330D RID: 13069
		public Vector3 Normal;

		// Token: 0x0400330E RID: 13070
		public uint Colour;

		// Token: 0x0400330F RID: 13071
		public Vector2 Texcoord0;

		// Token: 0x04003310 RID: 13072
		public Vector2 Texcoord1;

		// Token: 0x04003311 RID: 13073
		public Vector2 Texcoord2;

		// Token: 0x04003312 RID: 13074
		public Vector4 Tangents;
	}
}
