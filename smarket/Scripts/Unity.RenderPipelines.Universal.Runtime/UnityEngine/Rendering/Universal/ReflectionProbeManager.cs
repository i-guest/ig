using System;
using System.Collections.Generic;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	internal struct ReflectionProbeManager : IDisposable
	{
		private struct CachedProbe
		{
			public uint updateCount;

			public Hash128 imageContentsHash;

			public int size;

			public int mipCount;

			public unsafe fixed int dataIndices[7];

			public unsafe fixed int levels[7];

			public Texture texture;

			public int lastUsed;

			public Vector4 hdrData;
		}

		private static class ShaderProperties
		{
			public static readonly int BoxMin;

			public static readonly int BoxMax;

			public static readonly int ProbePosition;

			public static readonly int MipScaleOffset;

			public static readonly int Count;

			public static readonly int Atlas;

			public static readonly int Rotation;
		}

		private int2 m_Resolution;

		private RenderTexture m_AtlasTexture0;

		private RenderTexture m_AtlasTexture1;

		private RTHandle m_AtlasTexture0Handle;

		private BuddyAllocator m_AtlasAllocator;

		private Dictionary<int, CachedProbe> m_Cache;

		private Dictionary<int, int> m_WarningCache;

		private List<int> m_NeedsUpdate;

		private List<int> m_NeedsRemove;

		private Vector4[] m_BoxMax;

		private Vector4[] m_BoxMin;

		private Vector4[] m_ProbePosition;

		private Vector4[] m_MipScaleOffset;

		private Vector4[] m_Rotations;

		private const int k_MaxMipCount = 7;

		private const string k_ReflectionProbeAtlasName = "URP Reflection Probe Atlas";

		public RenderTexture atlasRT => null;

		public RTHandle atlasRTHandle => null;

		public static ReflectionProbeManager Create()
		{
			return default(ReflectionProbeManager);
		}

		private void Init()
		{
		}

		public void UpdateGpuData(CommandBuffer cmd, ref CullingResults cullResults)
		{
		}

		private float4 GetScaleOffset(int level, int dataIndex, bool includePadding, bool yflip)
		{
			return default(float4);
		}

		public void Dispose()
		{
		}
	}
}
