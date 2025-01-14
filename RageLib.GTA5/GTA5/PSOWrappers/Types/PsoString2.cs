using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000290 RID: 656
	public class PsoString2 : IPsoValue
	{
		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00083F0C File Offset: 0x0008210C
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00083F14 File Offset: 0x00082114
		public string Value { get; set; }

		// Token: 0x06000B72 RID: 2930 RVA: 0x00083F20 File Offset: 0x00082120
		public void Read(PsoDataReader reader)
		{
			int num = reader.ReadInt32();
			if (reader.ReadInt32() != 0)
			{
				throw new Exception("zero_Ch should be 0");
			}
			int num2 = num & 4095;
			int num3 = (int)(((long)num & (long)((ulong)-4096)) >> 12);
			int currentSectionIndex = reader.CurrentSectionIndex;
			long position = reader.Position;
			reader.SetSectionIndex(num2 - 1);
			reader.Position = (long)num3;
			this.Value = reader.ReadString();
			reader.SetSectionIndex(currentSectionIndex);
			reader.Position = position;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
