using System;
using UnityEngine.Categorization;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering
{
	public static class STP
	{
		public struct PerViewConfig
		{
			public Matrix4x4 currentProj;

			public Matrix4x4 lastProj;

			public Matrix4x4 lastLastProj;

			public Matrix4x4 currentView;

			public Matrix4x4 lastView;

			public Matrix4x4 lastLastView;
		}

		public struct Config
		{
			public Texture2D noiseTexture;

			public TextureHandle inputColor;

			public TextureHandle inputDepth;

			public TextureHandle inputMotion;

			public TextureHandle inputStencil;

			public TextureHandle debugView;

			public TextureHandle destination;

			public HistoryContext historyContext;

			public bool enableHwDrs;

			public bool enableTexArray;

			public bool enableMotionScaling;

			public float nearPlane;

			public float farPlane;

			public int frameIndex;

			public bool hasValidHistory;

			public int stencilMask;

			public int debugViewIndex;

			public float deltaTime;

			public float lastDeltaTime;

			public Vector2Int currentImageSize;

			public Vector2Int priorImageSize;

			public Vector2Int outputImageSize;

			public int numActiveViews;

			public PerViewConfig[] perViewConfigs;
		}

		internal enum HistoryTextureType
		{
			DepthMotion = 0,
			Luma = 1,
			Convergence = 2,
			Feedback = 3,
			Count = 4
		}

		public struct HistoryUpdateInfo
		{
			public Vector2Int preUpscaleSize;

			public Vector2Int postUpscaleSize;

			public bool useHwDrs;

			public bool useTexArray;
		}

		public sealed class HistoryContext : IDisposable
		{
			private RTHandle[] m_textures;

			private Hash128 m_hash;

			public bool Update(ref HistoryUpdateInfo info)
			{
				return false;
			}

			internal RTHandle GetCurrentHistoryTexture(HistoryTextureType historyType, int frameIndex)
			{
				return null;
			}

			internal RTHandle GetPreviousHistoryTexture(HistoryTextureType historyType, int frameIndex)
			{
				return null;
			}

			public void Dispose()
			{
			}
		}

		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@9a9c0155552c\\Runtime\\STP\\STP.cs")]
		private enum StpSetupPerViewConstants
		{
			Count = 8
		}

		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.core@9a9c0155552c\\Runtime\\STP\\STP.cs", needAccessors = false, generateCBuffer = true)]
		private struct StpConstantBufferData
		{
			public Vector4 _StpCommonConstant;

			public Vector4 _StpSetupConstants0;

			public Vector4 _StpSetupConstants1;

			public Vector4 _StpSetupConstants2;

			public Vector4 _StpSetupConstants3;

			public Vector4 _StpSetupConstants4;

			public Vector4 _StpSetupConstants5;

			[HLSLArray(16, typeof(Vector4))]
			public unsafe fixed float _StpSetupPerViewConstants[64];

			public Vector4 _StpDilConstants0;

			public Vector4 _StpTaaConstants0;

			public Vector4 _StpTaaConstants1;

			public Vector4 _StpTaaConstants2;

			public Vector4 _StpTaaConstants3;
		}

		private static class ShaderResources
		{
			public static readonly int _StpConstantBufferData;

			public static readonly int _StpBlueNoiseIn;

			public static readonly int _StpDebugOut;

			public static readonly int _StpInputColor;

			public static readonly int _StpInputDepth;

			public static readonly int _StpInputMotion;

			public static readonly int _StpInputStencil;

			public static readonly int _StpIntermediateColor;

			public static readonly int _StpIntermediateConvergence;

			public static readonly int _StpIntermediateWeights;

			public static readonly int _StpPriorLuma;

			public static readonly int _StpLuma;

			public static readonly int _StpPriorDepthMotion;

			public static readonly int _StpDepthMotion;

			public static readonly int _StpPriorFeedback;

			public static readonly int _StpFeedback;

			public static readonly int _StpPriorConvergence;

			public static readonly int _StpConvergence;

			public static readonly int _StpOutput;
		}

		private static class ShaderKeywords
		{
			public static readonly string EnableDebugMode;

			public static readonly string EnableLargeKernel;

			public static readonly string EnableStencilResponsive;

			public static readonly string DisableTexture2DXArray;
		}

		[Serializable]
		[SupportedOnRenderPipeline(new Type[] { })]
		[CategoryInfo(Name = "R: STP", Order = 1000)]
		[ElementInfo(Order = 0)]
		[HideInInspector]
		internal class RuntimeResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
		{
			[SerializeField]
			[ResourcePath("Runtime/STP/StpSetup.compute", SearchType.ProjectPath)]
			private ComputeShader m_setupCS;

			[SerializeField]
			[ResourcePath("Runtime/STP/StpPreTaa.compute", SearchType.ProjectPath)]
			private ComputeShader m_preTaaCS;

			[SerializeField]
			[ResourcePath("Runtime/STP/StpTaa.compute", SearchType.ProjectPath)]
			private ComputeShader m_taaCS;

			public int version => 0;

			public ComputeShader setupCS
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ComputeShader preTaaCS
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ComputeShader taaCS
			{
				get
				{
					return null;
				}
				set
				{
				}
			}
		}

		private enum ProfileId
		{
			StpSetup = 0,
			StpPreTaa = 1,
			StpTaa = 2
		}

		private class SetupData
		{
			public ComputeShader cs;

			public int kernelIndex;

			public int viewCount;

			public Vector2Int dispatchSize;

			public StpConstantBufferData constantBufferData;

			public TextureHandle noiseTexture;

			public TextureHandle debugView;

			public TextureHandle inputColor;

			public TextureHandle inputDepth;

			public TextureHandle inputMotion;

			public TextureHandle inputStencil;

			public TextureHandle intermediateColor;

			public TextureHandle intermediateConvergence;

			public TextureHandle priorDepthMotion;

			public TextureHandle depthMotion;

			public TextureHandle priorLuma;

			public TextureHandle luma;

			public TextureHandle priorFeedback;

			public TextureHandle priorConvergence;
		}

		private class PreTaaData
		{
			public ComputeShader cs;

			public int kernelIndex;

			public int viewCount;

			public Vector2Int dispatchSize;

			public TextureHandle noiseTexture;

			public TextureHandle debugView;

			public TextureHandle intermediateConvergence;

			public TextureHandle intermediateWeights;

			public TextureHandle luma;

			public TextureHandle convergence;
		}

		private class TaaData
		{
			public ComputeShader cs;

			public int kernelIndex;

			public int viewCount;

			public Vector2Int dispatchSize;

			public TextureHandle noiseTexture;

			public TextureHandle debugView;

			public TextureHandle intermediateColor;

			public TextureHandle intermediateWeights;

			public TextureHandle priorFeedback;

			public TextureHandle depthMotion;

			public TextureHandle convergence;

			public TextureHandle feedback;

			public TextureHandle output;
		}

		private const int kNumDebugViews = 6;

		private static readonly GUIContent[] s_DebugViewDescriptions;

		private static readonly int[] s_DebugViewIndices;

		private const int kMaxPerViewConfigs = 2;

		private static PerViewConfig[] s_PerViewConfigs;

		private const int kNumHistoryTextureTypes = 4;

		private const int kTotalSetupViewConstantsCount = 16;

		private static readonly int kQualcommVendorId;

		public static GUIContent[] debugViewDescriptions => null;

		public static int[] debugViewIndices => null;

		public static PerViewConfig[] perViewConfigs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool IsSupported()
		{
			return false;
		}

		public static Vector2 Jit16(int frameIndex)
		{
			return default(Vector2);
		}

		private static Hash128 ComputeHistoryHash(ref HistoryUpdateInfo info)
		{
			return default(Hash128);
		}

		private static Vector2Int CalculateConvergenceTextureSize(Vector2Int historyTextureSize)
		{
			return default(Vector2Int);
		}

		private static float CalculateMotionScale(float deltaTime, float lastDeltaTime)
		{
			return 0f;
		}

		private static Matrix4x4 ExtractRotation(Matrix4x4 input)
		{
			return default(Matrix4x4);
		}

		private static int PackVector2ToInt(Vector2 value)
		{
			return 0;
		}

		private static void PopulateConstantData(ref Config config, ref StpConstantBufferData constants)
		{
		}

		private static TextureHandle UseTexture(IBaseRenderGraphBuilder builder, in TextureHandle texture, AccessFlags flags = AccessFlags.Read)
		{
			return default(TextureHandle);
		}

		public static TextureHandle Execute(RenderGraph renderGraph, ref Config config)
		{
			return default(TextureHandle);
		}
	}
}
