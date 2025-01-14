using System;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000117 RID: 279
	public class VertexDeclaration : ResourceSystemBlock
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0001F42C File Offset: 0x0001D62C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Flags = reader.ReadUInt32();
			this.Stride = reader.ReadUInt16();
			this.Unknown_6h = reader.ReadByte();
			this.Count = reader.ReadByte();
			this.Types = reader.ReadUInt64();
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0001F46A File Offset: 0x0001D66A
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Flags);
			writer.Write(this.Stride);
			writer.Write(this.Unknown_6h);
			writer.Write(this.Count);
			writer.Write(this.Types);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0001F4A8 File Offset: 0x0001D6A8
		public ulong GetDeclarationId()
		{
			ulong num = 0UL;
			for (int i = 0; i < 16; i++)
			{
				if ((this.Flags >> i & 1U) == 1U)
				{
					num += (this.Types & 15UL << (i * 4 & 31));
				}
			}
			return num;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001F4EC File Offset: 0x0001D6EC
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.Stride.ToString(),
				": ",
				this.Count.ToString(),
				": ",
				this.Flags.ToString(),
				": ",
				this.Types.ToString()
			});
		}

		// Token: 0x040032D3 RID: 13011
		public uint Flags;

		// Token: 0x040032D4 RID: 13012
		public ushort Stride;

		// Token: 0x040032D5 RID: 13013
		public byte Unknown_6h;

		// Token: 0x040032D6 RID: 13014
		public byte Count;

		// Token: 0x040032D7 RID: 13015
		public ulong Types;
	}
}
