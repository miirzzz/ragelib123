using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200012F RID: 303
	public struct VertexTypePCC
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x000202B4 File Offset: 0x0001E4B4
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 12, 0),
				new InputElement("COLOR", 1, Format.R8G8B8A8_UNorm, 16, 0)
			};
		}

		// Token: 0x0400335D RID: 13149
		public Vector3 Position;

		// Token: 0x0400335E RID: 13150
		public uint Colour0;

		// Token: 0x0400335F RID: 13151
		public uint Colour1;
	}
}
