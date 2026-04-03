using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	public class InstanceProvider : IInstanceProvider
	{
		private Dictionary<GameObject, AsyncOperationHandle<GameObject>> m_InstanceObjectToPrefabHandle;

		public GameObject ProvideInstance(ResourceManager resourceManager, AsyncOperationHandle<GameObject> prefabHandle, InstantiationParameters instantiateParameters)
		{
			return null;
		}

		public void ReleaseInstance(ResourceManager resourceManager, GameObject instance)
		{
		}
	}
}
