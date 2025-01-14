using System;
using System.IO;
using RageLib.Resources.GTA5;
using RageLib.Resources.GTA5.PC.Drawables;
using RageLib.ResourceWrappers;
using RageLib.ResourceWrappers.Drawables;

namespace RageLib.GTA5.ResourceWrappers.PC.Drawables
{
	// Token: 0x02000192 RID: 402
	public class DrawableDictionaryFileWrapper_GTA5_pc : IDrawableDictionaryFile, IResourceFile
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0002AA2F File Offset: 0x00028C2F
		public IDrawableDictionary DrawableDictionary
		{
			get
			{
				return new DrawableDictionaryWrapper_GTA5_pc(this.drawableDictionary);
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0002AA3C File Offset: 0x00028C3C
		public void Load(Stream stream)
		{
			ResourceFile_GTA5_pc<GtaDrawableDictionary> resourceFile_GTA5_pc = new ResourceFile_GTA5_pc<GtaDrawableDictionary>();
			resourceFile_GTA5_pc.Load(stream);
			this.drawableDictionary = resourceFile_GTA5_pc.ResourceData;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0002AA64 File Offset: 0x00028C64
		public void Load(string fileName)
		{
			ResourceFile_GTA5_pc<GtaDrawableDictionary> resourceFile_GTA5_pc = new ResourceFile_GTA5_pc<GtaDrawableDictionary>();
			resourceFile_GTA5_pc.Load(fileName);
			this.drawableDictionary = resourceFile_GTA5_pc.ResourceData;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0002AA8A File Offset: 0x00028C8A
		public void Save(Stream stream)
		{
			new ResourceFile_GTA5_pc<GtaDrawableDictionary>
			{
				ResourceData = this.drawableDictionary,
				Version = 165
			}.Save(stream);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0002AAAE File Offset: 0x00028CAE
		public void Save(string fileName)
		{
			new ResourceFile_GTA5_pc<GtaDrawableDictionary>
			{
				ResourceData = this.drawableDictionary,
				Version = 165
			}.Save(fileName);
		}

		// Token: 0x040036E3 RID: 14051
		private GtaDrawableDictionary drawableDictionary;
	}
}
