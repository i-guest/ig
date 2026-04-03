using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	public abstract class ScriptableRenderPass : IRenderGraphRecorder
	{
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public static RTHandle k_CameraTarget;

		private RenderBufferStoreAction[] m_ColorStoreActions;

		private RenderBufferStoreAction m_DepthStoreAction;

		private bool[] m_OverriddenColorStoreActions;

		private bool m_OverriddenDepthStoreAction;

		private ProfilingSampler m_ProfingSampler;

		private string m_PassName;

		private RenderGraphSettings m_RenderGraphSettings;

		internal NativeArray<int> m_ColorAttachmentIndices;

		internal NativeArray<int> m_InputAttachmentIndices;

		private RTHandle[] m_ColorAttachments;

		internal RTHandle[] m_InputAttachments;

		internal bool[] m_InputAttachmentIsTransient;

		private RTHandle m_DepthAttachment;

		private ScriptableRenderPassInput m_Input;

		private ClearFlag m_ClearFlag;

		private Color m_ClearColor;

		public RenderPassEvent renderPassEvent { get; set; }

		[Obsolete("Use colorAttachmentHandles. #from(2022.1) #breakingFrom(2023.2)", true)]
		public RenderTargetIdentifier[] colorAttachments => null;

		[Obsolete("Use colorAttachmentHandle. #from(2022.1) #breakingFrom(2023.2)", true)]
		public RenderTargetIdentifier[] colorAttachment => null;

		[Obsolete("Use depthAttachmentHandle. #from(2022.1) #breakingFrom(2023.2)", true)]
		public RenderTargetIdentifier depthAttachment => default(RenderTargetIdentifier);

		public RTHandle[] colorAttachmentHandles => null;

		public RTHandle colorAttachmentHandle => null;

		public RTHandle depthAttachmentHandle => null;

		public RenderBufferStoreAction[] colorStoreActions => null;

		public RenderBufferStoreAction depthStoreAction => default(RenderBufferStoreAction);

		internal bool[] overriddenColorStoreActions => null;

		internal bool overriddenDepthStoreAction => false;

		public ScriptableRenderPassInput input => default(ScriptableRenderPassInput);

		public ClearFlag clearFlag => default(ClearFlag);

		public Color clearColor => default(Color);

		public bool requiresIntermediateTexture { get; set; }

		protected internal ProfilingSampler profilingSampler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected internal string passName => null;

		internal bool isBlitRenderPass { get; set; }

		internal bool useNativeRenderPass { get; set; }

		internal int renderPassQueueIndex { get; set; }

		internal GraphicsFormat[] renderTargetFormat { get; set; }

		internal bool overrideCameraTarget { get; set; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void FrameCleanup(CommandBuffer cmd)
		{
		}

		internal static DebugHandler GetActiveDebugHandler(UniversalCameraData cameraData)
		{
			return null;
		}

		public ScriptableRenderPass()
		{
		}

		public void ConfigureInput(ScriptableRenderPassInput passInput)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0u)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void ConfigureColorStoreActions(RenderBufferStoreAction[] storeActions)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal void ConfigureInputAttachments(RTHandle input, bool isTransient = false)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal void ConfigureInputAttachments(RTHandle[] inputs)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal void ConfigureInputAttachments(RTHandle[] inputs, bool[] isTransient)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal void SetInputAttachmentTransient(int idx, bool isTransient)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal bool IsInputAttachmentTransient(int idx)
		{
			return false;
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void ResetTarget()
		{
		}

		[Obsolete("Use RTHandles for colorAttachment and depthAttachment. #from(2022.1) #breakingFrom(2023.1)", true)]
		public void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void ConfigureTarget(RTHandle colorAttachment, RTHandle depthAttachment)
		{
		}

		[Obsolete("Use RTHandles for colorAttachments and depthAttachment. #from(2022.1) #breakingFrom(2023.1)", true)]
		public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		internal void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment, GraphicsFormat[] formats)
		{
		}

		[Obsolete("Use RTHandle for colorAttachment. #from(2022.1) #breakingFrom(2023.1)", true)]
		public void ConfigureTarget(RenderTargetIdentifier colorAttachment)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void ConfigureTarget(RTHandle colorAttachment)
		{
		}

		[Obsolete("Use RTHandles for colorAttachments. #from(2022.1) #breakingFrom(2023.1)", true)]
		public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void ConfigureTarget(RTHandle[] colorAttachments)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void ConfigureClear(ClearFlag clearFlag, Color clearColor)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public virtual void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public virtual void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		[Obsolete("Use RTHandles for source and destination. #from(2022.1) #breakingFrom(2023.1)", true)]
		public void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material = null, int passIndex = 0)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void Blit(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material = null, int passIndex = 0)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0)
		{
		}

		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)")]
		public void Blit(CommandBuffer cmd, ref RenderingData data, RTHandle source, Material material, int passIndex = 0)
		{
		}

		public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public static bool operator <(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			return false;
		}

		public static bool operator >(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			return false;
		}

		internal static int GetRenderPassEventRange(RenderPassEvent renderPassEvent)
		{
			return 0;
		}
	}
}
