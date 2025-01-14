using System;
using System.Collections.Generic;
using RageLib.Data;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200028D RID: 653
	public class PsoMap : IPsoValue
	{
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00083C6F File Offset: 0x00081E6F
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00083C77 File Offset: 0x00081E77
		public List<PsoStructure> Entries { get; set; }

		// Token: 0x06000B63 RID: 2915 RVA: 0x00083C80 File Offset: 0x00081E80
		public PsoMap(PsoFile pso, PsoStructureInfo structureInfo, PsoStructureEntryInfo keyEntryInfo, PsoStructureEntryInfo valueEntryInfo)
		{
			this.pso = pso;
			this.structureInfo = structureInfo;
			this.keyEntryInfo = keyEntryInfo;
			this.valueEntryInfo = valueEntryInfo;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00083CA8 File Offset: 0x00081EA8
		public void Read(PsoDataReader reader)
		{
			reader.ReadInt32();
			reader.ReadInt32();
			int num = reader.ReadInt32();
			int num2 = num >> 12 & 1048575;
			int num3 = num & 4095;
			reader.ReadInt32();
			int num4 = reader.ReadInt32();
			int num5 = num4 >> 16 & 65535;
			int num6 = num4 & 65535;
			if (num5 != num6)
			{
				throw new Exception("length does not match");
			}
			reader.ReadInt32();
			int currentSectionIndex = reader.CurrentSectionIndex;
			long position = reader.Position;
			reader.SetSectionIndex(num3 - 1);
			reader.Position = (long)num2;
			int nameHash = this.pso.DataMappingSection.Entries[num3 - 1].NameHash;
			PsoStructureInfo psoStructureInfo = null;
			for (int i = 0; i < this.pso.DefinitionSection.EntriesIdx.Count; i++)
			{
				if (this.pso.DefinitionSection.EntriesIdx[i].NameHash == nameHash)
				{
					psoStructureInfo = (PsoStructureInfo)this.pso.DefinitionSection.Entries[i];
				}
			}
			this.Entries = new List<PsoStructure>();
			for (int j = 0; j < num5; j++)
			{
				PsoStructure psoStructure = new PsoStructure(this.pso, psoStructureInfo, null, null);
				psoStructure.Read(reader);
				this.Entries.Add(psoStructure);
			}
			reader.SetSectionIndex(currentSectionIndex);
			reader.Position = position;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}

		// Token: 0x04003FD4 RID: 16340
		public readonly PsoFile pso;

		// Token: 0x04003FD5 RID: 16341
		public readonly PsoStructureInfo structureInfo;

		// Token: 0x04003FD6 RID: 16342
		public readonly PsoStructureEntryInfo keyEntryInfo;

		// Token: 0x04003FD7 RID: 16343
		public readonly PsoStructureEntryInfo valueEntryInfo;
	}
}
