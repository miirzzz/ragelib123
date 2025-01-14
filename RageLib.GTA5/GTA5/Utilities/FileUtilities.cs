using System;
using System.Collections.Generic;
using System.IO;
using RageLib.Archives;
using RageLib.GTA5.Archives;

namespace RageLib.GTA5.Utilities
{
	// Token: 0x02000183 RID: 387
	public class FileUtilities
	{
		// Token: 0x06000603 RID: 1539 RVA: 0x00027B98 File Offset: 0x00025D98
		public static HashSet<string> GetAllFileNamesWithoutExtension(string gameDirectoryName)
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (string fileName in FileUtilities.GetAllFileNames(gameDirectoryName))
			{
				hashSet.Add(FileUtilities.RemoveExtension(fileName));
			}
			return hashSet;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00027BF8 File Offset: 0x00025DF8
		public static string RemoveExtension(string fileName)
		{
			return Path.ChangeExtension(fileName, null);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00027C04 File Offset: 0x00025E04
		public static HashSet<string> GetAllFileNames(string gameDirectoryName)
		{
			HashSet<string> fileNames = new HashSet<string>();
			string[] files = Directory.GetFiles(gameDirectoryName, "*.*", SearchOption.AllDirectories);
			for (int i = 0; i < files.Length; i++)
			{
				FileInfo fileInfo = new FileInfo(files[i]);
				fileNames.Add(fileInfo.Name);
			}
			ArchiveUtilities.ForEachFile(gameDirectoryName, delegate(string fullFileName, IArchiveFile file, RageArchiveEncryption7 encryption)
			{
				fileNames.Add(file.Name);
			}, null);
			return fileNames;
		}
	}
}
