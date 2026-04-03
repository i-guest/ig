using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
	{
		private RuntimeInitializeLoadType m_LoadType;

		private RuntimeInitializeLoadType loadType
		{
			set
			{
			}
		}

		public RuntimeInitializeOnLoadMethodAttribute()
		{
		}

		public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
		{
		}
	}
}
