using System;
using System.IO;
using RageLib.Resources.GTA5;
using RageLib.Resources.GTA5.PC.Particles;
using RageLib.ResourceWrappers;
using RageLib.ResourceWrappers.Particles;

namespace RageLib.GTA5.ResourceWrappers.PC.Particles
{
	// Token: 0x0200018D RID: 397
	public class ParticlesFileWrapper_GTA5_pc : IParticlesFile, IResourceFile
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0002A7C9 File Offset: 0x000289C9
		public IParticles Particles
		{
			get
			{
				return new ParticlesWrapper_GTA5_pc(this.particles);
			}
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0002A7D8 File Offset: 0x000289D8
		public void Load(string fileName)
		{
			ResourceFile_GTA5_pc<ParticleEffectsList> resourceFile_GTA5_pc = new ResourceFile_GTA5_pc<ParticleEffectsList>();
			resourceFile_GTA5_pc.Load(fileName);
			this.particles = resourceFile_GTA5_pc.ResourceData;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0002A7FE File Offset: 0x000289FE
		public void Save(string fileName)
		{
			new ResourceFile_GTA5_pc<ParticleEffectsList>
			{
				ResourceData = this.particles,
				Version = 68
			}.Save(fileName);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0002A820 File Offset: 0x00028A20
		public void Load(Stream stream)
		{
			ResourceFile_GTA5_pc<ParticleEffectsList> resourceFile_GTA5_pc = new ResourceFile_GTA5_pc<ParticleEffectsList>();
			resourceFile_GTA5_pc.Load(stream);
			if (resourceFile_GTA5_pc.Version != 68)
			{
				throw new Exception("version error");
			}
			this.particles = resourceFile_GTA5_pc.ResourceData;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0002A85B File Offset: 0x00028A5B
		public void Save(Stream stream)
		{
			new ResourceFile_GTA5_pc<ParticleEffectsList>
			{
				ResourceData = this.particles,
				Version = 68
			}.Save(stream);
		}

		// Token: 0x040036DE RID: 14046
		private ParticleEffectsList particles;
	}
}
