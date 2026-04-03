using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct ParameterBinding
	{
		[DontCreateProperty]
		[SerializeField]
		private int m_Index;

		[SerializeField]
		[DontCreateProperty]
		private string m_Name;

		[CreateProperty]
		public int index
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
		public string name
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
