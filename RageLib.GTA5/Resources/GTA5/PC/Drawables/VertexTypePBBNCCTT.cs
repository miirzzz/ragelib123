using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000131 RID: 305
	public struct VertexTypePBBNCCTT
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x000203C0 File Offset: 0x0001E5C0
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
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 48, 0)
			};
		}

		// Token: 0x04003367 RID: 13159
		public Vector3 Position;

		// Token: 0x04003368 RID: 13160
		public uint BlendWeights;

		// Token: 0x04003369 RID: 13161
		public uint BlendIndices;

		// Token: 0x0400336A RID: 13162
		public Vector3 Normal;

		// Token: 0x0400336B RID: 13163
		public uint Colour2;

		// Token: 0x0400336C RID: 13164
		public uint Colour3;

		// Token: 0x0400336D RID: 13165
		public Vector2 Texcoord0;

		// Token: 0x0400336E RID: 13166
		public Vector2 Texcoord1;
	}
}
