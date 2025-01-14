using System;
using System.IO;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001EC RID: 492
	public class FxcHeaderChunk
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00039557 File Offset: 0x00037757
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x0003955F File Offset: 0x0003775F
		public string Name { get; set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x00039568 File Offset: 0x00037768
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00039570 File Offset: 0x00037770
		public byte Unk1Byte { get; set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00039579 File Offset: 0x00037779
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00039581 File Offset: 0x00037781
		public byte Unk2Byte { get; set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0003958A File Offset: 0x0003778A
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x00039592 File Offset: 0x00037792
		public uint Unk3Uint { get; set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x0003959B File Offset: 0x0003779B
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x000395A3 File Offset: 0x000377A3
		public int Gindex { get; set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x000395AC File Offset: 0x000377AC
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x000395B4 File Offset: 0x000377B4
		public byte ShaderCount { get; set; }

		// Token: 0x0600088B RID: 2187 RVA: 0x000395BD File Offset: 0x000377BD
		public void Read(BinaryReader br)
		{
			this.Name = FxcFile.ReadString(br);
			this.Unk1Byte = br.ReadByte();
			this.Unk2Byte = br.ReadByte();
			this.Unk3Uint = br.ReadUInt32();
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000395F0 File Offset: 0x000377F0
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.Name,
				": ",
				this.Gindex.ToString(),
				": ",
				this.ShaderCount.ToString(),
				": ",
				this.Unk1Byte.ToString(),
				": ",
				this.Unk2Byte.ToString(),
				": ",
				this.Unk3Uint.ToString()
			});
		}
	}
}
