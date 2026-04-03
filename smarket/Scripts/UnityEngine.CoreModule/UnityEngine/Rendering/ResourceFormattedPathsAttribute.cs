namespace UnityEngine.Rendering
{
	public sealed class ResourceFormattedPathsAttribute : ResourcePathsBaseAttribute
	{
		public ResourceFormattedPathsAttribute(string pathFormat, int rangeMin, int rangeMax, SearchType location = SearchType.ProjectPath)
			: base(null, isField: false, default(SearchType))
		{
		}
	}
}
