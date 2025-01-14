using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000041 RID: 65
	public class ShaderVar : ResourceSystemBlock, IResourceXXSystemBlock, IResourceSystemBlock, IResourceBlock
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00009D93 File Offset: 0x00007F93
		public override long Length
		{
			get
			{
				return 24L;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00009D98 File Offset: 0x00007F98
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Type = reader.ReadByte();
			this.Unknown_15h = reader.ReadByte();
			this.Unknown_16h = reader.ReadUInt16();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00009E08 File Offset: 0x00008008
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Type);
			writer.Write(this.Unknown_15h);
			writer.Write(this.Unknown_16h);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00009E78 File Offset: 0x00008078
		public IResourceSystemBlock GetType(ResourceDataReader reader, params object[] parameters)
		{
			reader.Position += 20L;
			byte b = reader.ReadByte();
			reader.Position -= 21L;
			switch (b)
			{
			case 2:
			case 4:
				return new ShaderVarVector();
			case 6:
				return new ShaderVarTexture();
			case 7:
				return new ShaderVarKeyframe();
			}
			throw new Exception("Unknown shader var type");
		}

		// Token: 0x04000367 RID: 871
		public uint VFT;

		// Token: 0x04000368 RID: 872
		public uint Unknown_4h;

		// Token: 0x04000369 RID: 873
		public uint Unknown_8h;

		// Token: 0x0400036A RID: 874
		public uint Unknown_Ch;

		// Token: 0x0400036B RID: 875
		public uint Unknown_10h;

		// Token: 0x0400036C RID: 876
		public byte Type;

		// Token: 0x0400036D RID: 877
		public byte Unknown_15h;

		// Token: 0x0400036E RID: 878
		public ushort Unknown_16h;
	}
}
