using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000126 RID: 294
	public struct VertexTypePBBNCTX
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
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
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 44, 0)
			};
		}

		// Token: 0x04003337 RID: 13111
		public Vector3 Position;

		// Token: 0x04003338 RID: 13112
		public uint BlendWeights;

		// Token: 0x04003339 RID: 13113
		public uint BlendIndices;

		// Token: 0x0400333A RID: 13114
		public Vector3 Normal;

		// Token: 0x0400333B RID: 13115
		public uint Colour0;

		// Token: 0x0400333C RID: 13116
		public Vector2 Texcoord;

		// Token: 0x0400333D RID: 13117
		public Vector4 Tangent;
	}
}
