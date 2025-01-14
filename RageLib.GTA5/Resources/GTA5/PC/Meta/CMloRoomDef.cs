using System;
using SharpDX;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x020000B7 RID: 183
	public struct CMloRoomDef
	{
		// Token: 0x04002CDA RID: 11482
		public uint Unused0;

		// Token: 0x04002CDB RID: 11483
		public uint Unused1;

		// Token: 0x04002CDC RID: 11484
		public CharPointer name;

		// Token: 0x04002CDD RID: 11485
		public uint Unused2;

		// Token: 0x04002CDE RID: 11486
		public uint Unused3;

		// Token: 0x04002CDF RID: 11487
		public Vector3 bbMin;

		// Token: 0x04002CE0 RID: 11488
		public uint Unused4;

		// Token: 0x04002CE1 RID: 11489
		public Vector3 bbMax;

		// Token: 0x04002CE2 RID: 11490
		public uint Unused5;

		// Token: 0x04002CE3 RID: 11491
		public float blend;

		// Token: 0x04002CE4 RID: 11492
		public uint timecycleName;

		// Token: 0x04002CE5 RID: 11493
		public uint secondaryTimecycleName;

		// Token: 0x04002CE6 RID: 11494
		public uint flags;

		// Token: 0x04002CE7 RID: 11495
		public uint portalCount;

		// Token: 0x04002CE8 RID: 11496
		public int floorId;

		// Token: 0x04002CE9 RID: 11497
		public int exteriorVisibiltyDepth;

		// Token: 0x04002CEA RID: 11498
		public uint Unused6;

		// Token: 0x04002CEB RID: 11499
		public Array_uint attachedObjects;
	}
}
