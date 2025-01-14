using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000288 RID: 648
	public class PsoFloat3 : IPsoValue
	{
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00083AD0 File Offset: 0x00081CD0
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00083AD8 File Offset: 0x00081CD8
		public float X { get; set; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x00083AE1 File Offset: 0x00081CE1
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x00083AE9 File Offset: 0x00081CE9
		public float Y { get; set; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00083AF2 File Offset: 0x00081CF2
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x00083AFA File Offset: 0x00081CFA
		public float Z { get; set; }

		// Token: 0x06000B3F RID: 2879 RVA: 0x00083B03 File Offset: 0x00081D03
		public void Read(PsoDataReader reader)
		{
			this.X = reader.ReadSingle();
			this.Y = reader.ReadSingle();
			this.Z = reader.ReadSingle();
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
