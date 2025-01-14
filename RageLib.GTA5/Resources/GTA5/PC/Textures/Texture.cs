using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Textures
{
	// Token: 0x02000015 RID: 21
	public class Texture : ResourceSystemBlock
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003F54 File Offset: 0x00002154
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.NamePointer = reader.ReadUInt64();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000402C File Offset: 0x0000222C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			string_r name = this.Name;
			this.NamePointer = (ulong)((name != null) ? name.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.NamePointer);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004108 File Offset: 0x00002308
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			return list.ToArray();
		}

		// Token: 0x04000080 RID: 128
		public uint VFT;

		// Token: 0x04000081 RID: 129
		public uint Unknown_4h;

		// Token: 0x04000082 RID: 130
		public uint Unknown_8h;

		// Token: 0x04000083 RID: 131
		public uint Unknown_Ch;

		// Token: 0x04000084 RID: 132
		public uint Unknown_10h;

		// Token: 0x04000085 RID: 133
		public uint Unknown_14h;

		// Token: 0x04000086 RID: 134
		public uint Unknown_18h;

		// Token: 0x04000087 RID: 135
		public uint Unknown_1Ch;

		// Token: 0x04000088 RID: 136
		public uint Unknown_20h;

		// Token: 0x04000089 RID: 137
		public uint Unknown_24h;

		// Token: 0x0400008A RID: 138
		public ulong NamePointer;

		// Token: 0x0400008B RID: 139
		public uint Unknown_30h;

		// Token: 0x0400008C RID: 140
		public uint Unknown_34h;

		// Token: 0x0400008D RID: 141
		public uint Unknown_38h;

		// Token: 0x0400008E RID: 142
		public uint Unknown_3Ch;

		// Token: 0x0400008F RID: 143
		public string_r Name;
	}
}
