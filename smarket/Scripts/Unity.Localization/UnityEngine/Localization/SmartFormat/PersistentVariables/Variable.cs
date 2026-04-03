using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.UIElements;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	[Serializable]
	[UxmlObject]
	public class Variable<T> : IVariableValueChanged, IVariable
	{
		[Serializable]
		public class UxmlSerializedData : UnityEngine.UIElements.UxmlSerializedData
		{
			[UxmlAttribute("value")]
			[SerializeField]
			private T ValueUXML;

			[SerializeField]
			[UxmlIgnore]
			[HideInInspector]
			private UxmlAttributeFlags ValueUXML_UxmlAttributeFlags;

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

		[SerializeField]
		private T m_Value;

		[UxmlAttribute("value")]
		public T ValueUXML
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public event Action<IVariable> ValueChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public object GetSourceValue(ISelectorInfo _)
		{
			return null;
		}

		private void SendValueChangedEvent()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
