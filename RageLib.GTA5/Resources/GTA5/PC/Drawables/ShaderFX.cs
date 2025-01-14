using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200010E RID: 270
	public class ShaderFX : ResourceSystemBlock
	{
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0001DEB8 File Offset: 0x0001C0B8
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.ParametersPointer = reader.ReadUInt64();
			this.NameHash = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.ParameterCount = reader.ReadByte();
			this.Unknown_11h = reader.ReadByte();
			this.Unknown_12h = reader.ReadUInt16();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt16();
			this.Unknown_26h = reader.ReadByte();
			this.TextureParametersCount = reader.ReadByte();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.ParametersList = reader.ReadBlockAt<ShaderParametersBlock_GTA5_pc>(this.ParametersPointer, new object[]
			{
				this.ParameterCount
			});
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.ParametersPointer = (ulong)((this.ParametersList != null) ? this.ParametersList.Position : 0L);
			writer.Write(this.ParametersPointer);
			writer.Write(this.NameHash);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.ParameterCount);
			writer.Write(this.Unknown_11h);
			writer.Write(this.Unknown_12h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_26h);
			writer.Write(this.TextureParametersCount);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0001E080 File Offset: 0x0001C280
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.ParametersList != null)
			{
				list.Add(this.ParametersList);
			}
			return list.ToArray();
		}

		// Token: 0x04003238 RID: 12856
		public ulong ParametersPointer;

		// Token: 0x04003239 RID: 12857
		public uint NameHash;

		// Token: 0x0400323A RID: 12858
		public uint Unknown_Ch;

		// Token: 0x0400323B RID: 12859
		public byte ParameterCount;

		// Token: 0x0400323C RID: 12860
		public byte Unknown_11h;

		// Token: 0x0400323D RID: 12861
		public ushort Unknown_12h;

		// Token: 0x0400323E RID: 12862
		public uint Unknown_14h;

		// Token: 0x0400323F RID: 12863
		public uint Unknown_18h;

		// Token: 0x04003240 RID: 12864
		public uint Unknown_1Ch;

		// Token: 0x04003241 RID: 12865
		public uint Unknown_20h;

		// Token: 0x04003242 RID: 12866
		public ushort Unknown_24h;

		// Token: 0x04003243 RID: 12867
		public byte Unknown_26h;

		// Token: 0x04003244 RID: 12868
		public byte TextureParametersCount;

		// Token: 0x04003245 RID: 12869
		public uint Unknown_28h;

		// Token: 0x04003246 RID: 12870
		public uint Unknown_2Ch;

		// Token: 0x04003247 RID: 12871
		public ShaderParametersBlock_GTA5_pc ParametersList;
	}
}
