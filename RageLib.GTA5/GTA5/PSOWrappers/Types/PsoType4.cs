using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000298 RID: 664
	public class PsoType4 : IPsoValue
	{
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00084379 File Offset: 0x00082579
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x00084381 File Offset: 0x00082581
		public short Value { get; set; }

		// Token: 0x06000B9D RID: 2973 RVA: 0x0008438A File Offset: 0x0008258A
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadInt16();
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
