using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct PostProcessingPass
	{
		[Obsolete("This delegate will be removed. Use ApplyFilterPassSettingsDelegate instead.")]
		public delegate void PrepareMaterialPropertyBlockDelegate(MaterialPropertyBlock mpb, FilterFunction func);

		public delegate void ApplyFilterPassSettingsDelegate(MaterialPropertyBlock mpb, FilterPassContext context);

		public delegate PostProcessingMargins ComputeRequiredMarginsDelegate(FilterFunction func);

		[DontCreateProperty]
		[SerializeField]
		private Material m_Material;

		[DontCreateProperty]
		[SerializeField]
		private int m_PassIndex;

		[DontCreateProperty]
		[SerializeField]
		private ParameterBinding[] m_ParameterBindings;

		[SerializeField]
		private PostProcessingMargins m_ReadMargins;

		[SerializeField]
		[DontCreateProperty]
		private PostProcessingMargins m_WriteMargins;

		[CreateProperty]
		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CreateProperty]
		public int passIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreateProperty]
		public ParameterBinding[] parameterBindings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal PostProcessingMargins readMargins
		{
			get
			{
				return default(PostProcessingMargins);
			}
			set
			{
			}
		}

		[CreateProperty]
		public PostProcessingMargins writeMargins
		{
			get
			{
				return default(PostProcessingMargins);
			}
			set
			{
			}
		}

		[Obsolete("This property will be removed. Use applySettingsCallback instead, which provides additional contextual information.")]
		public PrepareMaterialPropertyBlockDelegate prepareMaterialPropertyBlockCallback { get; }

		public ApplyFilterPassSettingsDelegate applySettingsCallback { get; set; }

		public ComputeRequiredMarginsDelegate computeRequiredReadMarginsCallback { get; set; }

		public ComputeRequiredMarginsDelegate computeRequiredWriteMarginsCallback { get; set; }
	}
}
