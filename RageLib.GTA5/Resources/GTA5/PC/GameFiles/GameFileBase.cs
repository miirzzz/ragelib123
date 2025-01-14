using System;
using System.IO;

namespace RageLib.Resources.GTA5.PC.GameFiles
{
	// Token: 0x020000E2 RID: 226
	public abstract class GameFileBase : IGameFile
	{
		// Token: 0x0600039E RID: 926 RVA: 0x00016C31 File Offset: 0x00014E31
		public GameFileBase()
		{
			this.Stream = null;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00016C40 File Offset: 0x00014E40
		public void Load(string fileName, object[] parameters = null)
		{
			byte[] data = File.ReadAllBytes(fileName);
			this.Load(data, parameters);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00016C5C File Offset: 0x00014E5C
		public void Load(Stream stream, object[] parameters = null)
		{
			this.Stream = stream;
			this.Stream.Position = 0L;
			this.Parse(parameters);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00016C79 File Offset: 0x00014E79
		public void Load(byte[] data, object[] parameters = null)
		{
			this.Stream = new MemoryStream();
			this.Stream.Write(data, 0, data.Length);
			this.Stream.Position = 0L;
			this.Parse(parameters);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00016CAC File Offset: 0x00014EAC
		public void Save(string fileName, object[] parameters = null)
		{
			this.Stream.Position = 0L;
			this.Build(parameters);
			using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
			{
				this.Stream.CopyTo(fileStream);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00016D00 File Offset: 0x00014F00
		public void Save(Stream stream, object[] parameters = null)
		{
			this.Stream.Position = 0L;
			this.Build(parameters);
			this.Stream.CopyTo(stream);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00016D24 File Offset: 0x00014F24
		public byte[] Save(object[] parameters = null)
		{
			this.Stream.Position = 0L;
			this.Build(parameters);
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				this.Stream.CopyTo(memoryStream);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060003A5 RID: 933
		public abstract void Parse(object[] parameters = null);

		// Token: 0x060003A6 RID: 934
		public abstract void Build(object[] parameters = null);

		// Token: 0x04002EAF RID: 11951
		public Stream Stream;
	}
}
