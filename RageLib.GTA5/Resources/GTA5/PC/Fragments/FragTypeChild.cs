using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000F5 RID: 245
	public class FragTypeChild : ResourceSystemBlock
	{
		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000195EC File Offset: 0x000177EC
		public override long Length
		{
			get
			{
				return 256L;
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000195F4 File Offset: 0x000177F4
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
			this.Drawable1Pointer = reader.ReadUInt64();
			this.Drawable2Pointer = reader.ReadUInt64();
			this.EvtSetPointer = reader.ReadUInt64();
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
			this.Drawable1 = reader.ReadBlockAt<FragDrawable>(this.Drawable1Pointer, Array.Empty<object>());
			this.Drawable2 = reader.ReadBlockAt<FragDrawable>(this.Drawable2Pointer, Array.Empty<object>());
			this.EvtSet = reader.ReadBlockAt<EvtSet>(this.EvtSetPointer, Array.Empty<object>());
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00019924 File Offset: 0x00017B24
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.Drawable1Pointer = (ulong)((this.Drawable1 != null) ? this.Drawable1.Position : 0L);
			this.Drawable2Pointer = (ulong)((this.Drawable2 != null) ? this.Drawable2.Position : 0L);
			this.EvtSetPointer = (ulong)((this.EvtSet != null) ? this.EvtSet.Position : 0L);
			writer.Write(this.VFT);
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
			writer.Write(this.Drawable1Pointer);
			writer.Write(this.Drawable2Pointer);
			writer.Write(this.EvtSetPointer);
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
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00019C64 File Offset: 0x00017E64
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Drawable1 != null)
			{
				list.Add(this.Drawable1);
			}
			if (this.Drawable2 != null)
			{
				list.Add(this.Drawable2);
			}
			if (this.EvtSet != null)
			{
				list.Add(this.EvtSet);
			}
			return list.ToArray();
		}

		// Token: 0x04002FC4 RID: 12228
		public uint VFT;

		// Token: 0x04002FC5 RID: 12229
		public uint Unknown_4h;

		// Token: 0x04002FC6 RID: 12230
		public uint Unknown_8h;

		// Token: 0x04002FC7 RID: 12231
		public uint Unknown_Ch;

		// Token: 0x04002FC8 RID: 12232
		public uint Unknown_10h;

		// Token: 0x04002FC9 RID: 12233
		public uint Unknown_14h;

		// Token: 0x04002FCA RID: 12234
		public uint Unknown_18h;

		// Token: 0x04002FCB RID: 12235
		public uint Unknown_1Ch;

		// Token: 0x04002FCC RID: 12236
		public uint Unknown_20h;

		// Token: 0x04002FCD RID: 12237
		public uint Unknown_24h;

		// Token: 0x04002FCE RID: 12238
		public uint Unknown_28h;

		// Token: 0x04002FCF RID: 12239
		public uint Unknown_2Ch;

		// Token: 0x04002FD0 RID: 12240
		public uint Unknown_30h;

		// Token: 0x04002FD1 RID: 12241
		public uint Unknown_34h;

		// Token: 0x04002FD2 RID: 12242
		public uint Unknown_38h;

		// Token: 0x04002FD3 RID: 12243
		public uint Unknown_3Ch;

		// Token: 0x04002FD4 RID: 12244
		public uint Unknown_40h;

		// Token: 0x04002FD5 RID: 12245
		public uint Unknown_44h;

		// Token: 0x04002FD6 RID: 12246
		public uint Unknown_48h;

		// Token: 0x04002FD7 RID: 12247
		public uint Unknown_4Ch;

		// Token: 0x04002FD8 RID: 12248
		public uint Unknown_50h;

		// Token: 0x04002FD9 RID: 12249
		public uint Unknown_54h;

		// Token: 0x04002FDA RID: 12250
		public uint Unknown_58h;

		// Token: 0x04002FDB RID: 12251
		public uint Unknown_5Ch;

		// Token: 0x04002FDC RID: 12252
		public uint Unknown_60h;

		// Token: 0x04002FDD RID: 12253
		public uint Unknown_64h;

		// Token: 0x04002FDE RID: 12254
		public uint Unknown_68h;

		// Token: 0x04002FDF RID: 12255
		public uint Unknown_6Ch;

		// Token: 0x04002FE0 RID: 12256
		public uint Unknown_70h;

		// Token: 0x04002FE1 RID: 12257
		public uint Unknown_74h;

		// Token: 0x04002FE2 RID: 12258
		public uint Unknown_78h;

		// Token: 0x04002FE3 RID: 12259
		public uint Unknown_7Ch;

		// Token: 0x04002FE4 RID: 12260
		public uint Unknown_80h;

		// Token: 0x04002FE5 RID: 12261
		public uint Unknown_84h;

		// Token: 0x04002FE6 RID: 12262
		public uint Unknown_88h;

		// Token: 0x04002FE7 RID: 12263
		public uint Unknown_8Ch;

		// Token: 0x04002FE8 RID: 12264
		public uint Unknown_90h;

		// Token: 0x04002FE9 RID: 12265
		public uint Unknown_94h;

		// Token: 0x04002FEA RID: 12266
		public uint Unknown_98h;

		// Token: 0x04002FEB RID: 12267
		public uint Unknown_9Ch;

		// Token: 0x04002FEC RID: 12268
		public ulong Drawable1Pointer;

		// Token: 0x04002FED RID: 12269
		public ulong Drawable2Pointer;

		// Token: 0x04002FEE RID: 12270
		public ulong EvtSetPointer;

		// Token: 0x04002FEF RID: 12271
		public uint Unknown_B8h;

		// Token: 0x04002FF0 RID: 12272
		public uint Unknown_BCh;

		// Token: 0x04002FF1 RID: 12273
		public uint Unknown_C0h;

		// Token: 0x04002FF2 RID: 12274
		public uint Unknown_C4h;

		// Token: 0x04002FF3 RID: 12275
		public uint Unknown_C8h;

		// Token: 0x04002FF4 RID: 12276
		public uint Unknown_CCh;

		// Token: 0x04002FF5 RID: 12277
		public uint Unknown_D0h;

		// Token: 0x04002FF6 RID: 12278
		public uint Unknown_D4h;

		// Token: 0x04002FF7 RID: 12279
		public uint Unknown_D8h;

		// Token: 0x04002FF8 RID: 12280
		public uint Unknown_DCh;

		// Token: 0x04002FF9 RID: 12281
		public uint Unknown_E0h;

		// Token: 0x04002FFA RID: 12282
		public uint Unknown_E4h;

		// Token: 0x04002FFB RID: 12283
		public uint Unknown_E8h;

		// Token: 0x04002FFC RID: 12284
		public uint Unknown_ECh;

		// Token: 0x04002FFD RID: 12285
		public uint Unknown_F0h;

		// Token: 0x04002FFE RID: 12286
		public uint Unknown_F4h;

		// Token: 0x04002FFF RID: 12287
		public uint Unknown_F8h;

		// Token: 0x04003000 RID: 12288
		public uint Unknown_FCh;

		// Token: 0x04003001 RID: 12289
		public FragDrawable Drawable1;

		// Token: 0x04003002 RID: 12290
		public FragDrawable Drawable2;

		// Token: 0x04003003 RID: 12291
		public EvtSet EvtSet;
	}
}
