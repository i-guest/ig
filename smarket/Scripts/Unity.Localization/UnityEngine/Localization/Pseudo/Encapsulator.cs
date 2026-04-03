using System;

namespace UnityEngine.Localization.Pseudo
{
	[Serializable]
	public class Encapsulator : IPseudoLocalizationMethod
	{
		[SerializeField]
		private string m_Start;

		[SerializeField]
		private string m_End;

		public string Start
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string End
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Transform(Message message)
		{
		}
	}
}
