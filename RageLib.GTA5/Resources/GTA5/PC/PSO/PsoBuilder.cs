using System;
using System.Collections.Generic;
using System.IO;
using RageLib.GTA5.PSO;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.Resources.GTA5.PC.PSO
{
	// Token: 0x02000067 RID: 103
	public class PsoBuilder
	{
		// Token: 0x0600021D RID: 541 RVA: 0x0000D4D4 File Offset: 0x0000B6D4
		public PsoFile GetPso()
		{
			PsoFile psoFile = new PsoFile();
			psoFile.DefinitionSection = new PsoDefinitionSection();
			psoFile.DataMappingSection = new PsoDataMappingSection();
			psoFile.DataSection = new PsoDataSection();
			foreach (KeyValuePair<MetaName, PsoStructureInfo> keyValuePair in this.StructureInfos)
			{
				PsoElementIndexInfo psoElementIndexInfo = new PsoElementIndexInfo();
				psoElementIndexInfo.Offset = 0;
				psoElementIndexInfo.NameHash = keyValuePair.Value.IndexInfo.NameHash;
				psoFile.DefinitionSection.EntriesIdx.Add(psoElementIndexInfo);
				psoFile.DefinitionSection.Entries.Add(keyValuePair.Value);
			}
			foreach (KeyValuePair<MetaName, PsoEnumInfo> keyValuePair2 in this.EnumInfos)
			{
				PsoElementIndexInfo psoElementIndexInfo2 = new PsoElementIndexInfo();
				psoElementIndexInfo2.Offset = 0;
				psoElementIndexInfo2.NameHash = keyValuePair2.Value.IndexInfo.NameHash;
				psoFile.DefinitionSection.EntriesIdx.Add(psoElementIndexInfo2);
				psoFile.DefinitionSection.Entries.Add(keyValuePair2.Value);
			}
			psoFile.DefinitionSection.Count = (uint)psoFile.DefinitionSection.Entries.Count;
			psoFile.DataMappingSection.Entries = new List<PsoDataMappingEntry>();
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Position = 16L;
			byte[] array = new byte[memoryStream.Length];
			memoryStream.Position = 0L;
			memoryStream.Read(array, 0, array.Length);
			psoFile.DataSection.Data = array;
			psoFile.DataMappingSection.RootIndex = 1;
			return psoFile;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000D698 File Offset: 0x0000B898
		public void AddStructureInfo(MetaName name)
		{
			if (!this.StructureInfos.ContainsKey(name))
			{
				PsoStructureInfo structureInfo = PsoInfo.GetStructureInfo(name);
				if (structureInfo != null)
				{
					this.StructureInfos[name] = structureInfo;
				}
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000D6CC File Offset: 0x0000B8CC
		public void AddEnumInfo(MetaName name)
		{
			if (!this.EnumInfos.ContainsKey(name))
			{
				PsoEnumInfo psoEnumInfo = null;
				PsoInfo.GetEnumInfo(name);
				if (psoEnumInfo != null)
				{
					this.EnumInfos[name] = psoEnumInfo;
				}
			}
		}

		// Token: 0x040004F6 RID: 1270
		private Dictionary<MetaName, PsoStructureInfo> StructureInfos = new Dictionary<MetaName, PsoStructureInfo>();

		// Token: 0x040004F7 RID: 1271
		private Dictionary<MetaName, PsoEnumInfo> EnumInfos = new Dictionary<MetaName, PsoEnumInfo>();
	}
}
