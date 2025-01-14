using System;
using System.Collections.Generic;
using RageLib.Data;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000294 RID: 660
	public class PsoStructure : IPsoValue
	{
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x000840EA File Offset: 0x000822EA
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x000840F2 File Offset: 0x000822F2
		public Dictionary<int, IPsoValue> Values { get; set; }

		// Token: 0x06000B88 RID: 2952 RVA: 0x000840FB File Offset: 0x000822FB
		public PsoStructure(PsoFile pso, PsoStructureInfo structureInfo, PsoElementIndexInfo entryIndexInfo, PsoStructureEntryInfo entryInfo)
		{
			this.pso = pso;
			this.structureInfo = structureInfo;
			this.entryIndexInfo = entryIndexInfo;
			this.entryInfo = entryInfo;
			this.Values = new Dictionary<int, IPsoValue>();
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0008412C File Offset: 0x0008232C
		public void Read(PsoDataReader reader)
		{
			long position = reader.Position;
			this.Values = new Dictionary<int, IPsoValue>();
			for (int i = 0; i < this.structureInfo.Entries.Count; i++)
			{
				PsoStructureEntryInfo psoStructureEntryInfo = this.structureInfo.Entries[i];
				if (psoStructureEntryInfo.EntryNameHash != 256)
				{
					reader.Position = position + (long)psoStructureEntryInfo.DataOffset;
					IPsoValue psoValue = PsoTypeBuilder.Make(this.pso, this.structureInfo, psoStructureEntryInfo);
					psoValue.Read(reader);
					this.Values.Add(psoStructureEntryInfo.EntryNameHash, psoValue);
				}
			}
			reader.Position = position + (long)this.structureInfo.StructureLength;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}

		// Token: 0x04003FE0 RID: 16352
		public readonly PsoFile pso;

		// Token: 0x04003FE1 RID: 16353
		public readonly PsoStructureInfo structureInfo;

		// Token: 0x04003FE2 RID: 16354
		public readonly PsoElementIndexInfo entryIndexInfo;

		// Token: 0x04003FE3 RID: 16355
		public readonly PsoStructureEntryInfo entryInfo;
	}
}
