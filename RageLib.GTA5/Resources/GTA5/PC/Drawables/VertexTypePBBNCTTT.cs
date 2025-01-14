using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200013A RID: 314
	public struct VertexTypePBBNCTTT
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x0002094C File Offset: 0x0001EB4C
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
				new InputElement("TEXCOORD", 2, Format.R32G32_Float, 52, 0)
			};
		}

		// Token: 0x040033A3 RID: 13219
		public Vector3 Position;

		// Token: 0x040033A4 RID: 13220
		public uint BlendWeights;

		// Token: 0x040033A5 RID: 13221
		public uint BlendIndices;

		// Token: 0x040033A6 RID: 13222
		public Vector3 Normal;

		// Token: 0x040033A7 RID: 13223
		public uint Colour0;

		// Token: 0x040033A8 RID: 13224
		public Vector2 Texcoord0;

		// Token: 0x040033A9 RID: 13225
		public Vector2 Texcoord1;

		// Token: 0x040033AA RID: 13226
		public Vector2 Texcoord2;
	}
}
