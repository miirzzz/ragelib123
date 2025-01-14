using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Textures
{
	// Token: 0x02000016 RID: 22
	public class TextureDictionary : FileBase64_GTA5_pc
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004135 File Offset: 0x00002335
		public TextureDictionary()
		{
			this.TextureNameHashes = new ResourceSimpleList64<uint_r>();
			this.Textures = new ResourcePointerList64<TextureDX11>();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004154 File Offset: 0x00002354
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.TextureNameHashes = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Textures = reader.ReadBlock<ResourcePointerList64<TextureDX11>>(Array.Empty<object>());
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000041BC File Offset: 0x000023BC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.TextureNameHashes);
			writer.WriteBlock(this.Textures);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004219 File Offset: 0x00002419
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.TextureNameHashes),
				new Tuple<long, IResourceBlock>(48L, this.Textures)
			};
		}

		// Token: 0x04000090 RID: 144
		public uint Unknown_10h;

		// Token: 0x04000091 RID: 145
		public uint Unknown_14h;

		// Token: 0x04000092 RID: 146
		public uint Unknown_18h;

		// Token: 0x04000093 RID: 147
		public uint Unknown_1Ch;

		// Token: 0x04000094 RID: 148
		public ResourceSimpleList64<uint_r> TextureNameHashes;

		// Token: 0x04000095 RID: 149
		public ResourcePointerList64<TextureDX11> Textures;
	}
}
