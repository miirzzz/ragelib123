using System;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001B5 RID: 437
	public struct LODLightEntry
	{
		// Token: 0x04003826 RID: 14374
		public MVECTOR3 Direction;

		// Token: 0x04003827 RID: 14375
		public float FallOff;

		// Token: 0x04003828 RID: 14376
		public float FalloffExponent;

		// Token: 0x04003829 RID: 14377
		public uint TimeAndStateFlags;

		// Token: 0x0400382A RID: 14378
		public uint Hash;

		// Token: 0x0400382B RID: 14379
		public byte ConeInnerAngle;

		// Token: 0x0400382C RID: 14380
		public byte ConeOuterAngleOrCapExt;

		// Token: 0x0400382D RID: 14381
		public byte CoronaIntensity;
	}
}
