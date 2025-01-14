using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x02000142 RID: 322
	public class ClothDictionary : FileBase64_GTA5_pc
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00021C78 File Offset: 0x0001FE78
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.ClothNameHashes = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Clothes = reader.ReadBlock<ResourcePointerList64<CharacterCloth>>(Array.Empty<object>());
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00021CE0 File Offset: 0x0001FEE0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.ClothNameHashes);
			writer.WriteBlock(this.Clothes);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00021D3D File Offset: 0x0001FF3D
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.ClothNameHashes),
				new Tuple<long, IResourceBlock>(48L, this.Clothes)
			};
		}

		// Token: 0x04003440 RID: 13376
		public uint Unknown_10h;

		// Token: 0x04003441 RID: 13377
		public uint Unknown_14h;

		// Token: 0x04003442 RID: 13378
		public uint Unknown_18h;

		// Token: 0x04003443 RID: 13379
		public uint Unknown_1Ch;

		// Token: 0x04003444 RID: 13380
		public ResourceSimpleList64<uint_r> ClothNameHashes;

		// Token: 0x04003445 RID: 13381
		public ResourcePointerList64<CharacterCloth> Clothes;
	}
}
