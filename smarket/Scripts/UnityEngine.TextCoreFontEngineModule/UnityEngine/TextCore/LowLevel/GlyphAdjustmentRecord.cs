using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[Serializable]
	[UsedByNativeCode]
	public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord>
	{
		[NativeName("glyphIndex")]
		[SerializeField]
		private uint m_GlyphIndex;

		[NativeName("glyphValueRecord")]
		[SerializeField]
		private GlyphValueRecord m_GlyphValueRecord;

		public uint glyphIndex => 0u;

		public GlyphValueRecord glyphValueRecord => default(GlyphValueRecord);

		public GlyphAdjustmentRecord(uint glyphIndex, GlyphValueRecord glyphValueRecord)
		{
			m_GlyphIndex = 0u;
			m_GlyphValueRecord = default(GlyphValueRecord);
		}

		[ExcludeFromDocs]
		public override int GetHashCode()
		{
			return 0;
		}

		[ExcludeFromDocs]
		public override bool Equals(object obj)
		{
			return false;
		}

		[ExcludeFromDocs]
		public bool Equals(GlyphAdjustmentRecord other)
		{
			return false;
		}
	}
}
