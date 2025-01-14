using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x02000061 RID: 97
	public class Sector : ResourceSystemBlock
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000201 RID: 513 RVA: 0x000090FA File Offset: 0x000072FA
		public override long Length
		{
			get
			{
				return 96L;
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000CC04 File Offset: 0x0000AE04
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadSingle();
			this.Unknown_4h = reader.ReadSingle();
			this.Unknown_8h = reader.ReadSingle();
			this.Unknown_Ch = reader.ReadSingle();
			this.Unknown_10h = reader.ReadSingle();
			this.Unknown_14h = reader.ReadSingle();
			this.Unknown_18h = reader.ReadSingle();
			this.Unknown_1Ch = reader.ReadSingle();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.DataPointer = reader.ReadUInt64();
			this.SubTree1Pointer = reader.ReadUInt64();
			this.SubTree2Pointer = reader.ReadUInt64();
			this.SubTree3Pointer = reader.ReadUInt64();
			this.SubTree4Pointer = reader.ReadUInt64();
			this.Unknown_54h = reader.ReadUInt32();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Data = reader.ReadBlockAt<SectorData>(this.DataPointer, Array.Empty<object>());
			this.SubTree1 = reader.ReadBlockAt<Sector>(this.SubTree1Pointer, Array.Empty<object>());
			this.SubTree2 = reader.ReadBlockAt<Sector>(this.SubTree2Pointer, Array.Empty<object>());
			this.SubTree3 = reader.ReadBlockAt<Sector>(this.SubTree3Pointer, Array.Empty<object>());
			this.SubTree4 = reader.ReadBlockAt<Sector>(this.SubTree4Pointer, Array.Empty<object>());
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000CD68 File Offset: 0x0000AF68
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.DataPointer = (ulong)((this.Data != null) ? this.Data.Position : 0L);
			this.SubTree1Pointer = (ulong)((this.SubTree1 != null) ? this.SubTree1.Position : 0L);
			this.SubTree2Pointer = (ulong)((this.SubTree2 != null) ? this.SubTree2.Position : 0L);
			this.SubTree3Pointer = (ulong)((this.SubTree3 != null) ? this.SubTree3.Position : 0L);
			this.SubTree4Pointer = (ulong)((this.SubTree4 != null) ? this.SubTree4.Position : 0L);
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.DataPointer);
			writer.Write(this.SubTree1Pointer);
			writer.Write(this.SubTree2Pointer);
			writer.Write(this.SubTree3Pointer);
			writer.Write(this.SubTree4Pointer);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Data != null)
			{
				list.Add(this.Data);
			}
			if (this.SubTree1 != null)
			{
				list.Add(this.SubTree1);
			}
			if (this.SubTree2 != null)
			{
				list.Add(this.SubTree2);
			}
			if (this.SubTree3 != null)
			{
				list.Add(this.SubTree3);
			}
			if (this.SubTree4 != null)
			{
				list.Add(this.SubTree4);
			}
			return list.ToArray();
		}

		// Token: 0x040004BE RID: 1214
		public float Unknown_0h;

		// Token: 0x040004BF RID: 1215
		public float Unknown_4h;

		// Token: 0x040004C0 RID: 1216
		public float Unknown_8h;

		// Token: 0x040004C1 RID: 1217
		public float Unknown_Ch;

		// Token: 0x040004C2 RID: 1218
		public float Unknown_10h;

		// Token: 0x040004C3 RID: 1219
		public float Unknown_14h;

		// Token: 0x040004C4 RID: 1220
		public float Unknown_18h;

		// Token: 0x040004C5 RID: 1221
		public float Unknown_1Ch;

		// Token: 0x040004C6 RID: 1222
		public uint Unknown_20h;

		// Token: 0x040004C7 RID: 1223
		public uint Unknown_24h;

		// Token: 0x040004C8 RID: 1224
		public uint Unknown_28h;

		// Token: 0x040004C9 RID: 1225
		public ulong DataPointer;

		// Token: 0x040004CA RID: 1226
		public ulong SubTree1Pointer;

		// Token: 0x040004CB RID: 1227
		public ulong SubTree2Pointer;

		// Token: 0x040004CC RID: 1228
		public ulong SubTree3Pointer;

		// Token: 0x040004CD RID: 1229
		public ulong SubTree4Pointer;

		// Token: 0x040004CE RID: 1230
		public uint Unknown_54h;

		// Token: 0x040004CF RID: 1231
		public uint Unknown_58h;

		// Token: 0x040004D0 RID: 1232
		public uint Unknown_5Ch;

		// Token: 0x040004D1 RID: 1233
		public SectorData Data;

		// Token: 0x040004D2 RID: 1234
		public Sector SubTree1;

		// Token: 0x040004D3 RID: 1235
		public Sector SubTree2;

		// Token: 0x040004D4 RID: 1236
		public Sector SubTree3;

		// Token: 0x040004D5 RID: 1237
		public Sector SubTree4;
	}
}
