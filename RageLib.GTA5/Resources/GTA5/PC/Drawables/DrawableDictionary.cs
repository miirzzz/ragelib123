using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000104 RID: 260
	public class DrawableDictionary : FileBase64_GTA5_pc
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0001C124 File Offset: 0x0001A324
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Hashes = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Drawables = reader.ReadBlock<ResourcePointerList64<Drawable>>(Array.Empty<object>());
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0001C18C File Offset: 0x0001A38C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.Hashes);
			writer.WriteBlock(this.Drawables);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0001C1E9 File Offset: 0x0001A3E9
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.Hashes),
				new Tuple<long, IResourceBlock>(48L, this.Drawables)
			};
		}

		// Token: 0x04003145 RID: 12613
		public uint Unknown_10h;

		// Token: 0x04003146 RID: 12614
		public uint Unknown_14h;

		// Token: 0x04003147 RID: 12615
		public uint Unknown_18h;

		// Token: 0x04003148 RID: 12616
		public uint Unknown_1Ch;

		// Token: 0x04003149 RID: 12617
		public ResourceSimpleList64<uint_r> Hashes;

		// Token: 0x0400314A RID: 12618
		public ResourcePointerList64<Drawable> Drawables;
	}
}
