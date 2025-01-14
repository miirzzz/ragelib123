using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Drawables;
using RageLib.Resources.GTA5.PC.Textures;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200003E RID: 62
	public class ParticleEffectsList : FileBase64_GTA5_pc
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000090FA File Offset: 0x000072FA
		public override long Length
		{
			get
			{
				return 96L;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00009100 File Offset: 0x00007300
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.NamePointer = reader.ReadUInt64();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.TextureDictionaryPointer = reader.ReadUInt64();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.DrawableDictionaryPointer = reader.ReadUInt64();
			this.ParticleRuleDictionaryPointer = reader.ReadUInt64();
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.EmitterRuleDictionaryPointer = reader.ReadUInt64();
			this.EffectRuleDictionaryPointer = reader.ReadUInt64();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
			this.TextureDictionary = reader.ReadBlockAt<TextureDictionary>(this.TextureDictionaryPointer, Array.Empty<object>());
			this.DrawableDictionary = reader.ReadBlockAt<DrawableDictionary>(this.DrawableDictionaryPointer, Array.Empty<object>());
			this.ParticleRuleDictionary = reader.ReadBlockAt<ParticleRuleDictionary>(this.ParticleRuleDictionaryPointer, Array.Empty<object>());
			this.EffectRuleDictionary = reader.ReadBlockAt<EffectRuleDictionary>(this.EmitterRuleDictionaryPointer, Array.Empty<object>());
			this.EmitterRuleDictionary = reader.ReadBlockAt<EmitterRuleDictionary>(this.EffectRuleDictionaryPointer, Array.Empty<object>());
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00009248 File Offset: 0x00007448
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			this.TextureDictionaryPointer = (ulong)((this.TextureDictionary != null) ? this.TextureDictionary.Position : 0L);
			this.DrawableDictionaryPointer = (ulong)((this.DrawableDictionary != null) ? this.DrawableDictionary.Position : 0L);
			this.ParticleRuleDictionaryPointer = (ulong)((this.ParticleRuleDictionary != null) ? this.ParticleRuleDictionary.Position : 0L);
			this.EmitterRuleDictionaryPointer = (ulong)((this.EffectRuleDictionary != null) ? this.EffectRuleDictionary.Position : 0L);
			this.EffectRuleDictionaryPointer = (ulong)((this.EmitterRuleDictionary != null) ? this.EmitterRuleDictionary.Position : 0L);
			writer.Write(this.NamePointer);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.TextureDictionaryPointer);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.DrawableDictionaryPointer);
			writer.Write(this.ParticleRuleDictionaryPointer);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.EmitterRuleDictionaryPointer);
			writer.Write(this.EffectRuleDictionaryPointer);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000093B4 File Offset: 0x000075B4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			if (this.TextureDictionary != null)
			{
				list.Add(this.TextureDictionary);
			}
			if (this.DrawableDictionary != null)
			{
				list.Add(this.DrawableDictionary);
			}
			if (this.ParticleRuleDictionary != null)
			{
				list.Add(this.ParticleRuleDictionary);
			}
			if (this.EffectRuleDictionary != null)
			{
				list.Add(this.EffectRuleDictionary);
			}
			if (this.EmitterRuleDictionary != null)
			{
				list.Add(this.EmitterRuleDictionary);
			}
			return list.ToArray();
		}

		// Token: 0x04000307 RID: 775
		public ulong NamePointer;

		// Token: 0x04000308 RID: 776
		public uint Unknown_18h;

		// Token: 0x04000309 RID: 777
		public uint Unknown_1Ch;

		// Token: 0x0400030A RID: 778
		public ulong TextureDictionaryPointer;

		// Token: 0x0400030B RID: 779
		public uint Unknown_28h;

		// Token: 0x0400030C RID: 780
		public uint Unknown_2Ch;

		// Token: 0x0400030D RID: 781
		public ulong DrawableDictionaryPointer;

		// Token: 0x0400030E RID: 782
		public ulong ParticleRuleDictionaryPointer;

		// Token: 0x0400030F RID: 783
		public uint Unknown_40h;

		// Token: 0x04000310 RID: 784
		public uint Unknown_44h;

		// Token: 0x04000311 RID: 785
		public ulong EmitterRuleDictionaryPointer;

		// Token: 0x04000312 RID: 786
		public ulong EffectRuleDictionaryPointer;

		// Token: 0x04000313 RID: 787
		public uint Unknown_58h;

		// Token: 0x04000314 RID: 788
		public uint Unknown_5Ch;

		// Token: 0x04000315 RID: 789
		public string_r Name;

		// Token: 0x04000316 RID: 790
		public TextureDictionary TextureDictionary;

		// Token: 0x04000317 RID: 791
		public DrawableDictionary DrawableDictionary;

		// Token: 0x04000318 RID: 792
		public ParticleRuleDictionary ParticleRuleDictionary;

		// Token: 0x04000319 RID: 793
		public EffectRuleDictionary EffectRuleDictionary;

		// Token: 0x0400031A RID: 794
		public EmitterRuleDictionary EmitterRuleDictionary;
	}
}
