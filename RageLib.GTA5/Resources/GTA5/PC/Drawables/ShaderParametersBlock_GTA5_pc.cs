using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Textures;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200010F RID: 271
	public class ShaderParametersBlock_GTA5_pc : ResourceSystemBlock
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001E0B0 File Offset: 0x0001C2B0
		public override long Length
		{
			get
			{
				long num = 0L;
				foreach (ShaderParameter shaderParameter in this.Parameters)
				{
					num += 16L;
				}
				foreach (ShaderParameter shaderParameter2 in this.Parameters)
				{
					num += (long)(16 * shaderParameter2.DataType);
				}
				num += (long)(this.Parameters.Count * 4);
				return num;
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0001E160 File Offset: 0x0001C360
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			int num = Convert.ToInt32(parameters[0]);
			this.Parameters = new List<ShaderParameter>();
			for (int i = 0; i < num; i++)
			{
				this.Parameters.Add(reader.ReadBlock<ShaderParameter>(Array.Empty<object>()));
			}
			int num2 = 0;
			for (int j = 0; j < num; j++)
			{
				ShaderParameter shaderParameter = this.Parameters[j];
				byte dataType = shaderParameter.DataType;
				if (dataType != 0)
				{
					if (dataType != 1)
					{
						num2 += (int)(16 * shaderParameter.DataType);
						shaderParameter.Data = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Vector4>>(shaderParameter.DataPointer, new object[]
						{
							shaderParameter.DataType
						});
					}
					else
					{
						num2 += 16;
						shaderParameter.Data = reader.ReadBlockAt<RAGE_Vector4>(shaderParameter.DataPointer, Array.Empty<object>());
					}
				}
				else
				{
					num2 = num2;
					shaderParameter.Data = reader.ReadBlockAt<Texture>(shaderParameter.DataPointer, Array.Empty<object>());
				}
			}
			reader.Position += (long)num2;
			this.Hashes = new List<uint>();
			for (int k = 0; k < num; k++)
			{
				this.Hashes.Add(reader.ReadUInt32());
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0001E288 File Offset: 0x0001C488
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			foreach (ShaderParameter shaderParameter in this.Parameters)
			{
				if (shaderParameter.Data != null)
				{
					shaderParameter.DataPointer = (ulong)shaderParameter.Data.Position;
				}
				else
				{
					shaderParameter.DataPointer = 0UL;
				}
			}
			foreach (ShaderParameter value in this.Parameters)
			{
				writer.WriteBlock(value);
			}
			foreach (ShaderParameter shaderParameter2 in this.Parameters)
			{
				if (shaderParameter2.DataType != 0)
				{
					writer.WriteBlock(shaderParameter2.Data);
				}
			}
			foreach (uint value2 in this.Hashes)
			{
				writer.Write(value2);
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0001E3D0 File Offset: 0x0001C5D0
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			list.AddRange(base.GetReferences());
			foreach (ShaderParameter shaderParameter in this.Parameters)
			{
				if (shaderParameter.DataType == 0)
				{
					list.Add(shaderParameter.Data);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001E448 File Offset: 0x0001C648
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			List<Tuple<long, IResourceBlock>> list = new List<Tuple<long, IResourceBlock>>();
			list.AddRange(base.GetParts());
			long num = 0L;
			foreach (ShaderParameter item in this.Parameters)
			{
				list.Add(new Tuple<long, IResourceBlock>(num, item));
				num += 16L;
			}
			foreach (ShaderParameter shaderParameter in this.Parameters)
			{
				if (shaderParameter.DataType != 0)
				{
					list.Add(new Tuple<long, IResourceBlock>(num, shaderParameter.Data));
				}
				num += (long)(16 * shaderParameter.DataType);
			}
			return list.ToArray();
		}

		// Token: 0x04003248 RID: 12872
		public List<ShaderParameter> Parameters = new List<ShaderParameter>();

		// Token: 0x04003249 RID: 12873
		public List<uint> Hashes = new List<uint>();
	}
}
