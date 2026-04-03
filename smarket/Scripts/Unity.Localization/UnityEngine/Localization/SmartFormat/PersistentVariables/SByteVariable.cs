using System;
using System.Diagnostics;
using UnityEngine.UIElements;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	[Serializable]
	[UxmlObject]
	[DisplayName("Signed Byte", null)]
	public class SByteVariable : Variable<sbyte>
	{
		[Serializable]
		[DisplayName("Signed Byte", null)]
		public new class UxmlSerializedData : Variable<sbyte>.UxmlSerializedData
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
