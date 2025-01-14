using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000128 RID: 296
	public struct VertexTypePNCCTX
	{
		// Token: 0x060004B5 RID: 1205 RVA: 0x0002000C File Offset: 0x0001E20C
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("COLOR", 1, Format.R8G8B8A8_UNorm, 28, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 32, 0),
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 40, 0)
			};
		}

		// Token: 0x04003344 RID: 13124
		public Vector3 Position;

		// Token: 0x04003345 RID: 13125
		public Vector3 Normal;

		// Token: 0x04003346 RID: 13126
		public uint Colour0;

		// Token: 0x04003347 RID: 13127
		public uint Colour1;

		// Token: 0x04003348 RID: 13128
		public Vector2 Texcoord;

		// Token: 0x04003349 RID: 13129
		public Vector4 Tangent;
	}
}
