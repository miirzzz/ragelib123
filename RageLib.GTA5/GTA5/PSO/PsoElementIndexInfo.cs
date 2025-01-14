using System;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200020B RID: 523
	public class PsoElementIndexInfo
	{
		// Token: 0x0600099D RID: 2461 RVA: 0x0003CD67 File Offset: 0x0003AF67
		public void Read(DataReader reader)
		{
			this.NameHash = reader.ReadInt32();
			this.Offset = reader.ReadInt32();
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0003CD81 File Offset: 0x0003AF81
		public void Write(DataWriter writer)
		{
			writer.Write(this.NameHash);
			writer.Write(this.Offset);
		}

		// Token: 0x04003ACD RID: 15053
		public int NameHash;

		// Token: 0x04003ACE RID: 15054
		public int Offset;
	}
}
