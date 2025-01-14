using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200011C RID: 284
	public struct VertexTypePBBNCCTTX
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x0001F790 File Offset: 0x0001D990
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("BLENDWEIGHTS", 0, Format.R8G8B8A8_UNorm, 12, 0),
				new InputElement("BLENDINDICES", 0, Format.R8G8B8A8_UNorm, 16, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 20, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 32, 0),
				new InputElement("COLOR", 1, Format.R8G8B8A8_UNorm, 36, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 40, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 48, 0),
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 56, 0)
			};
		}

		// Token: 0x040032EE RID: 13038
		public Vector3 Position;

		// Token: 0x040032EF RID: 13039
		public uint BlendWeights;

		// Token: 0x040032F0 RID: 13040
		public uint BlendIndices;

		// Token: 0x040032F1 RID: 13041
		public Vector3 Normal;

		// Token: 0x040032F2 RID: 13042
		public uint Colour0;

		// Token: 0x040032F3 RID: 13043
		public uint Colour1;

		// Token: 0x040032F4 RID: 13044
		public Vector2 Texcoord0;

		// Token: 0x040032F5 RID: 13045
		public Vector2 Texcoord1;

		// Token: 0x040032F6 RID: 13046
		public Vector4 Tangents;
	}
}
