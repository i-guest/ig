using System;
using System.Collections.Generic;

namespace UnityEngine.Localization.Pseudo
{
	[Serializable]
	public class Expander : IPseudoLocalizationMethod
	{
		public enum InsertLocation
		{
			Start = 0,
			End = 1,
			Both = 2
		}

		[Serializable]
		public struct ExpansionRule : IComparable<ExpansionRule>
		{
			[SerializeField]
			private int m_MinCharacters;

			[SerializeField]
			private int m_MaxCharacters;

			[SerializeField]
			private float m_ExpansionAmount;

			public int MinCharacters
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int MaxCharacters
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public float ExpansionAmount
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public ExpansionRule(int minCharacters, int maxCharacters, float expansion)
			{
				m_MinCharacters = 0;
				m_MaxCharacters = 0;
				m_ExpansionAmount = 0f;
			}

			internal bool InRange(int length)
			{
				return false;
			}

			public int CompareTo(ExpansionRule other)
			{
				return 0;
			}
		}

		[SerializeField]
		private List<ExpansionRule> m_ExpansionRules;

		[SerializeField]
		private InsertLocation m_Location;

		[SerializeField]
		private int m_MinimumStringLength;

		[SerializeField]
		private List<char> m_PaddingCharacters;

		public List<ExpansionRule> ExpansionRules => null;

		public InsertLocation Location
		{
			get
			{
				return default(InsertLocation);
			}
			set
			{
			}
		}

		public List<char> PaddingCharacters => null;

		public int MinimumStringLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Expander()
		{
		}

		public Expander(char paddingCharacter)
		{
		}

		public Expander(char start, char end)
		{
		}

		public void AddCharacterRange(char start, char end)
		{
		}

		public void SetConstantExpansion(float expansion)
		{
		}

		public void AddExpansionRule(int minCharacters, int maxCharacters, float expansion)
		{
		}

		internal float GetExpansionForLength(int length)
		{
			return 0f;
		}

		public void Transform(Message message)
		{
		}

		private void AddPaddingToMessage(Message message, char[] padding)
		{
		}

		private int GetRandomSeed(string input)
		{
			return 0;
		}
	}
}
