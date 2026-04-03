using System;
using System.ComponentModel;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[DisplayName("Text Data Provider")]
	public class TextDataProvider : ResourceProviderBase
	{
		internal class InternalOp
		{
			private TextDataProvider m_Provider;

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

			public void Start(ProvideHandle provideHandle, TextDataProvider rawProvider)
			{
			}

			private bool WaitForCompletionHandler()
			{
				return false;
			}

			private void RequestOperation_completed(AsyncOperation op)
			{
			}

			protected void CompleteOperation(string text, Exception exception)
			{
			}

			private object ConvertText(string text)
			{
				return null;
			}

			protected virtual void SendWebRequest(string path)
			{
			}
		}

		public bool IgnoreFailures { get; set; }

		public virtual object Convert(Type type, string text)
		{
			return null;
		}

		public override void Provide(ProvideHandle provideHandle)
		{
		}
	}
}
