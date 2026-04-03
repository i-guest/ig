using System;
using System.Globalization;

namespace UnityEngine.Localization
{
	[Serializable]
	public struct LocaleIdentifier : IEquatable<LocaleIdentifier>, IComparable<LocaleIdentifier>
	{
		[SerializeField]
		private string m_Code;

		private CultureInfo m_CultureInfo;

		public string Code => null;

		public CultureInfo CultureInfo => null;

		public LocaleIdentifier(string code)
		{
			m_Code = null;
			m_CultureInfo = null;
		}

		public LocaleIdentifier(CultureInfo culture)
		{
			m_Code = null;
			m_CultureInfo = null;
		}

		public LocaleIdentifier(SystemLanguage systemLanguage)
		{
			m_Code = null;
			m_CultureInfo = null;
		}

		public static implicit operator LocaleIdentifier(string code)
		{
			return default(LocaleIdentifier);
		}

		public static implicit operator LocaleIdentifier(CultureInfo culture)
		{
			return default(LocaleIdentifier);
		}

		public static implicit operator LocaleIdentifier(SystemLanguage systemLanguage)
		{
			return default(LocaleIdentifier);
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(LocaleIdentifier other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public int CompareTo(LocaleIdentifier other)
		{
			return 0;
		}

		public static bool operator ==(LocaleIdentifier l1, LocaleIdentifier l2)
		{
			return false;
		}

		public static bool operator !=(LocaleIdentifier l1, LocaleIdentifier l2)
		{
			return false;
		}
	}
}
