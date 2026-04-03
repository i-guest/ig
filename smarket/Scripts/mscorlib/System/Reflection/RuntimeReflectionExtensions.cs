namespace System.Reflection
{
	/// <summary>Provides methods that retrieve information about types at run time.</summary>
	public static class RuntimeReflectionExtensions
	{
		/// <summary>Retrieves an object that represents a specified field.</summary>
		/// <param name="type">The type that contains the field.</param>
		/// <param name="name">The name of the field.</param>
		/// <returns>An object that represents the specified field, or <see langword="null" /> if the field is not found.</returns>
		public static FieldInfo GetRuntimeField(this Type type, string name)
		{
			return null;
		}
	}
}
