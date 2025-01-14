using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200026F RID: 623
	public struct CScenarioPointManifest : IPsoSwapEnd
	{
		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00081B5F File Offset: 0x0007FD5F
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00081B67 File Offset: 0x0007FD67
		public int VersionNumber { get; set; }

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00081B70 File Offset: 0x0007FD70
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00081B78 File Offset: 0x0007FD78
		public uint Unused0 { get; set; }

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00081B81 File Offset: 0x0007FD81
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00081B89 File Offset: 0x0007FD89
		public Array_StructurePointer RegionDefs { get; set; }

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00081B92 File Offset: 0x0007FD92
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00081B9A File Offset: 0x0007FD9A
		public Array_StructurePointer Groups { get; set; }

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00081BA3 File Offset: 0x0007FDA3
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00081BAB File Offset: 0x0007FDAB
		public Array_uint InteriorNames { get; set; }

		// Token: 0x06000A6A RID: 2666 RVA: 0x00081BB4 File Offset: 0x0007FDB4
		public override string ToString()
		{
			return this.VersionNumber.ToString();
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00081BD0 File Offset: 0x0007FDD0
		public void SwapEnd()
		{
			this.VersionNumber = MetaUtils.SwapBytes(this.VersionNumber);
			Array_StructurePointer regionDefs = this.RegionDefs;
			regionDefs.SwapEnd();
			this.RegionDefs = regionDefs;
			Array_StructurePointer groups = this.Groups;
			groups.SwapEnd();
			this.Groups = groups;
			Array_uint interiorNames = this.InteriorNames;
			interiorNames.SwapEnd();
			this.InteriorNames = interiorNames;
		}
	}
}
