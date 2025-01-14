using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200013C RID: 316
	public struct VertexTypePNCTTT
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x00020A98 File Offset: 0x0001EC98
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 28, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 36, 0),
				new InputElement("TEXCOORD", 2, Format.R32G32_Float, 44, 0)
			};
		}

		// Token: 0x040033B0 RID: 13232
		public Vector3 Position;

		// Token: 0x040033B1 RID: 13233
		public Vector3 Normal;

		// Token: 0x040033B2 RID: 13234
		public uint Colour;

		// Token: 0x040033B3 RID: 13235
		public Vector2 Texcoord0;

		// Token: 0x040033B4 RID: 13236
		public Vector2 Texcoord1;

		// Token: 0x040033B5 RID: 13237
		public Vector2 Texcoord2;
	}
}
