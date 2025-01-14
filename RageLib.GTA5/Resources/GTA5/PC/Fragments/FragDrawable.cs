using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Bounds;
using RageLib.Resources.GTA5.PC.Drawables;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000F0 RID: 240
	public class FragDrawable : Drawable
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00017DE9 File Offset: 0x00015FE9
		public override long Length
		{
			get
			{
				return 336L;
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00017DF4 File Offset: 0x00015FF4
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_A8h = reader.ReadUInt32();
			this.Unknown_ACh = reader.ReadUInt32();
			this.Unknown_B0h = reader.ReadBlock<RAGE_Matrix4>(Array.Empty<object>());
			this.BoundPointer = reader.ReadUInt64();
			this.Unknown_F8h_Pointer = reader.ReadUInt64();
			this.Count1 = reader.ReadUInt16();
			this.Count2 = reader.ReadUInt16();
			this.Unknown_104h = reader.ReadUInt32();
			this.Unknown_108h_Pointer = reader.ReadUInt64();
			this.Count3 = reader.ReadUInt16();
			this.Count4 = reader.ReadUInt16();
			this.Unknown_114h = reader.ReadUInt32();
			this.Unknown_118h = reader.ReadUInt32();
			this.Unknown_11Ch = reader.ReadUInt32();
			this.Unknown_120h = reader.ReadUInt32();
			this.Unknown_124h = reader.ReadUInt32();
			this.Unknown_128h = reader.ReadUInt32();
			this.Unknown_12Ch = reader.ReadUInt32();
			this.NamePointer = reader.ReadUInt64();
			this.Unknown_138h = reader.ReadUInt32();
			this.Unknown_13Ch = reader.ReadUInt32();
			this.Unknown_140h = reader.ReadUInt32();
			this.Unknown_144h = reader.ReadUInt32();
			this.Unknown_148h = reader.ReadUInt32();
			this.Unknown_14Ch = reader.ReadUInt32();
			this.Bound = reader.ReadBlockAt<Bound>(this.BoundPointer, Array.Empty<object>());
			this.Unknown_F8h_Data = reader.ReadBlockAt<ResourceSimpleArray<ulong_r>>(this.Unknown_F8h_Pointer, new object[]
			{
				this.Count1
			});
			this.Unknown_108h_Data = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Matrix4>>(this.Unknown_108h_Pointer, new object[]
			{
				this.Count2
			});
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00017FB4 File Offset: 0x000161B4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.BoundPointer = (ulong)((this.Bound != null) ? this.Bound.Position : 0L);
			this.Unknown_F8h_Pointer = (ulong)((this.Unknown_F8h_Data != null) ? this.Unknown_F8h_Data.Position : 0L);
			this.Unknown_108h_Pointer = (ulong)((this.Unknown_108h_Data != null) ? this.Unknown_108h_Data.Position : 0L);
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			writer.Write(this.Unknown_A8h);
			writer.Write(this.Unknown_ACh);
			writer.WriteBlock(this.Unknown_B0h);
			writer.Write(this.BoundPointer);
			writer.Write(this.Unknown_F8h_Pointer);
			writer.Write(this.Count1);
			writer.Write(this.Count2);
			writer.Write(this.Unknown_104h);
			writer.Write(this.Unknown_108h_Pointer);
			writer.Write(this.Count3);
			writer.Write(this.Count4);
			writer.Write(this.Unknown_114h);
			writer.Write(this.Unknown_118h);
			writer.Write(this.Unknown_11Ch);
			writer.Write(this.Unknown_120h);
			writer.Write(this.Unknown_124h);
			writer.Write(this.Unknown_128h);
			writer.Write(this.Unknown_12Ch);
			writer.Write(this.NamePointer);
			writer.Write(this.Unknown_138h);
			writer.Write(this.Unknown_13Ch);
			writer.Write(this.Unknown_140h);
			writer.Write(this.Unknown_144h);
			writer.Write(this.Unknown_148h);
			writer.Write(this.Unknown_14Ch);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0001816C File Offset: 0x0001636C
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Bound != null)
			{
				list.Add(this.Bound);
			}
			if (this.Unknown_F8h_Data != null)
			{
				list.Add(this.Unknown_F8h_Data);
			}
			if (this.Unknown_108h_Data != null)
			{
				list.Add(this.Unknown_108h_Data);
			}
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			return list.ToArray();
		}

		// Token: 0x04002F18 RID: 12056
		public uint Unknown_A8h;

		// Token: 0x04002F19 RID: 12057
		public uint Unknown_ACh;

		// Token: 0x04002F1A RID: 12058
		public RAGE_Matrix4 Unknown_B0h;

		// Token: 0x04002F1B RID: 12059
		public ulong BoundPointer;

		// Token: 0x04002F1C RID: 12060
		public ulong Unknown_F8h_Pointer;

		// Token: 0x04002F1D RID: 12061
		public ushort Count1;

		// Token: 0x04002F1E RID: 12062
		public ushort Count2;

		// Token: 0x04002F1F RID: 12063
		public uint Unknown_104h;

		// Token: 0x04002F20 RID: 12064
		public ulong Unknown_108h_Pointer;

		// Token: 0x04002F21 RID: 12065
		public ushort Count3;

		// Token: 0x04002F22 RID: 12066
		public ushort Count4;

		// Token: 0x04002F23 RID: 12067
		public uint Unknown_114h;

		// Token: 0x04002F24 RID: 12068
		public uint Unknown_118h;

		// Token: 0x04002F25 RID: 12069
		public uint Unknown_11Ch;

		// Token: 0x04002F26 RID: 12070
		public uint Unknown_120h;

		// Token: 0x04002F27 RID: 12071
		public uint Unknown_124h;

		// Token: 0x04002F28 RID: 12072
		public uint Unknown_128h;

		// Token: 0x04002F29 RID: 12073
		public uint Unknown_12Ch;

		// Token: 0x04002F2A RID: 12074
		public ulong NamePointer;

		// Token: 0x04002F2B RID: 12075
		public uint Unknown_138h;

		// Token: 0x04002F2C RID: 12076
		public uint Unknown_13Ch;

		// Token: 0x04002F2D RID: 12077
		public uint Unknown_140h;

		// Token: 0x04002F2E RID: 12078
		public uint Unknown_144h;

		// Token: 0x04002F2F RID: 12079
		public uint Unknown_148h;

		// Token: 0x04002F30 RID: 12080
		public uint Unknown_14Ch;

		// Token: 0x04002F31 RID: 12081
		public Bound Bound;

		// Token: 0x04002F32 RID: 12082
		public ResourceSimpleArray<ulong_r> Unknown_F8h_Data;

		// Token: 0x04002F33 RID: 12083
		public ResourceSimpleArray<RAGE_Matrix4> Unknown_108h_Data;

		// Token: 0x04002F34 RID: 12084
		public string_r Name;
	}
}
