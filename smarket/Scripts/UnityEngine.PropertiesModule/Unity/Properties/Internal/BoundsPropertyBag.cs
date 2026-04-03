using UnityEngine;

namespace Unity.Properties.Internal
{
	internal class BoundsPropertyBag : ContainerPropertyBag<Bounds>
	{
		private class CenterProperty : Property<Bounds, Vector3>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override Vector3 GetValue(ref Bounds container)
			{
				return default(Vector3);
			}

			public override void SetValue(ref Bounds container, Vector3 value)
			{
			}
		}

		private class ExtentsProperty : Property<Bounds, Vector3>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override Vector3 GetValue(ref Bounds container)
			{
				return default(Vector3);
			}

			public override void SetValue(ref Bounds container, Vector3 value)
			{
			}
		}
	}
}
