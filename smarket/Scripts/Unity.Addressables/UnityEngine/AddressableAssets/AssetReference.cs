using System;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace UnityEngine.AddressableAssets
{
	[Serializable]
	public class AssetReference : IKeyEvaluator
	{
		[FormerlySerializedAs("m_assetGUID")]
		[SerializeField]
		protected internal string m_AssetGUID;

		[SerializeField]
		private string m_SubObjectName;

		[SerializeField]
		private string m_SubObjectType;

		private AsyncOperationHandle m_Operation;

		public AsyncOperationHandle OperationHandle
		{
			get
			{
				return default(AsyncOperationHandle);
			}
			internal set
			{
			}
		}

		public virtual object RuntimeKey => null;

		public virtual string AssetGUID => null;

		public virtual string SubObjectName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal virtual Type SubObjectType => null;

		public bool IsDone => false;

		public virtual Object Asset => null;

		public bool IsValid()
		{
			return false;
		}

		public AssetReference()
		{
		}

		public AssetReference(string guid)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private static AsyncOperationHandle<T> CreateFailedOperation<T>()
		{
			return default(AsyncOperationHandle<T>);
		}

		public virtual AsyncOperationHandle<TObject> LoadAssetAsync<TObject>()
		{
			return default(AsyncOperationHandle<TObject>);
		}

		public virtual AsyncOperationHandle<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public virtual AsyncOperationHandle<SceneInstance> UnLoadScene()
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}

		public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent = null)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public virtual AsyncOperationHandle<GameObject> InstantiateAsync(Transform parent = null, bool instantiateInWorldSpace = false)
		{
			return default(AsyncOperationHandle<GameObject>);
		}

		public virtual bool RuntimeKeyIsValid()
		{
			return false;
		}

		public virtual void ReleaseAsset()
		{
		}

		public virtual void ReleaseInstance(GameObject obj)
		{
		}

		public virtual bool ValidateAsset(Object obj)
		{
			return false;
		}

		public virtual bool ValidateAsset(string path)
		{
			return false;
		}
	}
}
