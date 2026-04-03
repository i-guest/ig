using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
	[NativeHeader("Runtime/Math/Rect.h")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	public struct Rect : IEquatable<Rect>, IFormattable
	{
		[NativeName("x")]
		private float m_XMin;

		[NativeName("y")]
		private float m_YMin;

		[NativeName("width")]
		private float m_Width;

		[NativeName("height")]
		private float m_Height;

		private static readonly Rect kZero;

		public static Rect zero
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Rect);
			}
		}

		public float x
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public float y
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector2 position
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector2);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector2 center
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector2);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector2 min
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector2);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector2 max
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector2);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public float width
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public float height
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public Vector2 size
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return default(Vector2);
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public float xMin
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public float yMin
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public float xMax
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		public float yMax
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return 0f;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Rect(float x, float y, float width, float height)
		{
			m_XMin = 0f;
			m_YMin = 0f;
			m_Width = 0f;
			m_Height = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Rect(Vector2 position, Vector2 size)
		{
			m_XMin = 0f;
			m_YMin = 0f;
			m_Width = 0f;
			m_Height = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Rect(Rect source)
		{
			m_XMin = 0f;
			m_YMin = 0f;
			m_Width = 0f;
			m_Height = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
		{
			return default(Rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Set(float x, float y, float width, float height)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Contains(Vector2 point)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Contains(Vector3 point)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Rect OrderMinMax(in Rect rect)
		{
			return default(Rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Overlaps(Rect other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Overlaps(in Rect other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Overlaps(Rect other, bool allowInverse)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Rect lhs, Rect rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Rect lhs, Rect rhs)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly bool Equals(object other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(Rect other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(in Rect other)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
