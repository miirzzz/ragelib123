using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200027B RID: 635
	public interface IPsoValue
	{
		// Token: 0x06000AEA RID: 2794
		void Read(PsoDataReader reader);

		// Token: 0x06000AEB RID: 2795
		void Write(DataWriter writer);
	}
}
