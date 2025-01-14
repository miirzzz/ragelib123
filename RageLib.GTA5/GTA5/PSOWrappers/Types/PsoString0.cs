using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200028E RID: 654
	public class PsoString0 : IPsoValue
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00083E06 File Offset: 0x00082006
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00083E0E File Offset: 0x0008200E
		public string Value { get; set; }

		// Token: 0x06000B68 RID: 2920 RVA: 0x00083E17 File Offset: 0x00082017
		public PsoString0(int length)
		{
			this.length = length;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00083E28 File Offset: 0x00082028
		public void Read(PsoDataReader reader)
		{
			this.Value = "";
			bool flag = true;
			for (int i = 0; i < this.length; i++)
			{
				char c = (char)reader.ReadByte();
				if (c == '\0')
				{
					flag = false;
				}
				else
				{
					if (!flag)
					{
						throw new Exception("Unexpected char.");
					}
					this.Value += c.ToString();
				}
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}

		// Token: 0x04003FD9 RID: 16345
		private readonly int length;
	}
}
