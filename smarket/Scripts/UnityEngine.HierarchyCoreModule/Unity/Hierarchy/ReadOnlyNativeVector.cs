using System;
using System.Runtime.CompilerServices;

namespace Unity.Hierarchy
{
	internal readonly struct ReadOnlyNativeVector<T> where T : struct
	{
		private readonly IntPtr m_Ptr;

		private readonly int m_Count;

		public int Count
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
		}

		public ref readonly T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}

		public ReadOnlyNativeVector(IntPtr ptr, int size)
		{
			m_Ptr = (IntPtr)0;
			m_Count = 0;
		}
	}
}
