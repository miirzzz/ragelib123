using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000151 RID: 337
	public class Clip : ResourceSystemBlock, IResourceXXSystemBlock, IResourceSystemBlock, IResourceBlock
	{
		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x000067F5 File Offset: 0x000049F5
		public override long Length
		{
			get
			{
				return 112L;
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00024024 File Offset: 0x00022224
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.NamePointer = reader.ReadUInt64();
			this.NameLength1 = reader.ReadUInt16();
			this.NameLength2 = reader.ReadUInt16();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.TagsPointer = reader.ReadUInt64();
			this.PropertiesPointer = reader.ReadUInt64();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
			this.Tags = reader.ReadBlockAt<Tags>(this.TagsPointer, Array.Empty<object>());
			this.Properties = reader.ReadBlockAt<PropertyMap>(this.PropertiesPointer, Array.Empty<object>());
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00024150 File Offset: 0x00022350
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			this.NameLength1 = (ushort)((this.Name != null) ? this.Name.Value.Length : 0);
			this.NameLength2 = (ushort)((this.Name != null) ? (this.Name.Value.Length + 1) : 0);
			this.TagsPointer = (ulong)((this.Tags != null) ? this.Tags.Position : 0L);
			this.PropertiesPointer = (ulong)((this.Properties != null) ? this.Properties.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.NamePointer);
			writer.Write(this.NameLength1);
			writer.Write(this.NameLength2);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.TagsPointer);
			writer.Write(this.PropertiesPointer);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x000242D4 File Offset: 0x000224D4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			if (this.Tags != null)
			{
				list.Add(this.Tags);
			}
			if (this.Properties != null)
			{
				list.Add(this.Properties);
			}
			return list.ToArray();
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0002432C File Offset: 0x0002252C
		public IResourceSystemBlock GetType(ResourceDataReader reader, params object[] parameters)
		{
			reader.Position += 16L;
			byte b = reader.ReadByte();
			reader.Position -= 17L;
			if (b == 1)
			{
				return new ClipAnimation();
			}
			if (b != 2)
			{
				throw new Exception("Unknown clip type");
			}
			return new ClipAnimations();
		}

		// Token: 0x0400356D RID: 13677
		public uint VFT;

		// Token: 0x0400356E RID: 13678
		public uint Unknown_4h;

		// Token: 0x0400356F RID: 13679
		public uint Unknown_8h;

		// Token: 0x04003570 RID: 13680
		public uint Unknown_Ch;

		// Token: 0x04003571 RID: 13681
		public uint Unknown_10h;

		// Token: 0x04003572 RID: 13682
		public uint Unknown_14h;

		// Token: 0x04003573 RID: 13683
		public ulong NamePointer;

		// Token: 0x04003574 RID: 13684
		public ushort NameLength1;

		// Token: 0x04003575 RID: 13685
		public ushort NameLength2;

		// Token: 0x04003576 RID: 13686
		public uint Unknown_24h;

		// Token: 0x04003577 RID: 13687
		public uint Unknown_28h;

		// Token: 0x04003578 RID: 13688
		public uint Unknown_2Ch;

		// Token: 0x04003579 RID: 13689
		public uint Unknown_30h;

		// Token: 0x0400357A RID: 13690
		public uint Unknown_34h;

		// Token: 0x0400357B RID: 13691
		public ulong TagsPointer;

		// Token: 0x0400357C RID: 13692
		public ulong PropertiesPointer;

		// Token: 0x0400357D RID: 13693
		public uint Unknown_48h;

		// Token: 0x0400357E RID: 13694
		public uint Unknown_4Ch;

		// Token: 0x0400357F RID: 13695
		public string_r Name;

		// Token: 0x04003580 RID: 13696
		public Tags Tags;

		// Token: 0x04003581 RID: 13697
		public PropertyMap Properties;
	}
}
