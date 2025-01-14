using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000121 RID: 289
	public struct VertexTypePNCTTX
	{
		// Token: 0x060004AE RID: 1198 RVA: 0x0001FB34 File Offset: 0x0001DD34
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 28, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 36, 0),
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 44, 0)
			};
		}

		// Token: 0x04003313 RID: 13075
		public Vector3 Position;

		// Token: 0x04003314 RID: 13076
		public Vector3 Normal;

		// Token: 0x04003315 RID: 13077
		public uint Colour;

		// Token: 0x04003316 RID: 13078
		public Vector2 Texcoord0;

		// Token: 0x04003317 RID: 13079
		public Vector2 Texcoord1;

		// Token: 0x04003318 RID: 13080
		public Vector4 Tangents;
	}
}
