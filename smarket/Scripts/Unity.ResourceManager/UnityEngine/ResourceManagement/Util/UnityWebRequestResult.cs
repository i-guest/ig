using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.Util
{
	public class UnityWebRequestResult
	{
		public string Error { get; set; }

		public long ResponseCode { get; }

		public UnityWebRequest.Result Result { get; }

		public string Method { get; }

		public string Url { get; }

		public UnityWebRequestResult(UnityWebRequest request)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public bool ShouldRetryDownloadError()
		{
			return false;
		}
	}
}
