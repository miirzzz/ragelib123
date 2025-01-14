using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000129 RID: 297
	public struct VertexTypePCT
	{
		// Token: 0x060004B6 RID: 1206 RVA: 0x000200A8 File Offset: 0x0001E2A8
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 12, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 16, 0)
			};
		}

		// Token: 0x0400334A RID: 13130
		public Vector3 Position;

		// Token: 0x0400334B RID: 13131
		public uint Colour;

		// Token: 0x0400334C RID: 13132
		public Vector2 Texcoord;
	}
}
