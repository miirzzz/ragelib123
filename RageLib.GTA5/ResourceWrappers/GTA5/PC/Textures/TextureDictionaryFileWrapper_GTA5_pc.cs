using System;
using System.IO;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5;
using RageLib.Resources.GTA5.PC.Textures;

namespace RageLib.ResourceWrappers.GTA5.PC.Textures
{
	// Token: 0x02000002 RID: 2
	public class TextureDictionaryFileWrapper_GTA5_pc : ITextureDictionaryFile, IResourceFile
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public ITextureDictionary TextureDictionary
		{
			get
			{
				return new TextureDictionaryWrapper_GTA5_pc(this.textureDictionary);
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205D File Offset: 0x0000025D
		public TextureDictionaryFileWrapper_GTA5_pc()
		{
			this.textureDictionary = new TextureDictionary();
			this.textureDictionary.TextureNameHashes.Entries = new ResourceSimpleArray<uint_r>();
			this.textureDictionary.Textures.Entries = new ResourcePointerArray64<TextureDX11>();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000209C File Offset: 0x0000029C
		public void Load(string fileName)
		{
			ResourceFile_GTA5_pc<TextureDictionary> resourceFile_GTA5_pc = new ResourceFile_GTA5_pc<TextureDictionary>();
			resourceFile_GTA5_pc.Load(fileName);
			this.textureDictionary = resourceFile_GTA5_pc.ResourceData;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020C2 File Offset: 0x000002C2
		public void Save(string fileName)
		{
			new TextureDictionaryWrapper_GTA5_pc(this.textureDictionary).UpdateClass();
			new ResourceFile_GTA5_pc<TextureDictionary>
			{
				ResourceData = this.textureDictionary,
				Version = 13
			}.Save(fileName);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020F4 File Offset: 0x000002F4
		public void Load(Stream stream)
		{
			ResourceFile_GTA5_pc<TextureDictionary> resourceFile_GTA5_pc = new ResourceFile_GTA5_pc<TextureDictionary>();
			resourceFile_GTA5_pc.Load(stream);
			if (resourceFile_GTA5_pc.Version != 13)
			{
				throw new Exception("version error");
			}
			this.textureDictionary = resourceFile_GTA5_pc.ResourceData;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000212F File Offset: 0x0000032F
		public void Save(Stream stream)
		{
			new TextureDictionaryWrapper_GTA5_pc(this.textureDictionary).UpdateClass();
			new ResourceFile_GTA5_pc<TextureDictionary>
			{
				ResourceData = this.textureDictionary,
				Version = 13
			}.Save(stream);
		}

		// Token: 0x04000001 RID: 1
		private TextureDictionary textureDictionary;
	}
}
