using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public sealed class VolumeProfile : ScriptableObject
	{
		[Flags]
		internal enum DirtyState
		{
			None = 0,
			DirtyByComponentChange = 1,
			DirtyByProfileReset = 2,
			Other = 4
		}

		public List<VolumeComponent> components;

		internal DirtyState dirtyState;

		[Obsolete("This field was only public for editor access. #from(6000.0)")]
		public bool isDirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		internal void OnDisable()
		{
		}

		public void Reset()
		{
		}

		public T Add<T>(bool overrides = false) where T : VolumeComponent
		{
			return null;
		}

		public VolumeComponent Add(Type type, bool overrides = false)
		{
			return null;
		}

		public void Remove<T>() where T : VolumeComponent
		{
		}

		public void Remove(Type type)
		{
		}

		public bool Has<T>() where T : VolumeComponent
		{
			return false;
		}

		public bool Has(Type type)
		{
			return false;
		}

		public bool HasSubclassOf(Type type)
		{
			return false;
		}

		public bool TryGet<T>(out T component) where T : VolumeComponent
		{
			component = null;
			return false;
		}

		public bool TryGet<T>(Type type, out T component) where T : VolumeComponent
		{
			component = null;
			return false;
		}

		public bool TryGetSubclassOf<T>(Type type, out T component) where T : VolumeComponent
		{
			component = null;
			return false;
		}

		public bool TryGetAllSubclassOf<T>(Type type, List<T> result) where T : VolumeComponent
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal int GetComponentListHashCode()
		{
			return 0;
		}

		internal void Sanitize()
		{
		}
	}
}
