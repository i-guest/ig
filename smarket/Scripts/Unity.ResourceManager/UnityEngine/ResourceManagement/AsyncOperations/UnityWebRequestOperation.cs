using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	internal class UnityWebRequestOperation : AsyncOperationBase<UnityWebRequest>
	{
		private UnityWebRequest m_UWR;

		public UnityWebRequestOperation(UnityWebRequest webRequest)
		{
		}

		protected override void Execute()
		{
		}
	}
}
