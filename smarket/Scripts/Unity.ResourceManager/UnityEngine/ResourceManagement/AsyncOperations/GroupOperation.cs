using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	internal class GroupOperation : AsyncOperationBase<IList<AsyncOperationHandle>>, ICachable
	{
		[Flags]
		public enum GroupOperationSettings
		{
			None = 0,
			ReleaseDependenciesOnFailure = 1,
			AllowFailedDependencies = 2
		}

		private Action<AsyncOperationHandle> m_InternalOnComplete;

		private int m_LoadedCount;

		private GroupOperationSettings m_Settings;

		private string debugName;

		private const int k_MaxDisplayedLocationLength = 45;

		private const int k_MaxDebugNameLength = 2000;

		private HashSet<string> m_CachedDependencyLocations;

		IOperationCacheKey ICachable.Key
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override string DebugName => null;

		protected override float Progress => 0f;

		protected override bool InvokeWaitForCompletion()
		{
			return false;
		}

		internal IList<AsyncOperationHandle> GetDependentOps()
		{
			return null;
		}

		public override void GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		internal override void ReleaseDependencies()
		{
		}

		internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
		{
			return default(DownloadStatus);
		}

		private bool DependenciesAreUnchanged(List<AsyncOperationHandle> deps)
		{
			return false;
		}

		protected override void Execute()
		{
		}

		private void CompleteIfDependenciesComplete()
		{
		}

		protected override void Destroy()
		{
		}

		public void Init(List<AsyncOperationHandle> operations, bool releaseDependenciesOnFailure = true, bool allowFailedDependencies = false)
		{
		}

		public void Init(List<AsyncOperationHandle> operations, GroupOperationSettings settings)
		{
		}

		private void OnOperationCompleted(AsyncOperationHandle op)
		{
		}
	}
}
