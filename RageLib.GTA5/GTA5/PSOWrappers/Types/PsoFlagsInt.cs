using System;
using RageLib.Data;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000284 RID: 644
	public class PsoFlagsInt : IPsoValue
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x000839D1 File Offset: 0x00081BD1
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x000839D9 File Offset: 0x00081BD9
		public int Value { get; set; }

		// Token: 0x06000B20 RID: 2848 RVA: 0x00002192 File Offset: 0x00000392
		public PsoFlagsInt()
		{
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x000839E2 File Offset: 0x00081BE2
		public PsoFlagsInt(byte value)
		{
			this.Value = (int)value;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x000839F1 File Offset: 0x00081BF1
		public PsoFlagsInt(PsoEnumInfo typeInfo, byte value)
		{
			this.TypeInfo = typeInfo;
			this.Value = (int)value;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00083A07 File Offset: 0x00081C07
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadInt32();
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00083A15 File Offset: 0x00081C15
		public void Write(DataWriter writer)
		{
			writer.Write(this.Value);
		}

		// Token: 0x04003FC0 RID: 16320
		public PsoEnumInfo TypeInfo;
	}
}
