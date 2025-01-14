using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000269 RID: 617
	public struct CMapDataGroup : IPsoSwapEnd
	{
		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000815B7 File Offset: 0x0007F7B7
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x000815BF File Offset: 0x0007F7BF
		public MetaName Name { get; set; }

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x000815C8 File Offset: 0x0007F7C8
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x000815D0 File Offset: 0x0007F7D0
		public uint Unused0 { get; set; }

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x000815D9 File Offset: 0x0007F7D9
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x000815E1 File Offset: 0x0007F7E1
		public Array_uint Bounds { get; set; }

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x000815EA File Offset: 0x0007F7EA
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x000815F2 File Offset: 0x0007F7F2
		public ushort Flags { get; set; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x000815FB File Offset: 0x0007F7FB
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00081603 File Offset: 0x0007F803
		public ushort Unused1 { get; set; }

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0008160C File Offset: 0x0007F80C
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00081614 File Offset: 0x0007F814
		public uint Unused2 { get; set; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0008161D File Offset: 0x0007F81D
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00081625 File Offset: 0x0007F825
		public Array_uint WeatherTypes { get; set; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0008162E File Offset: 0x0007F82E
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00081636 File Offset: 0x0007F836
		public uint HoursOnOff { get; set; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0008163F File Offset: 0x0007F83F
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00081647 File Offset: 0x0007F847
		public uint Unused3 { get; set; }

		// Token: 0x06000A2E RID: 2606 RVA: 0x00081650 File Offset: 0x0007F850
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.Name.ToString(),
				": ybn:",
				this.Bounds.Count1.ToString(),
				", wt:",
				this.WeatherTypes.Count1.ToString(),
				", flags:",
				this.Flags.ToString(),
				", hours:",
				this.HoursOnOff.ToString()
			});
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000816F4 File Offset: 0x0007F8F4
		public void SwapEnd()
		{
			this.Name = (MetaName)MetaUtils.SwapBytes((uint)this.Name);
			Array_uint bounds = this.Bounds;
			bounds.SwapEnd();
			this.Bounds = bounds;
			Array_uint weatherTypes = this.WeatherTypes;
			weatherTypes.SwapEnd();
			this.WeatherTypes = weatherTypes;
			this.HoursOnOff = MetaUtils.SwapBytes(this.HoursOnOff);
			this.Flags = MetaUtils.SwapBytes(this.Flags);
		}
	}
}
