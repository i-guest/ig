using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[Serializable]
	[UsedByNativeCode]
	[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule", "UnityEditor.TextCoreTextEngineModule" })]
	internal struct LigatureSubstitutionRecord : IEquatable<LigatureSubstitutionRecord>
	{
		[NativeName("componentGlyphs")]
		[SerializeField]
		private uint[] m_ComponentGlyphIDs;

		[NativeName("ligatureGlyph")]
		[SerializeField]
		private uint m_LigatureGlyphID;

		public uint[] componentGlyphIDs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint ligatureGlyphID
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public bool Equals(LigatureSubstitutionRecord other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs)
		{
			return false;
		}
	}
}
