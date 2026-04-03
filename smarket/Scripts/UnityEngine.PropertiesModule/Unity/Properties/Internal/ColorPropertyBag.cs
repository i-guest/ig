using UnityEngine;

namespace Unity.Properties.Internal
{
	internal class ColorPropertyBag : ContainerPropertyBag<Color>
	{
		private class RProperty : Property<Color, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Color container)
			{
				return 0f;
			}

			public override void SetValue(ref Color container, float value)
			{
			}
		}

		private class GProperty : Property<Color, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Color container)
			{
				return 0f;
			}

			public override void SetValue(ref Color container, float value)
			{
			}
		}

		private class BProperty : Property<Color, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Color container)
			{
				return 0f;
			}

			public override void SetValue(ref Color container, float value)
			{
			}
		}

		private class AProperty : Property<Color, float>
		{
			public override string Name => null;

			public override bool IsReadOnly => false;

			public override float GetValue(ref Color container)
			{
				return 0f;
			}

			public override void SetValue(ref Color container, float value)
			{
			}
		}
	}
}
