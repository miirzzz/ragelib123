using System;
using RageLib.Archives;
using RageLib.GTA5.Archives;

namespace RageLib.GTA5.Utilities
{
	// Token: 0x02000185 RID: 389
	public interface IRebuildBinaryFileHandler
	{
		// Token: 0x0600060E RID: 1550
		bool CanRebuild(IArchiveBinaryFile sourceFile);

		// Token: 0x0600060F RID: 1551
		void Rebuild(IArchiveBinaryFile sourceFile, IArchiveDirectory targetDirectory, RageArchiveEncryption7 encryption);
	}
}
