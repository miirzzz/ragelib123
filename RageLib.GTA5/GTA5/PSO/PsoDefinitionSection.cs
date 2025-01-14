using System;
using System.Collections.Generic;
using System.IO;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200020A RID: 522
	public class PsoDefinitionSection
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x0003CAA6 File Offset: 0x0003ACA6
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x0003CAAE File Offset: 0x0003ACAE
		public int Ident { get; private set; } = 1347633992;

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0003CAB7 File Offset: 0x0003ACB7
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x0003CABF File Offset: 0x0003ACBF
		public int Length { get; set; }

		// Token: 0x0600099A RID: 2458 RVA: 0x0003CAC8 File Offset: 0x0003ACC8
		public void Read(DataReader reader)
		{
			this.Ident = reader.ReadInt32();
			this.Length = reader.ReadInt32();
			this.Count = reader.ReadUInt32();
			this.EntriesIdx = new List<PsoElementIndexInfo>();
			int num = 0;
			while ((long)num < (long)((ulong)this.Count))
			{
				PsoElementIndexInfo psoElementIndexInfo = new PsoElementIndexInfo();
				psoElementIndexInfo.Read(reader);
				this.EntriesIdx.Add(psoElementIndexInfo);
				num++;
			}
			this.Entries = new List<PsoElementInfo>();
			int num2 = 0;
			while ((long)num2 < (long)((ulong)this.Count))
			{
				reader.Position = (long)this.EntriesIdx[num2].Offset;
				byte b = reader.ReadByte();
				reader.Position = (long)this.EntriesIdx[num2].Offset;
				if (b == 0)
				{
					PsoStructureInfo psoStructureInfo = new PsoStructureInfo();
					psoStructureInfo.Read(reader);
					psoStructureInfo.IndexInfo = this.EntriesIdx[num2];
					this.Entries.Add(psoStructureInfo);
				}
				else
				{
					if (b != 1)
					{
						throw new Exception("unknown type!");
					}
					PsoEnumInfo psoEnumInfo = new PsoEnumInfo();
					psoEnumInfo.Read(reader);
					psoEnumInfo.IndexInfo = this.EntriesIdx[num2];
					this.Entries.Add(psoEnumInfo);
				}
				num2++;
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0003CC00 File Offset: 0x0003AE00
		public void Write(DataWriter writer)
		{
			MemoryStream memoryStream = new MemoryStream();
			DataWriter dataWriter = new DataWriter(memoryStream, Endianess.BigEndian);
			for (int i = 0; i < this.Entries.Count; i++)
			{
				this.EntriesIdx[i].Offset = 12 + 8 * this.Entries.Count + (int)dataWriter.Position;
				this.Entries[i].Write(dataWriter);
			}
			MemoryStream memoryStream2 = new MemoryStream();
			DataWriter writer2 = new DataWriter(memoryStream2, Endianess.BigEndian);
			foreach (PsoElementIndexInfo psoElementIndexInfo in this.EntriesIdx)
			{
				psoElementIndexInfo.Write(writer2);
			}
			writer.Write(this.Ident);
			writer.Write((int)(12L + memoryStream.Length + memoryStream2.Length));
			writer.Write(this.Entries.Count);
			byte[] array = new byte[memoryStream2.Length];
			memoryStream2.Position = 0L;
			memoryStream2.Read(array, 0, array.Length);
			writer.Write(array);
			byte[] array2 = new byte[memoryStream.Length];
			memoryStream.Position = 0L;
			memoryStream.Read(array2, 0, array2.Length);
			writer.Write(array2);
		}

		// Token: 0x04003ACA RID: 15050
		public uint Count;

		// Token: 0x04003ACB RID: 15051
		public List<PsoElementIndexInfo> EntriesIdx;

		// Token: 0x04003ACC RID: 15052
		public List<PsoElementInfo> Entries;
	}
}
