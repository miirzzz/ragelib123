using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x020000AA RID: 170
	public struct CLODLight
	{
		// Token: 0x04002BE4 RID: 11236
		public uint Unused0;

		// Token: 0x04002BE5 RID: 11237
		public uint Unused1;

		// Token: 0x04002BE6 RID: 11238
		public Array_Structure direction;

		// Token: 0x04002BE7 RID: 11239
		public Array_float falloff;

		// Token: 0x04002BE8 RID: 11240
		public Array_float falloffExponent;

		// Token: 0x04002BE9 RID: 11241
		public Array_uint timeAndStateFlags;

		// Token: 0x04002BEA RID: 11242
		public Array_uint hash;

		// Token: 0x04002BEB RID: 11243
		public Array_byte coneInnerAngle;

		// Token: 0x04002BEC RID: 11244
		public Array_byte coneOuterAngleOrCapExt;

		// Token: 0x04002BED RID: 11245
		public Array_byte coronaIntensity;
	}
}
