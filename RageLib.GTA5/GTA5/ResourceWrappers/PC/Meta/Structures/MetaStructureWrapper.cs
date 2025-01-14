using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001CE RID: 462
	public abstract class MetaStructureWrapper<T> where T : struct
	{
		// Token: 0x060007BA RID: 1978
		public abstract void Build(MetaBuilder mb, bool isRoot = false);

		// Token: 0x060007BB RID: 1979
		public abstract void Parse(MetaFile meta, T metaStructure);

		// Token: 0x060007BC RID: 1980 RVA: 0x0003534C File Offset: 0x0003354C
		public void AddMetaPointers<T1>(MetaBuilder mb, List<MetaPOINTER> mptrs, MetaName name, IEnumerable<T1> objs) where T1 : struct
		{
			List<T1> list = objs.ToList<T1>();
			for (int i = 0; i < list.Count; i++)
			{
				mptrs.Add(mb.AddItemPtr<T1>(name, list[i]));
			}
		}

		// Token: 0x04003935 RID: 14645
		public MetaName MetaName;

		// Token: 0x04003936 RID: 14646
		public T MetaStructure;
	}
}
