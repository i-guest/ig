using UnityEngine.Bindings;

namespace UnityEngineInternal
{
	internal class DisplayInternal
	{
		[FreeFunction("UnityDisplayManager_PrimaryDisplayIndex")]
		internal static int PrimaryDisplayIndex()
		{
			return 0;
		}

		internal static bool IsASecondaryDisplayIndex(int displayIndex)
		{
			return false;
		}
	}
}
