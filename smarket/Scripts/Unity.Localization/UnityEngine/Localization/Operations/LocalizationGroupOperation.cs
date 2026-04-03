using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	internal class LocalizationGroupOperation : GroupOperation
	{
		public static readonly ObjectPool<LocalizationGroupOperation> Pool;

		protected override bool InvokeWaitForCompletion()
		{
			return false;
		}

		protected override void Destroy()
		{
		}
	}
}
