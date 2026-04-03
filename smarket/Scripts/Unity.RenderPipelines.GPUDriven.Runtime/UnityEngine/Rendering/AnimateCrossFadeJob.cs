using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	[BurstCompile(DisableSafetyChecks = true, OptimizeFor = OptimizeFor.Performance)]
	internal struct AnimateCrossFadeJob : IJobParallelFor
	{
		public const int k_BatchSize = 512;

		public const byte k_MeshLODTransitionToLowerLODBit = 128;

		private const byte k_LODFadeOff = 255;

		private const float k_CrossfadeAnimationTimeS = 0.333f;

		[ReadOnly]
		public float deltaTime;

		public UnsafeList<byte> crossFadeArray;

		public void Execute(int instanceIndex)
		{
		}
	}
}
