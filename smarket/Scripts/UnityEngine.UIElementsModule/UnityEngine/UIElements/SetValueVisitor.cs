using Unity.Properties;
using UnityEngine.Pool;

namespace UnityEngine.UIElements
{
	internal class SetValueVisitor<TSrcValue> : PathVisitor
	{
		public static readonly UnityEngine.Pool.ObjectPool<SetValueVisitor<TSrcValue>> Pool;

		public TSrcValue Value;

		public ConverterGroup group { get; set; }

		public override void Reset()
		{
		}

		protected override void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
		{
		}
	}
}
