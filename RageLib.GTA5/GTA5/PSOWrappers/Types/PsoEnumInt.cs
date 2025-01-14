using System;
using RageLib.Data;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000282 RID: 642
	public class PsoEnumInt : IPsoValue
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0008391C File Offset: 0x00081B1C
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00083924 File Offset: 0x00081B24
		public PsoEnumInfo TypeInfo { get; set; }

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0008392D File Offset: 0x00081B2D
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00083935 File Offset: 0x00081B35
		public int Value { get; set; }

		// Token: 0x06000B12 RID: 2834 RVA: 0x00002192 File Offset: 0x00000392
		public PsoEnumInt()
		{
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0008393E File Offset: 0x00081B3E
		public PsoEnumInt(int value)
		{
			this.Value = value;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0008394D File Offset: 0x00081B4D
		public PsoEnumInt(PsoEnumInfo typeInfo, int value)
		{
			this.TypeInfo = typeInfo;
			this.Value = value;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00083963 File Offset: 0x00081B63
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadInt32();
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00083971 File Offset: 0x00081B71
		public void Write(DataWriter writer)
		{
			writer.Write(this.Value);
		}
	}
}
