using System;

namespace RageLib.Resources.GTA5.PC.Expressions
{
	// Token: 0x02000100 RID: 256
	public class Unknown_E_001 : ResourceSystemBlock
	{
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001B4CD File Offset: 0x000196CD
		public override long Length
		{
			get
			{
				return (long)(16 + this.Data1.Length + this.Data2.Length + this.Data3.Length);
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0001B4F0 File Offset: 0x000196F0
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.len1 = reader.ReadUInt32();
			this.len2 = reader.ReadUInt32();
			this.len3 = reader.ReadUInt16();
			this.Unknown_Eh = reader.ReadUInt16();
			this.Data1 = reader.ReadBytes((int)this.len1);
			this.Data2 = reader.ReadBytes((int)this.len2);
			this.Data3 = reader.ReadBytes((int)this.len3);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0001B570 File Offset: 0x00019770
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.len1);
			writer.Write(this.len2);
			writer.Write(this.len3);
			writer.Write(this.Unknown_Eh);
			writer.Write(this.Data1);
			writer.Write(this.Data2);
			writer.Write(this.Data3);
		}

		// Token: 0x040030DF RID: 12511
		public uint Unknown_0h;

		// Token: 0x040030E0 RID: 12512
		public uint len1;

		// Token: 0x040030E1 RID: 12513
		public uint len2;

		// Token: 0x040030E2 RID: 12514
		public ushort len3;

		// Token: 0x040030E3 RID: 12515
		public ushort Unknown_Eh;

		// Token: 0x040030E4 RID: 12516
		public byte[] Data1;

		// Token: 0x040030E5 RID: 12517
		public byte[] Data2;

		// Token: 0x040030E6 RID: 12518
		public byte[] Data3;
	}
}
