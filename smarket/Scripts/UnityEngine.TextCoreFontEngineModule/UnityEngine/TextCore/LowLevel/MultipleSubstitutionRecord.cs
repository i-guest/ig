using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[Serializable]
	[UsedByNativeCode]
	[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
	internal struct MultipleSubstitutionRecord
	{
		[NativeName("targetGlyphID")]
		[SerializeField]
		private uint m_TargetGlyphID;

		[NativeName("substituteGlyphIDs")]
		[SerializeField]
		private uint[] m_SubstituteGlyphIDs;
	}
}
