using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace UnityEngine.Rendering
{
	public static class RemoveRangeExtensions
	{
		[CollectionAccess(CollectionAccessType.ModifyExistingContent)]
		[MustUseReturnValue]
		public static bool TryRemoveElementsInRange<TValue>([DisallowNull] this IList<TValue> list, int index, int count, [NotNullWhen(false)] out Exception error)
		{
			error = null;
			return false;
		}
	}
}
