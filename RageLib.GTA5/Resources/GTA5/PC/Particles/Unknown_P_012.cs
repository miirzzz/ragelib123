using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Drawables;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000050 RID: 80
	public class Unknown_P_012 : ResourceSystemBlock
	{
		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h_Pointer = reader.ReadUInt64();
			this.DrawablePointer = reader.ReadUInt64();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_10h_Data = reader.ReadBlockAt<string_r>(this.Unknown_10h_Pointer, Array.Empty<object>());
			this.Drawable = reader.ReadBlockAt<Drawable>(this.DrawablePointer, Array.Empty<object>());
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000AD54 File Offset: 0x00008F54
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.Unknown_10h_Pointer = (ulong)((this.Unknown_10h_Data != null) ? this.Unknown_10h_Data.Position : 0L);
			this.DrawablePointer = (ulong)((this.Drawable != null) ? this.Drawable.Position : 0L);
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h_Pointer);
			writer.Write(this.DrawablePointer);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000AE14 File Offset: 0x00009014
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Unknown_10h_Data != null)
			{
				list.Add(this.Unknown_10h_Data);
			}
			if (this.Drawable != null)
			{
				list.Add(this.Drawable);
			}
			return list.ToArray();
		}

		// Token: 0x040003D4 RID: 980
		public uint Unknown_0h;

		// Token: 0x040003D5 RID: 981
		public uint Unknown_4h;

		// Token: 0x040003D6 RID: 982
		public uint Unknown_8h;

		// Token: 0x040003D7 RID: 983
		public uint Unknown_Ch;

		// Token: 0x040003D8 RID: 984
		public ulong Unknown_10h_Pointer;

		// Token: 0x040003D9 RID: 985
		public ulong DrawablePointer;

		// Token: 0x040003DA RID: 986
		public uint Unknown_20h;

		// Token: 0x040003DB RID: 987
		public uint Unknown_24h;

		// Token: 0x040003DC RID: 988
		public uint Unknown_28h;

		// Token: 0x040003DD RID: 989
		public uint Unknown_2Ch;

		// Token: 0x040003DE RID: 990
		public string_r Unknown_10h_Data;

		// Token: 0x040003DF RID: 991
		public Drawable Drawable;
	}
}
