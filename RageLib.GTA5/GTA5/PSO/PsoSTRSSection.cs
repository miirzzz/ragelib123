using System;
using System.Collections.Generic;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000217 RID: 535
	public class PsoSTRSSection
	{
		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0003DA0E File Offset: 0x0003BC0E
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x0003DA16 File Offset: 0x0003BC16
		public int Ident { get; private set; } = 1398035027;

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0003DA1F File Offset: 0x0003BC1F
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x0003DA27 File Offset: 0x0003BC27
		public int Length { get; set; }

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0003DA30 File Offset: 0x0003BC30
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x0003DA38 File Offset: 0x0003BC38
		public string[] Strings { get; set; }

		// Token: 0x06000A14 RID: 2580 RVA: 0x0003DA44 File Offset: 0x0003BC44
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

		// Token: 0x06000A15 RID: 2581 RVA: 0x0003DA97 File Offset: 0x0003BC97
		public void Write(DataWriter writer)
		{
			writer.Write(this.Ident);
			writer.Write(this.Length);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0003DAB4 File Offset: 0x0003BCB4
		public override string ToString()
		{
			return this.Ident.ToString() + ": " + this.Length.ToString();
		}
	}
}
