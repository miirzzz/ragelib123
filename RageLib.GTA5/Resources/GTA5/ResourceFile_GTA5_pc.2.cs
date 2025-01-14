using System;
using System.Collections.Generic;
using System.IO;
using RageLib.Data;

namespace RageLib.Resources.GTA5
{
	// Token: 0x02000010 RID: 16
	public class ResourceFile_GTA5_pc<T> : ResourceFile_GTA5_pc, IResourceFile<T>, IResourceFile where T : IResourceBlock, new()
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00003798 File Offset: 0x00001998
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000037A0 File Offset: 0x000019A0
		public T ResourceData { get; set; }

		// Token: 0x06000094 RID: 148 RVA: 0x000037AC File Offset: 0x000019AC
		public override void Load(Stream stream)
		{
			base.Load(stream);
			Stream systemStream = new MemoryStream(base.SystemData);
			MemoryStream graphicsStream = new MemoryStream(base.GraphicsData);
			this.ResourceData = new ResourceDataReader(systemStream, graphicsStream, Endianess.LittleEndian)
			{
				Position = 1342177280L
			}.ReadBlock<T>(Array.Empty<object>());
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000037FC File Offset: 0x000019FC
		public override void Save(Stream stream)
		{
			FileBase64_GTA5_pc fileBase64_GTA5_pc = (FileBase64_GTA5_pc)((object)this.ResourceData);
			fileBase64_GTA5_pc.PagesInfo = new PagesInfo_GTA5_pc();
			IList<IResourceBlock> list;
			IList<IResourceBlock> list2;
			ResourceHelpers.GetBlocks(this.ResourceData, out list, out list2);
			int num = 8192;
			int num2;
			ResourceHelpers.AssignPositions(list, 1342177280U, ref num, out num2);
			int num3 = 8192;
			int num4;
			ResourceHelpers.AssignPositions(list2, 1610612736U, ref num3, out num4);
			fileBase64_GTA5_pc.PagesInfo.SystemPagesCount = 0;
			if (num2 > 0)
			{
				fileBase64_GTA5_pc.PagesInfo.SystemPagesCount = 1;
			}
			fileBase64_GTA5_pc.PagesInfo.GraphicsPagesCount = (byte)num4;
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			ResourceDataWriter resourceDataWriter = new ResourceDataWriter(memoryStream, memoryStream2, Endianess.LittleEndian);
			resourceDataWriter.Position = 1342177280L;
			foreach (IResourceBlock resourceBlock in list)
			{
				resourceDataWriter.Position = resourceBlock.Position;
				long position = resourceDataWriter.Position;
				resourceBlock.Write(resourceDataWriter, Array.Empty<object>());
				if (resourceDataWriter.Position - position != resourceBlock.Length)
				{
					throw new Exception("error in system length");
				}
			}
			resourceDataWriter.Position = 1610612736L;
			foreach (IResourceBlock resourceBlock2 in list2)
			{
				resourceDataWriter.Position = resourceBlock2.Position;
				long position2 = resourceDataWriter.Position;
				resourceBlock2.Write(resourceDataWriter, Array.Empty<object>());
				if (resourceDataWriter.Position - position2 != resourceBlock2.Length)
				{
					throw new Exception("error in graphics length");
				}
			}
			base.SystemPagesDiv16 = 0;
			base.SystemPagesDiv8 = 0;
			base.SystemPagesDiv4 = 0;
			base.SystemPagesDiv2 = 0;
			base.SystemPagesMul1 = 1;
			base.SystemPagesMul2 = 0;
			base.SystemPagesMul4 = 0;
			base.SystemPagesMul8 = 0;
			base.SystemPagesMul16 = 0;
			base.SystemPagesSizeShift = 0;
			int num5 = 8192;
			while ((long)num5 < memoryStream.Length)
			{
				num5 *= 2;
				int num6 = base.SystemPagesSizeShift;
				base.SystemPagesSizeShift = num6 + 1;
			}
			byte[] array = new byte[num5];
			memoryStream.Flush();
			memoryStream.Position = 0L;
			memoryStream.Read(array, 0, (int)memoryStream.Length);
			base.SystemData = array;
			base.GraphicsPagesDiv16 = 0;
			base.GraphicsPagesDiv8 = 0;
			base.GraphicsPagesDiv4 = 0;
			base.GraphicsPagesDiv2 = 0;
			base.GraphicsPagesMul1 = num4;
			base.GraphicsPagesMul2 = 0;
			base.GraphicsPagesMul4 = 0;
			base.GraphicsPagesMul8 = 0;
			base.GraphicsPagesMul16 = 0;
			base.GraphicsPagesSizeShift = 0;
			int num7 = 8192;
			while (num7 != num3)
			{
				num7 *= 2;
				int num6 = base.GraphicsPagesSizeShift;
				base.GraphicsPagesSizeShift = num6 + 1;
			}
			byte[] array2 = new byte[base.GraphicsPagesMul1 * num7];
			memoryStream2.Flush();
			memoryStream2.Position = 0L;
			memoryStream2.Read(array2, 0, (int)memoryStream2.Length);
			base.GraphicsData = array2;
			base.Save(stream);
		}
	}
}
