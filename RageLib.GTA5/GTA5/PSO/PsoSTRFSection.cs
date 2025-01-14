using System;
using System.Collections.Generic;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000216 RID: 534
	public class PsoSTRFSection
	{
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0003D922 File Offset: 0x0003BB22
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x0003D92A File Offset: 0x0003BB2A
		public int Ident { get; private set; } = 1398035014;

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0003D933 File Offset: 0x0003BB33
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x0003D93B File Offset: 0x0003BB3B
		public int Length { get; set; }

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0003D944 File Offset: 0x0003BB44
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x0003D94C File Offset: 0x0003BB4C
		public string[] Strings { get; set; }

		// Token: 0x06000A0A RID: 2570 RVA: 0x0003D958 File Offset: 0x0003BB58
		public void Read(DataReader reader)
		{
			this.Ident = reader.ReadInt32();
			this.Length = reader.ReadInt32();
			List<string> list = new List<string>();
			while (reader.Position < reader.Length)
			{
				list.Add(reader.ReadString());
			}
			this.Strings = list.ToArray();
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0003D9AB File Offset: 0x0003BBAB
		public void Write(DataWriter writer)
		{
			writer.Write(this.Ident);
			writer.Write(this.Length);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0003D9C8 File Offset: 0x0003BBC8
		public override string ToString()
		{
			return this.Ident.ToString() + ": " + this.Length.ToString();
		}
	}
}
