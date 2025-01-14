using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200011E RID: 286
	public struct VertexTypePNCTTTX
	{
		// Token: 0x060004AB RID: 1195 RVA: 0x0001F924 File Offset: 0x0001DB24
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

		// Token: 0x040032FE RID: 13054
		public Vector3 Position;

		// Token: 0x040032FF RID: 13055
		public Vector3 Normal;

		// Token: 0x04003300 RID: 13056
		public uint Colour;

		// Token: 0x04003301 RID: 13057
		public Vector2 Texcoord0;

		// Token: 0x04003302 RID: 13058
		public Vector2 Texcoord1;

		// Token: 0x04003303 RID: 13059
		public Vector2 Texcoord2;

		// Token: 0x04003304 RID: 13060
		public Vector4 Tangents;
	}
}
