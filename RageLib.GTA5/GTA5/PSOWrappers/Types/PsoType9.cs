using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200029A RID: 666
	public class PsoType9 : IPsoValue
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x000843B7 File Offset: 0x000825B7
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x000843BF File Offset: 0x000825BF
		public int Value { get; set; }

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000843C8 File Offset: 0x000825C8
		public void Read(PsoDataReader reader)
		{
			reader.ReadSingle();
			reader.ReadSingle();
			reader.ReadSingle();
			reader.ReadSingle();
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
