using System;
using System.IO;
using System.IO.Compression;
using RageLib.Data;

namespace RageLib.Resources.GTA5
{
	// Token: 0x0200000F RID: 15
	public class ResourceFile_GTA5_pc : IResourceFile
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003137 File Offset: 0x00001337
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000313F File Offset: 0x0000133F
		public int Version { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003148 File Offset: 0x00001348
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00003150 File Offset: 0x00001350
		public int SystemPagesDiv16 { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00003159 File Offset: 0x00001359
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00003161 File Offset: 0x00001361
		public int SystemPagesDiv8 { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000316A File Offset: 0x0000136A
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00003172 File Offset: 0x00001372
		public int SystemPagesDiv4 { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000317B File Offset: 0x0000137B
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00003183 File Offset: 0x00001383
		public int SystemPagesDiv2 { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000318C File Offset: 0x0000138C
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00003194 File Offset: 0x00001394
		public int SystemPagesMul1 { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000319D File Offset: 0x0000139D
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000031A5 File Offset: 0x000013A5
		public int SystemPagesMul2 { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000031AE File Offset: 0x000013AE
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000031B6 File Offset: 0x000013B6
		public int SystemPagesMul4 { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000031BF File Offset: 0x000013BF
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000031C7 File Offset: 0x000013C7
		public int SystemPagesMul8 { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000031D0 File Offset: 0x000013D0
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000031D8 File Offset: 0x000013D8
		public int SystemPagesMul16 { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000031E1 File Offset: 0x000013E1
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000031E9 File Offset: 0x000013E9
		public int SystemPagesSizeShift { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000031F2 File Offset: 0x000013F2
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000031FA File Offset: 0x000013FA
		public int GraphicsPagesDiv16 { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003203 File Offset: 0x00001403
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000320B File Offset: 0x0000140B
		public int GraphicsPagesDiv8 { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00003214 File Offset: 0x00001414
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000321C File Offset: 0x0000141C
		public int GraphicsPagesDiv4 { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00003225 File Offset: 0x00001425
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000322D File Offset: 0x0000142D
		public int GraphicsPagesDiv2 { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003236 File Offset: 0x00001436
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000323E File Offset: 0x0000143E
		public int GraphicsPagesMul1 { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003247 File Offset: 0x00001447
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000324F File Offset: 0x0000144F
		public int GraphicsPagesMul2 { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003258 File Offset: 0x00001458
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00003260 File Offset: 0x00001460
		public int GraphicsPagesMul4 { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003269 File Offset: 0x00001469
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00003271 File Offset: 0x00001471
		public int GraphicsPagesMul8 { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000327A File Offset: 0x0000147A
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00003282 File Offset: 0x00001482
		public int GraphicsPagesMul16 { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000328B File Offset: 0x0000148B
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00003293 File Offset: 0x00001493
		public int GraphicsPagesSizeShift { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000329C File Offset: 0x0000149C
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000032A4 File Offset: 0x000014A4
		public byte[] SystemData { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000032AD File Offset: 0x000014AD
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000032B5 File Offset: 0x000014B5
		public byte[] GraphicsData { get; set; }

		// Token: 0x0600008A RID: 138 RVA: 0x000032C0 File Offset: 0x000014C0
		public void Load(string fileName)
		{
			using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
			{
				this.Load(fileStream);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000032F8 File Offset: 0x000014F8
		public virtual void Load(Stream stream)
		{
			DataReader dataReader = new DataReader(stream, Endianess.LittleEndian);
			dataReader.Position = 0L;
			dataReader.ReadUInt32();
			this.Version = dataReader.ReadInt32();
			uint num = dataReader.ReadUInt32();
			uint num2 = dataReader.ReadUInt32();
			this.SystemPagesDiv16 = (int)(num >> 27 & 1U);
			this.SystemPagesDiv8 = (int)(num >> 26 & 1U);
			this.SystemPagesDiv4 = (int)(num >> 25 & 1U);
			this.SystemPagesDiv2 = (int)(num >> 24 & 1U);
			this.SystemPagesMul1 = (int)(num >> 17 & 127U);
			this.SystemPagesMul2 = (int)(num >> 11 & 63U);
			this.SystemPagesMul4 = (int)(num >> 7 & 15U);
			this.SystemPagesMul8 = (int)(num >> 5 & 3U);
			this.SystemPagesMul16 = (int)(num >> 4 & 1U);
			this.SystemPagesSizeShift = (int)(num & 15U);
			int num3 = 8192 << this.SystemPagesSizeShift;
			int num4 = num3 * this.SystemPagesDiv16 / 16 + num3 * this.SystemPagesDiv8 / 8 + num3 * this.SystemPagesDiv4 / 4 + num3 * this.SystemPagesDiv2 / 2 + num3 * this.SystemPagesMul1 + num3 * this.SystemPagesMul2 * 2 + num3 * this.SystemPagesMul4 * 4 + num3 * this.SystemPagesMul8 * 8 + num3 * this.SystemPagesMul16 * 16;
			this.GraphicsPagesDiv16 = (int)(num2 >> 27 & 1U);
			this.GraphicsPagesDiv8 = (int)(num2 >> 26 & 1U);
			this.GraphicsPagesDiv4 = (int)(num2 >> 25 & 1U);
			this.GraphicsPagesDiv2 = (int)(num2 >> 24 & 1U);
			this.GraphicsPagesMul1 = (int)(num2 >> 17 & 127U);
			this.GraphicsPagesMul2 = (int)(num2 >> 11 & 63U);
			this.GraphicsPagesMul4 = (int)(num2 >> 7 & 15U);
			this.GraphicsPagesMul8 = (int)(num2 >> 5 & 3U);
			this.GraphicsPagesMul16 = (int)(num2 >> 4 & 1U);
			this.GraphicsPagesSizeShift = (int)(num2 & 15U);
			int num5 = 8192 << this.GraphicsPagesSizeShift;
			int num6 = num5 * this.GraphicsPagesDiv16 / 16 + num5 * this.GraphicsPagesDiv8 / 8 + num5 * this.GraphicsPagesDiv4 / 4 + num5 * this.GraphicsPagesDiv2 / 2 + num5 * this.GraphicsPagesMul1 + num5 * this.GraphicsPagesMul2 * 2 + num5 * this.GraphicsPagesMul4 * 4 + num5 * this.GraphicsPagesMul8 * 8 + num5 * this.GraphicsPagesMul16 * 16;
			this.SystemData = new byte[num4];
			this.GraphicsData = new byte[num6];
			DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress, true);
			deflateStream.Read(this.SystemData, 0, num4);
			deflateStream.Read(this.GraphicsData, 0, num6);
			deflateStream.Close();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000355C File Offset: 0x0000175C
		public void Load(byte[] data)
		{
			MemoryStream stream = new MemoryStream(data);
			this.Load(stream);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003578 File Offset: 0x00001778
		public void Save(string fileName)
		{
			using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
			{
				this.Save(fileStream);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000035B0 File Offset: 0x000017B0
		public virtual void Save(Stream stream)
		{
			DataWriter dataWriter = new DataWriter(stream, Endianess.LittleEndian);
			uint num = 0U;
			num |= (uint)((uint)(this.Version >> 4 & 15) << 28);
			num |= (uint)((uint)this.SystemPagesDiv16 << 27);
			num |= (uint)((uint)this.SystemPagesDiv8 << 26);
			num |= (uint)((uint)this.SystemPagesDiv4 << 25);
			num |= (uint)((uint)this.SystemPagesDiv2 << 24);
			num |= (uint)((uint)this.SystemPagesMul1 << 17);
			num |= (uint)((uint)this.SystemPagesMul2 << 11);
			num |= (uint)((uint)this.SystemPagesMul4 << 7);
			num |= (uint)((uint)this.SystemPagesMul8 << 5);
			num |= (uint)((uint)this.SystemPagesMul16 << 4);
			num |= (uint)this.SystemPagesSizeShift;
			uint num2 = 0U;
			num2 |= (uint)((uint)(this.Version & 15) << 28);
			num2 |= (uint)((uint)this.GraphicsPagesDiv16 << 27);
			num2 |= (uint)((uint)this.GraphicsPagesDiv8 << 26);
			num2 |= (uint)((uint)this.GraphicsPagesDiv4 << 25);
			num2 |= (uint)((uint)this.GraphicsPagesDiv2 << 24);
			num2 |= (uint)((uint)this.GraphicsPagesMul1 << 17);
			num2 |= (uint)((uint)this.GraphicsPagesMul2 << 11);
			num2 |= (uint)((uint)this.GraphicsPagesMul4 << 7);
			num2 |= (uint)((uint)this.GraphicsPagesMul8 << 5);
			num2 |= (uint)((uint)this.GraphicsPagesMul16 << 4);
			num2 |= (uint)this.GraphicsPagesSizeShift;
			dataWriter.Write(927159122U);
			dataWriter.Write(this.Version);
			dataWriter.Write(num);
			dataWriter.Write(num2);
			DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Compress, true);
			deflateStream.Write(this.SystemData, 0, this.SystemData.Length);
			deflateStream.Write(this.GraphicsData, 0, this.GraphicsData.Length);
			deflateStream.Flush();
			deflateStream.Close();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003730 File Offset: 0x00001930
		public byte[] Save()
		{
			MemoryStream memoryStream = new MemoryStream();
			this.Save(memoryStream);
			return memoryStream.ToArray();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003750 File Offset: 0x00001950
		public static bool IsResourceFile(string fileName)
		{
			bool result;
			using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
			{
				result = (new DataReader(fileStream, Endianess.LittleEndian).ReadInt32() == 927159122);
			}
			return result;
		}

		// Token: 0x04000045 RID: 69
		protected const int RESOURCE_IDENT = 927159122;

		// Token: 0x04000046 RID: 70
		protected const int BASE_SIZE = 8192;
	}
}
