using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore
{
	[Serializable]
	[UsedByNativeCode]
	public struct GlyphRect : IEquatable<GlyphRect>
	{
		[SerializeField]
		[NativeName("x")]
		private int m_X;

		[SerializeField]
		[NativeName("y")]
		private int m_Y;

		[SerializeField]
		[NativeName("width")]
		private int m_Width;

		[SerializeField]
		[NativeName("height")]
		private int m_Height;

		private static readonly GlyphRect s_ZeroGlyphRect;

		public int x => 0;

		public int y => 0;

		public int width => 0;

		public int height => 0;

		public static GlyphRect zero => default(GlyphRect);

		public GlyphRect(int x, int y, int width, int height)
		{
			m_X = 0;
			m_Y = 0;
			m_Width = 0;
			m_Height = 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(GlyphRect other)
		{
			return false;
		}
	}
}
