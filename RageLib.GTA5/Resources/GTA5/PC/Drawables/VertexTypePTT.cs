using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200012B RID: 299
	public struct VertexTypePTT
	{
		// Token: 0x060004B8 RID: 1208 RVA: 0x00020134 File Offset: 0x0001E334
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 12, 0),
				new InputElement("TEXCOORD", 1, Format.R32G32_Float, 20, 0)
			};
		}

		// Token: 0x0400334F RID: 13135
		public Vector3 Position;

		// Token: 0x04003350 RID: 13136
		public Vector2 Texcoord0;

		// Token: 0x04003351 RID: 13137
		public Vector2 Texcoord1;
	}
}
