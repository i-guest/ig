using UnityEngine;

namespace Unity.Properties.Internal
{
	internal class RectIntPropertyBag : ContainerPropertyBag<RectInt>
	{
		private class XProperty : Property<RectInt, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref RectInt container)
			{
				return 0;
			}

			public override void SetValue(ref RectInt container, int value)
			{
			}
		}

		private class YProperty : Property<RectInt, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref RectInt container)
			{
				return 0;
			}

			public override void SetValue(ref RectInt container, int value)
			{
			}
		}

		private class WidthProperty : Property<RectInt, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref RectInt container)
			{
				return 0;
			}

			public override void SetValue(ref RectInt container, int value)
			{
			}
		}

		private class HeightProperty : Property<RectInt, int>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override int GetValue(ref RectInt container)
			{
				return 0;
			}

			public override void SetValue(ref RectInt container, int value)
			{
			}
		}
	}
}
