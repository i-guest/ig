using Unity.Collections;
using UnityEngine.Jobs;
using UnityEngine.Scripting;

namespace UnityEngine.LowLevelPhysics2D
{
	[RequiredByNativeCode(GenerateProxy = true)]
	internal readonly struct PhysicsNativeMethods
	{
		private struct FastWriteTransformsJob : IJobParallelForTransform
		{
			public NativeArray<PhysicsBody.TransformWriteTween> TransformWriteTweens;

			[ReadOnly]
			public PhysicsWorld.TransformPlane TransformPlane;

			[ReadOnly]
			public bool TransformTweening;

			public void Execute(int index, TransformAccess transform)
			{
			}
		}

		private struct Slow3DWriteTransformsJob : IJobParallelForTransform
		{
			public NativeArray<PhysicsBody.TransformWriteTween> TransformWriteTweens;

			[ReadOnly]
			public PhysicsWorld.TransformPlane TransformPlane;

			[ReadOnly]
			public bool TransformTweening;

			public void Execute(int index, TransformAccess transform)
			{
			}
		}

		private struct WriteTransformTweensJob : IJobParallelForTransform
		{
			[ReadOnly]
			public NativeArray<PhysicsBody.TransformWriteTween> TransformWriteTweens;

			[ReadOnly]
			public PhysicsWorld.TransformWriteMode TransformWriteMode;

			[ReadOnly]
			public PhysicsWorld.TransformPlane TransformPlane;

			[ReadOnly]
			public float InterpolationTime;

			[ReadOnly]
			public float ExtrapolationTime;

			public void Execute(int index, TransformAccess transform)
			{
			}
		}

		private static TransformAccessArray[] s_WorldTransformAccessArrays;

		[RequiredByNativeCode]
		private static void CreateWorldTransformAccessArray(PhysicsWorld world, int capacity, int desiredJobCount)
		{
		}

		[RequiredByNativeCode]
		private static void DestroyWorldTransformAccessArray(PhysicsWorld world)
		{
		}

		private static TransformAccessArray GetWorldTransformAccessArray(PhysicsWorld world)
		{
			return default(TransformAccessArray);
		}

		[RequiredByNativeCode]
		private static void WriteWorldTransforms(PhysicsWorld world, PhysicsWorld.TransformWriteMode transformWriteMode, PhysicsWorld.TransformPlane transformPlane, int eventCount, bool transformTweening)
		{
		}

		[RequiredByNativeCode]
		private static void WriteTransformTweens(PhysicsWorld world, double lastSimulationTimestamp, float lastSimulationDeltaTime, PhysicsWorld.TransformWriteMode transformWriteMode, PhysicsWorld.TransformPlane transformPlane, PhysicsLowLevelScripting2D.PhysicsBuffer transformWriteTweensBuffer)
		{
		}
	}
}
