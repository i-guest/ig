using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	internal ref struct BlittableListWrapper
	{
		private BlittableArrayWrapper arrayWrapper;

		private int listSize;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public BlittableListWrapper(BlittableArrayWrapper arrayWrapper, int listSize)
		{
			this.arrayWrapper = default(BlittableArrayWrapper);
			this.listSize = 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Unmarshal<T>(List<T> list) where T : struct
		{
		}
	}
}
