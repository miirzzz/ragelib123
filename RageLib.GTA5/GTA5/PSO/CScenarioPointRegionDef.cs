using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000270 RID: 624
	public struct CScenarioPointRegionDef : IPsoSwapEnd
	{
		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00081C2D File Offset: 0x0007FE2D
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00081C35 File Offset: 0x0007FE35
		public MetaName Name { get; set; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00081C3E File Offset: 0x0007FE3E
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00081C46 File Offset: 0x0007FE46
		public uint Unused0 { get; set; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00081C4F File Offset: 0x0007FE4F
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00081C57 File Offset: 0x0007FE57
		public uint Unused1 { get; set; }

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00081C60 File Offset: 0x0007FE60
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00081C68 File Offset: 0x0007FE68
		public uint Unused2 { get; set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00081C71 File Offset: 0x0007FE71
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00081C79 File Offset: 0x0007FE79
		public rage__spdAABB AABB { get; set; }

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00081C82 File Offset: 0x0007FE82
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00081C8A File Offset: 0x0007FE8A
		public uint Unused3 { get; set; }

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00081C93 File Offset: 0x0007FE93
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00081C9B File Offset: 0x0007FE9B
		public uint Unused4 { get; set; }

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x00081CA4 File Offset: 0x0007FEA4
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00081CAC File Offset: 0x0007FEAC
		public uint Unused5 { get; set; }

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00081CB5 File Offset: 0x0007FEB5
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00081CBD File Offset: 0x0007FEBD
		public uint Unused6 { get; set; }

		// Token: 0x06000A7E RID: 2686 RVA: 0x00081CC8 File Offset: 0x0007FEC8
		public override string ToString()
		{
			return this.Name.ToString() + ", " + this.AABB.ToString();
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00081D08 File Offset: 0x0007FF08
		public void SwapEnd()
		{
			this.Name = (MetaName)MetaUtils.SwapBytes((uint)this.Name);
			rage__spdAABB aabb = this.AABB;
			aabb.SwapEnd();
			this.AABB = aabb;
		}
	}
}
