using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.Layout
{
	[Serializable]
	internal struct FixedBuffer2<T> where T : struct
	{
		[SerializeField]
		private T __0;

		[SerializeField]
		private T __1;

		public ref T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}
	}
}
