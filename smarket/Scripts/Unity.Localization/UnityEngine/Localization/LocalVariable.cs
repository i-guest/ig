using System;
using System.Diagnostics;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.UIElements;

namespace UnityEngine.Localization
{
	[UxmlObject]
	internal class LocalVariable
	{
		[Serializable]
		public class UxmlSerializedData : UnityEngine.UIElements.UxmlSerializedData
		{
			[UxmlObjectReference]
			[SerializeReference]
			private UnityEngine.UIElements.UxmlSerializedData Variable;

			[Delayed]
			[SerializeField]
			private string Name;

			[SerializeField]
			[UxmlIgnore]
			[HideInInspector]
			private UxmlAttributeFlags Variable_UxmlAttributeFlags;

			[SerializeField]
			[UxmlIgnore]
			[HideInInspector]
			private UxmlAttributeFlags Name_UxmlAttributeFlags;

			[RegisterUxmlCache]
			[Conditional("UNITY_EDITOR")]
			public static void Register()
			{
			}

			public override object CreateInstance()
			{
				return null;
			}

			public override void Deserialize(object obj)
			{
			}
		}

		[UxmlAttribute]
		[Delayed]
		public string Name { get; set; }

		[UxmlObjectReference]
		public IVariable Variable { get; set; }
	}
}
