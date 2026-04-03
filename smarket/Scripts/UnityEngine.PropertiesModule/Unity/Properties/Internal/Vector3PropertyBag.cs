using UnityEngine;

namespace Unity.Properties.Internal
{
	internal class Vector3PropertyBag : ContainerPropertyBag<Vector3>
	{
		private class XProperty : Property<Vector3, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Vector3 container)
			{
				return 0f;
			}

			public override void SetValue(ref Vector3 container, float value)
			{
			}
		}

		private class YProperty : Property<Vector3, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Vector3 container)
			{
				return 0f;
			}

			public override void SetValue(ref Vector3 container, float value)
			{
			}
		}

		private class ZProperty : Property<Vector3, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Vector3 container)
			{
				return 0f;
			}

			public override void SetValue(ref Vector3 container, float value)
			{
			}
		}
	}
}
