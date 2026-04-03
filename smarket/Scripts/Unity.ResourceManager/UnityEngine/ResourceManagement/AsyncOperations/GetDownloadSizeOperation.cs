using System.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	internal class GetDownloadSizeOperation : AsyncOperationBase<long>
	{
		private IEnumerable<IResourceLocation> m_Locations;

		private bool m_Started;

		public void Init(IEnumerable<IResourceLocation> locations, ResourceManager resourceManager)
		{
		}

		private void Calculate()
		{
		}

		protected override void Execute()
		{
		}

		protected override bool InvokeWaitForCompletion()
		{
			return false;
		}
	}
}
