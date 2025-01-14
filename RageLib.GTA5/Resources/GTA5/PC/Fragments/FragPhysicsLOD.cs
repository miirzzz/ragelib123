using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Bounds;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000F2 RID: 242
	public class FragPhysicsLOD : ResourceSystemBlock
	{
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x000182C1 File Offset: 0x000164C1
		public override long Length
		{
			get
			{
				return 304L;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000182CC File Offset: 0x000164CC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.ArticulatedBodyTypePointer = reader.ReadUInt64();
			this.Unknown_28h_Pointer = reader.ReadUInt64();
			this.Unknown_30h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_40h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_50h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_60h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_70h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_80h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_90h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_A0h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_B0h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.GroupNamesPointer = reader.ReadUInt64();
			this.GroupsPointer = reader.ReadUInt64();
			this.ChildrenPointer = reader.ReadUInt64();
			this.Archetype1Pointer = reader.ReadUInt64();
			this.Archetype2Pointer = reader.ReadUInt64();
			this.BoundPointer = reader.ReadUInt64();
			this.Unknown_F0h_Pointer = reader.ReadUInt64();
			this.Unknown_F8h_Pointer = reader.ReadUInt64();
			this.Unknown_100h_Pointer = reader.ReadUInt64();
			this.Unknown_108h_Pointer = reader.ReadUInt64();
			this.Unknown_110h_Pointer = reader.ReadUInt64();
			this.Count1 = reader.ReadByte();
			this.Count2 = reader.ReadByte();
			this.GroupsCount = reader.ReadByte();
			this.Unknown_11Bh = reader.ReadByte();
			this.Unknown_11Ch = reader.ReadByte();
			this.ChildrenCount = reader.ReadByte();
			this.Count3 = reader.ReadByte();
			this.Unknown_11Fh = reader.ReadByte();
			this.Unknown_120h = reader.ReadUInt32();
			this.Unknown_124h = reader.ReadUInt32();
			this.Unknown_128h = reader.ReadUInt32();
			this.Unknown_12Ch = reader.ReadUInt32();
			this.ArticulatedBodyType = reader.ReadBlockAt<ArticulatedBodyType>(this.ArticulatedBodyTypePointer, Array.Empty<object>());
			this.Unknown_28h_Data = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(this.Unknown_28h_Pointer, new object[]
			{
				this.ChildrenCount
			});
			this.GroupNames = reader.ReadBlockAt<ResourcePointerArray64<fragNameStruct>>(this.GroupNamesPointer, new object[]
			{
				this.GroupsCount
			});
			this.Groups = reader.ReadBlockAt<ResourcePointerArray64<FragTypeGroup>>(this.GroupsPointer, new object[]
			{
				this.GroupsCount
			});
			this.Children = reader.ReadBlockAt<ResourcePointerArray64<FragTypeChild>>(this.ChildrenPointer, new object[]
			{
				this.ChildrenCount
			});
			this.Archetype1 = reader.ReadBlockAt<Archetype>(this.Archetype1Pointer, Array.Empty<object>());
			this.Archetype2 = reader.ReadBlockAt<Archetype>(this.Archetype2Pointer, Array.Empty<object>());
			this.Bound = reader.ReadBlockAt<Bound>(this.BoundPointer, Array.Empty<object>());
			this.Unknown_F0h_Data = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Vector4>>(this.Unknown_F0h_Pointer, new object[]
			{
				this.ChildrenCount
			});
			this.Unknown_F8h_Data = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Vector4>>(this.Unknown_F8h_Pointer, new object[]
			{
				this.ChildrenCount
			});
			this.Unknown_100h_Data = reader.ReadBlockAt<Unknown_F_001>(this.Unknown_100h_Pointer, Array.Empty<object>());
			this.Unknown_108h_Data = reader.ReadBlockAt<ResourceSimpleArray<byte_r>>(this.Unknown_108h_Pointer, new object[]
			{
				this.Count1
			});
			this.Unknown_110h_Data = reader.ReadBlockAt<ResourceSimpleArray<byte_r>>(this.Unknown_110h_Pointer, new object[]
			{
				this.Count2
			});
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000186A4 File Offset: 0x000168A4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.ArticulatedBodyTypePointer = (ulong)((this.ArticulatedBodyType != null) ? this.ArticulatedBodyType.Position : 0L);
			this.Unknown_28h_Pointer = (ulong)((this.Unknown_28h_Data != null) ? this.Unknown_28h_Data.Position : 0L);
			this.GroupNamesPointer = (ulong)((this.GroupNames != null) ? this.GroupNames.Position : 0L);
			this.GroupsPointer = (ulong)((this.Groups != null) ? this.Groups.Position : 0L);
			this.ChildrenPointer = (ulong)((this.Children != null) ? this.Children.Position : 0L);
			this.Archetype1Pointer = (ulong)((this.Archetype1 != null) ? this.Archetype1.Position : 0L);
			this.Archetype2Pointer = (ulong)((this.Archetype2 != null) ? this.Archetype2.Position : 0L);
			this.BoundPointer = (ulong)((this.Bound != null) ? this.Bound.Position : 0L);
			this.Unknown_F0h_Pointer = (ulong)((this.Unknown_F0h_Data != null) ? this.Unknown_F0h_Data.Position : 0L);
			this.Unknown_F8h_Pointer = (ulong)((this.Unknown_F8h_Data != null) ? this.Unknown_F8h_Data.Position : 0L);
			this.Unknown_100h_Pointer = (ulong)((this.Unknown_100h_Data != null) ? this.Unknown_100h_Data.Position : 0L);
			this.Unknown_108h_Pointer = (ulong)((this.Unknown_108h_Data != null) ? this.Unknown_108h_Data.Position : 0L);
			this.Unknown_110h_Pointer = (ulong)((this.Unknown_110h_Data != null) ? this.Unknown_110h_Data.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.ArticulatedBodyTypePointer);
			writer.Write(this.Unknown_28h_Pointer);
			writer.WriteBlock(this.Unknown_30h);
			writer.WriteBlock(this.Unknown_40h);
			writer.WriteBlock(this.Unknown_50h);
			writer.WriteBlock(this.Unknown_60h);
			writer.WriteBlock(this.Unknown_70h);
			writer.WriteBlock(this.Unknown_80h);
			writer.WriteBlock(this.Unknown_90h);
			writer.WriteBlock(this.Unknown_A0h);
			writer.WriteBlock(this.Unknown_B0h);
			writer.Write(this.GroupNamesPointer);
			writer.Write(this.GroupsPointer);
			writer.Write(this.ChildrenPointer);
			writer.Write(this.Archetype1Pointer);
			writer.Write(this.Archetype2Pointer);
			writer.Write(this.BoundPointer);
			writer.Write(this.Unknown_F0h_Pointer);
			writer.Write(this.Unknown_F8h_Pointer);
			writer.Write(this.Unknown_100h_Pointer);
			writer.Write(this.Unknown_108h_Pointer);
			writer.Write(this.Unknown_110h_Pointer);
			writer.Write(this.Count1);
			writer.Write(this.Count2);
			writer.Write(this.GroupsCount);
			writer.Write(this.Unknown_11Bh);
			writer.Write(this.Unknown_11Ch);
			writer.Write(this.ChildrenCount);
			writer.Write(this.Count3);
			writer.Write(this.Unknown_11Fh);
			writer.Write(this.Unknown_120h);
			writer.Write(this.Unknown_124h);
			writer.Write(this.Unknown_128h);
			writer.Write(this.Unknown_12Ch);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00018A24 File Offset: 0x00016C24
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.ArticulatedBodyType != null)
			{
				list.Add(this.ArticulatedBodyType);
			}
			if (this.Unknown_28h_Data != null)
			{
				list.Add(this.Unknown_28h_Data);
			}
			if (this.Groups != null)
			{
				list.Add(this.Groups);
			}
			if (this.Children != null)
			{
				list.Add(this.Children);
			}
			if (this.Archetype1 != null)
			{
				list.Add(this.Archetype1);
			}
			if (this.Archetype2 != null)
			{
				list.Add(this.Archetype2);
			}
			if (this.Bound != null)
			{
				list.Add(this.Bound);
			}
			if (this.Unknown_F0h_Data != null)
			{
				list.Add(this.Unknown_F0h_Data);
			}
			if (this.Unknown_F8h_Data != null)
			{
				list.Add(this.Unknown_F8h_Data);
			}
			if (this.Unknown_100h_Data != null)
			{
				list.Add(this.Unknown_100h_Data);
			}
			if (this.Unknown_108h_Data != null)
			{
				list.Add(this.Unknown_108h_Data);
			}
			if (this.Unknown_110h_Data != null)
			{
				list.Add(this.Unknown_110h_Data);
			}
			if (this.GroupNames != null)
			{
				list.Add(this.GroupNames);
			}
			return list.ToArray();
		}

		// Token: 0x04002F3D RID: 12093
		public uint VFT;

		// Token: 0x04002F3E RID: 12094
		public uint Unknown_4h;

		// Token: 0x04002F3F RID: 12095
		public uint Unknown_8h;

		// Token: 0x04002F40 RID: 12096
		public uint Unknown_Ch;

		// Token: 0x04002F41 RID: 12097
		public uint Unknown_10h;

		// Token: 0x04002F42 RID: 12098
		public uint Unknown_14h;

		// Token: 0x04002F43 RID: 12099
		public uint Unknown_18h;

		// Token: 0x04002F44 RID: 12100
		public uint Unknown_1Ch;

		// Token: 0x04002F45 RID: 12101
		public ulong ArticulatedBodyTypePointer;

		// Token: 0x04002F46 RID: 12102
		public ulong Unknown_28h_Pointer;

		// Token: 0x04002F47 RID: 12103
		public RAGE_Vector4 Unknown_30h;

		// Token: 0x04002F48 RID: 12104
		public RAGE_Vector4 Unknown_40h;

		// Token: 0x04002F49 RID: 12105
		public RAGE_Vector4 Unknown_50h;

		// Token: 0x04002F4A RID: 12106
		public RAGE_Vector4 Unknown_60h;

		// Token: 0x04002F4B RID: 12107
		public RAGE_Vector4 Unknown_70h;

		// Token: 0x04002F4C RID: 12108
		public RAGE_Vector4 Unknown_80h;

		// Token: 0x04002F4D RID: 12109
		public RAGE_Vector4 Unknown_90h;

		// Token: 0x04002F4E RID: 12110
		public RAGE_Vector4 Unknown_A0h;

		// Token: 0x04002F4F RID: 12111
		public RAGE_Vector4 Unknown_B0h;

		// Token: 0x04002F50 RID: 12112
		public ulong GroupNamesPointer;

		// Token: 0x04002F51 RID: 12113
		public ulong GroupsPointer;

		// Token: 0x04002F52 RID: 12114
		public ulong ChildrenPointer;

		// Token: 0x04002F53 RID: 12115
		public ulong Archetype1Pointer;

		// Token: 0x04002F54 RID: 12116
		public ulong Archetype2Pointer;

		// Token: 0x04002F55 RID: 12117
		public ulong BoundPointer;

		// Token: 0x04002F56 RID: 12118
		public ulong Unknown_F0h_Pointer;

		// Token: 0x04002F57 RID: 12119
		public ulong Unknown_F8h_Pointer;

		// Token: 0x04002F58 RID: 12120
		public ulong Unknown_100h_Pointer;

		// Token: 0x04002F59 RID: 12121
		public ulong Unknown_108h_Pointer;

		// Token: 0x04002F5A RID: 12122
		public ulong Unknown_110h_Pointer;

		// Token: 0x04002F5B RID: 12123
		public byte Count1;

		// Token: 0x04002F5C RID: 12124
		public byte Count2;

		// Token: 0x04002F5D RID: 12125
		public byte GroupsCount;

		// Token: 0x04002F5E RID: 12126
		public byte Unknown_11Bh;

		// Token: 0x04002F5F RID: 12127
		public byte Unknown_11Ch;

		// Token: 0x04002F60 RID: 12128
		public byte ChildrenCount;

		// Token: 0x04002F61 RID: 12129
		public byte Count3;

		// Token: 0x04002F62 RID: 12130
		public byte Unknown_11Fh;

		// Token: 0x04002F63 RID: 12131
		public uint Unknown_120h;

		// Token: 0x04002F64 RID: 12132
		public uint Unknown_124h;

		// Token: 0x04002F65 RID: 12133
		public uint Unknown_128h;

		// Token: 0x04002F66 RID: 12134
		public uint Unknown_12Ch;

		// Token: 0x04002F67 RID: 12135
		public ArticulatedBodyType ArticulatedBodyType;

		// Token: 0x04002F68 RID: 12136
		public ResourceSimpleArray<uint_r> Unknown_28h_Data;

		// Token: 0x04002F69 RID: 12137
		public ResourcePointerArray64<fragNameStruct> GroupNames;

		// Token: 0x04002F6A RID: 12138
		public ResourcePointerArray64<FragTypeGroup> Groups;

		// Token: 0x04002F6B RID: 12139
		public ResourcePointerArray64<FragTypeChild> Children;

		// Token: 0x04002F6C RID: 12140
		public Archetype Archetype1;

		// Token: 0x04002F6D RID: 12141
		public Archetype Archetype2;

		// Token: 0x04002F6E RID: 12142
		public Bound Bound;

		// Token: 0x04002F6F RID: 12143
		public ResourceSimpleArray<RAGE_Vector4> Unknown_F0h_Data;

		// Token: 0x04002F70 RID: 12144
		public ResourceSimpleArray<RAGE_Vector4> Unknown_F8h_Data;

		// Token: 0x04002F71 RID: 12145
		public Unknown_F_001 Unknown_100h_Data;

		// Token: 0x04002F72 RID: 12146
		public ResourceSimpleArray<byte_r> Unknown_108h_Data;

		// Token: 0x04002F73 RID: 12147
		public ResourceSimpleArray<byte_r> Unknown_110h_Data;
	}
}
