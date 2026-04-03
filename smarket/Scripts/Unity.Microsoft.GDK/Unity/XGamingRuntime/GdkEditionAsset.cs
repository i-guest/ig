using UnityEngine;

namespace Unity.XGamingRuntime
{
	public class GdkEditionAsset : ScriptableObject
	{
		[SerializeField]
		[Tooltip("The GDK Edition number used for API compatibility checks")]
		private int m_EditionNumber;

		public int EditionNumber => 0;

		public static GdkEditionAsset CreateInstance(int editionNumber)
		{
			return null;
		}
	}
}
