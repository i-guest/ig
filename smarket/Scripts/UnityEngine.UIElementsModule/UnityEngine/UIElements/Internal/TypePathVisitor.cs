using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;

namespace UnityEngine.UIElements.Internal
{
	internal class TypePathVisitor : ITypeVisitor, IPropertyBagVisitor, IPropertyVisitor
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Type _003CresolvedType_003Ek__BackingField;

		private Type m_LastType;

		private int m_PathIndex;

		public PropertyPath Path { get; set; }

		private Type resolvedType
		{
			[CompilerGenerated]
			set
			{
				_003CresolvedType_003Ek__BackingField = value;
			}
		}

		public VisitReturnCode ReturnCode { get; internal set; }

		public void Reset()
		{
		}

		void IPropertyBagVisitor.Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container)
		{
		}

		void IPropertyVisitor.Visit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container)
		{
		}

		void ITypeVisitor.Visit<TContainer>()
		{
		}

		private bool IsLastPartReached()
		{
			return false;
		}

		private static Type GetElementType(Type type)
		{
			return null;
		}
	}
}
