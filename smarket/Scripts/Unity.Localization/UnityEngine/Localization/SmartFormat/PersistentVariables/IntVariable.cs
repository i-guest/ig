using System;
using System.Diagnostics;
using UnityEngine.UIElements;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	[Serializable]
	[UxmlObject]
	[DisplayName("Integer", null)]
	public class IntVariable : Variable<int>
	{
		[Serializable]
		[DisplayName("Integer", null)]
		public new class UxmlSerializedData : Variable<int>.UxmlSerializedData
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
