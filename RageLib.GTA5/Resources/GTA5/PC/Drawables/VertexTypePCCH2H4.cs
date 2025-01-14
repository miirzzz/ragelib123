using System;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000136 RID: 310
	public struct VertexTypePCCH2H4
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x000206E0 File Offset: 0x0001E8E0
		public static InputElement[] GetLayout()
		{
			return new InputElement[]
			{
				new InputElement("POSITION", 0, Format.R32G32B32_Float, 0, 0),
				new InputElement("NORMAL", 0, Format.R8G8B8A8_SNorm, 12, 0),
				new InputElement("COLOR", 0, Format.R8G8B8A8_UNorm, 16, 0),
				new InputElement("TEXCOORD", 0, Format.R16G16_Float, 20, 0),
				new InputElement("TANGENT", 0, Format.R16G16B16A16_Float, 24, 0)
			};
		}

		// Token: 0x04003386 RID: 13190
		public Vector3 Position;

		// Token: 0x04003387 RID: 13191
		public uint NormalPacked;

		// Token: 0x04003388 RID: 13192
		public uint Colour;

		// Token: 0x04003389 RID: 13193
		public ushort TexcoordX;

		// Token: 0x0400338A RID: 13194
		public ushort TexcoordY;

		// Token: 0x0400338B RID: 13195
		public ushort TangentX;

		// Token: 0x0400338C RID: 13196
		public ushort TangentY;

		// Token: 0x0400338D RID: 13197
		public ushort TangentZ;

		// Token: 0x0400338E RID: 13198
		public ushort TangentW;
	}
}
