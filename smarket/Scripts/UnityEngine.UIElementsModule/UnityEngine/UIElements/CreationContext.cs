using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public struct CreationContext : IEquatable<CreationContext>
	{
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal struct AttributeOverrideRange
		{
			internal readonly VisualTreeAsset sourceAsset;

			internal readonly List<TemplateAsset.AttributeOverride> attributeOverrides;

			public AttributeOverrideRange(VisualTreeAsset sourceAsset, List<TemplateAsset.AttributeOverride> attributeOverrides)
			{
				this.sourceAsset = null;
				this.attributeOverrides = null;
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal struct SerializedDataOverrideRange
		{
			internal readonly VisualTreeAsset sourceAsset;

			internal readonly int templateId;

			internal readonly List<TemplateAsset.UxmlSerializedDataOverride> attributeOverrides;
		}

		public static readonly CreationContext Default;

		public VisualElement target { get; private set; }

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal List<int> veaIdsPath
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get;
			private set; }

		internal TemplateAsset templateAsset { get; private set; }

		public VisualTreeAsset visualTreeAsset { get; private set; }

		public Dictionary<string, VisualElement> slotInsertionPoints { get; private set; }

		internal List<AttributeOverrideRange> attributeOverrides { get; private set; }

		internal List<SerializedDataOverrideRange> serializedDataOverrides { get; private set; }

		internal List<string> namesPath { get; private set; }

		internal bool hasOverrides => false;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal CreationContext(VisualTreeAsset vta)
		{
			target = null;
			veaIdsPath = null;
			templateAsset = null;
			visualTreeAsset = null;
			slotInsertionPoints = null;
			attributeOverrides = null;
			serializedDataOverrides = null;
			namesPath = null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides)
		{
			target = null;
			veaIdsPath = null;
			templateAsset = null;
			visualTreeAsset = null;
			this.slotInsertionPoints = null;
			this.attributeOverrides = null;
			serializedDataOverrides = null;
			namesPath = null;
		}

		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target)
		{
			this.target = null;
			veaIdsPath = null;
			templateAsset = null;
			visualTreeAsset = null;
			this.slotInsertionPoints = null;
			attributeOverrides = null;
			serializedDataOverrides = null;
			namesPath = null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides, VisualTreeAsset vta, VisualElement target)
		{
			this.target = null;
			veaIdsPath = null;
			templateAsset = null;
			visualTreeAsset = null;
			this.slotInsertionPoints = null;
			this.attributeOverrides = null;
			serializedDataOverrides = null;
			namesPath = null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<AttributeOverrideRange> attributeOverrides, List<SerializedDataOverrideRange> serializedDataOverrides, VisualTreeAsset vta, VisualElement target, List<int> veaIdsPath, List<string> namesPath, TemplateAsset ta)
		{
			this.target = null;
			this.veaIdsPath = null;
			templateAsset = null;
			visualTreeAsset = null;
			this.slotInsertionPoints = null;
			this.attributeOverrides = null;
			this.serializedDataOverrides = null;
			this.namesPath = null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(CreationContext other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
