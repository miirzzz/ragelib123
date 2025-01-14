using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000296 RID: 662
	public class PsoType3 : IPsoValue
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x00084339 File Offset: 0x00082539
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x00084341 File Offset: 0x00082541
		public short Value { get; set; }

		// Token: 0x06000B93 RID: 2963 RVA: 0x0008434A File Offset: 0x0008254A
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadInt16();
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
