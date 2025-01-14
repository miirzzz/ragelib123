using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000293 RID: 659
	public class PsoString8 : IPsoValue
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x000840A7 File Offset: 0x000822A7
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x000840AF File Offset: 0x000822AF
		public int Value { get; set; }

		// Token: 0x06000B82 RID: 2946 RVA: 0x00002192 File Offset: 0x00000392
		public PsoString8()
		{
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000840B8 File Offset: 0x000822B8
		public PsoString8(int value)
		{
			this.Value = value;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000840C8 File Offset: 0x000822C8
		public void Read(PsoDataReader reader)
		{
			int value = reader.ReadInt32();
			reader.ReadInt32();
			this.Value = value;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
