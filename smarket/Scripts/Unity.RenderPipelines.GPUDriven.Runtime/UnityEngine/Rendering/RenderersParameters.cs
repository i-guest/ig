using System;

namespace UnityEngine.Rendering
{
	internal struct RenderersParameters
	{
		[Flags]
		public enum Flags
		{
			None = 0,
			UseBoundingSphereParameter = 1
		}

		public static class ParamNames
		{
			public static readonly int _BaseColor;

			public static readonly int unity_SpecCube0_HDR;

			public static readonly int unity_SHCoefficients;

			public static readonly int unity_LightmapST;

			public static readonly int unity_ObjectToWorld;

			public static readonly int unity_WorldToObject;

			public static readonly int unity_MatrixPreviousM;

			public static readonly int unity_MatrixPreviousMI;

			public static readonly int unity_WorldBoundingSphere;

			public static readonly int unity_RendererUserValuesPropertyEntry;

			public static readonly int[] DOTS_ST_WindParams;

			public static readonly int[] DOTS_ST_WindHistoryParams;

			static ParamNames()
			{
			}
		}

		public struct ParamInfo
		{
			public int index;

			public int gpuAddress;

			public int uintOffset;

			public bool valid => false;
		}

		private static int s_uintSize;

		public ParamInfo lightmapScale;

		public ParamInfo localToWorld;

		public ParamInfo worldToLocal;

		public ParamInfo matrixPreviousM;

		public ParamInfo matrixPreviousMI;

		public ParamInfo shCoefficients;

		public ParamInfo rendererUserValues;

		public ParamInfo boundingSphere;

		public ParamInfo[] windParams;

		public ParamInfo[] windHistoryParams;

		public static GPUInstanceDataBuffer CreateInstanceDataBuffer(Flags flags, in InstanceNumInfo instanceNumInfo)
		{
			return null;
		}

		public RenderersParameters(in GPUInstanceDataBuffer instanceDataBuffer)
		{
			lightmapScale = default(ParamInfo);
			localToWorld = default(ParamInfo);
			worldToLocal = default(ParamInfo);
			matrixPreviousM = default(ParamInfo);
			matrixPreviousMI = default(ParamInfo);
			shCoefficients = default(ParamInfo);
			rendererUserValues = default(ParamInfo);
			boundingSphere = default(ParamInfo);
			windParams = null;
			windHistoryParams = null;
		}
	}
}
