using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
	[Serializable]
	[NativeClass("UnitySceneHandle")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/SceneManager/UnitySceneHandle.h")]
	public struct SceneHandle : IEquatable<SceneHandle>
	{
		internal EntityId m_Value;

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(SceneHandle other)
		{
			return false;
		}

		public static bool operator ==(SceneHandle left, SceneHandle right)
		{
			return false;
		}

		public static bool operator !=(SceneHandle left, SceneHandle right)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
