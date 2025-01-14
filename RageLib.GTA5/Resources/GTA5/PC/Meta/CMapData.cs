using System;
using SharpDX;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x020000AD RID: 173
	public struct CMapData
	{
		// Token: 0x04002BFB RID: 11259
		public uint Unused0;

		// Token: 0x04002BFC RID: 11260
		public uint Unused1;

		// Token: 0x04002BFD RID: 11261
		public uint name;

		// Token: 0x04002BFE RID: 11262
		public uint parent;

		// Token: 0x04002BFF RID: 11263
		public uint flags;

		// Token: 0x04002C00 RID: 11264
		public uint contentFlags;

		// Token: 0x04002C01 RID: 11265
		public uint Unused2;

		// Token: 0x04002C02 RID: 11266
		public uint Unused3;

		// Token: 0x04002C03 RID: 11267
		public Vector3 streamingExtentsMin;

		// Token: 0x04002C04 RID: 11268
		public uint Unused4;

		// Token: 0x04002C05 RID: 11269
		public Vector3 streamingExtentsMax;

		// Token: 0x04002C06 RID: 11270
		public uint Unused5;

		// Token: 0x04002C07 RID: 11271
		public Vector3 entitiesExtentsMin;

		// Token: 0x04002C08 RID: 11272
		public uint Unused6;

		// Token: 0x04002C09 RID: 11273
		public Vector3 entitiesExtentsMax;

		// Token: 0x04002C0A RID: 11274
		public uint Unused7;

		// Token: 0x04002C0B RID: 11275
		public Array_StructurePointer entities;

		// Token: 0x04002C0C RID: 11276
		public Array_Structure containerLods;

		// Token: 0x04002C0D RID: 11277
		public Array_Structure boxOccluders;

		// Token: 0x04002C0E RID: 11278
		public Array_Structure occludeModels;

		// Token: 0x04002C0F RID: 11279
		public Array_uint physicsDictionaries;

		// Token: 0x04002C10 RID: 11280
		public rage__fwInstancedMapData instancedData;

		// Token: 0x04002C11 RID: 11281
		public Array_Structure timeCycleModifiers;

		// Token: 0x04002C12 RID: 11282
		public Array_Structure carGenerators;

		// Token: 0x04002C13 RID: 11283
		public CLODLight LODLightsSOA;

		// Token: 0x04002C14 RID: 11284
		public CDistantLODLight DistantLODLightsSOA;

		// Token: 0x04002C15 RID: 11285
		public CBlockDesc block;
	}
}
