using System;
using System.Collections.Generic;
using RageLib.Data;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200027D RID: 637
	public class PsoArray1 : IPsoValue
	{
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00083762 File Offset: 0x00081962
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x0008376A File Offset: 0x0008196A
		public List<IPsoValue> Entries { get; set; }

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00083773 File Offset: 0x00081973
		public PsoArray1(PsoFile pso, PsoStructureInfo structureInfo, PsoStructureEntryInfo entryInfo, int numberOfEntries)
		{
			this.pso = pso;
			this.structureInfo = structureInfo;
			this.entryInfo = entryInfo;
			this.numberOfEntries = numberOfEntries;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00083798 File Offset: 0x00081998
		public void Read(PsoDataReader reader)
		{
			this.Entries = new List<IPsoValue>();
			for (int i = 0; i < this.numberOfEntries; i++)
			{
				IPsoValue psoValue = PsoTypeBuilder.Make(this.pso, this.structureInfo, this.entryInfo);
				psoValue.Read(reader);
				this.Entries.Add(psoValue);
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}

		// Token: 0x04003FAE RID: 16302
		public readonly PsoFile pso;

		// Token: 0x04003FAF RID: 16303
		public readonly PsoStructureInfo structureInfo;

		// Token: 0x04003FB0 RID: 16304
		public readonly PsoStructureEntryInfo entryInfo;

		// Token: 0x04003FB1 RID: 16305
		public readonly int numberOfEntries;
	}
}
