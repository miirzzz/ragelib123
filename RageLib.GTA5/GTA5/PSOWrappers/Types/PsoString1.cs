using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200028F RID: 655
	public class PsoString1 : IPsoValue
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00083E87 File Offset: 0x00082087
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00083E8F File Offset: 0x0008208F
		public string Value { get; set; }

		// Token: 0x06000B6D RID: 2925 RVA: 0x00083E98 File Offset: 0x00082098
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

		// Token: 0x06000B6E RID: 2926 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
