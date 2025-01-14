using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000119 RID: 281
	public struct VertexTypeDefaultEx
	{
		// Token: 0x060004A6 RID: 1190 RVA: 0x0001F5C0 File Offset: 0x0001D7C0
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 24, 0),
				new InputElement("TEXCOORD", 0, Format.R32G32_Float, 28, 0),
				new InputElement("TANGENT", 0, Format.R32G32B32A32_Float, 36, 0)
			};
		}

		// Token: 0x040032DC RID: 13020
		public Vector3 Position;

		// Token: 0x040032DD RID: 13021
		public Vector3 Normal;

		// Token: 0x040032DE RID: 13022
		public uint Colour;

		// Token: 0x040032DF RID: 13023
		public Vector2 Texcoord;

		// Token: 0x040032E0 RID: 13024
		public Vector4 Tangent;
	}
}
