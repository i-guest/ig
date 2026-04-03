using System.Diagnostics;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.Util
{
	public class UnityWebRequestUtilities
	{
		private const string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";

		public static bool RequestHasErrors(UnityWebRequest webReq, out UnityWebRequestResult result)
		{
			result = null;
			return false;
		}

		public static bool IsAssetBundleDownloaded(UnityWebRequestAsyncOperation op)
		{
			return false;
		}

		internal static void LogOperationResult(AsyncOperation op)
		{
		}

		[Conditional("ADDRESSABLES_LOG_ALL")]
		internal static void Log(string msg)
		{
		}

		internal static void LogError(string msg)
		{
		}
	}
}
