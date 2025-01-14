using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000286 RID: 646
	public class PsoFloat : IPsoValue
	{
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x00083A75 File Offset: 0x00081C75
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x00083A7D File Offset: 0x00081C7D
		public float Value { get; set; }

		// Token: 0x06000B2E RID: 2862 RVA: 0x00083A86 File Offset: 0x00081C86
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadSingle();
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
