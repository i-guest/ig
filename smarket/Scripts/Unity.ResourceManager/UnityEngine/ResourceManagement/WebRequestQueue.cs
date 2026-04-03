using System.Collections.Generic;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement
{
	public static class WebRequestQueue
	{
		internal static int s_MaxRequest;

		internal static Queue<WebRequestQueueOperation> s_QueuedOperations;

		internal static List<UnityWebRequestAsyncOperation> s_ActiveRequests;

		public static void SetMaxConcurrentRequests(int maxRequests)
		{
		}

		public static WebRequestQueueOperation QueueRequest(UnityWebRequest request)
		{
			return null;
		}

		public static void WaitForRequestToBeActive(WebRequestQueueOperation request, int millisecondsTimeout)
		{
		}

		internal static void DequeueRequest(UnityWebRequestAsyncOperation operation)
		{
		}

		private static void OnWebAsyncOpComplete(AsyncOperation operation)
		{
		}

		private static void OnWebAsyncOpComplete(UnityWebRequestAsyncOperation operation)
		{
		}

		private static void BeginWebRequest(WebRequestQueueOperation queueOperation)
		{
		}
	}
}
