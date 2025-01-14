using System;
using System.IO;

namespace RageLib.Resources.GTA5.PC.GameFiles
{
	// Token: 0x020000E1 RID: 225
	public interface IGameFile
	{
		// Token: 0x06000396 RID: 918
		void Load(string fileName, object[] parameters = null);

		// Token: 0x06000397 RID: 919
		void Load(Stream stream, object[] parameters = null);

		// Token: 0x06000398 RID: 920
		void Load(byte[] data, object[] parameters = null);

		// Token: 0x06000399 RID: 921
		void Save(string fileName, object[] parameters = null);

		// Token: 0x0600039A RID: 922
		void Save(Stream stream, object[] parameters = null);

		// Token: 0x0600039B RID: 923
		byte[] Save(object[] parameters = null);

		// Token: 0x0600039C RID: 924
		void Parse(object[] parameters = null);

		// Token: 0x0600039D RID: 925
		void Build(object[] parameters = null);
	}
}
