using System;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements
{
	[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
	public abstract class BaseCompositeField<TValueType, TField, TFieldValue> : BaseField<TValueType>, IDelayedField where TField : TextValueField<TFieldValue>, new()
	{
		internal struct FieldDescription
		{
			public delegate void WriteDelegate(ref TValueType val, TFieldValue fieldValue);

			internal readonly string name;

			internal readonly string ussName;

			internal readonly Func<TValueType, TFieldValue> read;

			internal readonly WriteDelegate write;

			public FieldDescription(string name, string ussName, Func<TValueType, TFieldValue> read, WriteDelegate write)
			{
				this.name = null;
				this.ussName = null;
				this.read = null;
				this.write = null;
			}
		}

		internal static readonly BindingId isDelayedProperty;

		private List<TField> m_Fields;

		private bool m_ShouldUpdateDisplay;

		private bool m_ForceUpdateDisplay;

		private bool m_IsDelayed;

		public new static readonly string ussClassName;

		public new static readonly string labelUssClassName;

		public new static readonly string inputUssClassName;

		public static readonly string spacerUssClassName;

		public static readonly string multilineVariantUssClassName;

		public static readonly string fieldGroupUssClassName;

		public static readonly string fieldUssClassName;

		public static readonly string firstFieldVariantUssClassName;

		public static readonly string twoLinesVariantUssClassName;

		internal List<TField> fields => null;

		[CreateProperty]
		public bool isDelayed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private VisualElement GetSpacer()
		{
			return null;
		}

		internal abstract FieldDescription[] DescribeFields();

		protected BaseCompositeField(string label, int fieldsByLine)
			: base((string)null)
		{
		}

		private void UpdateDisplay()
		{
		}

		public override void SetValueWithoutNotify(TValueType newValue)
		{
		}

		internal override void OnViewDataReady()
		{
		}

		protected override void UpdateMixedValueContent()
		{
		}
	}
}
