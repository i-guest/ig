using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.Layout
{
	[Serializable]
	internal struct FixedBuffer9<T> where T : struct
	{
		[SerializeField]
		private T __0;

		[SerializeField]
		private T __1;

		[SerializeField]
		private T __2;

		[SerializeField]
		private T __3;

		[SerializeField]
		private T __4;

		[SerializeField]
		private T __5;

		[SerializeField]
		private T __6;

		[SerializeField]
		private T __7;

		[SerializeField]
		private T __8;

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
