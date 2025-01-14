using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200029B RID: 667
	public class PsoXXByte : IPsoValue
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x000843E6 File Offset: 0x000825E6
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x000843EE File Offset: 0x000825EE
		public byte Value { get; set; }

		// Token: 0x06000BAC RID: 2988 RVA: 0x000843F7 File Offset: 0x000825F7
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadByte();
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
