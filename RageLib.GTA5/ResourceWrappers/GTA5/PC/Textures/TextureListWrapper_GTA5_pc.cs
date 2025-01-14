using System;
using System.Collections;
using System.Collections.Generic;
using RageLib.Resources.GTA5.PC.Textures;

namespace RageLib.ResourceWrappers.GTA5.PC.Textures
{
	// Token: 0x02000004 RID: 4
	public class TextureListWrapper_GTA5_pc : ITextureList, IList<ITexture>, ICollection<ITexture>, IEnumerable<ITexture>, IEnumerable
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000023C8 File Offset: 0x000005C8
		public TextureListWrapper_GTA5_pc(IList<TextureDX11> list)
		{
			this.list = list;
		}

		// Token: 0x17000003 RID: 3
		public ITexture this[int index]
		{
			get
			{
				return new TextureWrapper_GTA5_pc(this.list[index]);
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000023EA File Offset: 0x000005EA
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000218B File Offset: 0x0000038B
		public bool IsReadOnly
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023F7 File Offset: 0x000005F7
		public void Add(ITexture item)
		{
			this.list.Add(((TextureWrapper_GTA5_pc)item).texture);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000218B File Offset: 0x0000038B
		public void Clear()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000218B File Offset: 0x0000038B
		public bool Contains(ITexture item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000218B File Offset: 0x0000038B
		public void CopyTo(ITexture[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000240F File Offset: 0x0000060F
		public IEnumerator<ITexture> GetEnumerator()
		{
			foreach (TextureDX11 texture in this.list)
			{
				yield return new TextureWrapper_GTA5_pc(texture);
			}
			IEnumerator<TextureDX11> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000218B File Offset: 0x0000038B
		public int IndexOf(ITexture item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000218B File Offset: 0x0000038B
		public void Insert(int index, ITexture item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000241E File Offset: 0x0000061E
		public bool Remove(ITexture item)
		{
			return this.list.Remove(((TextureWrapper_GTA5_pc)item).texture);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002436 File Offset: 0x00000636
		public void RemoveAt(int index)
		{
			this.list.RemoveAt(index);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000218B File Offset: 0x0000038B
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000003 RID: 3
		private IList<TextureDX11> list;
	}
}
