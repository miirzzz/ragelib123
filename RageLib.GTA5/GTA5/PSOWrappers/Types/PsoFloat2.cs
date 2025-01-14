using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000287 RID: 647
	public class PsoFloat2 : IPsoValue
	{
		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00083A94 File Offset: 0x00081C94
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00083A9C File Offset: 0x00081C9C
		public float X { get; set; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00083AA5 File Offset: 0x00081CA5
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00083AAD File Offset: 0x00081CAD
		public float Y { get; set; }

		// Token: 0x06000B36 RID: 2870 RVA: 0x00083AB6 File Offset: 0x00081CB6
		public void Read(PsoDataReader reader)
		{
			this.X = reader.ReadSingle();
			this.Y = reader.ReadSingle();
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
