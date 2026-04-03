using System;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[HideInInspector]
	[UxmlElement("Instance")]
	public class TemplateContainer : BindableElement
	{
		[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlFactory : UxmlFactory<TemplateContainer, UxmlTraits>
		{
			public override string uxmlName => null;

			public override string uxmlQualifiedName => null;
		}

		[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			private UxmlStringAttributeDescription m_Template;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		internal static readonly BindingId templateIdProperty;

		internal static readonly BindingId templateSourceProperty;

		internal const string k_ElementName = "Instance";

		private VisualElement m_ContentContainer;

		private VisualTreeAsset m_TemplateSource;

		[CreateProperty(ReadOnly = true)]
		public string templateId { get; private set; }

		[CreateProperty(ReadOnly = true)]
		public VisualTreeAsset templateSource
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public override VisualElement contentContainer => null;

		public TemplateContainer()
		{
		}

		public TemplateContainer(string templateId)
		{
		}

		internal TemplateContainer(string templateId, VisualTreeAsset templateSource)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void SetContentContainer(VisualElement content)
		{
		}
	}
}
