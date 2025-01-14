using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000124 RID: 292
	public struct VertexTypePBBNCCTX
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x0001FD48 File Offset: 0x0001DF48
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
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 48, 0)
			};
		}

		// Token: 0x04003328 RID: 13096
		public Vector3 Position;

		// Token: 0x04003329 RID: 13097
		public uint BlendWeights;

		// Token: 0x0400332A RID: 13098
		public uint BlendIndices;

		// Token: 0x0400332B RID: 13099
		public Vector3 Normal;

		// Token: 0x0400332C RID: 13100
		public uint Colour0;

		// Token: 0x0400332D RID: 13101
		public uint Colour1;

		// Token: 0x0400332E RID: 13102
		public Vector2 Texcoord;

		// Token: 0x0400332F RID: 13103
		public Vector4 Tangent;
	}
}
