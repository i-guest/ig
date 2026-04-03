using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct StyleValueHandle : IEquatable<StyleValueHandle>
	{
		[SerializeField]
		private StyleValueType m_ValueType;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		[SerializeField]
		internal int valueIndex;

		public StyleValueType valueType
		{
			get
			{
				return default(StyleValueType);
			}
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			internal set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal StyleValueHandle(int valueIndex, StyleValueType valueType)
		{
			m_ValueType = default(StyleValueType);
			this.valueIndex = 0;
		}

		public bool IsVarFunction()
		{
			return false;
		}

		public bool Equals(StyleValueHandle other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
