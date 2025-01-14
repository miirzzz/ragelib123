using System;
using System.Collections.Generic;
using System.IO;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;
using RageLib.GTA5.PSOWrappers.Types;

namespace RageLib.GTA5.PSOWrappers
{
	// Token: 0x02000272 RID: 626
	public class PsoReader
	{
		// Token: 0x06000A8A RID: 2698 RVA: 0x00081DB4 File Offset: 0x0007FFB4
		public IPsoValue Read(string fileName)
		{
			IPsoValue result;
			using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
			{
				result = this.Read(fileStream);
			}
			return result;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00081DF0 File Offset: 0x0007FFF0
		public IPsoValue Read(Stream fileStream)
		{
			PsoFile psoFile = new PsoFile();
			psoFile.Load(fileStream);
			return this.Parse(psoFile);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00081E14 File Offset: 0x00080014
		public IPsoValue Parse(PsoFile meta)
		{
			new List<int>();
			new List<List<IPsoValue>>();
			PsoStructureInfo structureInfo = null;
			PsoElementIndexInfo entryIndexInfo = null;
			int nameHash = meta.DataMappingSection.Entries[meta.DataMappingSection.RootIndex - 1].NameHash;
			int num = 0;
			while ((long)num < (long)((ulong)meta.DefinitionSection.Count))
			{
				if (meta.DefinitionSection.EntriesIdx[num].NameHash == nameHash)
				{
					structureInfo = (PsoStructureInfo)meta.DefinitionSection.Entries[num];
					entryIndexInfo = meta.DefinitionSection.EntriesIdx[num];
				}
				num++;
			}
			PsoStructure psoStructure = new PsoStructure(meta, structureInfo, entryIndexInfo, null);
			PsoDataReader psoDataReader = new PsoDataReader(meta);
			psoDataReader.SetSectionIndex(meta.DataMappingSection.RootIndex - 1);
			psoDataReader.Position = 0L;
			psoStructure.Read(psoDataReader);
			return psoStructure;
		}
	}
}
