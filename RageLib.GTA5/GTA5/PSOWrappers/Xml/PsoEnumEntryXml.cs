using System;
using System.Xml.Serialization;

namespace RageLib.GTA5.PSOWrappers.Xml
{
	// Token: 0x02000279 RID: 633
	[Serializable]
	public class PsoEnumEntryXml
	{
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x000835C2 File Offset: 0x000817C2
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x000835CA File Offset: 0x000817CA
		[XmlIgnore]
		public int NameHash { get; set; }

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x000835D3 File Offset: 0x000817D3
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x000835E0 File Offset: 0x000817E0
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x000835EE File Offset: 0x000817EE
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x000835F6 File Offset: 0x000817F6
		[XmlAttribute("Value")]
		public int Value { get; set; }
	}
}
