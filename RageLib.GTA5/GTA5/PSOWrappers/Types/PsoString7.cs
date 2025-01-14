using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000292 RID: 658
	public class PsoString7 : IPsoValue
	{
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00084079 File Offset: 0x00082279
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x00084081 File Offset: 0x00082281
		public int Value { get; set; }

		// Token: 0x06000B7C RID: 2940 RVA: 0x00002192 File Offset: 0x00000392
		public PsoString7()
		{
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0008408A File Offset: 0x0008228A
		public PsoString7(int value)
		{
			this.Value = value;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00084099 File Offset: 0x00082299
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadInt32();
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
