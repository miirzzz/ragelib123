using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200003C RID: 60
	public class EventEmitter : ResourceSystemBlock
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000067F5 File Offset: 0x000049F5
		public override long Length
		{
			get
			{
				return 112L;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000089E0 File Offset: 0x00006BE0
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.p1 = reader.ReadUInt64();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.p2 = reader.ReadUInt64();
			this.p3 = reader.ReadUInt64();
			this.p4 = reader.ReadUInt64();
			this.p5 = reader.ReadUInt64();
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Unknown_60h = reader.ReadUInt32();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.p1data = reader.ReadBlockAt<Unknown_P_005>(this.p1, Array.Empty<object>());
			this.p2data = reader.ReadBlockAt<string_r>(this.p2, Array.Empty<object>());
			this.p3data = reader.ReadBlockAt<string_r>(this.p3, Array.Empty<object>());
			this.EmitterRule = reader.ReadBlockAt<EmitterRule>(this.p4, Array.Empty<object>());
			this.ParticleRule = reader.ReadBlockAt<ParticleRule>(this.p5, Array.Empty<object>());
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00008B74 File Offset: 0x00006D74
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.p1 = (ulong)((this.p1data != null) ? this.p1data.Position : 0L);
			this.p2 = (ulong)((this.p2data != null) ? this.p2data.Position : 0L);
			this.p3 = (ulong)((this.p3data != null) ? this.p3data.Position : 0L);
			this.p4 = (ulong)((this.EmitterRule != null) ? this.EmitterRule.Position : 0L);
			this.p5 = (ulong)((this.ParticleRule != null) ? this.ParticleRule.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.p1);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.p2);
			writer.Write(this.p3);
			writer.Write(this.p4);
			writer.Write(this.p5);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00008D28 File Offset: 0x00006F28
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.p1data != null)
			{
				list.Add(this.p1data);
			}
			if (this.p2data != null)
			{
				list.Add(this.p2data);
			}
			if (this.p3data != null)
			{
				list.Add(this.p3data);
			}
			if (this.EmitterRule != null)
			{
				list.Add(this.EmitterRule);
			}
			if (this.ParticleRule != null)
			{
				list.Add(this.ParticleRule);
			}
			return list.ToArray();
		}

		// Token: 0x040002CA RID: 714
		public uint VFT;

		// Token: 0x040002CB RID: 715
		public uint Unknown_4h;

		// Token: 0x040002CC RID: 716
		public uint Unknown_8h;

		// Token: 0x040002CD RID: 717
		public uint Unknown_Ch;

		// Token: 0x040002CE RID: 718
		public uint Unknown_10h;

		// Token: 0x040002CF RID: 719
		public uint Unknown_14h;

		// Token: 0x040002D0 RID: 720
		public ulong p1;

		// Token: 0x040002D1 RID: 721
		public uint Unknown_20h;

		// Token: 0x040002D2 RID: 722
		public uint Unknown_24h;

		// Token: 0x040002D3 RID: 723
		public uint Unknown_28h;

		// Token: 0x040002D4 RID: 724
		public uint Unknown_2Ch;

		// Token: 0x040002D5 RID: 725
		public ulong p2;

		// Token: 0x040002D6 RID: 726
		public ulong p3;

		// Token: 0x040002D7 RID: 727
		public ulong p4;

		// Token: 0x040002D8 RID: 728
		public ulong p5;

		// Token: 0x040002D9 RID: 729
		public uint Unknown_50h;

		// Token: 0x040002DA RID: 730
		public uint Unknown_54h;

		// Token: 0x040002DB RID: 731
		public uint Unknown_58h;

		// Token: 0x040002DC RID: 732
		public uint Unknown_5Ch;

		// Token: 0x040002DD RID: 733
		public uint Unknown_60h;

		// Token: 0x040002DE RID: 734
		public uint Unknown_64h;

		// Token: 0x040002DF RID: 735
		public uint Unknown_68h;

		// Token: 0x040002E0 RID: 736
		public uint Unknown_6Ch;

		// Token: 0x040002E1 RID: 737
		public Unknown_P_005 p1data;

		// Token: 0x040002E2 RID: 738
		public string_r p2data;

		// Token: 0x040002E3 RID: 739
		public string_r p3data;

		// Token: 0x040002E4 RID: 740
		public EmitterRule EmitterRule;

		// Token: 0x040002E5 RID: 741
		public ParticleRule ParticleRule;
	}
}
