using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200001A RID: 26
	public class Behaviour : ResourceSystemBlock, IResourceXXSystemBlock, IResourceSystemBlock, IResourceBlock
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000045B9 File Offset: 0x000027B9
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Type = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000045EB File Offset: 0x000027EB
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Type);
			writer.Write(this.Unknown_Ch);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004620 File Offset: 0x00002820
		public IResourceSystemBlock GetType(ResourceDataReader reader, params object[] parameters)
		{
			reader.Position += 8L;
			BehaviourType behaviourType = (BehaviourType)reader.ReadUInt32();
			reader.Position -= 12L;
			if (behaviourType <= BehaviourType.Velocity)
			{
				if (behaviourType <= BehaviourType.Attractor)
				{
					if (behaviourType <= BehaviourType.Light)
					{
						if (behaviourType == BehaviourType.Dampening)
						{
							return new BehaviourDampening();
						}
						if (behaviourType == BehaviourType.Light)
						{
							return new BehaviourLight();
						}
					}
					else
					{
						if (behaviourType == BehaviourType.Colour)
						{
							return new BehaviourColour();
						}
						if (behaviourType == BehaviourType.Rotation)
						{
							return new BehaviourRotation();
						}
						if (behaviourType == BehaviourType.Attractor)
						{
							return new BehaviourAttractor();
						}
					}
				}
				else if (behaviourType <= BehaviourType.Model)
				{
					if (behaviourType == BehaviourType.Size)
					{
						return new BehaviourSize();
					}
					if (behaviourType == BehaviourType.Wind)
					{
						return new BehaviourWind();
					}
					if (behaviourType == BehaviourType.Model)
					{
						return new BehaviourModel();
					}
				}
				else
				{
					if (behaviourType == BehaviourType.MatrixWeight)
					{
						return new BehaviourMatrixWeight();
					}
					if (behaviourType == BehaviourType.Sprite)
					{
						return new BehaviourSprite();
					}
					if (behaviourType == BehaviourType.Velocity)
					{
						return new BehaviourVelocity();
					}
				}
			}
			else if (behaviourType <= (BehaviourType)3078614297U)
			{
				if (behaviourType <= (BehaviourType)2690491966U)
				{
					if (behaviourType == (BehaviourType)2403033142U)
					{
						return new BehaviourDecal();
					}
					if (behaviourType == (BehaviourType)2458524741U)
					{
						return new BehaviourCollision();
					}
					if (behaviourType == (BehaviourType)2690491966U)
					{
						return new BehaviourFogVolume();
					}
				}
				else
				{
					if (behaviourType == (BehaviourType)2731990079U)
					{
						return new BehaviourDecalPool();
					}
					if (behaviourType == (BehaviourType)2740744735U)
					{
						return new BehaviourZCull();
					}
					if (behaviourType == (BehaviourType)3078614297U)
					{
						return new BehaviourNoise();
					}
				}
			}
			else if (behaviourType <= (BehaviourType)3594362651U)
			{
				if (behaviourType == (BehaviourType)3312678904U)
				{
					return new BehaviourTrail();
				}
				if (behaviourType == (BehaviourType)3562621935U)
				{
					return new BehaviourRiver();
				}
				if (behaviourType == (BehaviourType)3594362651U)
				{
					return new BehaviourAcceleration();
				}
			}
			else
			{
				if (behaviourType == (BehaviourType)3743585602U)
				{
					return new BehaviourLiquid();
				}
				if (behaviourType == (BehaviourType)3970452510U)
				{
					return new BehaviourAnimateTexture();
				}
				if (behaviourType == (BehaviourType)4122164138U)
				{
					return new BehaviourAge();
				}
			}
			throw new Exception("Unknown behaviour type");
		}

		// Token: 0x040000C7 RID: 199
		public uint VFT;

		// Token: 0x040000C8 RID: 200
		public uint Unknown_4h;

		// Token: 0x040000C9 RID: 201
		public uint Type;

		// Token: 0x040000CA RID: 202
		public uint Unknown_Ch;
	}
}
