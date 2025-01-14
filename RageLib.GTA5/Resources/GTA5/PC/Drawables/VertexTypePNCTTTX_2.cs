using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200011F RID: 287
	public struct VertexTypePNCTTTX_2
	{
		// Token: 0x060004AC RID: 1196 RVA: 0x0001F9D4 File Offset: 0x0001DBD4
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
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 52, 0)
			};
		}

		// Token: 0x04003305 RID: 13061
		public Vector3 Position;

		// Token: 0x04003306 RID: 13062
		public Vector3 Normal;

		// Token: 0x04003307 RID: 13063
		public uint Colour;

		// Token: 0x04003308 RID: 13064
		public Vector2 Texcoord0;

		// Token: 0x04003309 RID: 13065
		public Vector2 Texcoord1;

		// Token: 0x0400330A RID: 13066
		public Vector2 Texcoord2;

		// Token: 0x0400330B RID: 13067
		public Vector4 Tangents;
	}
}
