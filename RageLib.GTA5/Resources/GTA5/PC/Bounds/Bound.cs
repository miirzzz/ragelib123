using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x02000166 RID: 358
	public class Bound : FileBase64_GTA5_pc, IResourceXXSystemBlock, IResourceSystemBlock, IResourceBlock
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x000067F5 File Offset: 0x000049F5
		public override long Length
		{
			get
			{
				return 112L;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00025AF5 File Offset: 0x00023CF5
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x00025B00 File Offset: 0x00023D00
		public int RoomId
		{
			get
			{
				return (int)(31 & this.RoomId_And_PedDensity);
			}
			set
			{
				this.RoomId_And_PedDensity = (byte)(((int)this.RoomId_And_PedDensity & -32) | value);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00025B14 File Offset: 0x00023D14
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x00025B24 File Offset: 0x00023D24
		public int PedDensity
		{
			get
			{
				return (224 & this.RoomId_And_PedDensity) >> 5;
			}
			set
			{
				this.RoomId_And_PedDensity = (byte)(((int)this.RoomId_And_PedDensity & -225) | value << 5);
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00025B40 File Offset: 0x00023D40
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Type = reader.ReadByte();
			this.Unknown_11h = reader.ReadByte();
			this.Unknown_12h = reader.ReadUInt16();
			this.BoundingSphereRadius = reader.ReadSingle();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.BoundingBoxMax = reader.ReadBlock<RAGE_Vector3>(Array.Empty<object>());
			this.Margin = reader.ReadSingle();
			this.BoundingBoxMin = reader.ReadBlock<RAGE_Vector3>(Array.Empty<object>());
			this.Unknown_3Ch = reader.ReadUInt32();
			this.BoundingBoxCenter = reader.ReadBlock<RAGE_Vector3>(Array.Empty<object>());
			this.MaterialIndex = reader.ReadByte();
			this.ProceduralId = reader.ReadByte();
			this.RoomId_And_PedDensity = reader.ReadByte();
			this.Unknown_4Fh = reader.ReadByte();
			this.CenterGravity = reader.ReadBlock<RAGE_Vector3>(Array.Empty<object>());
			this.PolyFlags = reader.ReadByte();
			this.MaterialColorIndex = reader.ReadByte();
			this.Unknown_5Eh = reader.ReadUInt16();
			this.Unknown_60h = reader.ReadSingle();
			this.Unknown_64h = reader.ReadSingle();
			this.Unknown_68h = reader.ReadSingle();
			this.BoundingBoxVolume = reader.ReadSingle();
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00025C80 File Offset: 0x00023E80
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Type);
			writer.Write(this.Unknown_11h);
			writer.Write(this.Unknown_12h);
			writer.Write(this.BoundingSphereRadius);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.BoundingBoxMax);
			writer.Write(this.Margin);
			writer.WriteBlock(this.BoundingBoxMin);
			writer.Write(this.Unknown_3Ch);
			writer.WriteBlock(this.BoundingBoxCenter);
			writer.Write(this.MaterialIndex);
			writer.Write(this.ProceduralId);
			writer.Write(this.RoomId_And_PedDensity);
			writer.Write(this.Unknown_4Fh);
			writer.WriteBlock(this.CenterGravity);
			writer.Write(this.PolyFlags);
			writer.Write(this.MaterialColorIndex);
			writer.Write(this.Unknown_5Eh);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.BoundingBoxVolume);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00025DAC File Offset: 0x00023FAC
		public IResourceSystemBlock GetType(ResourceDataReader reader, params object[] parameters)
		{
			reader.Position += 16L;
			byte b = reader.ReadByte();
			reader.Position -= 17L;
			switch (b)
			{
			case 0:
				return new BoundSphere();
			case 1:
				return new BoundCapsule();
			case 3:
				return new BoundBox();
			case 4:
				return new BoundGeometry();
			case 8:
				return new BoundBVH();
			case 10:
				return new BoundComposite();
			case 12:
				return new BoundDisc();
			case 13:
				return new BoundCylinder();
			case 15:
				return new BoundPlane();
			}
			throw new Exception("Unknown bound type");
		}

		// Token: 0x04003616 RID: 13846
		public byte Type;

		// Token: 0x04003617 RID: 13847
		public byte Unknown_11h;

		// Token: 0x04003618 RID: 13848
		public ushort Unknown_12h;

		// Token: 0x04003619 RID: 13849
		public float BoundingSphereRadius;

		// Token: 0x0400361A RID: 13850
		public uint Unknown_18h;

		// Token: 0x0400361B RID: 13851
		public uint Unknown_1Ch;

		// Token: 0x0400361C RID: 13852
		public RAGE_Vector3 BoundingBoxMax;

		// Token: 0x0400361D RID: 13853
		public float Margin;

		// Token: 0x0400361E RID: 13854
		public RAGE_Vector3 BoundingBoxMin;

		// Token: 0x0400361F RID: 13855
		public uint Unknown_3Ch;

		// Token: 0x04003620 RID: 13856
		public RAGE_Vector3 BoundingBoxCenter;

		// Token: 0x04003621 RID: 13857
		public byte MaterialIndex;

		// Token: 0x04003622 RID: 13858
		public byte ProceduralId;

		// Token: 0x04003623 RID: 13859
		public byte RoomId_And_PedDensity;

		// Token: 0x04003624 RID: 13860
		public byte Unknown_4Fh;

		// Token: 0x04003625 RID: 13861
		public RAGE_Vector3 CenterGravity;

		// Token: 0x04003626 RID: 13862
		public byte PolyFlags;

		// Token: 0x04003627 RID: 13863
		public byte MaterialColorIndex;

		// Token: 0x04003628 RID: 13864
		public ushort Unknown_5Eh;

		// Token: 0x04003629 RID: 13865
		public float Unknown_60h;

		// Token: 0x0400362A RID: 13866
		public float Unknown_64h;

		// Token: 0x0400362B RID: 13867
		public float Unknown_68h;

		// Token: 0x0400362C RID: 13868
		public float BoundingBoxVolume;
	}
}
