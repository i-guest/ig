using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
	[UsedByNativeCode]
	internal struct MarkToMarkAdjustmentRecord
	{
		[SerializeField]
		[NativeName("baseMarkGlyphID")]
		private uint m_BaseMarkGlyphID;

		[SerializeField]
		[NativeName("baseMarkAnchor")]
		private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint;

		[NativeName("combiningMarkGlyphID")]
		[SerializeField]
		private uint m_CombiningMarkGlyphID;

		[SerializeField]
		[NativeName("combiningMarkPositionAdjustment")]
		private MarkPositionAdjustment m_CombiningMarkPositionAdjustment;

		public uint baseMarkGlyphID
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public GlyphAnchorPoint baseMarkGlyphAnchorPoint
		{
			get
			{
				return default(GlyphAnchorPoint);
			}
			set
			{
			}
		}

		public uint combiningMarkGlyphID
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public MarkPositionAdjustment combiningMarkPositionAdjustment
		{
			get
			{
				return default(MarkPositionAdjustment);
			}
			set
			{
			}
		}
	}
}
