using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x02000146 RID: 326
	public class MorphController : ResourceSystemBlock
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00022500 File Offset: 0x00020700
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h_Pointer = reader.ReadUInt64();
			this.Unknown_20h_Pointer = reader.ReadUInt64();
			this.Unknown_28h_Pointer = reader.ReadUInt64();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_18h_Data = reader.ReadBlockAt<Unknown_C_006>(this.Unknown_18h_Pointer, Array.Empty<object>());
			this.Unknown_20h_Data = reader.ReadBlockAt<Unknown_C_006>(this.Unknown_20h_Pointer, Array.Empty<object>());
			this.Unknown_28h_Data = reader.ReadBlockAt<Unknown_C_006>(this.Unknown_28h_Pointer, Array.Empty<object>());
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000225F0 File Offset: 0x000207F0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.Unknown_18h_Pointer = (ulong)((this.Unknown_18h_Data != null) ? this.Unknown_18h_Data.Position : 0L);
			this.Unknown_20h_Pointer = (ulong)((this.Unknown_20h_Data != null) ? this.Unknown_20h_Data.Position : 0L);
			this.Unknown_28h_Pointer = (ulong)((this.Unknown_28h_Data != null) ? this.Unknown_28h_Data.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h_Pointer);
			writer.Write(this.Unknown_20h_Pointer);
			writer.Write(this.Unknown_28h_Pointer);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000226F0 File Offset: 0x000208F0
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Unknown_18h_Data != null)
			{
				list.Add(this.Unknown_18h_Data);
			}
			if (this.Unknown_20h_Data != null)
			{
				list.Add(this.Unknown_20h_Data);
			}
			if (this.Unknown_28h_Data != null)
			{
				list.Add(this.Unknown_28h_Data);
			}
			return list.ToArray();
		}

		// Token: 0x04003487 RID: 13447
		public uint VFT;

		// Token: 0x04003488 RID: 13448
		public uint Unknown_4h;

		// Token: 0x04003489 RID: 13449
		public uint Unknown_8h;

		// Token: 0x0400348A RID: 13450
		public uint Unknown_Ch;

		// Token: 0x0400348B RID: 13451
		public uint Unknown_10h;

		// Token: 0x0400348C RID: 13452
		public uint Unknown_14h;

		// Token: 0x0400348D RID: 13453
		public ulong Unknown_18h_Pointer;

		// Token: 0x0400348E RID: 13454
		public ulong Unknown_20h_Pointer;

		// Token: 0x0400348F RID: 13455
		public ulong Unknown_28h_Pointer;

		// Token: 0x04003490 RID: 13456
		public uint Unknown_30h;

		// Token: 0x04003491 RID: 13457
		public uint Unknown_34h;

		// Token: 0x04003492 RID: 13458
		public uint Unknown_38h;

		// Token: 0x04003493 RID: 13459
		public uint Unknown_3Ch;

		// Token: 0x04003494 RID: 13460
		public Unknown_C_006 Unknown_18h_Data;

		// Token: 0x04003495 RID: 13461
		public Unknown_C_006 Unknown_20h_Data;

		// Token: 0x04003496 RID: 13462
		public Unknown_C_006 Unknown_28h_Data;
	}
}
