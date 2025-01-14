using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000122 RID: 290
	public struct VertexTypePNCCTTX
	{
		// Token: 0x060004AF RID: 1199 RVA: 0x0001FBD0 File Offset: 0x0001DDD0
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
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 48, 0)
			};
		}

		// Token: 0x04003319 RID: 13081
		public Vector3 Position;

		// Token: 0x0400331A RID: 13082
		public Vector3 Normal;

		// Token: 0x0400331B RID: 13083
		public uint Colour0;

		// Token: 0x0400331C RID: 13084
		public uint Colour1;

		// Token: 0x0400331D RID: 13085
		public Vector2 Texcoord0;

		// Token: 0x0400331E RID: 13086
		public Vector2 Texcoord1;

		// Token: 0x0400331F RID: 13087
		public Vector4 Tangents;
	}
}
