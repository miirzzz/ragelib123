using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RageLib.GTA5.PSOWrappers.Xml
{
	// Token: 0x02000276 RID: 630
	[Serializable]
	public class PsoStructureXml
	{
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00083454 File Offset: 0x00081654
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x0008345C File Offset: 0x0008165C
		[XmlIgnore]
		public int NameHash { get; set; }

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00083465 File Offset: 0x00081665
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00083472 File Offset: 0x00081672
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

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00083480 File Offset: 0x00081680
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00083488 File Offset: 0x00081688
		[XmlIgnore]
		public int Unknown { get; set; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00083491 File Offset: 0x00081691
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x0008349E File Offset: 0x0008169E
		[XmlAttribute("Unknown")]
		public string UnknownAsHex
		{
			get
			{
				return HexConverter.ToHex(this.Unknown);
			}
			set
			{
				this.Unknown = HexConverter.ToUInt32(value);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x000834AC File Offset: 0x000816AC
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x000834B4 File Offset: 0x000816B4
		[XmlAttribute("Length")]
		public int Length { get; set; }

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x000834BD File Offset: 0x000816BD
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x000834C5 File Offset: 0x000816C5
		[XmlElement("StructureEntry")]
		public List<PsoStructureEntryXml> Entries { get; set; }
	}
}
