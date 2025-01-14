using System;
using System.Collections.Generic;
using RageLib.Hash;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Textures;

namespace RageLib.ResourceWrappers.GTA5.PC.Textures
{
	// Token: 0x02000003 RID: 3
	public class TextureDictionaryWrapper_GTA5_pc : ITextureDictionary
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000218B File Offset: 0x0000038B
		public ITextureList Textures
		{
			get
			{
				if (this.textureDictionary.Textures.Entries != null)
				{
					return new TextureListWrapper_GTA5_pc(this.textureDictionary.Textures.Entries);
				}
				return null;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002192 File Offset: 0x00000392
		public TextureDictionaryWrapper_GTA5_pc()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000219A File Offset: 0x0000039A
		public TextureDictionaryWrapper_GTA5_pc(TextureDictionary baseClass)
		{
			this.textureDictionary = baseClass;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021AC File Offset: 0x000003AC
		public void UpdateClass()
		{
			this.textureDictionary.VFT = 1079447504U;
			this.textureDictionary.Unknown_4h = 1U;
			this.textureDictionary.Unknown_10h = 0U;
			this.textureDictionary.Unknown_14h = 0U;
			this.textureDictionary.Unknown_18h = 1U;
			this.textureDictionary.Unknown_1Ch = 0U;
			this.textureDictionary.PagesInfo = null;
			if (this.textureDictionary.Textures.Entries != null)
			{
				List<uint> list = new List<uint>();
				foreach (TextureDX11 textureDX in this.textureDictionary.Textures.Entries)
				{
					uint item = Jenkins.Hash((string)textureDX.Name);
					list.Add(item);
				}
				list.Sort();
				ResourcePointerArray64<TextureDX11> entries = this.textureDictionary.Textures.Entries;
				this.textureDictionary.TextureNameHashes.Entries = new ResourceSimpleArray<uint_r>();
				this.textureDictionary.Textures.Entries = new ResourcePointerArray64<TextureDX11>();
				foreach (uint num in list)
				{
					this.textureDictionary.TextureNameHashes.Entries.Add((uint_r)num);
					foreach (TextureDX11 textureDX2 in entries)
					{
						if (Jenkins.Hash((string)textureDX2.Name) == num)
						{
							this.textureDictionary.Textures.Entries.Add(textureDX2);
						}
					}
				}
				foreach (TextureDX11 texture in this.textureDictionary.Textures.Entries)
				{
					new TextureWrapper_GTA5_pc(texture).UpdateClass();
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000023C0 File Offset: 0x000005C0
		public TextureDictionary GetObject()
		{
			return this.textureDictionary;
		}

		// Token: 0x04000002 RID: 2
		private TextureDictionary textureDictionary;
	}
}
