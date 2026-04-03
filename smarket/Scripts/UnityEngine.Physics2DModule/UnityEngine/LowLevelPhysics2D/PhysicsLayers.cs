using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.LowLevelPhysics2D
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public readonly struct PhysicsLayers
	{
		[Serializable]
		public class LayerNames : ISerializationCallbackReceiver
		{
			[SerializeField]
			internal string[] m_Names;

			private Dictionary<string, int> m_NameMap;

			private string[] Names => null;

			private Dictionary<string, int> NameMap => null;

			internal static LayerNames DefaultLayerNames => null;

			public void OnBeforeSerialize()
			{
			}

			public void OnAfterDeserialize()
			{
			}
		}
	}
}
