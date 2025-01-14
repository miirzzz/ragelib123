using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000132 RID: 306
	public struct VertexTypePCTT
	{
		// Token: 0x060004BF RID: 1215 RVA: 0x00020488 File Offset: 0x0001E688
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 12, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 16, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 24, 0)
			};
		}

		// Token: 0x0400336F RID: 13167
		public Vector3 Position;

		// Token: 0x04003370 RID: 13168
		public uint Colour;

		// Token: 0x04003371 RID: 13169
		public Vector2 Texcoord0;

		// Token: 0x04003372 RID: 13170
		public Vector2 Texcoord1;
	}
}
