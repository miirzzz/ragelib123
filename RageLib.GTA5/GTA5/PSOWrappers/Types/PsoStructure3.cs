using System;
using RageLib.Data;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000295 RID: 661
	public class PsoStructure3 : IPsoValue
	{
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x000841D4 File Offset: 0x000823D4
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x000841DC File Offset: 0x000823DC
		public PsoStructure Value { get; set; }

		// Token: 0x06000B8D RID: 2957 RVA: 0x000841E5 File Offset: 0x000823E5
		public PsoStructure3(PsoFile pso, PsoStructureInfo structureInfo, PsoStructureEntryInfo entryInfo)
		{
			this.pso = pso;
			this.structureInfo = structureInfo;
			this.entryInfo = entryInfo;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00084204 File Offset: 0x00082404
		public void Read(PsoDataReader reader)
		{
			int num = reader.ReadInt32();
			if (reader.ReadInt32() != 0)
			{
				throw new Exception("z2 should be zero");
			}
			int num2 = num >> 12 & 1048575;
			int num3 = num & 4095;
			if (num3 > 0)
			{
				int nameHash = this.pso.DataMappingSection.Entries[num3 - 1].NameHash;
				PsoStructureInfo psoStructureInfo = null;
				PsoElementIndexInfo entryIndexInfo = null;
				for (int i = 0; i < this.pso.DefinitionSection.Entries.Count; i++)
				{
					if (this.pso.DefinitionSection.EntriesIdx[i].NameHash == nameHash)
					{
						psoStructureInfo = (PsoStructureInfo)this.pso.DefinitionSection.Entries[i];
						entryIndexInfo = this.pso.DefinitionSection.EntriesIdx[i];
					}
				}
				int currentSectionIndex = reader.CurrentSectionIndex;
				long position = reader.Position;
				reader.SetSectionIndex(num3 - 1);
				reader.Position = (long)num2;
				this.Value = new PsoStructure(this.pso, psoStructureInfo, entryIndexInfo, null);
				this.Value.Read(reader);
				reader.SetSectionIndex(currentSectionIndex);
				reader.Position = position;
				return;
			}
			this.Value = null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}

		// Token: 0x04003FE5 RID: 16357
		public readonly PsoFile pso;

		// Token: 0x04003FE6 RID: 16358
		public readonly PsoStructureInfo structureInfo;

		// Token: 0x04003FE7 RID: 16359
		public readonly PsoStructureEntryInfo entryInfo;
	}
}
