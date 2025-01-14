using System;
using RageLib.Archives;
using RageLib.GTA5.Archives;

namespace RageLib.GTA5.Utilities
{
	// Token: 0x02000186 RID: 390
	public interface IRebuildResourceFileHandler
	{
		// Token: 0x06000610 RID: 1552
		bool CanRebuild(IArchiveResourceFile sourceFile);

		// Token: 0x06000611 RID: 1553
		void Rebuild(IArchiveResourceFile sourceFile, IArchiveDirectory targetDirectory, RageArchiveEncryption7 encryption);
	}
}
