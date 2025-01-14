using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000118 RID: 280
	public struct VertexTypeDefault
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x0001F554 File Offset: 0x0001D754
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 28, 0)
			};
		}

		// Token: 0x040032D8 RID: 13016
		public Vector3 Position;

		// Token: 0x040032D9 RID: 13017
		public Vector3 Normal;

		// Token: 0x040032DA RID: 13018
		public uint Colour;

		// Token: 0x040032DB RID: 13019
		public Vector2 Texcoord;
	}
}
