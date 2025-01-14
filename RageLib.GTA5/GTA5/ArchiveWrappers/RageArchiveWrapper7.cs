using System;
using System.Collections.Generic;
using System.IO;
using RageLib.Archives;
using RageLib.Data;
using RageLib.GTA5.Archives;
using RageLib.GTA5.Cryptography;

namespace RageLib.GTA5.ArchiveWrappers
{
	// Token: 0x020002A8 RID: 680
	public class RageArchiveWrapper7 : IArchive, IDisposable
	{
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x000884E5 File Offset: 0x000866E5
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x000884ED File Offset: 0x000866ED
		public string FileName { get; set; }

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x000884F6 File Offset: 0x000866F6
		public IArchiveDirectory Root
		{
			get
			{
				return new RageArchiveDirectoryWrapper7(this, this.archive_.Root);
			}
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00088509 File Offset: 0x00086709
		private RageArchiveWrapper7(Stream stream, string fileName, bool leaveOpen = false)
		{
			this.archive_ = new RageArchive7(stream, leaveOpen);
			this.FileName = fileName;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00088528 File Offset: 0x00086728
		public void Flush()
		{
			long headerSize = this.GetHeaderSize();
			for (;;)
			{
				List<DataBlock> blocks = this.GetBlocks();
				if (ArchiveHelpers.FindSpace(blocks, blocks[0]) >= headerSize)
				{
					break;
				}
				long num = ArchiveHelpers.FindOffset(blocks, blocks[1].Length, 512L);
				ArchiveHelpers.MoveBytes(this.archive_.BaseStream, blocks[1].Offset, num, blocks[1].Length);
				((IRageArchiveFileEntry7)blocks[1].Tag).FileOffset = (uint)(num / 512L);
				blocks = this.GetBlocks();
				ArchiveHelpers.FindSpace(blocks, blocks[0]);
			}
			uint num2 = (GTA5Hash.CalculateHash(this.FileName) + (uint)this.archive_.BaseStream.Length + 61U) % 101U;
			this.archive_.WriteHeader(GTA5Constants.PC_AES_KEY, GTA5Constants.PC_NG_KEYS[(int)num2]);
			this.archive_.BaseStream.Flush();
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00088619 File Offset: 0x00086819
		public void Dispose()
		{
			if (this.archive_ != null)
			{
				this.archive_.Dispose();
			}
			this.archive_ = null;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00088638 File Offset: 0x00086838
		internal Stream GetStream(RageArchiveBinaryFile7 file_)
		{
			return new PartialStream(this.archive_.BaseStream, () => (long)((ulong)(512U * file_.FileOffset)), delegate()
			{
				if (file_.FileSize != 0U)
				{
					return (long)((ulong)file_.FileSize);
				}
				return (long)((ulong)file_.FileUncompressedSize);
			}, delegate(long newLength)
			{
				this.RequestBytes(file_, newLength);
			});
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00088690 File Offset: 0x00086890
		private long GetHeaderSize()
		{
			long num = 16L;
			Stack<RageArchiveDirectory7> stack = new Stack<RageArchiveDirectory7>();
			stack.Push(this.archive_.Root);
			while (stack.Count > 0)
			{
				RageArchiveDirectory7 rageArchiveDirectory = stack.Pop();
				num += 16L;
				num += (long)(rageArchiveDirectory.Name.Length + 1);
				foreach (RageArchiveDirectory7 item in rageArchiveDirectory.Directories)
				{
					stack.Push(item);
				}
				foreach (IRageArchiveEntry7 rageArchiveEntry in rageArchiveDirectory.Files)
				{
					num += (long)(16 + rageArchiveEntry.Name.Length + 1);
				}
			}
			return num;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00088784 File Offset: 0x00086984
		internal long FindSpace(long length)
		{
			this.GetHeaderSize();
			return ArchiveHelpers.FindOffset(this.GetBlocks(), length, 512L);
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x000887A0 File Offset: 0x000869A0
		private List<DataBlock> GetBlocks()
		{
			List<DataBlock> list = new List<DataBlock>();
			list.Add(new DataBlock(0L, this.GetHeaderSize(), null));
			Stack<RageArchiveDirectory7> stack = new Stack<RageArchiveDirectory7>();
			stack.Push(this.archive_.Root);
			while (stack.Count > 0)
			{
				RageArchiveDirectory7 rageArchiveDirectory = stack.Pop();
				foreach (RageArchiveDirectory7 item in rageArchiveDirectory.Directories)
				{
					stack.Push(item);
				}
				foreach (IRageArchiveEntry7 rageArchiveEntry in rageArchiveDirectory.Files)
				{
					IRageArchiveFileEntry7 rageArchiveFileEntry = (IRageArchiveFileEntry7)rageArchiveEntry;
					if (rageArchiveFileEntry is RageArchiveBinaryFile7)
					{
						RageArchiveBinaryFile7 rageArchiveBinaryFile = (RageArchiveBinaryFile7)rageArchiveFileEntry;
						long length;
						if (rageArchiveFileEntry.FileSize == 0U)
						{
							length = (long)((ulong)rageArchiveBinaryFile.FileUncompressedSize);
						}
						else
						{
							length = (long)((ulong)rageArchiveBinaryFile.FileSize);
						}
						list.Add(new DataBlock((long)((ulong)(rageArchiveFileEntry.FileOffset * 512U)), length, rageArchiveFileEntry));
					}
					else
					{
						long length2 = (long)((ulong)((RageArchiveResourceFile7)rageArchiveFileEntry).FileSize);
						list.Add(new DataBlock((long)((ulong)(rageArchiveFileEntry.FileOffset * 512U)), length2, rageArchiveFileEntry));
					}
				}
			}
			list.Sort(delegate(DataBlock a, DataBlock b)
			{
				long offset = a.Offset;
				long offset2 = b.Offset;
				return a.Offset.CompareTo(b.Offset);
			});
			return list;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0008892C File Offset: 0x00086B2C
		public void RequestBytes(RageArchiveBinaryFile7 file_, long newLength)
		{
			this.GetHeaderSize();
			DataBlock dataBlock = null;
			List<DataBlock> blocks = this.GetBlocks();
			foreach (DataBlock dataBlock2 in blocks)
			{
				if (dataBlock2.Tag == file_)
				{
					dataBlock = dataBlock2;
				}
			}
			if (ArchiveHelpers.FindSpace(blocks, dataBlock) < newLength)
			{
				long num = ArchiveHelpers.FindOffset(blocks, newLength, 512L);
				ArchiveHelpers.MoveBytes(this.archive_.BaseStream, dataBlock.Offset, num, dataBlock.Length);
				((IRageArchiveFileEntry7)dataBlock.Tag).FileOffset = (uint)num / 512U;
			}
			if (file_.FileSize != 0U)
			{
				file_.FileSize = (uint)newLength;
				return;
			}
			file_.FileUncompressedSize = (uint)newLength;
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000889F8 File Offset: 0x00086BF8
		public void RequestBytesRES(RageArchiveResourceFile7 file_, long newLength)
		{
			this.GetHeaderSize();
			DataBlock dataBlock = null;
			List<DataBlock> blocks = this.GetBlocks();
			foreach (DataBlock dataBlock2 in blocks)
			{
				if (dataBlock2.Tag == file_)
				{
					dataBlock = dataBlock2;
				}
			}
			if (ArchiveHelpers.FindSpace(blocks, dataBlock) < newLength)
			{
				long num = ArchiveHelpers.FindOffset(blocks, newLength, 512L);
				ArchiveHelpers.MoveBytes(this.archive_.BaseStream, dataBlock.Offset, num, dataBlock.Length);
				((IRageArchiveFileEntry7)dataBlock.Tag).FileOffset = (uint)num / 512U;
			}
			file_.FileSize = (uint)newLength;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00088AB4 File Offset: 0x00086CB4
		public static RageArchiveWrapper7 Create(string fileName)
		{
			FileInfo fileInfo = new FileInfo(fileName);
			RageArchiveWrapper7 rageArchiveWrapper = new RageArchiveWrapper7(new FileStream(fileName, FileMode.Create), fileInfo.Name, false);
			RageArchiveDirectory7 rageArchiveDirectory = new RageArchiveDirectory7();
			rageArchiveDirectory.Name = "";
			rageArchiveWrapper.archive_.Root = rageArchiveDirectory;
			return rageArchiveWrapper;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00088AF8 File Offset: 0x00086CF8
		public static RageArchiveWrapper7 Create(Stream stream, string fileName, bool leaveOpen = false)
		{
			RageArchiveWrapper7 rageArchiveWrapper = new RageArchiveWrapper7(stream, fileName, leaveOpen);
			RageArchiveDirectory7 rageArchiveDirectory = new RageArchiveDirectory7();
			rageArchiveDirectory.Name = "";
			rageArchiveWrapper.archive_.Root = rageArchiveDirectory;
			return rageArchiveWrapper;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00088B2C File Offset: 0x00086D2C
		public static RageArchiveWrapper7 Open(string fileName)
		{
			FileInfo fileInfo = new FileInfo(fileName);
			FileStream fileStream = new FileStream(fileName, FileMode.Open);
			RageArchiveWrapper7 rageArchiveWrapper = new RageArchiveWrapper7(fileStream, fileInfo.Name, false);
			RageArchiveWrapper7 result;
			try
			{
				if (GTA5Constants.PC_LUT != null && GTA5Constants.PC_NG_KEYS != null)
				{
					uint num = (GTA5Hash.CalculateHash(rageArchiveWrapper.FileName) + (uint)fileInfo.Length + 61U) % 101U;
					rageArchiveWrapper.archive_.ReadHeader(GTA5Constants.PC_AES_KEY, GTA5Constants.PC_NG_KEYS[(int)num]);
				}
				else
				{
					rageArchiveWrapper.archive_.ReadHeader(GTA5Constants.PC_AES_KEY, null);
				}
				result = rageArchiveWrapper;
			}
			catch
			{
				fileStream.Dispose();
				rageArchiveWrapper.Dispose();
				throw;
			}
			return result;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00088BD0 File Offset: 0x00086DD0
		public static RageArchiveWrapper7 Open(Stream stream, string fileName, bool leaveOpen = false)
		{
			RageArchiveWrapper7 rageArchiveWrapper = new RageArchiveWrapper7(stream, fileName, leaveOpen);
			RageArchiveWrapper7 result;
			try
			{
				if (GTA5Constants.PC_LUT != null && GTA5Constants.PC_NG_KEYS != null)
				{
					uint num = (GTA5Hash.CalculateHash(rageArchiveWrapper.FileName) + (uint)stream.Length + 61U) % 101U;
					rageArchiveWrapper.archive_.ReadHeader(GTA5Constants.PC_AES_KEY, GTA5Constants.PC_NG_KEYS[(int)num]);
				}
				else
				{
					rageArchiveWrapper.archive_.ReadHeader(GTA5Constants.PC_AES_KEY, null);
				}
				result = rageArchiveWrapper;
			}
			catch
			{
				rageArchiveWrapper.Dispose();
				throw;
			}
			return result;
		}

		// Token: 0x04004006 RID: 16390
		public static int BLOCK_SIZE = 512;

		// Token: 0x04004007 RID: 16391
		public RageArchive7 archive_;
	}
}
