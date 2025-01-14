using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200028A RID: 650
	public class PsoFloat4B : IPsoValue
	{
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x00083B9F File Offset: 0x00081D9F
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x00083BA7 File Offset: 0x00081DA7
		public float X { get; set; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00083BB0 File Offset: 0x00081DB0
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x00083BB8 File Offset: 0x00081DB8
		public float Y { get; set; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x00083BC1 File Offset: 0x00081DC1
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x00083BC9 File Offset: 0x00081DC9
		public float Z { get; set; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00083BD2 File Offset: 0x00081DD2
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x00083BDA File Offset: 0x00081DDA
		public float W { get; set; }

		// Token: 0x06000B55 RID: 2901 RVA: 0x00083BE3 File Offset: 0x00081DE3
		public void Read(PsoDataReader reader)
		{
			this.X = reader.ReadSingle();
			this.Y = reader.ReadSingle();
			this.Z = reader.ReadSingle();
			this.W = reader.ReadSingle();
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
