using System;
using Unity.Burst;
using Unity.Collections;

namespace UnityEngine.Animations.Rigging
{
	[BurstCompile]
	internal struct RigSyncSceneToStreamJob : IAnimationJob
	{
		public struct TransformSyncer : IDisposable
		{
			public NativeArray<TransformSceneHandle> sceneHandles;

			public NativeArray<TransformStreamHandle> streamHandles;

			public static TransformSyncer Create(int size)
			{
				return default(TransformSyncer);
			}

			public void Dispose()
			{
			}

			public void BindAt(int index, Animator animator, Transform transform)
			{
			}

			public void Sync(ref AnimationStream stream)
			{
			}
		}

		internal struct PropertySyncer : IDisposable
		{
			public NativeArray<PropertySceneHandle> sceneHandles;

			public NativeArray<PropertyStreamHandle> streamHandles;

			public NativeArray<float> buffer;

			public static PropertySyncer Create(int size)
			{
				return default(PropertySyncer);
			}

			public void Dispose()
			{
			}

			public void BindAt(int index, Animator animator, Component component, string property)
			{
			}

			public void Sync(ref AnimationStream stream)
			{
			}

			public NativeArray<float> StreamValues(ref AnimationStream stream)
			{
				return default(NativeArray<float>);
			}
		}

		public TransformSyncer transformSyncer;

		public PropertySyncer propertySyncer;

		public PropertySyncer rigWeightSyncer;

		public PropertySyncer constraintWeightSyncer;

		public NativeArray<float> rigStates;

		public NativeArray<int> rigConstraintEndIdx;

		public NativeArray<PropertyStreamHandle> modulatedConstraintWeights;

		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		public void ProcessAnimation(AnimationStream stream)
		{
		}
	}
}
