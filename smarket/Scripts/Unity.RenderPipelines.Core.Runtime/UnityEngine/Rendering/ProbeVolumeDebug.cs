using System;

namespace UnityEngine.Rendering
{
	internal class ProbeVolumeDebug : IDebugData
	{
		public bool drawProbes;

		public bool drawBricks;

		public bool drawCells;

		public bool realtimeSubdivision;

		public int subdivisionCellUpdatePerFrame;

		public float subdivisionDelayInSeconds;

		public DebugProbeShadingMode probeShading;

		public float probeSize;

		public float subdivisionViewCullingDistance;

		public float probeCullingDistance;

		public int maxSubdivToVisualize;

		public int minSubdivToVisualize;

		public float exposureCompensation;

		public bool drawProbeSamplingDebug;

		public float probeSamplingDebugSize;

		public bool debugWithSamplingNoise;

		public uint samplingRenderingLayer;

		public bool drawVirtualOffsetPush;

		public float offsetSize;

		public bool freezeStreaming;

		public bool displayCellStreamingScore;

		public bool displayIndexFragmentation;

		public int otherStateIndex;

		public bool verboseStreamingLog;

		public bool debugStreaming;

		public bool autoDrawProbes;

		public bool isolationProbeDebug;

		public byte visibleLayers;

		public static Vector3 currentOffset;

		internal static int s_ActiveAdjustmentVolumes;

		private void Init()
		{
		}

		public Action GetReset()
		{
			return null;
		}
	}
}
