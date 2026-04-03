using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.Layout
{
	[Serializable]
	internal struct FixedBuffer4<T> where T : struct
	{
		[SerializeField]
		private T __0;

		[SerializeField]
		private T __1;

		[SerializeField]
		private T __2;

		[SerializeField]
		private T __3;

		public const int Length = 4;

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
