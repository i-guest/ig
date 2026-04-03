using System;
using System.ComponentModel;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[DisplayName("Binary Data Provider")]
	internal class BinaryDataProvider : ResourceProviderBase
	{
		internal class InternalOp
		{
			private BinaryDataProvider m_Provider;

			private UnityWebRequestAsyncOperation m_RequestOperation;

			private WebRequestQueueOperation m_RequestQueueOperation;

			private ProvideHandle m_PI;

			private bool m_IgnoreFailures;

			private bool m_Complete;

			private int m_Timeout;

			private float GetPercentComplete()
			{
				return 0f;
			}

			public void Start(ProvideHandle provideHandle, BinaryDataProvider rawProvider)
			{
			}

			private bool WaitForCompletionHandler()
			{
				return false;
			}

			private void RequestOperation_completed(AsyncOperation op)
			{
			}

			protected void CompleteOperation(byte[] data, Exception exception)
			{
			}

			private object ConvertBytes(byte[] data)
			{
				return null;
			}

			protected virtual void SendWebRequest(string path)
			{
			}
		}

		public bool IgnoreFailures { get; set; }

		public virtual object Convert(Type type, byte[] data)
		{
			return null;
		}

		public override void Provide(ProvideHandle provideHandle)
		{
		}
	}
}
