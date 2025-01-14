using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x0200016C RID: 364
	public class BoundDictionary : FileBase64_GTA5_pc
	{
		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0002647C File Offset: 0x0002467C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.BoundNameHashes = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Bounds = reader.ReadBlock<ResourcePointerList64<Bound>>(Array.Empty<object>());
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000264E4 File Offset: 0x000246E4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.BoundNameHashes);
			writer.WriteBlock(this.Bounds);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00026541 File Offset: 0x00024741
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.BoundNameHashes),
				new Tuple<long, IResourceBlock>(48L, this.Bounds)
			};
		}

		// Token: 0x0400364F RID: 13903
		public uint Unknown_10h;

		// Token: 0x04003650 RID: 13904
		public uint Unknown_14h;

		// Token: 0x04003651 RID: 13905
		public uint Unknown_18h;

		// Token: 0x04003652 RID: 13906
		public uint Unknown_1Ch;

		// Token: 0x04003653 RID: 13907
		public ResourceSimpleList64<uint_r> BoundNameHashes;

		// Token: 0x04003654 RID: 13908
		public ResourcePointerList64<Bound> Bounds;
	}
}
