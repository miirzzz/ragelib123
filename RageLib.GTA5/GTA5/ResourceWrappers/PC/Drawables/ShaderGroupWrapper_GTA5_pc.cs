using System;
using RageLib.Resources.GTA5.PC.Drawables;
using RageLib.ResourceWrappers;
using RageLib.ResourceWrappers.Drawables;
using RageLib.ResourceWrappers.GTA5.PC.Textures;

namespace RageLib.GTA5.ResourceWrappers.PC.Drawables
{
	// Token: 0x02000197 RID: 407
	public class ShaderGroupWrapper_GTA5_pc : IShaderGroup
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0000218B File Offset: 0x0000038B
		public IShaderList Shaders
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0002AC2E File Offset: 0x00028E2E
		public ITextureDictionary TextureDictionary
		{
			get
			{
				if (this.shaderGroup.TextureDictionary != null)
				{
					return new TextureDictionaryWrapper_GTA5_pc(this.shaderGroup.TextureDictionary);
				}
				return null;
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0002AC4F File Offset: 0x00028E4F
		public ShaderGroupWrapper_GTA5_pc(ShaderGroup shaderGroup)
		{
			this.shaderGroup = shaderGroup;
		}

		// Token: 0x040036E8 RID: 14056
		private ShaderGroup shaderGroup;
	}
}
