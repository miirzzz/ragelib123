using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000137 RID: 311
	public struct VertexTypePNCH2
	{
		// Token: 0x060004C4 RID: 1220 RVA: 0x00020764 File Offset: 0x0001E964
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("TEXCOORD", 0, Format.R16G16_Float, 28, 0)
			};
		}

		// Token: 0x0400338F RID: 13199
		public Vector3 Position;

		// Token: 0x04003390 RID: 13200
		public Vector3 Normal;

		// Token: 0x04003391 RID: 13201
		public uint Colour;

		// Token: 0x04003392 RID: 13202
		public ushort TexcoordX;

		// Token: 0x04003393 RID: 13203
		public ushort TexcoordY;
	}
}
