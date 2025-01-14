using System;
using System.Xml.Serialization;

namespace RageLib.GTA5.PSOWrappers.Xml
{
	// Token: 0x02000277 RID: 631
	[Serializable]
	public class PsoStructureEntryXml
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x000834CE File Offset: 0x000816CE
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x000834D6 File Offset: 0x000816D6
		[XmlIgnore]
		public int NameHash { get; set; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x000834DF File Offset: 0x000816DF
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x000834EC File Offset: 0x000816EC
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

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x000834FA File Offset: 0x000816FA
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00083502 File Offset: 0x00081702
		[XmlAttribute("Offset")]
		public int Offset { get; set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0008350B File Offset: 0x0008170B
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00083513 File Offset: 0x00081713
		[XmlAttribute("Type")]
		public int Type { get; set; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0008351C File Offset: 0x0008171C
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00083524 File Offset: 0x00081724
		[XmlIgnore]
		public int TypeHash { get; set; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0008352D File Offset: 0x0008172D
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0008353A File Offset: 0x0008173A
		[XmlAttribute("TypeHash")]
		public string TypeHashAsHex
		{
			get
			{
				return HexConverter.ToHex(this.TypeHash);
			}
			set
			{
				this.TypeHash = HexConverter.ToUInt32(value);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00083548 File Offset: 0x00081748
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00083550 File Offset: 0x00081750
		[XmlIgnore]
		public int Unknown { get; set; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00083559 File Offset: 0x00081759
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00083566 File Offset: 0x00081766
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00083574 File Offset: 0x00081774
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x0008357C File Offset: 0x0008177C
		[XmlElement("ArrayType")]
		public PsoStructureEntryXml ArrayType { get; set; }
	}
}
