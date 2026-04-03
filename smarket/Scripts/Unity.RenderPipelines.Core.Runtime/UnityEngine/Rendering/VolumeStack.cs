using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public sealed class VolumeStack : IDisposable
	{
		internal readonly Dictionary<Type, VolumeComponent> components;

		internal VolumeParameter[] parameters;

		internal bool requiresReset;

		internal bool requiresResetForAllProperties;

		public bool isValid { get; private set; }

		internal VolumeStack()
		{
		}

		internal void Clear()
		{
		}

		internal void Reload(Type[] componentTypes)
		{
		}

		public T GetComponent<T>() where T : VolumeComponent
		{
			return null;
		}

		public VolumeComponent GetComponent(Type type)
		{
			return null;
		}

		public void Dispose()
		{
		}
	}
}
