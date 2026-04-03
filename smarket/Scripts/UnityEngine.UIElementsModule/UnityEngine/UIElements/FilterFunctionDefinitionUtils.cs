namespace UnityEngine.UIElements
{
	internal static class FilterFunctionDefinitionUtils
	{
		private static FilterFunctionDefinition s_BlurDef;

		private static FilterFunctionDefinition s_TintDef;

		private static FilterFunctionDefinition s_OpacityDef;

		private static FilterFunctionDefinition s_InvertDef;

		private static FilterFunctionDefinition s_GrayscaleDef;

		private static FilterFunctionDefinition s_SepiaDef;

		private static FilterFunctionDefinition s_ContrastDef;

		private static FilterFunctionDefinition s_HueRotateDef;

		public static string GetBuiltinFilterName(FilterFunctionType type)
		{
			return null;
		}

		public static FilterFunctionDefinition GetBuiltinDefinition(FilterFunctionType type)
		{
			return null;
		}

		private static FilterFunctionDefinition CreateBlurFilterFunctionDefinition()
		{
			return null;
		}

		private static FilterFunctionDefinition CreateColorEffectFilterFunctionDefinition(FilterFunctionType filterType)
		{
			return null;
		}

		private static PostProcessingMargins ComputeHorizontalBlurMargins(FilterFunction func)
		{
			return default(PostProcessingMargins);
		}

		private static PostProcessingMargins ComputeVerticalBlurMargins(FilterFunction func)
		{
			return default(PostProcessingMargins);
		}

		private static void ApplySettings(MaterialPropertyBlock mpb, FilterPassContext context)
		{
		}
	}
}
