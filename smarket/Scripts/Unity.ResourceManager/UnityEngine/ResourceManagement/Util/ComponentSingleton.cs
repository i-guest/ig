namespace UnityEngine.ResourceManagement.Util
{
	[ExecuteInEditMode]
	public abstract class ComponentSingleton<T> : MonoBehaviour
	{
		private static T s_Instance;

		public static bool Exists => false;

		public static T Instance => default(T);

		private static T FindInstance()
		{
			return default(T);
		}

		protected virtual string GetGameObjectName()
		{
			return null;
		}

		private static T CreateNewSingleton()
		{
			return default(T);
		}

		private void Awake()
		{
		}

		public static void DestroySingleton()
		{
		}
	}
}
