using System;
using RageLib.Data;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000283 RID: 643
	public class PsoFlagsByte : IPsoValue
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0008397F File Offset: 0x00081B7F
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00083987 File Offset: 0x00081B87
		public byte Value { get; set; }

		// Token: 0x06000B19 RID: 2841 RVA: 0x00002192 File Offset: 0x00000392
		public PsoFlagsByte()
		{
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00083990 File Offset: 0x00081B90
		public PsoFlagsByte(byte value)
		{
			this.Value = value;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0008399F File Offset: 0x00081B9F
		public PsoFlagsByte(PsoEnumInfo typeInfo, byte value)
		{
			this.TypeInfo = typeInfo;
			this.Value = value;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x000839B5 File Offset: 0x00081BB5
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadByte();
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x000839C3 File Offset: 0x00081BC3
		public void Write(DataWriter writer)
		{
			writer.Write(this.Value);
		}

		// Token: 0x04003FBE RID: 16318
		public PsoEnumInfo TypeInfo;
	}
}
