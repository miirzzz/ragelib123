using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000130 RID: 304
	public struct VertexTypePNCTTTT
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x0002030C File Offset: 0x0001E50C
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 28, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 36, 0),
				new InputElement("TEXCOORD", 2, Format.R32G32_Float, 44, 0),
				new InputElement("TEXCOORD", 3, Format.R32G32_Float, 52, 0)
			};
		}

		// Token: 0x04003360 RID: 13152
		public Vector3 Position;

		// Token: 0x04003361 RID: 13153
		public Vector3 Normal;

		// Token: 0x04003362 RID: 13154
		public uint Colour;

		// Token: 0x04003363 RID: 13155
		public Vector2 Texcoord0;

		// Token: 0x04003364 RID: 13156
		public Vector2 Texcoord1;

		// Token: 0x04003365 RID: 13157
		public Vector2 Texcoord2;

		// Token: 0x04003366 RID: 13158
		public Vector2 Texcoord3;
	}
}
