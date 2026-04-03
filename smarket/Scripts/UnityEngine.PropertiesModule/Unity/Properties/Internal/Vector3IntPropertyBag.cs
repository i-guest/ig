using UnityEngine;

namespace Unity.Properties.Internal
{
	internal class Vector3IntPropertyBag : ContainerPropertyBag<Vector3Int>
	{
		private class XProperty : Property<Vector3Int, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref Vector3Int container)
			{
				return 0;
			}

			public override void SetValue(ref Vector3Int container, int value)
			{
			}
		}

		private class YProperty : Property<Vector3Int, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref Vector3Int container)
			{
				return 0;
			}

			public override void SetValue(ref Vector3Int container, int value)
			{
			}
		}

		private class ZProperty : Property<Vector3Int, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref Vector3Int container)
			{
				return 0;
			}

			public override void SetValue(ref Vector3Int container, int value)
			{
			}
		}
	}
}
