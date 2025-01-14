using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000134 RID: 308
	public struct VertexTypePBBCCT
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x000205C0 File Offset: 0x0001E7C0
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("BLENDWEIGHTS", 0, Format.R8G8B8A8_UNorm, 12, 0),
				new InputElement("BLENDINDICES", 0, Format.R8G8B8A8_UNorm, 16, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 20, 0),
				new InputElement("COLOR", 1, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 28, 0)
			};
		}

		// Token: 0x0400337B RID: 13179
		public Vector3 Position;

		// Token: 0x0400337C RID: 13180
		public uint BlendWeights;

		// Token: 0x0400337D RID: 13181
		public uint BlendIndices;

		// Token: 0x0400337E RID: 13182
		public uint Colour0;

		// Token: 0x0400337F RID: 13183
		public uint Colour1;

		// Token: 0x04003380 RID: 13184
		public Vector2 Texcoord;
	}
}
