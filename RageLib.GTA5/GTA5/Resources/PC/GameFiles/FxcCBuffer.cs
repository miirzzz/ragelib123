using System;
using System.Collections.Generic;
using System.IO;
using RageLib.Hash;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001EF RID: 495
	public class FxcCBuffer
	{
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x000398AB File Offset: 0x00037AAB
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x000398B3 File Offset: 0x00037AB3
		public uint u003 { get; set; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x000398BC File Offset: 0x00037ABC
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x000398C4 File Offset: 0x00037AC4
		public ushort us001 { get; set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x000398CD File Offset: 0x00037ACD
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x000398D5 File Offset: 0x00037AD5
		public ushort us002 { get; set; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x000398DE File Offset: 0x00037ADE
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x000398E6 File Offset: 0x00037AE6
		public ushort us003 { get; set; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x000398EF File Offset: 0x00037AEF
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x000398F7 File Offset: 0x00037AF7
		public ushort us004 { get; set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00039900 File Offset: 0x00037B00
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00039908 File Offset: 0x00037B08
		public ushort us005 { get; set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00039911 File Offset: 0x00037B11
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00039919 File Offset: 0x00037B19
		public ushort us006 { get; set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00039922 File Offset: 0x00037B22
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x0003992A File Offset: 0x00037B2A
		public string Name { get; set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00039933 File Offset: 0x00037B33
		public uint NameHash
		{
			get
			{
				return Jenkins.Hash(this.Name);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x00039940 File Offset: 0x00037B40
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00039948 File Offset: 0x00037B48
		public FxcVariable[] Variables { get; set; }

		// Token: 0x060008BE RID: 2238 RVA: 0x00039954 File Offset: 0x00037B54
		public void Read(BinaryReader br)
		{
			this.u003 = br.ReadUInt32();
			this.us001 = br.ReadUInt16();
			this.us002 = br.ReadUInt16();
			this.us003 = br.ReadUInt16();
			this.us004 = br.ReadUInt16();
			this.us005 = br.ReadUInt16();
			this.us006 = br.ReadUInt16();
			this.Name = FxcFile.ReadString(br);
			Jenkins.Ensure(this.Name);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000399D0 File Offset: 0x00037BD0
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.Name,
				": ",
				this.u003.ToString(),
				", ",
				this.us001.ToString(),
				", ",
				this.us002.ToString(),
				", ",
				this.us003.ToString(),
				", ",
				this.us004.ToString(),
				", ",
				this.us005.ToString(),
				", ",
				this.us006.ToString()
			});
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00039AA7 File Offset: 0x00037CA7
		public void AddVariable(FxcVariable vari)
		{
			if (this.VariablesList == null)
			{
				this.VariablesList = new List<FxcVariable>();
			}
			this.VariablesList.Add(vari);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00039AC8 File Offset: 0x00037CC8
		public void ConsolidateVariables()
		{
			if (this.VariablesList != null)
			{
				this.Variables = this.VariablesList.ToArray();
				this.VariablesList = null;
			}
		}

		// Token: 0x04003A27 RID: 14887
		public List<FxcVariable> VariablesList;
	}
}
