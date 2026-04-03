using System;

namespace Unity.Properties
{
	public interface IProperty
	{
		string Name { get; }

		Type DeclaredValueType();
	}
	public interface IProperty<TContainer> : IProperty, IPropertyAccept<TContainer>
	{
	}
}
