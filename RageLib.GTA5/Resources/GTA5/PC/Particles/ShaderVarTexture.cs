using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Textures;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000043 RID: 67
	public class ShaderVarTexture : ShaderVar
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000A048 File Offset: 0x00008248
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.TexturePointer = reader.ReadUInt64();
			this.NamePointer = reader.ReadUInt64();
			this.NameHash = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Texture = reader.ReadBlockAt<TextureDX11>(this.TexturePointer, Array.Empty<object>());
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000A0EC File Offset: 0x000082EC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.TexturePointer = (ulong)((this.Texture != null) ? this.Texture.Position : 0L);
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.TexturePointer);
			writer.Write(this.NamePointer);
			writer.Write(this.NameHash);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000A19C File Offset: 0x0000839C
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Texture != null)
			{
				list.Add(this.Texture);
			}
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			return list.ToArray();
		}

		// Token: 0x0400037A RID: 890
		public uint Unknown_18h;

		// Token: 0x0400037B RID: 891
		public uint Unknown_1Ch;

		// Token: 0x0400037C RID: 892
		public uint Unknown_20h;

		// Token: 0x0400037D RID: 893
		public uint Unknown_24h;

		// Token: 0x0400037E RID: 894
		public ulong TexturePointer;

		// Token: 0x0400037F RID: 895
		public ulong NamePointer;

		// Token: 0x04000380 RID: 896
		public uint NameHash;

		// Token: 0x04000381 RID: 897
		public uint Unknown_3Ch;

		// Token: 0x04000382 RID: 898
		public TextureDX11 Texture;

		// Token: 0x04000383 RID: 899
		public string_r Name;
	}
}
