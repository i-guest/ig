using System;

namespace UnityEngine
{
	[Serializable]
	public struct LazyLoadReference<T> where T : Object
	{
		[SerializeField]
		private int m_InstanceID;

		public bool isSet => false;

		public T asset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static implicit operator LazyLoadReference<T>(T asset)
		{
			return default(LazyLoadReference<T>);
		}
	}
}
