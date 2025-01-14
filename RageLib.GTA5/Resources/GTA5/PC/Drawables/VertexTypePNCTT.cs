using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200013B RID: 315
	public struct VertexTypePNCTT
	{
		// Token: 0x060004C8 RID: 1224 RVA: 0x00020A14 File Offset: 0x0001EC14
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 28, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 36, 0)
			};
		}

		// Token: 0x040033AB RID: 13227
		public Vector3 Position;

		// Token: 0x040033AC RID: 13228
		public Vector3 Normal;

		// Token: 0x040033AD RID: 13229
		public uint Colour;

		// Token: 0x040033AE RID: 13230
		public Vector2 Texcoord0;

		// Token: 0x040033AF RID: 13231
		public Vector2 Texcoord1;
	}
}
