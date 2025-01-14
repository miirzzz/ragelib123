using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x0200005C RID: 92
	public class Navigation : FileBase64_GTA5_pc
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000483C File Offset: 0x00002A3C
		public override long Length
		{
			get
			{
				return 368L;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
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
			this.VerticesPointer = reader.ReadUInt64();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
			this.IndicesPointer = reader.ReadUInt64();
			this.p4 = reader.ReadUInt64();
			this.Unknown_90h = reader.ReadUInt32();
			this.Unknown_94h = reader.ReadUInt32();
			this.Unknown_98h = reader.ReadUInt32();
			this.Unknown_9Ch = reader.ReadUInt32();
			this.Unknown_A0h = reader.ReadUInt32();
			this.Unknown_A4h = reader.ReadUInt32();
			this.Unknown_A8h = reader.ReadUInt32();
			this.Unknown_ACh = reader.ReadUInt32();
			this.Unknown_B0h = reader.ReadUInt32();
			this.Unknown_B4h = reader.ReadUInt32();
			this.Unknown_B8h = reader.ReadUInt32();
			this.Unknown_BCh = reader.ReadUInt32();
			this.Unknown_C0h = reader.ReadUInt32();
			this.Unknown_C4h = reader.ReadUInt32();
			this.Unknown_C8h = reader.ReadUInt32();
			this.Unknown_CCh = reader.ReadUInt32();
			this.Unknown_D0h = reader.ReadUInt32();
			this.Unknown_D4h = reader.ReadUInt32();
			this.Unknown_D8h = reader.ReadUInt32();
			this.Unknown_DCh = reader.ReadUInt32();
			this.Unknown_E0h = reader.ReadUInt32();
			this.Unknown_E4h = reader.ReadUInt32();
			this.Unknown_E8h = reader.ReadUInt32();
			this.Unknown_ECh = reader.ReadUInt32();
			this.Unknown_F0h = reader.ReadUInt32();
			this.Unknown_F4h = reader.ReadUInt32();
			this.Unknown_F8h = reader.ReadUInt32();
			this.Unknown_FCh = reader.ReadUInt32();
			this.Unknown_100h = reader.ReadUInt32();
			this.Unknown_104h = reader.ReadUInt32();
			this.Unknown_108h = reader.ReadUInt32();
			this.Unknown_10Ch = reader.ReadUInt32();
			this.Unknown_110h = reader.ReadUInt32();
			this.Unknown_114h = reader.ReadUInt32();
			this.p5 = reader.ReadUInt64();
			this.SectorTreePointer = reader.ReadUInt64();
			this.PortalsPointer = reader.ReadUInt64();
			this.p8 = reader.ReadUInt64();
			this.Unknown_138h = reader.ReadUInt32();
			this.Unknown_13Ch = reader.ReadUInt32();
			this.Unknown_140h = reader.ReadUInt32();
			this.Unknown_144h = reader.ReadUInt32();
			this.Unknown_148h = reader.ReadUInt32();
			this.PortalsCount = reader.ReadUInt32();
			this.c1 = reader.ReadUInt32();
			this.Unknown_154h = reader.ReadUInt32();
			this.Unknown_158h = reader.ReadUInt32();
			this.Unknown_15Ch = reader.ReadUInt32();
			this.Unknown_160h = reader.ReadUInt32();
			this.Unknown_164h = reader.ReadUInt32();
			this.Unknown_168h = reader.ReadUInt32();
			this.Unknown_16Ch = reader.ReadUInt32();
			this.Vertices = reader.ReadBlockAt<VerticesList>(this.VerticesPointer, Array.Empty<object>());
			this.Indices = reader.ReadBlockAt<IndicesList>(this.IndicesPointer, Array.Empty<object>());
			this.AdjPolys = reader.ReadBlockAt<AdjPolysList>(this.p4, Array.Empty<object>());
			this.Polys = reader.ReadBlockAt<PolysList>(this.p5, Array.Empty<object>());
			this.SectorTree = reader.ReadBlockAt<Sector>(this.SectorTreePointer, Array.Empty<object>());
			this.Portals = reader.ReadBlockAt<ResourceSimpleArray<Portal>>(this.PortalsPointer, new object[]
			{
				this.PortalsCount
			});
			this.p8data = reader.ReadBlockAt<ResourceSimpleArray<ushort_r>>(this.p8, new object[]
			{
				this.c1
			});
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000C188 File Offset: 0x0000A388
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.VerticesPointer = (ulong)((this.Vertices != null) ? this.Vertices.Position : 0L);
			this.IndicesPointer = (ulong)((this.Indices != null) ? this.Indices.Position : 0L);
			this.p4 = (ulong)((this.AdjPolys != null) ? this.AdjPolys.Position : 0L);
			this.p5 = (ulong)((this.Polys != null) ? this.Polys.Position : 0L);
			this.SectorTreePointer = (ulong)((this.SectorTree != null) ? this.SectorTree.Position : 0L);
			this.PortalsPointer = (ulong)((this.Portals != null) ? this.Portals.Position : 0L);
			this.p8 = (ulong)((this.p8data != null) ? this.p8data.Position : 0L);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
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
			writer.Write(this.VerticesPointer);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
			writer.Write(this.IndicesPointer);
			writer.Write(this.p4);
			writer.Write(this.Unknown_90h);
			writer.Write(this.Unknown_94h);
			writer.Write(this.Unknown_98h);
			writer.Write(this.Unknown_9Ch);
			writer.Write(this.Unknown_A0h);
			writer.Write(this.Unknown_A4h);
			writer.Write(this.Unknown_A8h);
			writer.Write(this.Unknown_ACh);
			writer.Write(this.Unknown_B0h);
			writer.Write(this.Unknown_B4h);
			writer.Write(this.Unknown_B8h);
			writer.Write(this.Unknown_BCh);
			writer.Write(this.Unknown_C0h);
			writer.Write(this.Unknown_C4h);
			writer.Write(this.Unknown_C8h);
			writer.Write(this.Unknown_CCh);
			writer.Write(this.Unknown_D0h);
			writer.Write(this.Unknown_D4h);
			writer.Write(this.Unknown_D8h);
			writer.Write(this.Unknown_DCh);
			writer.Write(this.Unknown_E0h);
			writer.Write(this.Unknown_E4h);
			writer.Write(this.Unknown_E8h);
			writer.Write(this.Unknown_ECh);
			writer.Write(this.Unknown_F0h);
			writer.Write(this.Unknown_F4h);
			writer.Write(this.Unknown_F8h);
			writer.Write(this.Unknown_FCh);
			writer.Write(this.Unknown_100h);
			writer.Write(this.Unknown_104h);
			writer.Write(this.Unknown_108h);
			writer.Write(this.Unknown_10Ch);
			writer.Write(this.Unknown_110h);
			writer.Write(this.Unknown_114h);
			writer.Write(this.p5);
			writer.Write(this.SectorTreePointer);
			writer.Write(this.PortalsPointer);
			writer.Write(this.p8);
			writer.Write(this.Unknown_138h);
			writer.Write(this.Unknown_13Ch);
			writer.Write(this.Unknown_140h);
			writer.Write(this.Unknown_144h);
			writer.Write(this.Unknown_148h);
			writer.Write(this.PortalsCount);
			writer.Write(this.c1);
			writer.Write(this.Unknown_154h);
			writer.Write(this.Unknown_158h);
			writer.Write(this.Unknown_15Ch);
			writer.Write(this.Unknown_160h);
			writer.Write(this.Unknown_164h);
			writer.Write(this.Unknown_168h);
			writer.Write(this.Unknown_16Ch);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000C634 File Offset: 0x0000A834
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Vertices != null)
			{
				list.Add(this.Vertices);
			}
			if (this.Indices != null)
			{
				list.Add(this.Indices);
			}
			if (this.AdjPolys != null)
			{
				list.Add(this.AdjPolys);
			}
			if (this.Polys != null)
			{
				list.Add(this.Polys);
			}
			if (this.SectorTree != null)
			{
				list.Add(this.SectorTree);
			}
			if (this.Portals != null)
			{
				list.Add(this.Portals);
			}
			if (this.p8data != null)
			{
				list.Add(this.p8data);
			}
			return list.ToArray();
		}

		// Token: 0x04000441 RID: 1089
		public uint Unknown_10h;

		// Token: 0x04000442 RID: 1090
		public uint Unknown_14h;

		// Token: 0x04000443 RID: 1091
		public uint Unknown_18h;

		// Token: 0x04000444 RID: 1092
		public uint Unknown_1Ch;

		// Token: 0x04000445 RID: 1093
		public uint Unknown_20h;

		// Token: 0x04000446 RID: 1094
		public uint Unknown_24h;

		// Token: 0x04000447 RID: 1095
		public uint Unknown_28h;

		// Token: 0x04000448 RID: 1096
		public uint Unknown_2Ch;

		// Token: 0x04000449 RID: 1097
		public uint Unknown_30h;

		// Token: 0x0400044A RID: 1098
		public uint Unknown_34h;

		// Token: 0x0400044B RID: 1099
		public uint Unknown_38h;

		// Token: 0x0400044C RID: 1100
		public uint Unknown_3Ch;

		// Token: 0x0400044D RID: 1101
		public uint Unknown_40h;

		// Token: 0x0400044E RID: 1102
		public uint Unknown_44h;

		// Token: 0x0400044F RID: 1103
		public uint Unknown_48h;

		// Token: 0x04000450 RID: 1104
		public uint Unknown_4Ch;

		// Token: 0x04000451 RID: 1105
		public uint Unknown_50h;

		// Token: 0x04000452 RID: 1106
		public uint Unknown_54h;

		// Token: 0x04000453 RID: 1107
		public uint Unknown_58h;

		// Token: 0x04000454 RID: 1108
		public uint Unknown_5Ch;

		// Token: 0x04000455 RID: 1109
		public uint Unknown_60h;

		// Token: 0x04000456 RID: 1110
		public uint Unknown_64h;

		// Token: 0x04000457 RID: 1111
		public uint Unknown_68h;

		// Token: 0x04000458 RID: 1112
		public uint Unknown_6Ch;

		// Token: 0x04000459 RID: 1113
		public ulong VerticesPointer;

		// Token: 0x0400045A RID: 1114
		public uint Unknown_78h;

		// Token: 0x0400045B RID: 1115
		public uint Unknown_7Ch;

		// Token: 0x0400045C RID: 1116
		public ulong IndicesPointer;

		// Token: 0x0400045D RID: 1117
		public ulong p4;

		// Token: 0x0400045E RID: 1118
		public uint Unknown_90h;

		// Token: 0x0400045F RID: 1119
		public uint Unknown_94h;

		// Token: 0x04000460 RID: 1120
		public uint Unknown_98h;

		// Token: 0x04000461 RID: 1121
		public uint Unknown_9Ch;

		// Token: 0x04000462 RID: 1122
		public uint Unknown_A0h;

		// Token: 0x04000463 RID: 1123
		public uint Unknown_A4h;

		// Token: 0x04000464 RID: 1124
		public uint Unknown_A8h;

		// Token: 0x04000465 RID: 1125
		public uint Unknown_ACh;

		// Token: 0x04000466 RID: 1126
		public uint Unknown_B0h;

		// Token: 0x04000467 RID: 1127
		public uint Unknown_B4h;

		// Token: 0x04000468 RID: 1128
		public uint Unknown_B8h;

		// Token: 0x04000469 RID: 1129
		public uint Unknown_BCh;

		// Token: 0x0400046A RID: 1130
		public uint Unknown_C0h;

		// Token: 0x0400046B RID: 1131
		public uint Unknown_C4h;

		// Token: 0x0400046C RID: 1132
		public uint Unknown_C8h;

		// Token: 0x0400046D RID: 1133
		public uint Unknown_CCh;

		// Token: 0x0400046E RID: 1134
		public uint Unknown_D0h;

		// Token: 0x0400046F RID: 1135
		public uint Unknown_D4h;

		// Token: 0x04000470 RID: 1136
		public uint Unknown_D8h;

		// Token: 0x04000471 RID: 1137
		public uint Unknown_DCh;

		// Token: 0x04000472 RID: 1138
		public uint Unknown_E0h;

		// Token: 0x04000473 RID: 1139
		public uint Unknown_E4h;

		// Token: 0x04000474 RID: 1140
		public uint Unknown_E8h;

		// Token: 0x04000475 RID: 1141
		public uint Unknown_ECh;

		// Token: 0x04000476 RID: 1142
		public uint Unknown_F0h;

		// Token: 0x04000477 RID: 1143
		public uint Unknown_F4h;

		// Token: 0x04000478 RID: 1144
		public uint Unknown_F8h;

		// Token: 0x04000479 RID: 1145
		public uint Unknown_FCh;

		// Token: 0x0400047A RID: 1146
		public uint Unknown_100h;

		// Token: 0x0400047B RID: 1147
		public uint Unknown_104h;

		// Token: 0x0400047C RID: 1148
		public uint Unknown_108h;

		// Token: 0x0400047D RID: 1149
		public uint Unknown_10Ch;

		// Token: 0x0400047E RID: 1150
		public uint Unknown_110h;

		// Token: 0x0400047F RID: 1151
		public uint Unknown_114h;

		// Token: 0x04000480 RID: 1152
		public ulong p5;

		// Token: 0x04000481 RID: 1153
		public ulong SectorTreePointer;

		// Token: 0x04000482 RID: 1154
		public ulong PortalsPointer;

		// Token: 0x04000483 RID: 1155
		public ulong p8;

		// Token: 0x04000484 RID: 1156
		public uint Unknown_138h;

		// Token: 0x04000485 RID: 1157
		public uint Unknown_13Ch;

		// Token: 0x04000486 RID: 1158
		public uint Unknown_140h;

		// Token: 0x04000487 RID: 1159
		public uint Unknown_144h;

		// Token: 0x04000488 RID: 1160
		public uint Unknown_148h;

		// Token: 0x04000489 RID: 1161
		public uint PortalsCount;

		// Token: 0x0400048A RID: 1162
		public uint c1;

		// Token: 0x0400048B RID: 1163
		public uint Unknown_154h;

		// Token: 0x0400048C RID: 1164
		public uint Unknown_158h;

		// Token: 0x0400048D RID: 1165
		public uint Unknown_15Ch;

		// Token: 0x0400048E RID: 1166
		public uint Unknown_160h;

		// Token: 0x0400048F RID: 1167
		public uint Unknown_164h;

		// Token: 0x04000490 RID: 1168
		public uint Unknown_168h;

		// Token: 0x04000491 RID: 1169
		public uint Unknown_16Ch;

		// Token: 0x04000492 RID: 1170
		public VerticesList Vertices;

		// Token: 0x04000493 RID: 1171
		public IndicesList Indices;

		// Token: 0x04000494 RID: 1172
		public AdjPolysList AdjPolys;

		// Token: 0x04000495 RID: 1173
		public PolysList Polys;

		// Token: 0x04000496 RID: 1174
		public Sector SectorTree;

		// Token: 0x04000497 RID: 1175
		public ResourceSimpleArray<Portal> Portals;

		// Token: 0x04000498 RID: 1176
		public ResourceSimpleArray<ushort_r> p8data;
	}
}
