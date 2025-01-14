using System;
using System.IO;

namespace RageLib.Resources.GTA5.PC.GameFiles
{
	// Token: 0x020000E3 RID: 227
	public abstract class GameFileBase_Resource<T> : IGameFile where T : IResourceBlock, new()
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x00016D7C File Offset: 0x00014F7C
		public GameFileBase_Resource()
		{
			this.ResourceFile = new ResourceFile_GTA5_pc<T>();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00016D8F File Offset: 0x00014F8F
		public void Load(string fileName, object[] parameters = null)
		{
			this.ResourceFile.Load(fileName);
			this.Parse(parameters);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00016DA4 File Offset: 0x00014FA4
		public void Load(Stream stream, object[] parameters = null)
		{
			this.ResourceFile.Load(stream);
			this.Parse(parameters);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00016DB9 File Offset: 0x00014FB9
		public void Load(byte[] data, object[] parameters = null)
		{
			this.ResourceFile.Load(data);
			this.Parse(parameters);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00016DCE File Offset: 0x00014FCE
		public void Save(string fileName, object[] parameters = null)
		{
			this.Build(parameters);
			this.ResourceFile.Save(fileName);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00016DE3 File Offset: 0x00014FE3
		public void Save(Stream stream, object[] parameters = null)
		{
			this.Build(parameters);
			this.ResourceFile.Save(stream);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00016DF8 File Offset: 0x00014FF8
		public byte[] Save(object[] parameters = null)
		{
			this.Build(parameters);
			return this.ResourceFile.Save();
		}

		// Token: 0x060003AE RID: 942
		public abstract void Parse(object[] parameters = null);

		// Token: 0x060003AF RID: 943
		public abstract void Build(object[] parameters = null);

		// Token: 0x04002EB0 RID: 11952
		public ResourceFile_GTA5_pc<T> ResourceFile;
	}
}
