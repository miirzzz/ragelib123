using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200028C RID: 652
	public class PsoIntUnsigned : IPsoValue
	{
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00083C42 File Offset: 0x00081E42
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x00083C4A File Offset: 0x00081E4A
		public uint Value { get; set; }

		// Token: 0x06000B5F RID: 2911 RVA: 0x00083C53 File Offset: 0x00081E53
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadUInt32();
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00083C61 File Offset: 0x00081E61
		public void Write(DataWriter writer)
		{
			writer.Write(this.Value);
		}
	}
}
