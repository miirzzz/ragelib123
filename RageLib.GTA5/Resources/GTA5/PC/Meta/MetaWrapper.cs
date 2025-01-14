using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x0200007B RID: 123
	public abstract class MetaWrapper
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000ECF1 File Offset: 0x0000CEF1
		public virtual string Name
		{
			get
			{
				return this.ToString();
			}
		}

		// Token: 0x060002DD RID: 733
		public abstract void Load(MetaFile meta, MetaPOINTER ptr);

		// Token: 0x060002DE RID: 734
		public abstract MetaPOINTER Save(MetaBuilder mb);
	}
}
