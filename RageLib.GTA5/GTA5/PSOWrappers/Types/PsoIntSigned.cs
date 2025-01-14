using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200028B RID: 651
	public class PsoIntSigned : IPsoValue
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00083C15 File Offset: 0x00081E15
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x00083C1D File Offset: 0x00081E1D
		public int Value { get; set; }

		// Token: 0x06000B5A RID: 2906 RVA: 0x00083C26 File Offset: 0x00081E26
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadInt32();
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00083C34 File Offset: 0x00081E34
		public void Write(DataWriter writer)
		{
			writer.Write(this.Value);
		}
	}
}
