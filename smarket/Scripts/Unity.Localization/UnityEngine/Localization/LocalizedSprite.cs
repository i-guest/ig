using System;
using System.Diagnostics;
using UnityEngine.UIElements;

namespace UnityEngine.Localization
{
	[Serializable]
	[UxmlObject]
	public class LocalizedSprite : LocalizedAsset<Sprite>
	{
		[Serializable]
		public new class UxmlSerializedData : LocalizedAsset<Sprite>.UxmlSerializedData
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
