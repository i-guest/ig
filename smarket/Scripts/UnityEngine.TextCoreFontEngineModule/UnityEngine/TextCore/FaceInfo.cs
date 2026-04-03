using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore
{
	[Serializable]
	[UsedByNativeCode]
	public struct FaceInfo
	{
		[SerializeField]
		[NativeName("faceIndex")]
		private int m_FaceIndex;

		[SerializeField]
		[NativeName("familyName")]
		private string m_FamilyName;

		[NativeName("styleName")]
		[SerializeField]
		private string m_StyleName;

		[NativeName("pointSize")]
		[SerializeField]
		private float m_PointSize;

		[NativeName("scale")]
		[SerializeField]
		private float m_Scale;

		[NativeName("unitsPerEM")]
		[SerializeField]
		private int m_UnitsPerEM;

		[SerializeField]
		[NativeName("lineHeight")]
		private float m_LineHeight;

		[SerializeField]
		[NativeName("ascentLine")]
		private float m_AscentLine;

		[NativeName("capLine")]
		[SerializeField]
		private float m_CapLine;

		[NativeName("meanLine")]
		[SerializeField]
		private float m_MeanLine;

		[SerializeField]
		[NativeName("baseline")]
		private float m_Baseline;

		[SerializeField]
		[NativeName("descentLine")]
		private float m_DescentLine;

		[SerializeField]
		[NativeName("superscriptOffset")]
		private float m_SuperscriptOffset;

		[SerializeField]
		[NativeName("superscriptSize")]
		private float m_SuperscriptSize;

		[NativeName("subscriptOffset")]
		[SerializeField]
		private float m_SubscriptOffset;

		[NativeName("subscriptSize")]
		[SerializeField]
		private float m_SubscriptSize;

		[SerializeField]
		[NativeName("underlineOffset")]
		private float m_UnderlineOffset;

		[SerializeField]
		[NativeName("underlineThickness")]
		private float m_UnderlineThickness;

		[SerializeField]
		[NativeName("strikethroughOffset")]
		private float m_StrikethroughOffset;

		[NativeName("strikethroughThickness")]
		[SerializeField]
		private float m_StrikethroughThickness;

		[NativeName("tabWidth")]
		[SerializeField]
		private float m_TabWidth;

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal int faceIndex => 0;

		public string familyName => null;

		public string styleName => null;

		public float pointSize => 0f;

		public float scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
		internal int unitsPerEM
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float lineHeight => 0f;

		public float ascentLine => 0f;

		public float capLine
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float meanLine
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float baseline => 0f;

		public float descentLine => 0f;

		public float superscriptOffset => 0f;

		public float superscriptSize => 0f;

		public float subscriptOffset => 0f;

		public float subscriptSize => 0f;

		public float underlineOffset => 0f;

		public float underlineThickness => 0f;

		public float strikethroughOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float tabWidth => 0f;
	}
}
