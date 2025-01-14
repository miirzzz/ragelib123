using System;
using System.Collections.Generic;
using RageLib.GTA5.RBF.Types;

namespace RageLib.GTA5.RBF
{
	// Token: 0x020001F7 RID: 503
	public class RbfStructure : IRbfType
	{
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0003AFD4 File Offset: 0x000391D4
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x0003AFDC File Offset: 0x000391DC
		public string Name { get; set; }

		// Token: 0x06000916 RID: 2326 RVA: 0x0003AFE8 File Offset: 0x000391E8
		public IRbfType FindChild(string name)
		{
			foreach (IRbfType rbfType in this.Children)
			{
				if (rbfType != null && rbfType.Name == name)
				{
					return rbfType;
				}
			}
			return null;
		}

		// Token: 0x04003A4D RID: 14925
		public List<IRbfType> Children = new List<IRbfType>();
	}
}
