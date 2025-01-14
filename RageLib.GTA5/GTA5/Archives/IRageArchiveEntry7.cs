using System;
using RageLib.Data;

namespace RageLib.GTA5.Archives
{
	// Token: 0x020002AC RID: 684
	public interface IRageArchiveEntry7
	{
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000C2C RID: 3116
		// (set) Token: 0x06000C2D RID: 3117
		uint NameOffset { get; set; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000C2E RID: 3118
		// (set) Token: 0x06000C2F RID: 3119
		string Name { get; set; }

		// Token: 0x06000C30 RID: 3120
		void Read(DataReader reader);

		// Token: 0x06000C31 RID: 3121
		void Write(DataWriter writer);
	}
}
