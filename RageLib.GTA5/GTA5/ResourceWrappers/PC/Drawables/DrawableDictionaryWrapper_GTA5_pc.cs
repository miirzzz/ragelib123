using System;
using RageLib.Resources.GTA5.PC.Drawables;
using RageLib.ResourceWrappers.Drawables;

namespace RageLib.GTA5.ResourceWrappers.PC.Drawables
{
	// Token: 0x02000193 RID: 403
	public class DrawableDictionaryWrapper_GTA5_pc : IDrawableDictionary
	{
		// Token: 0x06000666 RID: 1638 RVA: 0x0002AAD2 File Offset: 0x00028CD2
		public DrawableDictionaryWrapper_GTA5_pc(GtaDrawableDictionary drawableDictionary)
		{
			this.drawableDictionary = drawableDictionary;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0002AAE1 File Offset: 0x00028CE1
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x0000218B File Offset: 0x0000038B
		public IDrawableList Drawables
		{
			get
			{
				return new DrawableListWrapper_GTA5_pc(this.drawableDictionary.Drawables);
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0002AAF3 File Offset: 0x00028CF3
		public uint GetHash(int index)
		{
			return (uint)this.drawableDictionary.Hashes[index];
		}

		// Token: 0x040036E4 RID: 14052
		private GtaDrawableDictionary drawableDictionary;
	}
}
