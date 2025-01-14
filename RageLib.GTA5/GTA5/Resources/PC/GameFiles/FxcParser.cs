using System;
using SharpDX.D3DCompiler;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001F5 RID: 501
	public static class FxcParser
	{
		// Token: 0x0600090F RID: 2319 RVA: 0x0003AAF4 File Offset: 0x00038CF4
		public static bool ParseShader(FxcShader shader)
		{
			try
			{
				ShaderBytecode shaderBytecode = new ShaderBytecode(shader.ByteCode);
				ShaderProfile version = shaderBytecode.GetVersion();
				ShaderVersion version2 = version.Version;
				if (version2 > ShaderVersion.GeometryShader)
				{
					shader.VersionMajor = (byte)version.Major;
					shader.VersionMinor = (byte)version.Minor;
				}
				shader.Disassembly = shaderBytecode.Disassemble();
			}
			catch (Exception ex)
			{
				shader.LastError = shader.LastError + ex.ToString() + "\r\n";
				return false;
			}
			return true;
		}
	}
}
