using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000289 RID: 649
	public class PsoFloat4A : IPsoValue
	{
		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00083B29 File Offset: 0x00081D29
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00083B31 File Offset: 0x00081D31
		public float X { get; set; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00083B3A File Offset: 0x00081D3A
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00083B42 File Offset: 0x00081D42
		public float Y { get; set; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00083B4B File Offset: 0x00081D4B
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00083B53 File Offset: 0x00081D53
		public float Z { get; set; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00083B5C File Offset: 0x00081D5C
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00083B64 File Offset: 0x00081D64
		public float W { get; set; }

		// Token: 0x06000B49 RID: 2889 RVA: 0x00083B6D File Offset: 0x00081D6D
		public void Read(PsoDataReader reader)
		{
			this.X = reader.ReadSingle();
			this.Y = reader.ReadSingle();
			this.Z = reader.ReadSingle();
			this.W = reader.ReadSingle();
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
