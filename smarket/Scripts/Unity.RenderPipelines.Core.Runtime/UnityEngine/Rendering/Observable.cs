using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	public struct Observable<T>
	{
		private T m_Value;

		public T value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public event Action<T> onValueChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public Observable(T newValue)
		{
			this.onValueChanged = null;
			m_Value = default(T);
		}
	}
}
