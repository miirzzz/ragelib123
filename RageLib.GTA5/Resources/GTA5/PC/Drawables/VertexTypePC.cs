using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200012E RID: 302
	public struct VertexTypePC
	{
		// Token: 0x060004BB RID: 1211 RVA: 0x0002027E File Offset: 0x0001E47E
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 12, 0)
			};
		}

		// Token: 0x0400335B RID: 13147
		public Vector3 Position;

		// Token: 0x0400335C RID: 13148
		public uint Colour;
	}
}
