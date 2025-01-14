using System;
using System.IO;
using RageLib.Resources.GTA5;
using RageLib.Resources.GTA5.PC.Drawables;
using RageLib.ResourceWrappers;
using RageLib.ResourceWrappers.Drawables;

namespace RageLib.GTA5.ResourceWrappers.PC.Drawables
{
	// Token: 0x02000194 RID: 404
	public class DrawableFileWrapper_GTA5_pc : IDrawableFile, IResourceFile
	{
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0002AB0B File Offset: 0x00028D0B
		public IDrawable Drawable
		{
			get
			{
				return new DrawableWrapper_GTA5_pc(this.drawable);
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0002AB18 File Offset: 0x00028D18
		public void Load(Stream stream)
		{
			ResourceFile_GTA5_pc<GtaDrawable> resourceFile_GTA5_pc = new ResourceFile_GTA5_pc<GtaDrawable>();
			resourceFile_GTA5_pc.Load(stream);
			this.drawable = resourceFile_GTA5_pc.ResourceData;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0002AB40 File Offset: 0x00028D40
		public void Load(string fileName)
		{
			ResourceFile_GTA5_pc<GtaDrawable> resourceFile_GTA5_pc = new ResourceFile_GTA5_pc<GtaDrawable>();
			resourceFile_GTA5_pc.Load(fileName);
			this.drawable = resourceFile_GTA5_pc.ResourceData;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0002AB66 File Offset: 0x00028D66
		public void Save(Stream stream)
		{
			new ResourceFile_GTA5_pc<GtaDrawable>
			{
				ResourceData = this.drawable,
				Version = 165
			}.Save(stream);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0002AB8A File Offset: 0x00028D8A
		public void Save(string fileName)
		{
			new ResourceFile_GTA5_pc<GtaDrawable>
			{
				ResourceData = this.drawable,
				Version = 165
			}.Save(fileName);
		}

		// Token: 0x040036E5 RID: 14053
		private GtaDrawable drawable;
	}
}
