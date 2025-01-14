using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200011A RID: 282
	public struct VertexTypePNCCT
	{
		// Token: 0x060004A7 RID: 1191 RVA: 0x0001F644 File Offset: 0x0001D844
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("COLOR", 1, Format.R8G8B8A8_UNorm, 28, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 32, 0)
			};
		}

		// Token: 0x040032E1 RID: 13025
		public Vector3 Position;

		// Token: 0x040032E2 RID: 13026
		public Vector3 Normal;

		// Token: 0x040032E3 RID: 13027
		public uint Colour0;

		// Token: 0x040032E4 RID: 13028
		public uint Colour1;

		// Token: 0x040032E5 RID: 13029
		public Vector2 Texcoord;
	}
}
