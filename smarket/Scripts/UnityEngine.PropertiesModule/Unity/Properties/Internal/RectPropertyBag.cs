using UnityEngine;

namespace Unity.Properties.Internal
{
	internal class RectPropertyBag : ContainerPropertyBag<Rect>
	{
		private class XProperty : Property<Rect, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Rect container)
			{
				return 0f;
			}

			public override void SetValue(ref Rect container, float value)
			{
			}
		}

		private class YProperty : Property<Rect, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Rect container)
			{
				return 0f;
			}

			public override void SetValue(ref Rect container, float value)
			{
			}
		}

		private class WidthProperty : Property<Rect, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Rect container)
			{
				return 0f;
			}

			public override void SetValue(ref Rect container, float value)
			{
			}
		}

		private class HeightProperty : Property<Rect, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Rect container)
			{
				return 0f;
			}

			public override void SetValue(ref Rect container, float value)
			{
			}
		}
	}
}
