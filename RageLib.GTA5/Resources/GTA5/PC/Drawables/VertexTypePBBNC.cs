using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000135 RID: 309
	public struct VertexTypePBBNC
	{
		// Token: 0x060004C2 RID: 1218 RVA: 0x0002065C File Offset: 0x0001E85C
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("BLENDWEIGHTS", 0, Format.R8G8B8A8_UNorm, 12, 0),
				new InputElement("BLENDINDICES", 0, Format.R8G8B8A8_UNorm, 16, 0),
				new InputElement("NORMAL", 0, Format.R32G32B32_Float, 20, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 32, 0)
			};
		}

		// Token: 0x04003381 RID: 13185
		public Vector3 Position;

		// Token: 0x04003382 RID: 13186
		public uint BlendWeights;

		// Token: 0x04003383 RID: 13187
		public uint BlendIndices;

		// Token: 0x04003384 RID: 13188
		public Vector3 Normal;

		// Token: 0x04003385 RID: 13189
		public uint Colour0;
	}
}
