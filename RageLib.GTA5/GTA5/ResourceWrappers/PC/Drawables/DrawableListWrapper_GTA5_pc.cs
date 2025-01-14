using System;
using System.Collections;
using System.Collections.Generic;
using RageLib.Resources.GTA5.PC.Drawables;
using RageLib.ResourceWrappers.Drawables;

namespace RageLib.GTA5.ResourceWrappers.PC.Drawables
{
	// Token: 0x02000195 RID: 405
	public class DrawableListWrapper_GTA5_pc : IDrawableList, IList<IDrawable>, ICollection<IDrawable>, IEnumerable<IDrawable>, IEnumerable
	{
		// Token: 0x06000670 RID: 1648 RVA: 0x0002ABAE File Offset: 0x00028DAE
		public DrawableListWrapper_GTA5_pc(IList<GtaDrawable> list)
		{
			this.list = list;
		}

		// Token: 0x17000187 RID: 391
		public IDrawable this[int index]
		{
			get
			{
				return new DrawableWrapper_GTA5_pc(this.list[index]);
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x0002ABD0 File Offset: 0x00028DD0
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x0000218B File Offset: 0x0000038B
		public bool IsReadOnly
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000218B File Offset: 0x0000038B
		public void Add(IDrawable item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0000218B File Offset: 0x0000038B
		public void Clear()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0000218B File Offset: 0x0000038B
		public bool Contains(IDrawable item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0000218B File Offset: 0x0000038B
		public void CopyTo(IDrawable[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0002ABDD File Offset: 0x00028DDD
		public IEnumerator<IDrawable> GetEnumerator()
		{
			foreach (GtaDrawable drawable in this.list)
			{
				yield return new DrawableWrapper_GTA5_pc(drawable);
			}
			IEnumerator<GtaDrawable> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0000218B File Offset: 0x0000038B
		public int IndexOf(IDrawable item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0000218B File Offset: 0x0000038B
		public void Insert(int index, IDrawable item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0000218B File Offset: 0x0000038B
		public bool Remove(IDrawable item)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0000218B File Offset: 0x0000038B
		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0000218B File Offset: 0x0000038B
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		// Token: 0x040036E6 RID: 14054
		private IList<GtaDrawable> list;
	}
}
