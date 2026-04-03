using System;

namespace UnityEngine.Rendering
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class SupportedOnRenderPipelineAttribute : Attribute
	{
		public enum SupportedMode
		{
			Unsupported = 0,
			Supported = 1,
			SupportedByBaseClass = 2
		}

		private static readonly Lazy<Type[]> k_DefaultRenderPipelineAsset;

		public Type[] renderPipelineTypes { get; }

		public SupportedOnRenderPipelineAttribute(Type renderPipeline)
		{
		}

		public SupportedOnRenderPipelineAttribute(params Type[] renderPipeline)
		{
		}

		public SupportedMode GetSupportedMode(Type renderPipelineAssetType)
		{
			return default(SupportedMode);
		}

		internal static SupportedMode GetSupportedMode(Type[] renderPipelineTypes, Type renderPipelineAssetType)
		{
			return default(SupportedMode);
		}

		public static bool IsTypeSupportedOnRenderPipeline(Type type, Type renderPipelineAssetType)
		{
			return false;
		}
	}
}
