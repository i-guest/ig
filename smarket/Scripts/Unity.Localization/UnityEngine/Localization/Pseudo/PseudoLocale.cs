using System.Collections.Generic;

namespace UnityEngine.Localization.Pseudo
{
	[CreateAssetMenu(menuName = "Localization/Pseudo-Locale", fileName = "Pseudo-Locale(pseudo)")]
	public class PseudoLocale : Locale
	{
		[SerializeReference]
		private List<IPseudoLocalizationMethod> m_Methods;

		public List<IPseudoLocalizationMethod> Methods => null;

		public static PseudoLocale CreatePseudoLocale()
		{
			return null;
		}

		private PseudoLocale()
		{
		}

		internal void Reset()
		{
		}

		public virtual string GetPseudoString(string input)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
