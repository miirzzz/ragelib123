using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Textures
{
	// Token: 0x02000017 RID: 23
	public class TextureDX11 : Texture
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00004243 File Offset: 0x00002443
		public override long Length
		{
			get
			{
				return 144L;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000424C File Offset: 0x0000244C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Width = reader.ReadUInt16();
			this.Height = reader.ReadUInt16();
			this.Unknown_54h = reader.ReadUInt16();
			this.Stride = reader.ReadUInt16();
			this.Format = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadByte();
			this.Levels = reader.ReadByte();
			this.Unknown_5Eh = reader.ReadUInt16();
			this.Unknown_60h = reader.ReadUInt32();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.DataPointer = reader.ReadUInt64();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
			this.Unknown_80h = reader.ReadUInt32();
			this.Unknown_84h = reader.ReadUInt32();
			this.Unknown_88h = reader.ReadUInt32();
			this.Unknown_8Ch = reader.ReadUInt32();
			this.Data = reader.ReadBlockAt<TextureData_GTA5_pc>(this.DataPointer, new object[]
			{
				this.Format,
				this.Width,
				this.Height,
				this.Levels,
				this.Stride
			});
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000043D4 File Offset: 0x000025D4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.DataPointer = (ulong)this.Data.Position;
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Width);
			writer.Write(this.Height);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Stride);
			writer.Write(this.Format);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.Levels);
			writer.Write(this.Unknown_5Eh);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
			writer.Write(this.DataPointer);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
			writer.Write(this.Unknown_80h);
			writer.Write(this.Unknown_84h);
			writer.Write(this.Unknown_88h);
			writer.Write(this.Unknown_8Ch);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000450E File Offset: 0x0000270E
		public override IResourceBlock[] GetReferences()
		{
			return new List<IResourceBlock>(base.GetReferences())
			{
				this.Data
			}.ToArray();
		}

		// Token: 0x04000096 RID: 150
		public uint Unknown_40h;

		// Token: 0x04000097 RID: 151
		public uint Unknown_44h;

		// Token: 0x04000098 RID: 152
		public uint Unknown_48h;

		// Token: 0x04000099 RID: 153
		public uint Unknown_4Ch;

		// Token: 0x0400009A RID: 154
		public ushort Width;

		// Token: 0x0400009B RID: 155
		public ushort Height;

		// Token: 0x0400009C RID: 156
		public ushort Unknown_54h;

		// Token: 0x0400009D RID: 157
		public ushort Stride;

		// Token: 0x0400009E RID: 158
		public uint Format;

		// Token: 0x0400009F RID: 159
		public byte Unknown_5Ch;

		// Token: 0x040000A0 RID: 160
		public byte Levels;

		// Token: 0x040000A1 RID: 161
		public ushort Unknown_5Eh;

		// Token: 0x040000A2 RID: 162
		public uint Unknown_60h;

		// Token: 0x040000A3 RID: 163
		public uint Unknown_64h;

		// Token: 0x040000A4 RID: 164
		public uint Unknown_68h;

		// Token: 0x040000A5 RID: 165
		public uint Unknown_6Ch;

		// Token: 0x040000A6 RID: 166
		public ulong DataPointer;

		// Token: 0x040000A7 RID: 167
		public uint Unknown_78h;

		// Token: 0x040000A8 RID: 168
		public uint Unknown_7Ch;

		// Token: 0x040000A9 RID: 169
		public uint Unknown_80h;

		// Token: 0x040000AA RID: 170
		public uint Unknown_84h;

		// Token: 0x040000AB RID: 171
		public uint Unknown_88h;

		// Token: 0x040000AC RID: 172
		public uint Unknown_8Ch;

		// Token: 0x040000AD RID: 173
		public TextureData_GTA5_pc Data;
	}
}
