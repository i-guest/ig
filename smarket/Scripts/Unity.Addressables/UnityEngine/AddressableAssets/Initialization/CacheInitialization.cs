using System;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.Initialization
{
	[Serializable]
	public class CacheInitialization : IInitializableObject
	{
		private class CacheInitOp : AsyncOperationBase<bool>, IUpdateReceiver
		{
			private Func<bool> m_Callback;

			private bool m_UpdateRequired;

			public void Init(Func<bool> callback)
			{
			}

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}

			public void Update(float unscaledDeltaTime)
			{
			}

			protected override void Execute()
			{
			}
		}

		public static string RootPath => null;

		public bool Initialize(string id, string dataStr)
		{
			return false;
		}

		public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data)
		{
			return default(AsyncOperationHandle<bool>);
		}
	}
}
