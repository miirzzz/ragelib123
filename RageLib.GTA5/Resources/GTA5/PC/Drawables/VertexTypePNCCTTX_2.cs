using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000125 RID: 293
	public struct VertexTypePNCCTTX_2
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x0001FE10 File Offset: 0x0001E010
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("COLOR", 1, Format.R8G8B8A8_UNorm, 28, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 32, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 40, 0),
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 48, 0)
			};
		}

		// Token: 0x04003330 RID: 13104
		public Vector3 Position;

		// Token: 0x04003331 RID: 13105
		public Vector3 Normal;

		// Token: 0x04003332 RID: 13106
		public uint Colour0;

		// Token: 0x04003333 RID: 13107
		public uint Colour1;

		// Token: 0x04003334 RID: 13108
		public Vector2 Texcoord0;

		// Token: 0x04003335 RID: 13109
		public Vector2 Texcoord1;

		// Token: 0x04003336 RID: 13110
		public Vector4 Tangent;
	}
}
