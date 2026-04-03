using System;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.Properties
{
	internal readonly struct FieldMember : IMemberInfo
	{
		internal readonly FieldInfo m_FieldInfo;

		public string Name { get; }

		public bool IsReadOnly => false;

		public Type ValueType => null;

		public FieldMember(FieldInfo fieldInfo)
		{
			m_FieldInfo = null;
			Name = null;
		}

		public object GetValue(object obj)
		{
			return null;
		}

		public void SetValue(object obj, object value)
		{
		}

		public IEnumerable<Attribute> GetCustomAttributes()
		{
			return null;
		}
	}
}
