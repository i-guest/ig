using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public readonly struct BindingId : IEquatable<BindingId>
	{
		public static readonly BindingId Invalid;

		private readonly PropertyPath m_PropertyPath;

		private readonly string m_Path;

		public BindingId(string path)
		{
			m_PropertyPath = default(PropertyPath);
			m_Path = null;
		}

		public BindingId(in PropertyPath path)
		{
			m_PropertyPath = default(PropertyPath);
			m_Path = null;
		}

		public static implicit operator PropertyPath(in BindingId vep)
		{
			return default(PropertyPath);
		}

		public static implicit operator string(in BindingId vep)
		{
			return null;
		}

		public static implicit operator BindingId(string name)
		{
			return default(BindingId);
		}

		public static implicit operator BindingId(in PropertyPath path)
		{
			return default(BindingId);
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(BindingId other)
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

		public static bool operator ==(in BindingId lhs, in BindingId rhs)
		{
			return false;
		}

		public static bool operator !=(in BindingId lhs, in BindingId rhs)
		{
			return false;
		}
	}
}
