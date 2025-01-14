using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RageLib.GTA5.PSOWrappers.Xml
{
	// Token: 0x02000275 RID: 629
	[Serializable]
	public class PsoDefinitionXml
	{
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00083432 File Offset: 0x00081632
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0008343A File Offset: 0x0008163A
		[XmlElement("Structure")]
		public List<PsoStructureXml> Structures { get; set; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00083443 File Offset: 0x00081643
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0008344B File Offset: 0x0008164B
		[XmlElement("Enum")]
		public List<PsoEnumXml> Enums { get; set; }
	}
}
