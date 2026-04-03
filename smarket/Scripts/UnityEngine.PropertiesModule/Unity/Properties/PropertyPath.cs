using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Unity.Properties
{
	public readonly struct PropertyPath : IEquatable<PropertyPath>
	{
		internal const int k_InlineCount = 4;

		private readonly PropertyPathPart m_Part0;

		private readonly PropertyPathPart m_Part1;

		private readonly PropertyPathPart m_Part2;

		private readonly PropertyPathPart m_Part3;

		private readonly PropertyPathPart[] m_AdditionalParts;

		public int Length { get; }

		public bool IsEmpty => false;

		public PropertyPathPart this[int index] => default(PropertyPathPart);

		public PropertyPath(string path)
		{
			m_Part0 = default(PropertyPathPart);
			m_Part1 = default(PropertyPathPart);
			m_Part2 = default(PropertyPathPart);
			m_Part3 = default(PropertyPathPart);
			m_AdditionalParts = null;
			Length = 0;
		}

		private PropertyPath(in PropertyPathPart part)
		{
			m_Part0 = default(PropertyPathPart);
			m_Part1 = default(PropertyPathPart);
			m_Part2 = default(PropertyPathPart);
			m_Part3 = default(PropertyPathPart);
			m_AdditionalParts = null;
			Length = 0;
		}

		private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1)
		{
			m_Part0 = default(PropertyPathPart);
			m_Part1 = default(PropertyPathPart);
			m_Part2 = default(PropertyPathPart);
			m_Part3 = default(PropertyPathPart);
			m_AdditionalParts = null;
			Length = 0;
		}

		private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2)
		{
			m_Part0 = default(PropertyPathPart);
			m_Part1 = default(PropertyPathPart);
			m_Part2 = default(PropertyPathPart);
			m_Part3 = default(PropertyPathPart);
			m_AdditionalParts = null;
			Length = 0;
		}

		private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2, in PropertyPathPart part3)
		{
			m_Part0 = default(PropertyPathPart);
			m_Part1 = default(PropertyPathPart);
			m_Part2 = default(PropertyPathPart);
			m_Part3 = default(PropertyPathPart);
			m_AdditionalParts = null;
			Length = 0;
		}

		internal PropertyPath(List<PropertyPathPart> parts)
		{
			m_Part0 = default(PropertyPathPart);
			m_Part1 = default(PropertyPathPart);
			m_Part2 = default(PropertyPathPart);
			m_Part3 = default(PropertyPathPart);
			m_AdditionalParts = null;
			Length = 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static PropertyPath FromIndex(int index)
		{
			return default(PropertyPath);
		}

		public static PropertyPath Combine(in PropertyPath path, in PropertyPath pathToAppend)
		{
			return default(PropertyPath);
		}

		public static PropertyPath AppendPart(in PropertyPath path, in PropertyPathPart part)
		{
			return default(PropertyPath);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static PropertyPath AppendIndex(in PropertyPath path, int index)
		{
			return default(PropertyPath);
		}

		public static PropertyPath AppendProperty(in PropertyPath path, IProperty property)
		{
			return default(PropertyPath);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static PropertyPath Pop(in PropertyPath path)
		{
			return default(PropertyPath);
		}

		public static PropertyPath SubPath(in PropertyPath path, int startIndex, int length)
		{
			return default(PropertyPath);
		}

		public override string ToString()
		{
			return null;
		}

		private static void AppendToBuilder(in PropertyPathPart part, StringBuilder builder)
		{
		}

		private static void GetParts(in PropertyPath path, List<PropertyPathPart> parts)
		{
		}

		private static PropertyPath ConstructFromPath(string path)
		{
			return default(PropertyPath);
		}

		public static bool operator ==(PropertyPath lhs, PropertyPath rhs)
		{
			return false;
		}

		public static bool operator !=(PropertyPath lhs, PropertyPath rhs)
		{
			return false;
		}

		public bool Equals(PropertyPath other)
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
	}
}
