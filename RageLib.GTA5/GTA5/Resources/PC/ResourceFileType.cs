using System;

namespace RageLib.GTA5.Resources.PC
{
	// Token: 0x020001E7 RID: 487
	public class ResourceFileType
	{
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x000383BE File Offset: 0x000365BE
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x000383C6 File Offset: 0x000365C6
		public string Extension { get; private set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000383CF File Offset: 0x000365CF
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x000383D7 File Offset: 0x000365D7
		public int Version { get; private set; }

		// Token: 0x06000841 RID: 2113 RVA: 0x000383E0 File Offset: 0x000365E0
		public ResourceFileType(string extension, int version)
		{
			this.Extension = extension;
			this.Version = version;
		}
	}
}
