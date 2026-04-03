using System;
using System.Runtime.CompilerServices;

namespace Unity.Properties
{
	public readonly struct PropertyPathPart : IEquatable<PropertyPathPart>
	{
		private readonly PropertyPathPartKind m_Kind;

		private readonly string m_Name;

		private readonly int m_Index;

		private readonly object m_Key;

		public bool IsName => false;

		public bool IsIndex => false;

		public PropertyPathPartKind Kind => default(PropertyPathPartKind);

		public string Name => null;

		public int Index => 0;

		public object Key => null;

		public PropertyPathPart(string name)
		{
			m_Kind = default(PropertyPathPartKind);
			m_Name = null;
			m_Index = 0;
			m_Key = null;
		}

		public PropertyPathPart(int index)
		{
			m_Kind = default(PropertyPathPartKind);
			m_Name = null;
			m_Index = 0;
			m_Key = null;
		}

		public PropertyPathPart(object key)
		{
			m_Kind = default(PropertyPathPartKind);
			m_Name = null;
			m_Index = 0;
			m_Key = null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void CheckKind(PropertyPathPartKind type)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(PropertyPathPart other)
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
