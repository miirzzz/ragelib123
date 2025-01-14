using System;
using RageLib.Resources.GTA5.PC.Particles;
using RageLib.ResourceWrappers;
using RageLib.ResourceWrappers.GTA5.PC.Textures;
using RageLib.ResourceWrappers.Particles;

namespace RageLib.GTA5.ResourceWrappers.PC.Particles
{
	// Token: 0x0200018E RID: 398
	public class ParticlesWrapper_GTA5_pc : IParticles
	{
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0002A87C File Offset: 0x00028A7C
		public ITextureDictionary TextureDictionary
		{
			get
			{
				if (this.particles.TextureDictionary != null)
				{
					return new TextureDictionaryWrapper_GTA5_pc(this.particles.TextureDictionary);
				}
				return null;
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0002A89D File Offset: 0x00028A9D
		public ParticlesWrapper_GTA5_pc(ParticleEffectsList particles)
		{
			this.particles = particles;
		}

		// Token: 0x040036DF RID: 14047
		private ParticleEffectsList particles;
	}
}
