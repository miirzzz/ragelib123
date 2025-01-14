using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Bounds;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000107 RID: 263
	public class GtaDrawable : Drawable
	{
		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00004B19 File Offset: 0x00002D19
		public override long Length
		{
			get
			{
				return 208L;
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.NamePointer = reader.ReadUInt64();
			this.LightAttributesPointer = reader.ReadUInt64();
			this.LightAttributesCount1 = reader.ReadUInt16();
			this.LightAttributesCount2 = reader.ReadUInt16();
			this.Unknown_BCh = reader.ReadUInt32();
			this.Unknown_C0h = reader.ReadUInt32();
			this.Unknown_C4h = reader.ReadUInt32();
			this.BoundPointer = reader.ReadUInt64();
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
			this.LightAttributes = reader.ReadBlockAt<ResourceSimpleArray<LightAttributes>>(this.LightAttributesPointer, new object[]
			{
				this.LightAttributesCount1
			});
			this.Bound = reader.ReadBlockAt<Bound>(this.BoundPointer, Array.Empty<object>());
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0001CAB4 File Offset: 0x0001ACB4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			this.LightAttributesPointer = (ulong)((this.LightAttributes != null) ? this.LightAttributes.Position : 0L);
			this.BoundPointer = (ulong)((this.Bound != null) ? this.Bound.Position : 0L);
			writer.Write(this.NamePointer);
			writer.Write(this.LightAttributesPointer);
			writer.Write(this.LightAttributesCount1);
			writer.Write(this.LightAttributesCount2);
			writer.Write(this.Unknown_BCh);
			writer.Write(this.Unknown_C0h);
			writer.Write(this.Unknown_C4h);
			writer.Write(this.BoundPointer);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0001CB80 File Offset: 0x0001AD80
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			if (this.LightAttributes != null)
			{
				list.Add(this.LightAttributes);
			}
			if (this.Bound != null)
			{
				list.Add(this.Bound);
			}
			return list.ToArray();
		}

		// Token: 0x04003181 RID: 12673
		public ulong NamePointer;

		// Token: 0x04003182 RID: 12674
		public ulong LightAttributesPointer;

		// Token: 0x04003183 RID: 12675
		public ushort LightAttributesCount1;

		// Token: 0x04003184 RID: 12676
		public ushort LightAttributesCount2;

		// Token: 0x04003185 RID: 12677
		public uint Unknown_BCh;

		// Token: 0x04003186 RID: 12678
		public uint Unknown_C0h;

		// Token: 0x04003187 RID: 12679
		public uint Unknown_C4h;

		// Token: 0x04003188 RID: 12680
		public ulong BoundPointer;

		// Token: 0x04003189 RID: 12681
		public string_r Name;

		// Token: 0x0400318A RID: 12682
		public ResourceSimpleArray<LightAttributes> LightAttributes;

		// Token: 0x0400318B RID: 12683
		public Bound Bound;
	}
}
