using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	[HelpURL("ui-systems/custom-filters")]
	public sealed class FilterFunctionDefinition : ScriptableObject
	{
		[SerializeField]
		[DontCreateProperty]
		private string m_FilterName;

		[SerializeField]
		[DontCreateProperty]
		private FilterParameterDeclaration[] m_Parameters;

		[DontCreateProperty]
		[SerializeField]
		private PostProcessingPass[] m_Passes;

		[CreateProperty]
		public string filterName
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
		public FilterParameterDeclaration[] parameters
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
		public PostProcessingPass[] passes
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
}
