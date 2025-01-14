using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RageLib.Hash;
using RageLib.Resources.GTA5.PC.Drawables;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001EA RID: 490
	public class FxcFile
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00038623 File Offset: 0x00036823
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x0003862B File Offset: 0x0003682B
		public string Name { get; set; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00038634 File Offset: 0x00036834
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x0003863C File Offset: 0x0003683C
		public uint Hash { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00038645 File Offset: 0x00036845
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x0003864D File Offset: 0x0003684D
		public VertexType VertexType { get; set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00038656 File Offset: 0x00036856
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x0003865E File Offset: 0x0003685E
		public FxcHeaderExt[] Exts { get; set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00038667 File Offset: 0x00036867
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x0003866F File Offset: 0x0003686F
		public FxcHeaderChunk[] Chunks { get; set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00038678 File Offset: 0x00036878
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00038680 File Offset: 0x00036880
		public FxcShader[] Shaders { get; set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00038689 File Offset: 0x00036889
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x00038691 File Offset: 0x00036891
		public FxcCBuffer[] CBuffers1 { get; set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0003869A File Offset: 0x0003689A
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x000386A2 File Offset: 0x000368A2
		public FxcVariable[] Variables1 { get; set; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x000386AB File Offset: 0x000368AB
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x000386B3 File Offset: 0x000368B3
		public FxcCBuffer[] CBuffers2 { get; set; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x000386BC File Offset: 0x000368BC
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x000386C4 File Offset: 0x000368C4
		public FxcVariable[] Variables2 { get; set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x000386CD File Offset: 0x000368CD
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x000386D5 File Offset: 0x000368D5
		public FxcTechnique[] Techniques { get; set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x000386DE File Offset: 0x000368DE
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x000386E6 File Offset: 0x000368E6
		public FxcShader[] VertexShaders { get; set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x000386EF File Offset: 0x000368EF
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x000386F7 File Offset: 0x000368F7
		public FxcShader[] PixelShaders { get; set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00038700 File Offset: 0x00036900
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00038708 File Offset: 0x00036908
		public FxcShader[] ComputeShaders { get; set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00038711 File Offset: 0x00036911
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00038719 File Offset: 0x00036919
		public FxcShader[] DomainShaders { get; set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00038722 File Offset: 0x00036922
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x0003872A File Offset: 0x0003692A
		public FxcShader[] GeometryShaders { get; set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x00038733 File Offset: 0x00036933
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x0003873B File Offset: 0x0003693B
		public FxcShader[] HullShaders { get; set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00038744 File Offset: 0x00036944
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x0003874C File Offset: 0x0003694C
		public Dictionary<uint, FxcCBuffer> CBufferDict { get; set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00038755 File Offset: 0x00036955
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x0003875D File Offset: 0x0003695D
		public FxcVariable[] GlobalVariables { get; set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00038766 File Offset: 0x00036966
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x0003876E File Offset: 0x0003696E
		public string LastError { get; set; }

		// Token: 0x0600086C RID: 2156 RVA: 0x00038778 File Offset: 0x00036978
		public void Load(byte[] data, string name = "")
		{
			this.Name = name;
			this.Hash = Jenkins.Hash(name.Replace(".fxc", ""));
			this.LastError = string.Empty;
			MemoryStream memoryStream = new MemoryStream(data);
			BinaryReader binaryReader = new BinaryReader(memoryStream);
			if (binaryReader.ReadUInt32() != 1702389618U)
			{
				return;
			}
			this.VertexType = (VertexType)binaryReader.ReadUInt32();
			byte b = binaryReader.ReadByte();
			List<FxcHeaderExt> list = new List<FxcHeaderExt>();
			for (int i = 0; i < (int)b; i++)
			{
				list.Add(new FxcHeaderExt
				{
					Name = FxcFile.ReadString(binaryReader),
					Unk0Byte = binaryReader.ReadByte(),
					Unk1Uint = binaryReader.ReadUInt32()
				});
			}
			this.Exts = list.ToArray();
			List<FxcShader>[] array = new List<FxcShader>[6];
			List<FxcHeaderChunk> list2 = new List<FxcHeaderChunk>();
			List<FxcShader> list3 = new List<FxcShader>();
			int j = 0;
			while (j < 6)
			{
				List<FxcShader> list4 = new List<FxcShader>();
				array[j] = list4;
				j++;
				byte b2 = binaryReader.ReadByte();
				if (b2 == 0)
				{
					b2 = binaryReader.ReadByte();
				}
				FxcHeaderChunk fxcHeaderChunk = new FxcHeaderChunk();
				fxcHeaderChunk.Read(binaryReader);
				fxcHeaderChunk.Gindex = j;
				fxcHeaderChunk.ShaderCount = b2;
				list2.Add(fxcHeaderChunk);
				for (int k = 1; k < (int)b2; k++)
				{
					bool exbyteflag = j == 5;
					bool vsgsps = j == 1 || j == 2 || j == 5;
					FxcShader fxcShader = new FxcShader();
					if (!fxcShader.Read(binaryReader, exbyteflag, vsgsps))
					{
						this.LastError += fxcShader.LastError;
					}
					list3.Add(fxcShader);
					list4.Add(fxcShader);
				}
			}
			this.Shaders = list3.ToArray();
			List<FxcShader> list5 = array[0];
			this.VertexShaders = ((list5 != null) ? list5.ToArray() : null);
			List<FxcShader> list6 = array[1];
			this.PixelShaders = ((list6 != null) ? list6.ToArray() : null);
			List<FxcShader> list7 = array[2];
			this.ComputeShaders = ((list7 != null) ? list7.ToArray() : null);
			List<FxcShader> list8 = array[3];
			this.DomainShaders = ((list8 != null) ? list8.ToArray() : null);
			List<FxcShader> list9 = array[4];
			this.GeometryShaders = ((list9 != null) ? list9.ToArray() : null);
			List<FxcShader> list10 = array[5];
			this.HullShaders = ((list10 != null) ? list10.ToArray() : null);
			this.Chunks = list2.ToArray();
			List<FxcVariable> list11 = new List<FxcVariable>();
			this.CBufferDict = new Dictionary<uint, FxcCBuffer>();
			FxcCBuffer fxcCBuffer = null;
			try
			{
				byte b3 = binaryReader.ReadByte();
				if (b3 > 0)
				{
					List<FxcCBuffer> list12 = new List<FxcCBuffer>();
					for (int l = 0; l < (int)b3; l++)
					{
						FxcCBuffer fxcCBuffer2 = new FxcCBuffer();
						fxcCBuffer2.Read(binaryReader);
						list12.Add(fxcCBuffer2);
						this.CBufferDict[fxcCBuffer2.NameHash] = fxcCBuffer2;
					}
					this.CBuffers1 = list12.ToArray();
				}
				byte b4 = binaryReader.ReadByte();
				if (b4 > 0)
				{
					List<FxcVariable> list13 = new List<FxcVariable>();
					for (int m = 0; m < (int)b4; m++)
					{
						FxcVariable fxcVariable = new FxcVariable();
						fxcVariable.Read(binaryReader);
						list13.Add(fxcVariable);
						if (this.CBufferDict.TryGetValue(fxcVariable.CBufferName, out fxcCBuffer))
						{
							fxcCBuffer.AddVariable(fxcVariable);
						}
						else
						{
							list11.Add(fxcVariable);
						}
					}
					this.Variables1 = list13.ToArray();
				}
				byte b5 = binaryReader.ReadByte();
				if (b5 > 0)
				{
					List<FxcCBuffer> list14 = new List<FxcCBuffer>();
					for (int n = 0; n < (int)b5; n++)
					{
						FxcCBuffer fxcCBuffer3 = new FxcCBuffer();
						fxcCBuffer3.Read(binaryReader);
						list14.Add(fxcCBuffer3);
						this.CBufferDict[fxcCBuffer3.NameHash] = fxcCBuffer3;
					}
					this.CBuffers2 = list14.ToArray();
				}
				byte b6 = binaryReader.ReadByte();
				if (b6 > 0)
				{
					List<FxcVariable> list15 = new List<FxcVariable>();
					for (int num = 0; num < (int)b6; num++)
					{
						FxcVariable fxcVariable2 = new FxcVariable();
						fxcVariable2.Read(binaryReader);
						list15.Add(fxcVariable2);
						if (this.CBufferDict.TryGetValue(fxcVariable2.CBufferName, out fxcCBuffer))
						{
							fxcCBuffer.AddVariable(fxcVariable2);
						}
						else
						{
							list11.Add(fxcVariable2);
						}
					}
					this.Variables2 = list15.ToArray();
				}
				byte b7 = binaryReader.ReadByte();
				if (b7 > 0)
				{
					List<FxcTechnique> list16 = new List<FxcTechnique>();
					for (int num2 = 0; num2 < (int)b7; num2++)
					{
						FxcTechnique fxcTechnique = new FxcTechnique();
						fxcTechnique.Read(binaryReader);
						list16.Add(fxcTechnique);
					}
					this.Techniques = list16.ToArray();
				}
				foreach (FxcCBuffer fxcCBuffer4 in this.CBufferDict.Values)
				{
					fxcCBuffer4.ConsolidateVariables();
				}
				this.GlobalVariables = list11.ToArray();
				long position = memoryStream.Position;
				long length = memoryStream.Length;
			}
			catch (Exception ex)
			{
				this.LastError = ex.ToString();
			}
			memoryStream.Dispose();
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00038C60 File Offset: 0x00036E60
		public string GetMetaString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Name: " + this.Name);
			stringBuilder.AppendLine("Hash: " + this.Hash.ToString());
			stringBuilder.AppendLine("Vertex type: " + ((uint)this.VertexType).ToString());
			stringBuilder.AppendLine();
			if (this.Exts != null)
			{
				stringBuilder.AppendLine("Header");
				foreach (FxcHeaderExt fxcHeaderExt in this.Exts)
				{
					stringBuilder.AppendLine("  " + fxcHeaderExt.ToString());
				}
				stringBuilder.AppendLine();
			}
			if (this.Chunks != null)
			{
				stringBuilder.AppendLine("Sections");
				foreach (FxcHeaderChunk fxcHeaderChunk in this.Chunks)
				{
					stringBuilder.AppendLine("  " + fxcHeaderChunk.ToString());
				}
				stringBuilder.AppendLine();
			}
			if (this.Shaders != null)
			{
				stringBuilder.AppendLine("Shaders (" + this.Shaders.Length.ToString() + ")");
				foreach (FxcShader fxcShader in this.Shaders)
				{
					stringBuilder.AppendLine("  " + fxcShader.Name);
					if (fxcShader.Params != null && fxcShader.Params.Length != 0)
					{
						stringBuilder.AppendLine("    (Params)");
						foreach (string str in fxcShader.Params)
						{
							stringBuilder.AppendLine("      " + str);
						}
					}
					if (fxcShader.Buffers != null && fxcShader.Buffers.Length != 0)
					{
						stringBuilder.AppendLine("    (Buffers)");
						foreach (FxcShaderBufferRef fxcShaderBufferRef in fxcShader.Buffers)
						{
							stringBuilder.AppendLine("      " + fxcShaderBufferRef.ToString());
						}
					}
				}
				stringBuilder.AppendLine();
			}
			if (this.CBuffers1 != null)
			{
				stringBuilder.AppendLine("CBuffers 1 (" + this.CBuffers1.Length.ToString() + ")");
				foreach (FxcCBuffer fxcCBuffer in this.CBuffers1)
				{
					stringBuilder.AppendLine("  " + fxcCBuffer.ToString());
				}
				stringBuilder.AppendLine();
			}
			if (this.Variables1 != null)
			{
				stringBuilder.AppendLine("Variables 1 (" + this.Variables1.Length.ToString() + ")");
				foreach (FxcVariable fxcVariable in this.Variables1)
				{
					stringBuilder.AppendLine("  " + fxcVariable.ToString());
					if (fxcVariable.Params != null && fxcVariable.Params.Length != 0)
					{
						stringBuilder.AppendLine("    (Params)");
						foreach (FxcVariableParam fxcVariableParam in fxcVariable.Params)
						{
							stringBuilder.AppendLine("      " + fxcVariableParam.ToString());
						}
					}
					if (fxcVariable.Values != null && fxcVariable.Values.Length != 0)
					{
						stringBuilder.AppendLine("    (Values)");
						foreach (float num in fxcVariable.Values)
						{
							stringBuilder.AppendLine("      " + num.ToString());
						}
					}
				}
				stringBuilder.AppendLine();
			}
			if (this.CBuffers2 != null)
			{
				stringBuilder.AppendLine("CBuffers 2 (" + this.CBuffers2.Length.ToString() + ")");
				foreach (FxcCBuffer fxcCBuffer2 in this.CBuffers2)
				{
					stringBuilder.AppendLine("  " + fxcCBuffer2.ToString());
				}
				stringBuilder.AppendLine();
			}
			if (this.Variables2 != null)
			{
				stringBuilder.AppendLine("Variables 2 (" + this.Variables2.Length.ToString() + ")");
				foreach (FxcVariable fxcVariable2 in this.Variables2)
				{
					stringBuilder.AppendLine("  " + fxcVariable2.ToString());
					if (fxcVariable2.Params != null && fxcVariable2.Params.Length != 0)
					{
						stringBuilder.AppendLine("    (Params)");
						foreach (FxcVariableParam fxcVariableParam2 in fxcVariable2.Params)
						{
							stringBuilder.AppendLine("      " + fxcVariableParam2.ToString());
						}
					}
					if (fxcVariable2.Values != null && fxcVariable2.Values.Length != 0)
					{
						stringBuilder.AppendLine("    (Values)");
						foreach (float num2 in fxcVariable2.Values)
						{
							stringBuilder.AppendLine("      " + num2.ToString());
						}
					}
				}
				stringBuilder.AppendLine();
			}
			if (this.Techniques != null)
			{
				stringBuilder.AppendLine("Techniques (" + this.Techniques.Length.ToString() + ")");
				foreach (FxcTechnique fxcTechnique in this.Techniques)
				{
					stringBuilder.AppendLine("  " + fxcTechnique.Name);
					if (fxcTechnique.PassCount > 0 && fxcTechnique.Passes != null)
					{
						stringBuilder.AppendLine("    (Passes)");
						foreach (FxcPass fxcPass in fxcTechnique.Passes)
						{
							stringBuilder.AppendLine("      " + fxcPass.ToString());
							if (fxcPass.ParamCount > 0 && fxcPass.Params != null)
							{
								foreach (FxcPassParam fxcPassParam in fxcPass.Params)
								{
									stringBuilder.AppendLine("         " + fxcPassParam.ToString());
								}
							}
						}
					}
				}
				stringBuilder.AppendLine();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000392D8 File Offset: 0x000374D8
		public FxcShader GetVS(int id)
		{
			int num = id - 1;
			if (num < 0 || this.VertexShaders == null || num >= this.VertexShaders.Length)
			{
				return null;
			}
			return this.VertexShaders[num];
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0003930C File Offset: 0x0003750C
		public FxcShader GetPS(int id)
		{
			int num = id - 1;
			if (num < 0 || this.PixelShaders == null || num >= this.PixelShaders.Length)
			{
				return null;
			}
			return this.PixelShaders[num];
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00039340 File Offset: 0x00037540
		public FxcShader GetCS(int id)
		{
			int num = id - 1;
			if (num < 0 || this.ComputeShaders == null || num >= this.ComputeShaders.Length)
			{
				return null;
			}
			return this.ComputeShaders[num];
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00039374 File Offset: 0x00037574
		public FxcShader GetDS(int id)
		{
			int num = id - 1;
			if (num < 0 || this.DomainShaders == null || num >= this.DomainShaders.Length)
			{
				return null;
			}
			return this.DomainShaders[num];
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000393A8 File Offset: 0x000375A8
		public FxcShader GetGS(int id)
		{
			int num = id - 1;
			if (num < 0 || this.GeometryShaders == null || num >= this.GeometryShaders.Length)
			{
				return null;
			}
			return this.GeometryShaders[num];
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000393DC File Offset: 0x000375DC
		public FxcShader GetHS(int id)
		{
			int num = id - 1;
			if (num < 0 || this.HullShaders == null || num >= this.HullShaders.Length)
			{
				return null;
			}
			return this.HullShaders[num];
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00039410 File Offset: 0x00037610
		public static string ReadString(BinaryReader br)
		{
			byte b = br.ReadByte();
			if (b == 0)
			{
				return string.Empty;
			}
			byte[] array = new byte[(int)b];
			br.Read(array, 0, (int)b);
			if (b <= 1)
			{
				return string.Empty;
			}
			return Encoding.ASCII.GetString(array, 0, (int)(b - 1));
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00039458 File Offset: 0x00037658
		public static string[] ReadStringArray(BinaryReader br)
		{
			string[] array = null;
			byte b = br.ReadByte();
			if (b > 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				array = new string[(int)b];
				for (int i = 0; i < (int)b; i++)
				{
					stringBuilder.Clear();
					byte b2 = br.ReadByte();
					for (int j = 0; j < (int)b2; j++)
					{
						stringBuilder.Append((char)br.ReadByte());
					}
					array[i] = stringBuilder.ToString().Replace("\0", "");
				}
			}
			return array;
		}
	}
}
