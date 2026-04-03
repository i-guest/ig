using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public struct BoundsInt : IEquatable<BoundsInt>, IFormattable
	{
		private Vector3Int m_Position;

		private Vector3Int m_Size;

		public Vector3Int position
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector3Int);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector3Int size
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector3Int);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public BoundsInt(Vector3Int position, Vector3Int size)
		{
			m_Position = default(Vector3Int);
			m_Size = default(Vector3Int);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly bool Equals(object other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(BoundsInt other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(in BoundsInt other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly int GetHashCode()
		{
			return 0;
		}
	}
}
