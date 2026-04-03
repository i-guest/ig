using UnityEngine;

namespace Unity.Properties.Internal
{
	internal class Vector2PropertyBag : ContainerPropertyBag<Vector2>
	{
		private class XProperty : Property<Vector2, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Vector2 container)
			{
				return 0f;
			}

			public override void SetValue(ref Vector2 container, float value)
			{
			}
		}

		private class YProperty : Property<Vector2, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Vector2 container)
			{
				return 0f;
			}

			public override void SetValue(ref Vector2 container, float value)
			{
			}
		}
	}
}
