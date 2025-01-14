using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000127 RID: 295
	public struct VertexTypePNCCTT
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x0001FF70 File Offset: 0x0001E170
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("COLOR", 1, Format.R8G8B8A8_UNorm, 28, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 32, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 40, 0)
			};
		}

		// Token: 0x0400333E RID: 13118
		public Vector3 Position;

		// Token: 0x0400333F RID: 13119
		public Vector3 Normal;

		// Token: 0x04003340 RID: 13120
		public uint Colour0;

		// Token: 0x04003341 RID: 13121
		public uint Colour1;

		// Token: 0x04003342 RID: 13122
		public Vector2 Texcoord0;

		// Token: 0x04003343 RID: 13123
		public Vector2 Texcoord1;
	}
}
