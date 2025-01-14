using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RageLib.Data;
using RageLib.GTA5.RBF.Types;

namespace RageLib.GTA5.RBF
{
	// Token: 0x020001F6 RID: 502
	public class RbfFile
	{
		// Token: 0x06000910 RID: 2320 RVA: 0x0003AB80 File Offset: 0x00038D80
		public RbfStructure Load(string fileName)
		{
			RbfStructure result;
			using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
			{
				result = this.Load(fileStream);
			}
			return result;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0003ABBC File Offset: 0x00038DBC
		public RbfStructure Load(Stream stream)
		{
			this.stack = new Stack<RbfStructure>();
			this.descriptors = new List<RbfEntryDescription>();
			DataReader dataReader = new DataReader(stream, Endianess.LittleEndian);
			if (dataReader.ReadInt32() != 809910866)
			{
				throw new Exception("The file identifier does not match.");
			}
			while (dataReader.Position < dataReader.Length)
			{
				byte b = dataReader.ReadByte();
				if (b == 255)
				{
					byte b2 = dataReader.ReadByte();
					if (b2 != 255)
					{
						throw new Exception("Expected 0xFF but was " + b2.ToString("X2"));
					}
					if (this.stack.Count > 0)
					{
						this.current = this.stack.Pop();
					}
					else
					{
						if (dataReader.Position != dataReader.Length)
						{
							throw new Exception("Expected end of stream but was not.");
						}
						return this.current;
					}
				}
				else if (b == 253)
				{
					byte b3 = dataReader.ReadByte();
					if (b3 != 255)
					{
						throw new Exception("Expected 0xFF but was " + b3.ToString("X2"));
					}
					int count = dataReader.ReadInt32();
					byte[] value = dataReader.ReadBytes(count);
					RbfBytes rbfBytes = new RbfBytes();
					rbfBytes.Value = value;
					this.current.Children.Add(rbfBytes);
				}
				else
				{
					byte b4 = dataReader.ReadByte();
					if ((int)b == this.descriptors.Count)
					{
						short count2 = dataReader.ReadInt16();
						byte[] bytes = dataReader.ReadBytes((int)count2);
						string @string = Encoding.ASCII.GetString(bytes);
						RbfEntryDescription rbfEntryDescription = new RbfEntryDescription();
						rbfEntryDescription.Name = @string;
						rbfEntryDescription.Type = (int)b4;
						this.descriptors.Add(rbfEntryDescription);
						this.ParseElement(dataReader, this.descriptors.Count - 1);
					}
					else
					{
						if ((int)b4 != this.descriptors[(int)b].Type)
						{
							throw new Exception("Data type does not match.");
						}
						this.ParseElement(dataReader, (int)b);
					}
				}
			}
			throw new Exception("Unexpected end of stream.");
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0003ADA4 File Offset: 0x00038FA4
		private void ParseElement(DataReader reader, int descriptorIndex)
		{
			RbfEntryDescription rbfEntryDescription = this.descriptors[descriptorIndex];
			int type = rbfEntryDescription.Type;
			if (type <= 32)
			{
				if (type == 0)
				{
					RbfStructure rbfStructure = new RbfStructure();
					rbfStructure.Name = rbfEntryDescription.Name;
					if (this.current != null)
					{
						this.current.Children.Add(rbfStructure);
						this.stack.Push(this.current);
					}
					this.current = rbfStructure;
					reader.ReadInt16();
					reader.ReadInt16();
					reader.ReadInt16();
					return;
				}
				if (type == 16)
				{
					RbfUint32 rbfUint = new RbfUint32();
					rbfUint.Name = rbfEntryDescription.Name;
					rbfUint.Value = reader.ReadUInt32();
					this.current.Children.Add(rbfUint);
					return;
				}
				if (type == 32)
				{
					RbfBoolean rbfBoolean = new RbfBoolean();
					rbfBoolean.Name = rbfEntryDescription.Name;
					rbfBoolean.Value = true;
					this.current.Children.Add(rbfBoolean);
					return;
				}
			}
			else if (type <= 64)
			{
				if (type == 48)
				{
					RbfBoolean rbfBoolean2 = new RbfBoolean();
					rbfBoolean2.Name = rbfEntryDescription.Name;
					rbfBoolean2.Value = false;
					this.current.Children.Add(rbfBoolean2);
					return;
				}
				if (type == 64)
				{
					RbfFloat rbfFloat = new RbfFloat();
					rbfFloat.Name = rbfEntryDescription.Name;
					rbfFloat.Value = reader.ReadSingle();
					this.current.Children.Add(rbfFloat);
					return;
				}
			}
			else
			{
				if (type == 80)
				{
					RbfFloat3 rbfFloat2 = new RbfFloat3();
					rbfFloat2.Name = rbfEntryDescription.Name;
					rbfFloat2.X = reader.ReadSingle();
					rbfFloat2.Y = reader.ReadSingle();
					rbfFloat2.Z = reader.ReadSingle();
					this.current.Children.Add(rbfFloat2);
					return;
				}
				if (type == 96)
				{
					short count = reader.ReadInt16();
					byte[] bytes = reader.ReadBytes((int)count);
					string @string = Encoding.ASCII.GetString(bytes);
					RbfString rbfString = new RbfString();
					rbfString.Name = rbfEntryDescription.Name;
					rbfString.Value = @string;
					this.current.Children.Add(rbfString);
					return;
				}
			}
			throw new Exception("Unsupported data type.");
		}

		// Token: 0x04003A48 RID: 14920
		private const int RBF_IDENT = 809910866;

		// Token: 0x04003A49 RID: 14921
		public RbfStructure current;

		// Token: 0x04003A4A RID: 14922
		public Stack<RbfStructure> stack;

		// Token: 0x04003A4B RID: 14923
		public List<RbfEntryDescription> descriptors;
	}
}
