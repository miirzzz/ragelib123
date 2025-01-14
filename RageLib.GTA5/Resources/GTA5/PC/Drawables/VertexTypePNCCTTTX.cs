using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000123 RID: 291
	public struct VertexTypePNCCTTTX
	{
		// Token: 0x060004B0 RID: 1200 RVA: 0x0001FC80 File Offset: 0x0001DE80
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("COLOR", 1, Format.R8G8B8A8_UNorm, 28, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 32, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 40, 0),
				new InputElement("TEXCOORD", 2, Format.R32G32_Float, 48, 0),
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 56, 0)
			};
		}

		// Token: 0x04003320 RID: 13088
		public Vector3 Position;

		// Token: 0x04003321 RID: 13089
		public Vector3 Normal;

		// Token: 0x04003322 RID: 13090
		public uint Colour0;

		// Token: 0x04003323 RID: 13091
		public uint Colour1;

		// Token: 0x04003324 RID: 13092
		public Vector2 Texcoord0;

		// Token: 0x04003325 RID: 13093
		public Vector2 Texcoord1;

		// Token: 0x04003326 RID: 13094
		public Vector2 Texcoord2;

		// Token: 0x04003327 RID: 13095
		public Vector4 Tangents;
	}
}
