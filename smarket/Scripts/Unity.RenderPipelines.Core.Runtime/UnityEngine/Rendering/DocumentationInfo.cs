namespace UnityEngine.Rendering
{
	public class DocumentationInfo
	{
		private const string fallbackVersion = "13.1";

		private const string packageDocumentationUrl = "https://docs.unity3d.com/Packages/{0}@{1}/manual/";

		private const string url = "https://docs.unity3d.com/Packages/{0}@{1}/manual/{2}.html{3}";

		public static string version => null;

		public static string GetPackageLink(string packageName, string packageVersion, string pageName)
		{
			return null;
		}

		public static string GetPackageLink(string packageName, string packageVersion, string pageName, string pageHash)
		{
			return null;
		}

		public static string GetPageLink(string packageName, string pageName)
		{
			return null;
		}

		public static string GetPageLink(string packageName, string pageName, string pageHash)
		{
			return null;
		}

		public static string GetDefaultPackageLink(string packageName, string packageVersion)
		{
			return null;
		}

		public static string GetDefaultPackageLink(string packageName)
		{
			return null;
		}
	}
}
