using UnityEngine.Pool;

namespace Unity.Properties
{
	public static class PropertyContainer
	{
		private class GetPropertyVisitor : PathVisitor
		{
			public static readonly ObjectPool<GetPropertyVisitor> Pool;

			public IProperty Property;

			public override void Reset()
			{
			}

			protected override void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
			{
			}
		}

		private class GetValueVisitor<TSrcValue> : PathVisitor
		{
			public static readonly ObjectPool<GetValueVisitor<TSrcValue>> Pool;

			public TSrcValue Value;

			public override void Reset()
			{
			}

			protected override void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
			{
			}
		}

		public static void Accept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, VisitParameters parameters = default(VisitParameters))
		{
		}

		public static bool TryAccept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, VisitParameters parameters = default(VisitParameters))
		{
			return false;
		}

		public static bool TryAccept<TContainer>(IPropertyBagVisitor visitor, ref TContainer container, out VisitReturnCode returnCode, VisitParameters parameters = default(VisitParameters))
		{
			returnCode = default(VisitReturnCode);
			return false;
		}

		public static bool TryGetProperty<TContainer>(ref TContainer container, in PropertyPath path, out IProperty property)
		{
			property = null;
			return false;
		}

		public static bool TryGetProperty<TContainer>(ref TContainer container, in PropertyPath path, out IProperty property, out VisitReturnCode returnCode)
		{
			property = null;
			returnCode = default(VisitReturnCode);
			return false;
		}

		public static bool TryGetValue<TContainer, TValue>(ref TContainer container, string name, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public static bool TryGetValue<TContainer, TValue>(ref TContainer container, in PropertyPath path, out TValue value, out VisitReturnCode returnCode)
		{
			value = default(TValue);
			returnCode = default(VisitReturnCode);
			return false;
		}
	}
}
