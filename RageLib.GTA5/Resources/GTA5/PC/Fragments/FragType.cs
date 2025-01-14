using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Clothes;
using RageLib.Resources.GTA5.PC.Drawables;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000F4 RID: 244
	public class FragType : FileBase64_GTA5_pc
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x000182C1 File Offset: 0x000164C1
		public override long Length
		{
			get
			{
				return 304L;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00018D2C File Offset: 0x00016F2C
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
			this.DrawablePointer = reader.ReadUInt64();
			this.Unknown_28h_Pointer = reader.ReadUInt64();
			this.Unknown_30h_Pointer = reader.ReadUInt64();
			this.Count0 = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.NamePointer = reader.ReadUInt64();
			this.Clothes = reader.ReadBlock<ResourcePointerList64<EnvironmentCloth>>(Array.Empty<object>());
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
			this.Unknown_80h = reader.ReadUInt32();
			this.Unknown_84h = reader.ReadUInt32();
			this.Unknown_88h = reader.ReadUInt32();
			this.Unknown_8Ch = reader.ReadUInt32();
			this.Unknown_90h = reader.ReadUInt32();
			this.Unknown_94h = reader.ReadUInt32();
			this.Unknown_98h = reader.ReadUInt32();
			this.Unknown_9Ch = reader.ReadUInt32();
			this.Unknown_A0h = reader.ReadUInt32();
			this.Unknown_A4h = reader.ReadUInt32();
			this.Unknown_A8h_Pointer = reader.ReadUInt64();
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
			this.Unknown_D8h = reader.ReadByte();
			this.Count3 = reader.ReadByte();
			this.Unknown_DAh = reader.ReadUInt16();
			this.Unknown_DCh = reader.ReadUInt32();
			this.Unknown_E0h_Pointer = reader.ReadUInt64();
			this.Unknown_E8h = reader.ReadUInt32();
			this.Unknown_ECh = reader.ReadUInt32();
			this.PhysicsLODGroupPointer = reader.ReadUInt64();
			this.Unknown_F8h_Pointer = reader.ReadUInt64();
			this.Unknown_100h = reader.ReadUInt32();
			this.Unknown_104h = reader.ReadUInt32();
			this.Unknown_108h = reader.ReadUInt32();
			this.Unknown_10Ch = reader.ReadUInt32();
			this.LightAttributes = reader.ReadBlock<ResourceSimpleList64<LightAttributes>>(Array.Empty<object>());
			this.Unknown_120h_Pointer = reader.ReadUInt64();
			this.Unknown_128h = reader.ReadUInt32();
			this.Unknown_12Ch = reader.ReadUInt32();
			this.Drawable = reader.ReadBlockAt<FragDrawable>(this.DrawablePointer, Array.Empty<object>());
			this.Unknown_28h_Data = reader.ReadBlockAt<ResourcePointerArray64<FragDrawable>>(this.Unknown_28h_Pointer, new object[]
			{
				this.Count0
			});
			this.Unknown_30h_Data = reader.ReadBlockAt<ResourcePointerArray64<string_r>>(this.Unknown_30h_Pointer, new object[]
			{
				this.Count0
			});
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
			this.Unknown_A8h_Data = reader.ReadBlockAt<Unknown_F_003>(this.Unknown_A8h_Pointer, Array.Empty<object>());
			this.Unknown_E0h_Data = reader.ReadBlockAt<ResourcePointerArray64<Unknown_F_004>>(this.Unknown_E0h_Pointer, new object[]
			{
				this.Count3
			});
			this.PhysicsLODGroup = reader.ReadBlockAt<FragPhysicsLODGroup>(this.PhysicsLODGroupPointer, Array.Empty<object>());
			this.Unknown_F8h_Data = reader.ReadBlockAt<FragDrawable>(this.Unknown_F8h_Pointer, Array.Empty<object>());
			this.Unknown_120h_Data = reader.ReadBlockAt<Unknown_F_002>(this.Unknown_120h_Pointer, Array.Empty<object>());
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001910C File Offset: 0x0001730C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.DrawablePointer = (ulong)((this.Drawable != null) ? this.Drawable.Position : 0L);
			this.Unknown_28h_Pointer = (ulong)((this.Unknown_28h_Data != null) ? this.Unknown_28h_Data.Position : 0L);
			this.Unknown_30h_Pointer = (ulong)((this.Unknown_30h_Data != null) ? this.Unknown_30h_Data.Position : 0L);
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			this.Unknown_A8h_Pointer = (ulong)((this.Unknown_A8h_Data != null) ? this.Unknown_A8h_Data.Position : 0L);
			this.Unknown_E0h_Pointer = (ulong)((this.Unknown_E0h_Data != null) ? this.Unknown_E0h_Data.Position : 0L);
			this.PhysicsLODGroupPointer = (ulong)((this.PhysicsLODGroup != null) ? this.PhysicsLODGroup.Position : 0L);
			this.Unknown_F8h_Pointer = (ulong)((this.Unknown_F8h_Data != null) ? this.Unknown_F8h_Data.Position : 0L);
			this.Unknown_120h_Pointer = (ulong)((this.Unknown_120h_Data != null) ? this.Unknown_120h_Data.Position : 0L);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.DrawablePointer);
			writer.Write(this.Unknown_28h_Pointer);
			writer.Write(this.Unknown_30h_Pointer);
			writer.Write(this.Count0);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.NamePointer);
			writer.WriteBlock(this.Clothes);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
			writer.Write(this.Unknown_80h);
			writer.Write(this.Unknown_84h);
			writer.Write(this.Unknown_88h);
			writer.Write(this.Unknown_8Ch);
			writer.Write(this.Unknown_90h);
			writer.Write(this.Unknown_94h);
			writer.Write(this.Unknown_98h);
			writer.Write(this.Unknown_9Ch);
			writer.Write(this.Unknown_A0h);
			writer.Write(this.Unknown_A4h);
			writer.Write(this.Unknown_A8h_Pointer);
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
			writer.Write(this.Count3);
			writer.Write(this.Unknown_DAh);
			writer.Write(this.Unknown_DCh);
			writer.Write(this.Unknown_E0h_Pointer);
			writer.Write(this.Unknown_E8h);
			writer.Write(this.Unknown_ECh);
			writer.Write(this.PhysicsLODGroupPointer);
			writer.Write(this.Unknown_F8h_Pointer);
			writer.Write(this.Unknown_100h);
			writer.Write(this.Unknown_104h);
			writer.Write(this.Unknown_108h);
			writer.Write(this.Unknown_10Ch);
			writer.WriteBlock(this.LightAttributes);
			writer.Write(this.Unknown_120h_Pointer);
			writer.Write(this.Unknown_128h);
			writer.Write(this.Unknown_12Ch);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000194EC File Offset: 0x000176EC
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Drawable != null)
			{
				list.Add(this.Drawable);
			}
			if (this.Unknown_28h_Data != null)
			{
				list.Add(this.Unknown_28h_Data);
			}
			if (this.Unknown_30h_Data != null)
			{
				list.Add(this.Unknown_30h_Data);
			}
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			if (this.Unknown_A8h_Data != null)
			{
				list.Add(this.Unknown_A8h_Data);
			}
			if (this.Unknown_E0h_Data != null)
			{
				list.Add(this.Unknown_E0h_Data);
			}
			if (this.PhysicsLODGroup != null)
			{
				list.Add(this.PhysicsLODGroup);
			}
			if (this.Unknown_F8h_Data != null)
			{
				list.Add(this.Unknown_F8h_Data);
			}
			if (this.Unknown_120h_Data != null)
			{
				list.Add(this.Unknown_120h_Data);
			}
			return list.ToArray();
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000195BF File Offset: 0x000177BF
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(96L, this.Clothes),
				new Tuple<long, IResourceBlock>(272L, this.LightAttributes)
			};
		}

		// Token: 0x04002F80 RID: 12160
		public uint Unknown_10h;

		// Token: 0x04002F81 RID: 12161
		public uint Unknown_14h;

		// Token: 0x04002F82 RID: 12162
		public uint Unknown_18h;

		// Token: 0x04002F83 RID: 12163
		public uint Unknown_1Ch;

		// Token: 0x04002F84 RID: 12164
		public uint Unknown_20h;

		// Token: 0x04002F85 RID: 12165
		public uint Unknown_24h;

		// Token: 0x04002F86 RID: 12166
		public uint Unknown_28h;

		// Token: 0x04002F87 RID: 12167
		public uint Unknown_2Ch;

		// Token: 0x04002F88 RID: 12168
		public ulong DrawablePointer;

		// Token: 0x04002F89 RID: 12169
		public ulong Unknown_28h_Pointer;

		// Token: 0x04002F8A RID: 12170
		public ulong Unknown_30h_Pointer;

		// Token: 0x04002F8B RID: 12171
		public uint Count0;

		// Token: 0x04002F8C RID: 12172
		public uint Unknown_4Ch;

		// Token: 0x04002F8D RID: 12173
		public uint Unknown_50h;

		// Token: 0x04002F8E RID: 12174
		public uint Unknown_54h;

		// Token: 0x04002F8F RID: 12175
		public ulong NamePointer;

		// Token: 0x04002F90 RID: 12176
		public ResourcePointerList64<EnvironmentCloth> Clothes;

		// Token: 0x04002F91 RID: 12177
		public uint Unknown_70h;

		// Token: 0x04002F92 RID: 12178
		public uint Unknown_74h;

		// Token: 0x04002F93 RID: 12179
		public uint Unknown_78h;

		// Token: 0x04002F94 RID: 12180
		public uint Unknown_7Ch;

		// Token: 0x04002F95 RID: 12181
		public uint Unknown_80h;

		// Token: 0x04002F96 RID: 12182
		public uint Unknown_84h;

		// Token: 0x04002F97 RID: 12183
		public uint Unknown_88h;

		// Token: 0x04002F98 RID: 12184
		public uint Unknown_8Ch;

		// Token: 0x04002F99 RID: 12185
		public uint Unknown_90h;

		// Token: 0x04002F9A RID: 12186
		public uint Unknown_94h;

		// Token: 0x04002F9B RID: 12187
		public uint Unknown_98h;

		// Token: 0x04002F9C RID: 12188
		public uint Unknown_9Ch;

		// Token: 0x04002F9D RID: 12189
		public uint Unknown_A0h;

		// Token: 0x04002F9E RID: 12190
		public uint Unknown_A4h;

		// Token: 0x04002F9F RID: 12191
		public ulong Unknown_A8h_Pointer;

		// Token: 0x04002FA0 RID: 12192
		public uint Unknown_B0h;

		// Token: 0x04002FA1 RID: 12193
		public uint Unknown_B4h;

		// Token: 0x04002FA2 RID: 12194
		public uint Unknown_B8h;

		// Token: 0x04002FA3 RID: 12195
		public uint Unknown_BCh;

		// Token: 0x04002FA4 RID: 12196
		public uint Unknown_C0h;

		// Token: 0x04002FA5 RID: 12197
		public uint Unknown_C4h;

		// Token: 0x04002FA6 RID: 12198
		public uint Unknown_C8h;

		// Token: 0x04002FA7 RID: 12199
		public uint Unknown_CCh;

		// Token: 0x04002FA8 RID: 12200
		public uint Unknown_D0h;

		// Token: 0x04002FA9 RID: 12201
		public uint Unknown_D4h;

		// Token: 0x04002FAA RID: 12202
		public byte Unknown_D8h;

		// Token: 0x04002FAB RID: 12203
		public byte Count3;

		// Token: 0x04002FAC RID: 12204
		public ushort Unknown_DAh;

		// Token: 0x04002FAD RID: 12205
		public uint Unknown_DCh;

		// Token: 0x04002FAE RID: 12206
		public ulong Unknown_E0h_Pointer;

		// Token: 0x04002FAF RID: 12207
		public uint Unknown_E8h;

		// Token: 0x04002FB0 RID: 12208
		public uint Unknown_ECh;

		// Token: 0x04002FB1 RID: 12209
		public ulong PhysicsLODGroupPointer;

		// Token: 0x04002FB2 RID: 12210
		public ulong Unknown_F8h_Pointer;

		// Token: 0x04002FB3 RID: 12211
		public uint Unknown_100h;

		// Token: 0x04002FB4 RID: 12212
		public uint Unknown_104h;

		// Token: 0x04002FB5 RID: 12213
		public uint Unknown_108h;

		// Token: 0x04002FB6 RID: 12214
		public uint Unknown_10Ch;

		// Token: 0x04002FB7 RID: 12215
		public ResourceSimpleList64<LightAttributes> LightAttributes;

		// Token: 0x04002FB8 RID: 12216
		public ulong Unknown_120h_Pointer;

		// Token: 0x04002FB9 RID: 12217
		public uint Unknown_128h;

		// Token: 0x04002FBA RID: 12218
		public uint Unknown_12Ch;

		// Token: 0x04002FBB RID: 12219
		public FragDrawable Drawable;

		// Token: 0x04002FBC RID: 12220
		public ResourcePointerArray64<FragDrawable> Unknown_28h_Data;

		// Token: 0x04002FBD RID: 12221
		public ResourcePointerArray64<string_r> Unknown_30h_Data;

		// Token: 0x04002FBE RID: 12222
		public string_r Name;

		// Token: 0x04002FBF RID: 12223
		public Unknown_F_003 Unknown_A8h_Data;

		// Token: 0x04002FC0 RID: 12224
		public ResourcePointerArray64<Unknown_F_004> Unknown_E0h_Data;

		// Token: 0x04002FC1 RID: 12225
		public FragPhysicsLODGroup PhysicsLODGroup;

		// Token: 0x04002FC2 RID: 12226
		public FragDrawable Unknown_F8h_Data;

		// Token: 0x04002FC3 RID: 12227
		public Unknown_F_002 Unknown_120h_Data;
	}
}
