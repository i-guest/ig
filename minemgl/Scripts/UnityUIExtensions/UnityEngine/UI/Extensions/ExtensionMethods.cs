using System;

namespace UnityEngine.UI.Extensions
{
	public static class ExtensionMethods
	{
		public static T GetOrAddComponent<T>(this GameObject child) where T : Component
		{
			T val = child.GetComponent<T>();
			if (val == null)
			{
				val = child.AddComponent<T>();
			}
			return val;
		}

		public static bool IsPrefab(this GameObject gameObject)
		{
			if (gameObject == null)
			{
				throw new ArgumentNullException("gameObject");
			}
			if (!gameObject.scene.IsValid() && !gameObject.scene.isLoaded && gameObject.GetInstanceID() >= 0)
			{
				return !gameObject.hideFlags.HasFlag(HideFlags.HideInHierarchy);
			}
			return false;
		}

		public static T Clamp<T>(this T value, T min, T max) where T : IComparable<T>
		{
			if (value.CompareTo(min) < 0)
			{
				value = min;
			}
			if (value.CompareTo(max) > 0)
			{
				value = max;
			}
			return value;
		}
	}
}
