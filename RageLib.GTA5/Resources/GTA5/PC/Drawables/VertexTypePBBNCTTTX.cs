using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200013D RID: 317
	public struct VertexTypePBBNCTTTX
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x00020B34 File Offset: 0x0001ED34
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
				new InputElement("TEXCOORD", 2, Format.R32G32_Float, 52, 0),
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 60, 0)
			};
		}

		// Token: 0x040033B6 RID: 13238
		public Vector3 Position;

		// Token: 0x040033B7 RID: 13239
		public uint BlendWeights;

		// Token: 0x040033B8 RID: 13240
		public uint BlendIndices;

		// Token: 0x040033B9 RID: 13241
		public Vector3 Normal;

		// Token: 0x040033BA RID: 13242
		public uint Colour0;

		// Token: 0x040033BB RID: 13243
		public Vector2 Texcoord0;

		// Token: 0x040033BC RID: 13244
		public Vector2 Texcoord1;

		// Token: 0x040033BD RID: 13245
		public Vector2 Texcoord2;

		// Token: 0x040033BE RID: 13246
		public Vector4 Tangent;
	}
}
