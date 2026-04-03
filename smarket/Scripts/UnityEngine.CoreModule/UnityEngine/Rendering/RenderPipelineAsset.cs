using System;

namespace UnityEngine.Rendering
{
	public abstract class RenderPipelineAsset : ScriptableObject
	{
		public virtual Material defaultMaterial => null;

		public virtual Shader autodeskInteractiveShader => null;

		public virtual Shader autodeskInteractiveTransparentShader => null;

		public virtual Shader autodeskInteractiveMaskedShader => null;

		public virtual Shader terrainDetailLitShader => null;

		public virtual Shader terrainDetailGrassShader => null;

		public virtual Shader terrainDetailGrassBillboardShader => null;

		public virtual Material defaultParticleMaterial => null;

		public virtual Material defaultLineMaterial => null;

		public virtual Material defaultTerrainMaterial => null;

		public virtual Material defaultUIMaterial => null;

		public virtual Material defaultUIOverdrawMaterial => null;

		public virtual Material defaultUIETC1SupportedMaterial => null;

		public virtual Material default2DMaterial => null;

		public virtual Material default2DMaskMaterial => null;

		public virtual Shader defaultShader => null;

		public virtual Shader defaultSpeedTree7Shader => null;

		public virtual Shader defaultSpeedTree8Shader => null;

		public virtual Shader defaultSpeedTree9Shader => null;

		public virtual string renderPipelineShaderTag => null;

		public virtual Type pipelineType => null;

		internal string pipelineTypeFullName => null;

		protected internal virtual bool requiresCompatibleRenderPipelineGlobalSettings { get; }

		[Obsolete("This property is obsolete. Use pipelineType instead. #from(23.2)", false)]
		protected internal virtual Type renderPipelineType => null;

		[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(23.3)", false)]
		public virtual string[] renderingLayerMaskNames => null;

		[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(23.3)", false)]
		public virtual string[] prefixedRenderingLayerMaskNames => null;

		internal RenderPipeline InternalCreatePipeline()
		{
			return null;
		}

		protected abstract RenderPipeline CreatePipeline();

		protected virtual void EnsureGlobalSettings()
		{
		}

		protected virtual void OnValidate()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
	public abstract class RenderPipelineAsset<TRenderPipeline> : RenderPipelineAsset where TRenderPipeline : RenderPipeline
	{
		public sealed override Type pipelineType => null;

		public override string renderPipelineShaderTag => null;

		[Obsolete("This property is obsolete. Use pipelineType instead. #from(23.2)", false)]
		protected internal sealed override Type renderPipelineType => null;
	}
}
