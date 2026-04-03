using UnityEngine;

namespace Unity.Properties.Internal
{
	internal class Vector4PropertyBag : ContainerPropertyBag<Vector4>
	{
		private class XProperty : Property<Vector4, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Vector4 container)
			{
				return 0f;
			}

			public override void SetValue(ref Vector4 container, float value)
			{
			}
		}

		private class YProperty : Property<Vector4, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Vector4 container)
			{
				return 0f;
			}

			public override void SetValue(ref Vector4 container, float value)
			{
			}
		}

		private class ZProperty : Property<Vector4, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Vector4 container)
			{
				return 0f;
			}

			public override void SetValue(ref Vector4 container, float value)
			{
			}
		}

		private class WProperty : Property<Vector4, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Vector4 container)
			{
				return 0f;
			}

			public override void SetValue(ref Vector4 container, float value)
			{
			}
		}
	}
}
