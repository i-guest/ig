using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsMask : IEnumerable<int>, IEnumerable
	{
		public struct SetBitIterator : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int m_BitIndex;

			private ulong bitMask;

			readonly int IEnumerator<int>.Current => 0;

			readonly object IEnumerator.Current => null;

			public SetBitIterator(PhysicsMask bitMask)
			{
				m_BitIndex = 0;
				this.bitMask = 0uL;
			}

			bool IEnumerator.MoveNext()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}

			public IEnumerator<int> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			readonly void IDisposable.Dispose()
			{
			}
		}

		public ulong bitMask;

		public static readonly PhysicsMask None;

		public static readonly PhysicsMask One;

		public static readonly PhysicsMask All;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator ulong(PhysicsMask bitMask)
		{
			return 0uL;
		}

		public readonly IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		readonly IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public override readonly string ToString()
		{
			return null;
		}
	}
}
