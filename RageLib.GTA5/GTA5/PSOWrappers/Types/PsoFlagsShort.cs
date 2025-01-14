using System;
using RageLib.Data;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000285 RID: 645
	public class PsoFlagsShort : IPsoValue
	{
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00083A23 File Offset: 0x00081C23
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x00083A2B File Offset: 0x00081C2B
		public short Value { get; set; }

		// Token: 0x06000B27 RID: 2855 RVA: 0x00002192 File Offset: 0x00000392
		public PsoFlagsShort()
		{
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00083A34 File Offset: 0x00081C34
		public PsoFlagsShort(byte value)
		{
			this.Value = (short)value;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00083A43 File Offset: 0x00081C43
		public PsoFlagsShort(PsoEnumInfo typeInfo, byte value)
		{
			this.TypeInfo = typeInfo;
			this.Value = (short)value;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00083A59 File Offset: 0x00081C59
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadInt16();
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00083A67 File Offset: 0x00081C67
		public void Write(DataWriter writer)
		{
			writer.Write(this.Value);
		}

		// Token: 0x04003FC2 RID: 16322
		public PsoEnumInfo TypeInfo;
	}
}
