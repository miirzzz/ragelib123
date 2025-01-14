using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200011B RID: 283
	public struct VertexTypePNCCTTTT
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x0001F6C8 File Offset: 0x0001D8C8
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
				new InputElement("TEXCOORD", 2, Format.R32G32_Float, 48, 0),
				new InputElement("TEXCOORD", 3, Format.R32G32_Float, 56, 0)
			};
		}

		// Token: 0x040032E6 RID: 13030
		public Vector3 Position;

		// Token: 0x040032E7 RID: 13031
		public Vector3 Normal;

		// Token: 0x040032E8 RID: 13032
		public uint Colour0;

		// Token: 0x040032E9 RID: 13033
		public uint Colour1;

		// Token: 0x040032EA RID: 13034
		public Vector2 Texcoord0;

		// Token: 0x040032EB RID: 13035
		public Vector2 Texcoord1;

		// Token: 0x040032EC RID: 13036
		public Vector2 Texcoord2;

		// Token: 0x040032ED RID: 13037
		public Vector2 Texcoord3;
	}
}
