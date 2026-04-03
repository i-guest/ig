using Unity.Properties;

namespace UnityEngine.UIElements
{
	internal class StyleValuePropertyBag<TContainer, TValue> : ContainerPropertyBag<TContainer> where TContainer : IStyleValue<TValue>
	{
		private class ValueProperty : Property<TContainer, TValue>
		{
			public override string Name { get; }

			public override bool IsReadOnly { get; }

			public override TValue GetValue(ref TContainer container)
			{
				return default(TValue);
			}

			public override void SetValue(ref TContainer container, TValue value)
			{
			}
		}

		private class KeywordProperty : Property<TContainer, StyleKeyword>
		{
			public override string Name { get; }

			public override bool IsReadOnly { get; }

			public override StyleKeyword GetValue(ref TContainer container)
			{
				return default(StyleKeyword);
			}

			public override void SetValue(ref TContainer container, StyleKeyword value)
			{
			}
		}
	}
}
