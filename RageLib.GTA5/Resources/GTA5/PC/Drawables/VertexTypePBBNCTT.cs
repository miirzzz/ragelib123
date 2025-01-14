using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000138 RID: 312
	public struct VertexTypePBBNCTT
	{
		// Token: 0x060004C5 RID: 1221 RVA: 0x000207D0 File Offset: 0x0001E9D0
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
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 44, 0)
			};
		}

		// Token: 0x04003394 RID: 13204
		public Vector3 Position;

		// Token: 0x04003395 RID: 13205
		public uint BlendWeights;

		// Token: 0x04003396 RID: 13206
		public uint BlendIndices;

		// Token: 0x04003397 RID: 13207
		public Vector3 Normal;

		// Token: 0x04003398 RID: 13208
		public uint Colour0;

		// Token: 0x04003399 RID: 13209
		public Vector2 Texcoord0;

		// Token: 0x0400339A RID: 13210
		public Vector2 Texcoord1;
	}
}
