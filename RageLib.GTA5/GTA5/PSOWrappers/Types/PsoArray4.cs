using System;
using System.Collections.Generic;
using RageLib.Data;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200027E RID: 638
	public class PsoArray4 : IPsoValue
	{
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x000837EC File Offset: 0x000819EC
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x000837F4 File Offset: 0x000819F4
		public List<IPsoValue> Entries { get; set; }

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000837FD File Offset: 0x000819FD
		public PsoArray4(PsoFile pso, PsoStructureInfo structureInfo, PsoStructureEntryInfo entryInfo, int numberOfEntries)
		{
			this.pso = pso;
			this.structureInfo = structureInfo;
			this.entryInfo = entryInfo;
			this.numberOfEntries = numberOfEntries;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00083824 File Offset: 0x00081A24
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

		// Token: 0x06000AFA RID: 2810 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}

		// Token: 0x04003FB3 RID: 16307
		public readonly PsoFile pso;

		// Token: 0x04003FB4 RID: 16308
		public readonly PsoStructureInfo structureInfo;

		// Token: 0x04003FB5 RID: 16309
		public readonly PsoStructureEntryInfo entryInfo;

		// Token: 0x04003FB6 RID: 16310
		public readonly int numberOfEntries;
	}
}
