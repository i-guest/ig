using System;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal
{
	internal struct AdditionalLightsShadowAtlasLayout
	{
		internal struct ShadowResolutionRequest
		{
			[Flags]
			private enum SettingsOptions : ushort
			{
				None = 0,
				SoftShadow = 1,
				PointLightShadow = 2,
				All = 0xFFFF
			}

			public ushort visibleLightIndex;

			public ushort perLightShadowSliceIndex;

			public ushort requestedResolution;

			public ushort offsetX;

			public ushort offsetY;

			public ushort allocatedResolution;

			private SettingsOptions m_ShadowProperties;

			public bool softShadow
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool pointLightShadow
			{
				get
				{
					return false;
				}
				set
				{
				}
			}
		}

		private static List<RectInt> s_UnusedAtlasSquareAreas;

		private static List<ShadowResolutionRequest> s_ShadowResolutionRequests;

		private static float[] s_VisibleLightIndexToCameraSquareDistance;

		private static Func<ShadowResolutionRequest, ShadowResolutionRequest, int> s_CompareShadowResolutionRequest;

		private static ShadowResolutionRequest[] s_SortedShadowResolutionRequests;

		private NativeArray<ShadowResolutionRequest> m_SortedShadowResolutionRequests;

		private NativeArray<int> m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex;

		private int m_TotalShadowSlicesCount;

		private int m_TotalShadowResolutionRequestCount;

		private bool m_TooManyShadowMaps;

		private int m_ShadowSlicesScaleFactor;

		private int m_AtlasSize;

		public AdditionalLightsShadowAtlasLayout(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData)
		{
			m_SortedShadowResolutionRequests = default(NativeArray<ShadowResolutionRequest>);
			m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex = default(NativeArray<int>);
			m_TotalShadowSlicesCount = 0;
			m_TotalShadowResolutionRequestCount = 0;
			m_TooManyShadowMaps = false;
			m_ShadowSlicesScaleFactor = 0;
			m_AtlasSize = 0;
		}

		public int GetTotalShadowSlicesCount()
		{
			return 0;
		}

		public int GetTotalShadowResolutionRequestCount()
		{
			return 0;
		}

		public bool HasTooManyShadowMaps()
		{
			return false;
		}

		public int GetShadowSlicesScaleFactor()
		{
			return 0;
		}

		public int GetAtlasSize()
		{
			return 0;
		}

		public bool HasSpaceForLight(int originalVisibleLightIndex)
		{
			return false;
		}

		public ShadowResolutionRequest GetSortedShadowResolutionRequest(int sortedShadowResolutionRequestIndex)
		{
			return default(ShadowResolutionRequest);
		}

		public ShadowResolutionRequest GetSliceShadowResolutionRequest(int originalVisibleLightIndex, int sliceIndex)
		{
			return default(ShadowResolutionRequest);
		}

		public static void ClearStaticCaches()
		{
		}

		private static int EstimateScaleFactorNeededToFitAllShadowsInAtlas(in NativeArray<ShadowResolutionRequest> shadowResolutionRequests, int endIndex, int atlasSize)
		{
			return 0;
		}

		private static Func<ShadowResolutionRequest, ShadowResolutionRequest, int> CreateCompareShadowResolutionRequesPredicate()
		{
			return null;
		}
	}
}
