using System;

namespace UnityEngine.UIElements
{
	[Obsolete("IUxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public interface IBaseUxmlFactory
	{
		string uxmlQualifiedName { get; }

		Type uxmlType { get; }

		bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
	}
}
