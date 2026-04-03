using UnityEngine;

namespace Unity.Properties.Internal
{
	internal class BoundsIntPropertyBag : ContainerPropertyBag<BoundsInt>
	{
		private class PositionProperty : Property<BoundsInt, Vector3Int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override Vector3Int GetValue(ref BoundsInt container)
			{
				return default(Vector3Int);
			}

			public override void SetValue(ref BoundsInt container, Vector3Int value)
			{
			}
		}

		private class SizeProperty : Property<BoundsInt, Vector3Int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override Vector3Int GetValue(ref BoundsInt container)
			{
				return default(Vector3Int);
			}

			public override void SetValue(ref BoundsInt container, Vector3Int value)
			{
			}
		}
	}
}
