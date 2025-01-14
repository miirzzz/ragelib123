using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Bounds;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000ED RID: 237
	public class Archetype : ResourceSystemBlock
	{
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000173D2 File Offset: 0x000155D2
		public override long Length
		{
			get
			{
				return 224L;
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000173DC File Offset: 0x000155DC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadSingle();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.NamePointer = reader.ReadUInt64();
			this.BoundPointer = reader.ReadUInt64();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_40h = reader.ReadSingle();
			this.Unknown_44h = reader.ReadSingle();
			this.Unknown_48h = reader.ReadSingle();
			this.Unknown_4Ch = reader.ReadSingle();
			this.Unknown_50h = reader.ReadSingle();
			this.Unknown_54h = reader.ReadSingle();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Unknown_60h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_70h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_80h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_90h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_A0h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_B0h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_C0h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Unknown_D0h = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
			this.Bound = reader.ReadBlockAt<Bound>(this.BoundPointer, Array.Empty<object>());
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000175A8 File Offset: 0x000157A8
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			this.BoundPointer = (ulong)((this.Bound != null) ? this.Bound.Position : 0L);
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.NamePointer);
			writer.Write(this.BoundPointer);
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
			writer.WriteBlock(this.Unknown_60h);
			writer.WriteBlock(this.Unknown_70h);
			writer.WriteBlock(this.Unknown_80h);
			writer.WriteBlock(this.Unknown_90h);
			writer.WriteBlock(this.Unknown_A0h);
			writer.WriteBlock(this.Unknown_B0h);
			writer.WriteBlock(this.Unknown_C0h);
			writer.WriteBlock(this.Unknown_D0h);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00017758 File Offset: 0x00015958
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			if (this.Bound != null)
			{
				list.Add(this.Bound);
			}
			return list.ToArray();
		}

		// Token: 0x04002EBE RID: 11966
		public float Unknown_0h;

		// Token: 0x04002EBF RID: 11967
		public uint Unknown_4h;

		// Token: 0x04002EC0 RID: 11968
		public uint Unknown_8h;

		// Token: 0x04002EC1 RID: 11969
		public uint Unknown_Ch;

		// Token: 0x04002EC2 RID: 11970
		public uint Unknown_10h;

		// Token: 0x04002EC3 RID: 11971
		public uint Unknown_14h;

		// Token: 0x04002EC4 RID: 11972
		public ulong NamePointer;

		// Token: 0x04002EC5 RID: 11973
		public ulong BoundPointer;

		// Token: 0x04002EC6 RID: 11974
		public uint Unknown_28h;

		// Token: 0x04002EC7 RID: 11975
		public uint Unknown_2Ch;

		// Token: 0x04002EC8 RID: 11976
		public uint Unknown_30h;

		// Token: 0x04002EC9 RID: 11977
		public uint Unknown_34h;

		// Token: 0x04002ECA RID: 11978
		public uint Unknown_38h;

		// Token: 0x04002ECB RID: 11979
		public uint Unknown_3Ch;

		// Token: 0x04002ECC RID: 11980
		public float Unknown_40h;

		// Token: 0x04002ECD RID: 11981
		public float Unknown_44h;

		// Token: 0x04002ECE RID: 11982
		public float Unknown_48h;

		// Token: 0x04002ECF RID: 11983
		public float Unknown_4Ch;

		// Token: 0x04002ED0 RID: 11984
		public float Unknown_50h;

		// Token: 0x04002ED1 RID: 11985
		public float Unknown_54h;

		// Token: 0x04002ED2 RID: 11986
		public uint Unknown_58h;

		// Token: 0x04002ED3 RID: 11987
		public uint Unknown_5Ch;

		// Token: 0x04002ED4 RID: 11988
		public RAGE_Vector4 Unknown_60h;

		// Token: 0x04002ED5 RID: 11989
		public RAGE_Vector4 Unknown_70h;

		// Token: 0x04002ED6 RID: 11990
		public RAGE_Vector4 Unknown_80h;

		// Token: 0x04002ED7 RID: 11991
		public RAGE_Vector4 Unknown_90h;

		// Token: 0x04002ED8 RID: 11992
		public RAGE_Vector4 Unknown_A0h;

		// Token: 0x04002ED9 RID: 11993
		public RAGE_Vector4 Unknown_B0h;

		// Token: 0x04002EDA RID: 11994
		public RAGE_Vector4 Unknown_C0h;

		// Token: 0x04002EDB RID: 11995
		public RAGE_Vector4 Unknown_D0h;

		// Token: 0x04002EDC RID: 11996
		public string_r Name;

		// Token: 0x04002EDD RID: 11997
		public Bound Bound;
	}
}
