using System;
using System.Collections.Generic;

namespace UnityEngine.InputSystem.Utilities
{
	internal struct TypeTable
	{
		public Dictionary<InternedString, Type> table;

		private InputManager m_Manager;

		public IEnumerable<string> names => null;

		public IEnumerable<InternedString> internedNames => null;

		public void Initialize(InputManager manager)
		{
		}

		public InternedString FindNameForType(Type type)
		{
			return default(InternedString);
		}

		public void AddTypeRegistration(string name, Type type)
		{
		}

		public Type LookupTypeRegistration(string name)
		{
			return null;
		}

		private Type TryLookupTypeRegistration(InternedString internedName)
		{
			return null;
		}
	}
}
