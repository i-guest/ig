using System;

namespace UnityEngine.Localization.Pseudo
{
	[Serializable]
	public class PreserveTags : IPseudoLocalizationMethod
	{
		[SerializeField]
		private char m_Opening;

		[SerializeField]
		private char m_Closing;

		public char Opening
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		public char Closing
		{
			get
			{
				return '\0';
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
