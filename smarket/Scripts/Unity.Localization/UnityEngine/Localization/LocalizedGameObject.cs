using System;
using System.Diagnostics;
using UnityEngine.UIElements;

namespace UnityEngine.Localization
{
	[Serializable]
	[UxmlObject]
	public class LocalizedGameObject : LocalizedAsset<GameObject>
	{
		[Serializable]
		public new class UxmlSerializedData : LocalizedAsset<GameObject>.UxmlSerializedData
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
