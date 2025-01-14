using System;
using System.Collections.Generic;
using RageLib.Data;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200020D RID: 525
	public class PsoStructureInfo : PsoElementInfo
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0003CDAC File Offset: 0x0003AFAC
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x0003CDB4 File Offset: 0x0003AFB4
		public byte Type { get; set; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0003CDBD File Offset: 0x0003AFBD
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x0003CDC5 File Offset: 0x0003AFC5
		public short EntriesCount { get; private set; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0003CDCE File Offset: 0x0003AFCE
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x0003CDD6 File Offset: 0x0003AFD6
		public byte Unk { get; set; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0003CDDF File Offset: 0x0003AFDF
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x0003CDE7 File Offset: 0x0003AFE7
		public int StructureLength { get; set; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0003CDF0 File Offset: 0x0003AFF0
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x0003CDF8 File Offset: 0x0003AFF8
		public uint Unk_Ch { get; set; }

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0003CE01 File Offset: 0x0003B001
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x0003CE09 File Offset: 0x0003B009
		public List<PsoStructureEntryInfo> Entries { get; set; } = new List<PsoStructureEntryInfo>();

		// Token: 0x060009B1 RID: 2481 RVA: 0x0003CE12 File Offset: 0x0003B012
		public PsoStructureInfo()
		{
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0003CE28 File Offset: 0x0003B028
		public PsoStructureInfo(byte type, byte unk, int structureLength, uint unk_ch, List<PsoStructureEntryInfo> entries)
		{
			this.Type = type;
			this.Unk = unk;
			this.StructureLength = structureLength;
			this.Unk_Ch = unk_ch;
			this.Entries = entries;
			this.EntriesCount = (short)entries.Count;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0003CE7C File Offset: 0x0003B07C
		public override void Read(DataReader reader)
		{
			uint num = reader.ReadUInt32();
			this.Type = (byte)((num & 4278190080U) >> 24);
			this.EntriesCount = (short)(num & 65535U);
			this.Unk = (byte)((num & 16711680U) >> 16);
			this.StructureLength = reader.ReadInt32();
			this.Unk_Ch = reader.ReadUInt32();
			this.Entries = new List<PsoStructureEntryInfo>();
			for (int i = 0; i < (int)this.EntriesCount; i++)
			{
				PsoStructureEntryInfo psoStructureEntryInfo = new PsoStructureEntryInfo();
				psoStructureEntryInfo.Read(reader);
				this.Entries.Add(psoStructureEntryInfo);
			}
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0003CF10 File Offset: 0x0003B110
		public override void Write(DataWriter writer)
		{
			this.Type = 0;
			this.EntriesCount = (short)this.Entries.Count;
			uint value = (uint)((int)this.Type << 24 | (int)this.Unk << 16 | (int)((ushort)this.EntriesCount));
			writer.Write(value);
			writer.Write(this.StructureLength);
			writer.Write(this.Unk_Ch);
			foreach (PsoStructureEntryInfo psoStructureEntryInfo in this.Entries)
			{
				psoStructureEntryInfo.Write(writer);
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0003CFB8 File Offset: 0x0003B1B8
		public PsoStructureEntryInfo FindEntry(MetaName name)
		{
			if (this.Entries != null)
			{
				foreach (PsoStructureEntryInfo psoStructureEntryInfo in this.Entries)
				{
					if (psoStructureEntryInfo.EntryNameHash == (int)name)
					{
						return psoStructureEntryInfo;
					}
				}
			}
			return null;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0003D01C File Offset: 0x0003B21C
		public PsoStructureEntryInfo GetEntry(int id)
		{
			if (this.Entries != null && id >= 0 && id < this.Entries.Count)
			{
				return this.Entries[id];
			}
			return null;
		}
	}
}
