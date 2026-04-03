using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.RenderGraphModule
{
	internal readonly struct ResourceHandle : IEquatable<ResourceHandle>
	{
		private const uint kValidityMask = 4294901760u;

		private const uint kIndexMask = 65535u;

		private readonly uint m_Value;

		private readonly int m_Version;

		private readonly RenderGraphResourceType m_Type;

		private static uint s_CurrentValidBit;

		private static uint s_SharedResourceValidBit;

		public int index
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
		}

		public int iType
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
		}

		public int version
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
		}

		public RenderGraphResourceType type
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(RenderGraphResourceType);
			}
		}

		public bool IsVersioned
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		internal ResourceHandle(int value, RenderGraphResourceType type, bool shared)
		{
			m_Value = 0u;
			m_Version = 0;
			m_Type = default(RenderGraphResourceType);
		}

		internal ResourceHandle(in ResourceHandle h, int version)
		{
			m_Value = 0u;
			m_Version = 0;
			m_Type = default(RenderGraphResourceType);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsValid()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsNull()
		{
			return false;
		}

		public static void NewFrame(int executionIndex)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(ResourceHandle hdl)
		{
			return false;
		}
	}
}
