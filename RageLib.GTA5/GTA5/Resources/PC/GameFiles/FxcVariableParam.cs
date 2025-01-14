using System;
using System.IO;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001F1 RID: 497
	public class FxcVariableParam
	{
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0003A6F0 File Offset: 0x000388F0
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x0003A6F8 File Offset: 0x000388F8
		public string Name { get; set; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0003A701 File Offset: 0x00038901
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x0003A709 File Offset: 0x00038909
		public byte Type { get; set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0003A712 File Offset: 0x00038912
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x0003A71A File Offset: 0x0003891A
		public object Value { get; set; }

		// Token: 0x060008EA RID: 2282 RVA: 0x0003A724 File Offset: 0x00038924
		public void Read(BinaryReader br)
		{
			this.Name = FxcFile.ReadString(br);
			this.Type = br.ReadByte();
			switch (this.Type)
			{
			case 0:
				this.Value = br.ReadUInt32();
				return;
			case 1:
				this.Value = br.ReadSingle();
				return;
			case 2:
				this.Value = FxcFile.ReadString(br);
				return;
			default:
				return;
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0003A793 File Offset: 0x00038993
		public override string ToString()
		{
			string name = this.Name;
			string str = ": ";
			object value = this.Value;
			return name + str + ((value != null) ? value.ToString() : null);
		}
	}
}
