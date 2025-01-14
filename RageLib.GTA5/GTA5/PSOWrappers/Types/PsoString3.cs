using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000291 RID: 657
	public class PsoString3 : IPsoValue
	{
		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00083F94 File Offset: 0x00082194
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x00083F9C File Offset: 0x0008219C
		public string Value { get; set; }

		// Token: 0x06000B77 RID: 2935 RVA: 0x00083FA8 File Offset: 0x000821A8
		public void Read(PsoDataReader reader)
		{
			uint num = reader.ReadUInt32();
			int num2 = (int)(num & 4095U);
			int num3 = (int)((num & 4294963200U) >> 12);
			if (reader.ReadUInt32() != 0U)
			{
				throw new Exception("zero_4h should be 0");
			}
			reader.ReadUInt16();
			int num4 = (int)(reader.ReadUInt16() & 4095);
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
				string text = "";
				for (int i = 0; i < num4; i++)
				{
					text += ((char)reader.ReadByte()).ToString();
				}
				this.Value = text;
				reader.SetSectionIndex(currentSectionIndex);
				reader.Position = position;
				return;
			}
			this.Value = null;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
