using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200012C RID: 300
	public struct VertexTypePNC
	{
		// Token: 0x060004B9 RID: 1209 RVA: 0x0002018C File Offset: 0x0001E38C
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0)
			};
		}

		// Token: 0x04003352 RID: 13138
		public Vector3 Position;

		// Token: 0x04003353 RID: 13139
		public Vector3 Normal;

		// Token: 0x04003354 RID: 13140
		public uint Colour;
	}
}
