using System;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	public abstract class ResourceProviderBase : IResourceProvider, IInitializableObject
	{
		private class BaseInitAsyncOp : AsyncOperationBase<bool>
		{
			private Func<bool> m_CallBack;

			public void Init(Func<bool> callback)
			{
			}

			protected override bool InvokeWaitForCompletion()
			{
				return false;
			}

			protected override void Execute()
			{
			}
		}

		protected string m_ProviderId;

		protected ProviderBehaviourFlags m_BehaviourFlags;

		public virtual string ProviderId => null;

		ProviderBehaviourFlags IResourceProvider.BehaviourFlags => default(ProviderBehaviourFlags);

		public virtual bool Initialize(string id, string data)
		{
			return false;
		}

		public virtual bool CanProvide(Type t, IResourceLocation location)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public virtual void Release(IResourceLocation location, object obj)
		{
		}

		public virtual Type GetDefaultType(IResourceLocation location)
		{
			return null;
		}

		public abstract void Provide(ProvideHandle provideHandle);

		public virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data)
		{
			return default(AsyncOperationHandle<bool>);
		}
	}
}
