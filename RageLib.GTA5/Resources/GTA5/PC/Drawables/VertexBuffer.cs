using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000115 RID: 277
	public class VertexBuffer : ResourceSystemBlock
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0001EE55 File Offset: 0x0001D055
		public override long Length
		{
			get
			{
				return 128L;
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001EE60 File Offset: 0x0001D060
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.VertexStride = reader.ReadUInt16();
			this.Unknown_Ah = reader.ReadUInt16();
			this.Unknown_Ch = reader.ReadUInt32();
			this.DataPointer1 = reader.ReadUInt64();
			this.VertexCount = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.DataPointer2 = reader.ReadUInt64();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.InfoPointer = reader.ReadUInt64();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Unknown_60h = reader.ReadUInt32();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
			this.Info = reader.ReadBlockAt<VertexDeclaration>(this.InfoPointer, Array.Empty<object>());
			this.Data1 = reader.ReadBlockAt<VertexData_GTA5_pc>(this.DataPointer1, new object[]
			{
				this.VertexStride,
				this.VertexCount,
				this.Info
			});
			this.Data2 = reader.ReadBlockAt<VertexData_GTA5_pc>(this.DataPointer2, new object[]
			{
				this.VertexStride,
				this.VertexCount,
				this.Info
			});
			if (this.Data1 == null && this.Data2 != null)
			{
				this.Data1 = this.Data2;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001F084 File Offset: 0x0001D284
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.VertexCount = (uint)((this.Data1 != null) ? this.Data1.VertexCount : 0);
			this.DataPointer1 = (ulong)((this.Data1 != null) ? this.Data1.Position : 0L);
			this.DataPointer2 = (ulong)((this.Data2 != null) ? this.Data2.Position : 0L);
			this.InfoPointer = (ulong)((this.Info != null) ? this.Info.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.VertexStride);
			writer.Write(this.Unknown_Ah);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.DataPointer1);
			writer.Write(this.VertexCount);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.DataPointer2);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.InfoPointer);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001F26C File Offset: 0x0001D46C
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Data1 != null)
			{
				list.Add(this.Data1);
			}
			if (this.Data2 != null)
			{
				list.Add(this.Data2);
			}
			if (this.Info != null)
			{
				list.Add(this.Info);
			}
			return list.ToArray();
		}

		// Token: 0x040032AB RID: 12971
		public uint VFT;

		// Token: 0x040032AC RID: 12972
		public uint Unknown_4h;

		// Token: 0x040032AD RID: 12973
		public ushort VertexStride;

		// Token: 0x040032AE RID: 12974
		public ushort Unknown_Ah;

		// Token: 0x040032AF RID: 12975
		public uint Unknown_Ch;

		// Token: 0x040032B0 RID: 12976
		public ulong DataPointer1;

		// Token: 0x040032B1 RID: 12977
		public uint VertexCount;

		// Token: 0x040032B2 RID: 12978
		public uint Unknown_1Ch;

		// Token: 0x040032B3 RID: 12979
		public ulong DataPointer2;

		// Token: 0x040032B4 RID: 12980
		public uint Unknown_28h;

		// Token: 0x040032B5 RID: 12981
		public uint Unknown_2Ch;

		// Token: 0x040032B6 RID: 12982
		public ulong InfoPointer;

		// Token: 0x040032B7 RID: 12983
		public uint Unknown_38h;

		// Token: 0x040032B8 RID: 12984
		public uint Unknown_3Ch;

		// Token: 0x040032B9 RID: 12985
		public uint Unknown_40h;

		// Token: 0x040032BA RID: 12986
		public uint Unknown_44h;

		// Token: 0x040032BB RID: 12987
		public uint Unknown_48h;

		// Token: 0x040032BC RID: 12988
		public uint Unknown_4Ch;

		// Token: 0x040032BD RID: 12989
		public uint Unknown_50h;

		// Token: 0x040032BE RID: 12990
		public uint Unknown_54h;

		// Token: 0x040032BF RID: 12991
		public uint Unknown_58h;

		// Token: 0x040032C0 RID: 12992
		public uint Unknown_5Ch;

		// Token: 0x040032C1 RID: 12993
		public uint Unknown_60h;

		// Token: 0x040032C2 RID: 12994
		public uint Unknown_64h;

		// Token: 0x040032C3 RID: 12995
		public uint Unknown_68h;

		// Token: 0x040032C4 RID: 12996
		public uint Unknown_6Ch;

		// Token: 0x040032C5 RID: 12997
		public uint Unknown_70h;

		// Token: 0x040032C6 RID: 12998
		public uint Unknown_74h;

		// Token: 0x040032C7 RID: 12999
		public uint Unknown_78h;

		// Token: 0x040032C8 RID: 13000
		public uint Unknown_7Ch;

		// Token: 0x040032C9 RID: 13001
		public VertexData_GTA5_pc Data1;

		// Token: 0x040032CA RID: 13002
		public VertexData_GTA5_pc Data2;

		// Token: 0x040032CB RID: 13003
		public VertexDeclaration Info;
	}
}
