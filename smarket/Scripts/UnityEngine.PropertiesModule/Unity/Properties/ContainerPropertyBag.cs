using System.Collections.Generic;

namespace Unity.Properties
{
	public abstract class ContainerPropertyBag<TContainer> : PropertyBag<TContainer>, INamedProperties<TContainer>
	{
		private readonly List<IProperty<TContainer>> m_PropertiesList;

		private readonly Dictionary<string, IProperty<TContainer>> m_PropertiesHash;

		static ContainerPropertyBag()
		{
		}

		protected void AddProperty<TValue>(Property<TContainer, TValue> property)
		{
		}

		public override PropertyCollection<TContainer> GetProperties()
		{
			return default(PropertyCollection<TContainer>);
		}

		public override PropertyCollection<TContainer> GetProperties(ref TContainer container)
		{
			return default(PropertyCollection<TContainer>);
		}

		public bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property)
		{
			property = null;
			return false;
		}
	}
}
