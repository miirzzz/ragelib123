using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200012D RID: 301
	public struct VertexTypePBBNCT
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x000201E4 File Offset: 0x0001E3E4
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("BLENDWEIGHTS", 0, Format.R8G8B8A8_UNorm, 12, 0),
				new InputElement("BLENDINDICES", 0, Format.R8G8B8A8_UNorm, 16, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 20, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 32, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 36, 0)
			};
		}

		// Token: 0x04003355 RID: 13141
		public Vector3 Position;

		// Token: 0x04003356 RID: 13142
		public uint BlendWeights;

		// Token: 0x04003357 RID: 13143
		public uint BlendIndices;

		// Token: 0x04003358 RID: 13144
		public Vector3 Normal;

		// Token: 0x04003359 RID: 13145
		public uint Colour0;

		// Token: 0x0400335A RID: 13146
		public Vector2 Texcoord;
	}
}
