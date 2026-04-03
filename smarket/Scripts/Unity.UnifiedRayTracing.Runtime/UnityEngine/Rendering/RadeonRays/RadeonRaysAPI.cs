using System;

namespace UnityEngine.Rendering.RadeonRays
{
	internal class RadeonRaysAPI : IDisposable
	{
		private readonly HlbvhBuilder buildBvh;

		private readonly HlbvhTopLevelBuilder buildTopLevelBvh;

		private readonly RestructureBvh restructureBvh;

		public const GraphicsBuffer.Target BufferTarget = GraphicsBuffer.Target.Structured;

		public RadeonRaysAPI(RadeonRaysShaders shaders)
		{
		}

		public void Dispose()
		{
		}

		public static int BvhInternalNodeSizeInDwords()
		{
			return 0;
		}

		public static int BvhInternalNodeSizeInBytes()
		{
			return 0;
		}

		public static int BvhLeafNodeSizeInBytes()
		{
			return 0;
		}

		public static int BvhLeafNodeSizeInDwords()
		{
			return 0;
		}

		public void BuildMeshAccelStruct(CommandBuffer cmd, MeshBuildInfo buildInfo, BuildFlags buildFlags, GraphicsBuffer scratchBuffer, in BottomLevelLevelAccelStruct result)
		{
		}

		public MeshBuildMemoryRequirements GetMeshBuildMemoryRequirements(MeshBuildInfo buildInfo, BuildFlags buildFlags)
		{
			return default(MeshBuildMemoryRequirements);
		}

		public TopLevelAccelStruct BuildSceneAccelStruct(CommandBuffer cmd, GraphicsBuffer meshAccelStructsBuffer, Instance[] instances, GraphicsBuffer scratchBuffer)
		{
			return default(TopLevelAccelStruct);
		}

		public TopLevelAccelStruct CreateSceneAccelStructBuffers(GraphicsBuffer meshAccelStructsBuffer, uint tlasSizeInDwords, Instance[] instances)
		{
			return default(TopLevelAccelStruct);
		}

		public SceneBuildMemoryRequirements GetSceneBuildMemoryRequirements(uint instanceCount)
		{
			return default(SceneBuildMemoryRequirements);
		}

		public SceneMemoryRequirements GetSceneMemoryRequirements(MeshBuildInfo[] buildInfos, BuildFlags buildFlags)
		{
			return null;
		}

		public static ulong GetTraceMemoryRequirements(uint rayCount)
		{
			return 0uL;
		}
	}
}
