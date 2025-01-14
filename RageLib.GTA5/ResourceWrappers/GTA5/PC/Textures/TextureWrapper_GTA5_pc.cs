using System;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Textures;

namespace RageLib.ResourceWrappers.GTA5.PC.Textures
{
	// Token: 0x02000005 RID: 5
	public class TextureWrapper_GTA5_pc : ITexture
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002444 File Offset: 0x00000644
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002456 File Offset: 0x00000656
		public string Name
		{
			get
			{
				return (string)this.texture.Name;
			}
			set
			{
				this.texture.Name = (string_r)value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002469 File Offset: 0x00000669
		public int Width
		{
			get
			{
				return (int)this.texture.Width;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002476 File Offset: 0x00000676
		public int Height
		{
			get
			{
				return (int)this.texture.Height;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002483 File Offset: 0x00000683
		public TextureFormat Format
		{
			get
			{
				return (TextureFormat)this.texture.Format;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002490 File Offset: 0x00000690
		public int Levels
		{
			get
			{
				return (int)this.texture.Levels;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002490 File Offset: 0x00000690
		public int MipMapLevels
		{
			get
			{
				return (int)this.texture.Levels;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000249D File Offset: 0x0000069D
		public int Stride
		{
			get
			{
				return (int)this.texture.Stride;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000024AA File Offset: 0x000006AA
		public TextureWrapper_GTA5_pc()
		{
			this.texture = new TextureDX11();
			this.texture.Data = new TextureData_GTA5_pc();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000024CD File Offset: 0x000006CD
		public TextureWrapper_GTA5_pc(TextureDX11 texture)
		{
			this.texture = texture;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000218B File Offset: 0x0000038B
		public void Encode(byte[] data, TextureFormat format)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000024DC File Offset: 0x000006DC
		public byte[] GetTextureData(int mipMapLevel)
		{
			int num = 0;
			int num2 = (int)(this.texture.Height * this.texture.Stride);
			for (int i = 0; i < mipMapLevel - 1; i++)
			{
				num += num2;
				num2 /= 4;
			}
			byte[] array = new byte[num2];
			Buffer.BlockCopy(this.texture.Data.FullData, num, array, 0, array.Length);
			return array;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000253C File Offset: 0x0000073C
		public void SetTextureData(byte[] data, int mipMapLevel)
		{
			int num = 0;
			int num2 = (int)(this.texture.Height * this.texture.Stride);
			for (int i = 0; i < mipMapLevel - 1; i++)
			{
				num += num2;
				num2 /= 4;
			}
			new byte[num2];
			Buffer.BlockCopy(data, 0, this.texture.Data.FullData, num, data.Length);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000259B File Offset: 0x0000079B
		public byte[] GetTextureData()
		{
			return (byte[])this.texture.Data.FullData.Clone();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000025B7 File Offset: 0x000007B7
		public void SetTextureData(byte[] data)
		{
			this.texture.Data.FullData = (byte[])data.Clone();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000025D4 File Offset: 0x000007D4
		public void Reset(int width, int height, int mipMapLevels, int stride, TextureFormat format)
		{
			this.texture.Width = (ushort)width;
			this.texture.Height = (ushort)height;
			this.texture.Levels = (byte)mipMapLevels;
			this.texture.Stride = (ushort)stride;
			this.texture.Format = (uint)format;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002624 File Offset: 0x00000824
		public void UpdateClass()
		{
			this.texture.VFT = 1080137272U;
			this.texture.Unknown_4h = 1U;
			this.texture.Unknown_8h = 0U;
			this.texture.Unknown_Ch = 0U;
			this.texture.Unknown_10h = 0U;
			this.texture.Unknown_14h = 0U;
			this.texture.Unknown_18h = 0U;
			this.texture.Unknown_1Ch = 0U;
			this.texture.Unknown_20h = 0U;
			this.texture.Unknown_24h = 0U;
			this.texture.Unknown_30h = 8388609U;
			this.texture.Unknown_34h = 0U;
			this.texture.Unknown_38h = 0U;
			this.texture.Unknown_3Ch = 0U;
			this.texture.Unknown_40h = 0U;
			this.texture.Unknown_44h = 0U;
			this.texture.Unknown_48h = 0U;
			this.texture.Unknown_4Ch = 0U;
			this.texture.Unknown_54h = 1;
			this.texture.Unknown_5Ch = 0;
			this.texture.Unknown_5Eh = 0;
			this.texture.Unknown_60h = 0U;
			this.texture.Unknown_64h = 0U;
			this.texture.Unknown_68h = 0U;
			this.texture.Unknown_6Ch = 0U;
			this.texture.Unknown_78h = 0U;
			this.texture.Unknown_7Ch = 0U;
			this.texture.Unknown_80h = 0U;
			this.texture.Unknown_84h = 0U;
			this.texture.Unknown_88h = 0U;
			this.texture.Unknown_8Ch = 0U;
		}

		// Token: 0x04000004 RID: 4
		public TextureDX11 texture;
	}
}
