using System;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Serializable]
	public class ProviderLoadRequestOptions
	{
		[SerializeField]
		private bool m_IgnoreFailures;

		private int m_WebRequestTimeout;

		public bool IgnoreFailures
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int WebRequestTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ProviderLoadRequestOptions Copy()
		{
			return null;
		}
	}
}
