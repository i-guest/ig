using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	public class UnicodeLineBreakingRules
	{
		[SerializeField]
		private UnityEngine.TextAsset m_UnicodeLineBreakingRules;

		[SerializeField]
		private UnityEngine.TextAsset m_LeadingCharacters;

		[SerializeField]
		private UnityEngine.TextAsset m_FollowingCharacters;

		[SerializeField]
		private bool m_UseModernHangulLineBreakingRules;

		private HashSet<uint> m_LeadingCharactersLookup;

		private HashSet<uint> m_FollowingCharactersLookup;

		internal HashSet<uint> leadingCharactersLookup => null;

		internal HashSet<uint> followingCharactersLookup => null;

		public bool useModernHangulLineBreakingRules => false;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal void LoadLineBreakingRules()
		{
		}

		private static HashSet<uint> GetCharacters(UnityEngine.TextAsset file)
		{
			return null;
		}
	}
}
