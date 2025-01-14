using System;
using System.IO;
using RageLib.Resources.GTA5;
using RageLib.Resources.GTA5.PC.Fragments;
using RageLib.ResourceWrappers;
using RageLib.ResourceWrappers.Fragments;

namespace RageLib.GTA5.ResourceWrappers.PC.Fragments
{
	// Token: 0x02000190 RID: 400
	public class FragmentFileWrapper_GTA5_pc : IFragmentFile, IResourceFile
	{
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0002A8EE File Offset: 0x00028AEE
		public IFragType FragType
		{
			get
			{
				return new FragTypeWrapper_GTA5_pc(this.fragType);
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0002A8FB File Offset: 0x00028AFB
		public FragmentFileWrapper_GTA5_pc()
		{
			this.fragType = new FragType();
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0002A910 File Offset: 0x00028B10
		public void Load(string fileName)
		{
			ResourceFile_GTA5_pc<FragType> resourceFile_GTA5_pc = new ResourceFile_GTA5_pc<FragType>();
			resourceFile_GTA5_pc.Load(fileName);
			this.fragType = resourceFile_GTA5_pc.ResourceData;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0002A936 File Offset: 0x00028B36
		public void Save(string fileName)
		{
			new FragTypeWrapper_GTA5_pc(this.fragType).UpdateClass();
			new ResourceFile_GTA5_pc<FragType>
			{
				ResourceData = this.fragType,
				Version = 162
			}.Save(fileName);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0002A96C File Offset: 0x00028B6C
		public void Load(Stream stream)
		{
			ResourceFile_GTA5_pc<FragType> resourceFile_GTA5_pc = new ResourceFile_GTA5_pc<FragType>();
			resourceFile_GTA5_pc.Load(stream);
			if (resourceFile_GTA5_pc.Version != 162)
			{
				throw new Exception("version error");
			}
			this.fragType = resourceFile_GTA5_pc.ResourceData;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0002A9AA File Offset: 0x00028BAA
		public void Save(Stream stream)
		{
			new FragTypeWrapper_GTA5_pc(this.fragType).UpdateClass();
			new ResourceFile_GTA5_pc<FragType>
			{
				ResourceData = this.fragType,
				Version = 162
			}.Save(stream);
		}

		// Token: 0x040036E1 RID: 14049
		private FragType fragType;
	}
}
