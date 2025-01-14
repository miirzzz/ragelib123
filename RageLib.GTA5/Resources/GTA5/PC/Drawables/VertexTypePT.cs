using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200012A RID: 298
	public struct VertexTypePT
	{
		// Token: 0x060004B7 RID: 1207 RVA: 0x000200FE File Offset: 0x0001E2FE
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 12, 0)
			};
		}

		// Token: 0x0400334D RID: 13133
		public Vector3 Position;

		// Token: 0x0400334E RID: 13134
		public Vector2 Texcoord;
	}
}
