using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace UnityEngine.UIElements
{
	internal class PropagationPaths : IDisposable
	{
		private static readonly ObjectPool<PropagationPaths> s_Pool;

		public readonly List<VisualElement> trickleDownPath;

		public readonly List<VisualElement> bubbleUpPath;

		[NotNull]
		public static PropagationPaths Build(VisualElement elem, EventBase evt, int eventCategories)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
