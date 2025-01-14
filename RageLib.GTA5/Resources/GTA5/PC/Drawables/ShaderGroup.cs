using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Textures;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000110 RID: 272
	public class ShaderGroup : ResourceSystemBlock
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0001E548 File Offset: 0x0001C748
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.TextureDictionaryPointer = reader.ReadUInt64();
			this.ShadersPointer = reader.ReadUInt64();
			this.ShadersCount1 = reader.ReadUInt16();
			this.ShadersCount2 = reader.ReadUInt16();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.TextureDictionary = reader.ReadBlockAt<TextureDictionary>(this.TextureDictionaryPointer, Array.Empty<object>());
			this.Shaders = reader.ReadBlockAt<ResourcePointerArray64<ShaderFX>>(this.ShadersPointer, new object[]
			{
				this.ShadersCount1
			});
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001E648 File Offset: 0x0001C848
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.TextureDictionaryPointer = (ulong)((this.TextureDictionary != null) ? this.TextureDictionary.Position : 0L);
			this.ShadersPointer = (ulong)((this.Shaders != null) ? this.Shaders.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.TextureDictionaryPointer);
			writer.Write(this.ShadersPointer);
			writer.Write(this.ShadersCount1);
			writer.Write(this.ShadersCount2);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001E744 File Offset: 0x0001C944
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.TextureDictionary != null)
			{
				list.Add(this.TextureDictionary);
			}
			if (this.Shaders != null)
			{
				list.Add(this.Shaders);
			}
			return list.ToArray();
		}

		// Token: 0x0400324A RID: 12874
		public uint VFT;

		// Token: 0x0400324B RID: 12875
		public uint Unknown_4h;

		// Token: 0x0400324C RID: 12876
		public ulong TextureDictionaryPointer;

		// Token: 0x0400324D RID: 12877
		public ulong ShadersPointer;

		// Token: 0x0400324E RID: 12878
		public ushort ShadersCount1;

		// Token: 0x0400324F RID: 12879
		public ushort ShadersCount2;

		// Token: 0x04003250 RID: 12880
		public uint Unknown_1Ch;

		// Token: 0x04003251 RID: 12881
		public uint Unknown_20h;

		// Token: 0x04003252 RID: 12882
		public uint Unknown_24h;

		// Token: 0x04003253 RID: 12883
		public uint Unknown_28h;

		// Token: 0x04003254 RID: 12884
		public uint Unknown_2Ch;

		// Token: 0x04003255 RID: 12885
		public uint Unknown_30h;

		// Token: 0x04003256 RID: 12886
		public uint Unknown_34h;

		// Token: 0x04003257 RID: 12887
		public uint Unknown_38h;

		// Token: 0x04003258 RID: 12888
		public uint Unknown_3Ch;

		// Token: 0x04003259 RID: 12889
		public TextureDictionary TextureDictionary;

		// Token: 0x0400325A RID: 12890
		public ResourcePointerArray64<ShaderFX> Shaders;
	}
}
