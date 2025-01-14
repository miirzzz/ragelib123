using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200011D RID: 285
	public struct VertexTypePBBNCCT
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x0001F870 File Offset: 0x0001DA70
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
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 40, 0)
			};
		}

		// Token: 0x040032F7 RID: 13047
		public Vector3 Position;

		// Token: 0x040032F8 RID: 13048
		public uint BlendWeights;

		// Token: 0x040032F9 RID: 13049
		public uint BlendIndices;

		// Token: 0x040032FA RID: 13050
		public Vector3 Normal;

		// Token: 0x040032FB RID: 13051
		public uint Colour0;

		// Token: 0x040032FC RID: 13052
		public uint Colour1;

		// Token: 0x040032FD RID: 13053
		public Vector2 Texcoord;
	}
}
