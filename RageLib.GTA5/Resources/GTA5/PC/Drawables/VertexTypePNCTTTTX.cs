using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000133 RID: 307
	public struct VertexTypePNCTTTTX
	{
		// Token: 0x060004C0 RID: 1216 RVA: 0x000204F8 File Offset: 0x0001E6F8
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
				new InputElement("TEXCOORD", 3, Format.R32G32_Float, 52, 0),
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 60, 0)
			};
		}

		// Token: 0x04003373 RID: 13171
		public Vector3 Position;

		// Token: 0x04003374 RID: 13172
		public Vector3 Normal;

		// Token: 0x04003375 RID: 13173
		public uint Colour;

		// Token: 0x04003376 RID: 13174
		public Vector2 Texcoord0;

		// Token: 0x04003377 RID: 13175
		public Vector2 Texcoord1;

		// Token: 0x04003378 RID: 13176
		public Vector2 Texcoord2;

		// Token: 0x04003379 RID: 13177
		public Vector2 Texcoord3;

		// Token: 0x0400337A RID: 13178
		public Vector4 Tangent;
	}
}
