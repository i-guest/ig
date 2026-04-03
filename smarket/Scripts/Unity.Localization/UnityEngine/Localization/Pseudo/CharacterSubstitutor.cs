using System;
using System.Collections.Generic;

namespace UnityEngine.Localization.Pseudo
{
	[Serializable]
	public class CharacterSubstitutor : IPseudoLocalizationMethod, ISerializationCallbackReceiver
	{
		public enum SubstitutionMethod
		{
			ToUpper = 0,
			ToLower = 1,
			List = 2,
			Map = 3
		}

		[Serializable]
		private struct CharReplacement
		{
			public char original;

			public char replacement;
		}

		public enum ListSelectionMethod
		{
			Random = 0,
			LoopFromPrevious = 1,
			LoopFromStart = 2
		}

		[SerializeField]
		private SubstitutionMethod m_SubstitutionMethod;

		[SerializeField]
		private ListSelectionMethod m_ListMode;

		[SerializeField]
		private List<CharReplacement> m_ReplacementsMap;

		[SerializeField]
		private List<char> m_ReplacementList;

		internal int m_ReplacementsPosition;

		public SubstitutionMethod Method
		{
			get
			{
				return default(SubstitutionMethod);
			}
			set
			{
			}
		}

		public Dictionary<char, char> ReplacementMap { get; private set; }

		public ListSelectionMethod ListMode
		{
			get
			{
				return default(ListSelectionMethod);
			}
			set
			{
			}
		}

		public List<char> ReplacementList => null;

		private int GetRandomSeed(string input)
		{
			return 0;
		}

		internal char ReplaceCharFromMap(char value)
		{
			return '\0';
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		private void TransformFragment(WritableMessageFragment writableFragment)
		{
		}

		public void Transform(Message message)
		{
		}
	}
}
