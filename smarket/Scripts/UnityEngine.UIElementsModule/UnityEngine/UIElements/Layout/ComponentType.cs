namespace UnityEngine.UIElements.Layout
{
	internal struct ComponentType
	{
		public int Size;

		public static ComponentType Create<T>() where T : struct
		{
			return default(ComponentType);
		}
	}
}
