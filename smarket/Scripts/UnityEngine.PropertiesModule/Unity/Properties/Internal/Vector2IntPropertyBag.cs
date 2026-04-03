using UnityEngine;

namespace Unity.Properties.Internal
{
	internal class Vector2IntPropertyBag : ContainerPropertyBag<Vector2Int>
	{
		private class XProperty : Property<Vector2Int, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref Vector2Int container)
			{
				return 0;
			}

			public override void SetValue(ref Vector2Int container, int value)
			{
			}
		}

		private class YProperty : Property<Vector2Int, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref Vector2Int container)
			{
				return 0;
			}

			public override void SetValue(ref Vector2Int container, int value)
			{
			}
		}
	}
}
