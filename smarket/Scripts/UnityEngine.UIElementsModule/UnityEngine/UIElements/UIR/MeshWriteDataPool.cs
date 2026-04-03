using System;

namespace UnityEngine.UIElements.UIR
{
	internal class MeshWriteDataPool : ImplicitPool<MeshWriteData>
	{
		private static readonly Func<MeshWriteData> k_CreateAction;

		public MeshWriteDataPool()
			: base((Func<MeshWriteData>)null, (Action<MeshWriteData>)null, 0, 0)
		{
		}
	}
}
