using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200027F RID: 639
	public class PsoBoolean : IPsoValue
	{
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00083878 File Offset: 0x00081A78
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00083880 File Offset: 0x00081A80
		public bool Value { get; set; }

		// Token: 0x06000AFD RID: 2813 RVA: 0x00083889 File Offset: 0x00081A89
		public void Read(PsoDataReader reader)
		{
			this.Value = (reader.ReadByte() > 0);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
