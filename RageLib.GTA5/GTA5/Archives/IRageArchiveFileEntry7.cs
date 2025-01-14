using System;

namespace RageLib.GTA5.Archives
{
	// Token: 0x020002AD RID: 685
	public interface IRageArchiveFileEntry7 : IRageArchiveEntry7
	{
		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000C32 RID: 3122
		// (set) Token: 0x06000C33 RID: 3123
		uint FileOffset { get; set; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000C34 RID: 3124
		// (set) Token: 0x06000C35 RID: 3125
		uint FileSize { get; set; }
	}
}
