using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000139 RID: 313
	public struct VertexTypePBBNCTTX
	{
		// Token: 0x060004C6 RID: 1222 RVA: 0x00020884 File Offset: 0x0001EA84
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("BLENDWEIGHTS", 0, Format.R8G8B8A8_UNorm, 12, 0),
				new InputElement("BLENDINDICES", 0, Format.R8G8B8A8_UNorm, 16, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 20, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 32, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 36, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 44, 0),
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 52, 0)
			};
		}

		// Token: 0x0400339B RID: 13211
		public Vector3 Position;

		// Token: 0x0400339C RID: 13212
		public uint BlendWeights;

		// Token: 0x0400339D RID: 13213
		public uint BlendIndices;

		// Token: 0x0400339E RID: 13214
		public Vector3 Normal;

		// Token: 0x0400339F RID: 13215
		public uint Colour0;

		// Token: 0x040033A0 RID: 13216
		public Vector2 Texcoord0;

		// Token: 0x040033A1 RID: 13217
		public Vector2 Texcoord1;

		// Token: 0x040033A2 RID: 13218
		public Vector4 Tangent;
	}
}
