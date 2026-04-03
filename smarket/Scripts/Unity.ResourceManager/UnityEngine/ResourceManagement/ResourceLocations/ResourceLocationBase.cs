using System;
using System.Collections.Generic;

namespace UnityEngine.ResourceManagement.ResourceLocations
{
	public class ResourceLocationBase : IResourceLocation
	{
		private string m_Name;

		private string m_Id;

		private string m_ProviderId;

		private object m_Data;

		private int m_DependencyHashCode;

		private int m_HashCode;

		private Type m_Type;

		private List<IResourceLocation> m_Dependencies;

		private string m_PrimaryKey;

		public string InternalId => null;

		public string ProviderId => null;

		public IList<IResourceLocation> Dependencies => null;

		public bool HasDependencies => false;

		public object Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PrimaryKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int DependencyHashCode => 0;

		public Type ResourceType => null;

		public int Hash(Type t)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public ResourceLocationBase(string name, string id, string providerId, Type t, params IResourceLocation[] dependencies)
		{
		}

		public void ComputeDependencyHash()
		{
		}
	}
}
