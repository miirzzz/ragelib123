using System;
using System.Collections.Generic;
using RageLib.Data;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200027C RID: 636
	public class PsoArray0 : IPsoValue
	{
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00083643 File Offset: 0x00081843
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x0008364B File Offset: 0x0008184B
		public List<IPsoValue> Entries { get; set; }

		// Token: 0x06000AEE RID: 2798 RVA: 0x00083654 File Offset: 0x00081854
		public PsoArray0(PsoFile pso, PsoStructureInfo structureInfo, PsoStructureEntryInfo entryInfo)
		{
			this.pso = pso;
			this.structureInfo = structureInfo;
			this.entryInfo = entryInfo;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00083674 File Offset: 0x00081874
		public void Read(PsoDataReader reader)
		{
			uint num = reader.ReadUInt32();
			int num2 = (int)(num & 4095U);
			int num3 = (int)((num & 4294963200U) >> 12);
			if (reader.ReadUInt32() != 0U)
			{
				throw new Exception("zero_4h should be 0");
			}
			ushort num4 = reader.ReadUInt16();
			ushort num5 = reader.ReadUInt16();
			if (num4 != num5)
			{
				throw new Exception("size1 should be size2");
			}
			ushort num6 = num4;
			if (reader.ReadUInt32() != 0U)
			{
				throw new Exception("zero_Ch should be 0");
			}
			if (num2 > 0)
			{
				int currentSectionIndex = reader.CurrentSectionIndex;
				long position = reader.Position;
				reader.SetSectionIndex(num2 - 1);
				reader.Position = (long)num3;
				this.Entries = new List<IPsoValue>();
				for (int i = 0; i < (int)num6; i++)
				{
					IPsoValue psoValue = PsoTypeBuilder.Make(this.pso, this.structureInfo, this.entryInfo);
					psoValue.Read(reader);
					this.Entries.Add(psoValue);
				}
				reader.SetSectionIndex(currentSectionIndex);
				reader.Position = position;
				return;
			}
			this.Entries = null;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}

		// Token: 0x04003FAA RID: 16298
		public readonly PsoFile pso;

		// Token: 0x04003FAB RID: 16299
		public readonly PsoStructureInfo structureInfo;

		// Token: 0x04003FAC RID: 16300
		public readonly PsoStructureEntryInfo entryInfo;
	}
}
