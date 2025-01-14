using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RageLib.GTA5.PSOWrappers.Xml
{
	// Token: 0x02000278 RID: 632
	[Serializable]
	public class PsoEnumXml
	{
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00083585 File Offset: 0x00081785
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x0008358D File Offset: 0x0008178D
		[XmlIgnore]
		public int NameHash { get; set; }

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00083596 File Offset: 0x00081796
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x000835A3 File Offset: 0x000817A3
		[XmlAttribute("NameHash")]
		public string NameHashAsHex
		{
			get
			{
				return HexConverter.ToHex(this.NameHash);
			}
			set
			{
				this.NameHash = HexConverter.ToUInt32(value);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x000835B1 File Offset: 0x000817B1
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x000835B9 File Offset: 0x000817B9
		[XmlElement("EnumEntry")]
		public List<PsoEnumEntryXml> Entries { get; set; }
	}
}
