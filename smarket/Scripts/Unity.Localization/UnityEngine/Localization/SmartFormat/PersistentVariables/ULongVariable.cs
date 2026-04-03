using System;
using System.Diagnostics;
using UnityEngine.UIElements;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	[Serializable]
	[UxmlObject]
	[DisplayName("Unsigned Long", null)]
	public class ULongVariable : Variable<ulong>
	{
		[Serializable]
		[DisplayName("Unsigned Long", null)]
		public new class UxmlSerializedData : Variable<ulong>.UxmlSerializedData
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
