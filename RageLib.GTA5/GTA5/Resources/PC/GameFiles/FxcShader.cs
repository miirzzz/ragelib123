using System;
using System.Collections.Generic;
using System.IO;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001ED RID: 493
	public class FxcShader
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00039691 File Offset: 0x00037891
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00039699 File Offset: 0x00037899
		public long Offset { get; set; }

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x000396A2 File Offset: 0x000378A2
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x000396AA File Offset: 0x000378AA
		public string Name { get; set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x000396B3 File Offset: 0x000378B3
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x000396BB File Offset: 0x000378BB
		public string[] Params { get; set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x000396C4 File Offset: 0x000378C4
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x000396CC File Offset: 0x000378CC
		public FxcShaderBufferRef[] Buffers { get; set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x000396D5 File Offset: 0x000378D5
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x000396DD File Offset: 0x000378DD
		public byte VersionMajor { get; set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x000396E6 File Offset: 0x000378E6
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x000396EE File Offset: 0x000378EE
		public byte VersionMinor { get; set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x000396F7 File Offset: 0x000378F7
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x000396FF File Offset: 0x000378FF
		public string VersionString { get; set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00039708 File Offset: 0x00037908
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00039710 File Offset: 0x00037910
		public byte[] ByteCode { get; set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00039719 File Offset: 0x00037919
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00039721 File Offset: 0x00037921
		public string Disassembly { get; set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0003972A File Offset: 0x0003792A
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00039732 File Offset: 0x00037932
		public string LastError { get; set; }

		// Token: 0x060008A2 RID: 2210 RVA: 0x0003973C File Offset: 0x0003793C
		public bool Read(BinaryReader br, bool exbyteflag, bool vsgsps)
		{
			this.Offset = br.BaseStream.Position;
			this.Name = FxcFile.ReadString(br);
			if (this.Name.Length == 0)
			{
				this.Name = FxcFile.ReadString(br);
				exbyteflag = true;
			}
			this.Params = FxcFile.ReadStringArray(br);
			byte b = br.ReadByte();
			List<FxcShaderBufferRef> list = new List<FxcShaderBufferRef>();
			for (int i = 0; i < (int)b; i++)
			{
				list.Add(new FxcShaderBufferRef
				{
					Name = FxcFile.ReadString(br),
					Unk0Ushort = br.ReadUInt16()
				});
			}
			this.Buffers = list.ToArray();
			if (exbyteflag)
			{
				br.ReadByte();
			}
			uint num = br.ReadUInt32();
			if (num > 0U)
			{
				if (br.ReadUInt32() != 1128421444U)
				{
					this.LastError += "Unexpected data found at DXBC header...\r\n";
					return false;
				}
				br.BaseStream.Position -= 4L;
				this.ByteCode = br.ReadBytes((int)num);
				if (vsgsps)
				{
					this.VersionMajor = br.ReadByte();
					this.VersionMinor = br.ReadByte();
				}
			}
			return true;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00039853 File Offset: 0x00037A53
		public override string ToString()
		{
			return this.Name;
		}
	}
}
