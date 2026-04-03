using System;
using System.Diagnostics;
using UnityEngine.UIElements;

namespace UnityEngine.Localization
{
	[Serializable]
	[UxmlObject]
	public class LocalizedTexture : LocalizedAsset<Texture>
	{
		[Serializable]
		public new class UxmlSerializedData : LocalizedAsset<Texture>.UxmlSerializedData
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

		protected override BindingResult ApplyDataBindingValue(in BindingContext context, Texture value)
		{
			return default(BindingResult);
		}
	}
}
