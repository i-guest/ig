using System;
using System.Diagnostics;
using UnityEngine.UIElements;

namespace UnityEngine.Localization
{
	[Serializable]
	[UxmlObject]
	public class LocalizedFont : LocalizedAsset<Font>
	{
		[Serializable]
		public new class UxmlSerializedData : LocalizedAsset<Font>.UxmlSerializedData
		{
			[RegisterUxmlCache]
			[Conditional("UNITY_EDITOR")]
			public new static void Register()
			{
			}

			public override object CreateInstance()
			{
				return null;
			}
		}
	}
}
