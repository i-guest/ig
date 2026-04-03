using Unity.Collections;

namespace UnityEngine.Animations.Rigging
{
	public class WeightedTransformArrayBinder
	{
		public static void BindReadOnlyTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadOnlyTransformHandle> transforms)
		{
			transforms = default(NativeArray<ReadOnlyTransformHandle>);
		}

		public static void BindReadWriteTransforms(Animator animator, Component component, WeightedTransformArray weightedTransformArray, out NativeArray<ReadWriteTransformHandle> transforms)
		{
			transforms = default(NativeArray<ReadWriteTransformHandle>);
		}

		public static void BindWeights(Animator animator, Component component, WeightedTransformArray weightedTransformArray, string name, out NativeArray<PropertyStreamHandle> weights)
		{
			weights = default(NativeArray<PropertyStreamHandle>);
		}
	}
}
