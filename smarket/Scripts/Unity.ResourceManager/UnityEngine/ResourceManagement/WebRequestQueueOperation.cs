using System;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement
{
	public class WebRequestQueueOperation
	{
		private bool m_Completed;

		public UnityWebRequestAsyncOperation Result;

		public Action<UnityWebRequestAsyncOperation> OnComplete;

		internal UnityWebRequest m_WebRequest;

		public bool IsDone => false;

		public UnityWebRequest WebRequest
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public WebRequestQueueOperation(UnityWebRequest request)
		{
		}

		internal void Complete(UnityWebRequestAsyncOperation asyncOp)
		{
		}
	}
}
