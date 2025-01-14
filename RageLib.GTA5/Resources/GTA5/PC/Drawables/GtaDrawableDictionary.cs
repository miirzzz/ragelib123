using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000108 RID: 264
	public class GtaDrawableDictionary : FileBase64_GTA5_pc
	{
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001CBDC File Offset: 0x0001ADDC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.HashesPointer = reader.ReadUInt64();
			this.HashesCount1 = reader.ReadUInt16();
			this.HashesCount2 = reader.ReadUInt16();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.DrawablesPointer = reader.ReadUInt64();
			this.DrawablesCount1 = reader.ReadUInt16();
			this.DrawablesCount2 = reader.ReadUInt16();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Hashes = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(this.HashesPointer, new object[]
			{
				this.HashesCount1
			});
			this.Drawables = reader.ReadBlockAt<ResourcePointerArray64<GtaDrawable>>(this.DrawablesPointer, new object[]
			{
				this.DrawablesCount1
			});
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0001CCD0 File Offset: 0x0001AED0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.HashesPointer = (ulong)((this.Hashes != null) ? this.Hashes.Position : 0L);
			this.DrawablesPointer = (ulong)((this.Drawables != null) ? this.Drawables.Position : 0L);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.HashesPointer);
			writer.Write(this.HashesCount1);
			writer.Write(this.HashesCount2);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.DrawablesPointer);
			writer.Write(this.DrawablesCount1);
			writer.Write(this.DrawablesCount2);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0001CDB0 File Offset: 0x0001AFB0
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Hashes != null)
			{
				list.Add(this.Hashes);
			}
			if (this.Drawables != null)
			{
				list.Add(this.Drawables);
			}
			return list.ToArray();
		}

		// Token: 0x0400318C RID: 12684
		public uint Unknown_10h;

		// Token: 0x0400318D RID: 12685
		public uint Unknown_14h;

		// Token: 0x0400318E RID: 12686
		public uint Unknown_18h;

		// Token: 0x0400318F RID: 12687
		public uint Unknown_1Ch;

		// Token: 0x04003190 RID: 12688
		public ulong HashesPointer;

		// Token: 0x04003191 RID: 12689
		public ushort HashesCount1;

		// Token: 0x04003192 RID: 12690
		public ushort HashesCount2;

		// Token: 0x04003193 RID: 12691
		public uint Unknown_2Ch;

		// Token: 0x04003194 RID: 12692
		public ulong DrawablesPointer;

		// Token: 0x04003195 RID: 12693
		public ushort DrawablesCount1;

		// Token: 0x04003196 RID: 12694
		public ushort DrawablesCount2;

		// Token: 0x04003197 RID: 12695
		public uint Unknown_3Ch;

		// Token: 0x04003198 RID: 12696
		public ResourceSimpleArray<uint_r> Hashes;

		// Token: 0x04003199 RID: 12697
		public ResourcePointerArray64<GtaDrawable> Drawables;
	}
}
