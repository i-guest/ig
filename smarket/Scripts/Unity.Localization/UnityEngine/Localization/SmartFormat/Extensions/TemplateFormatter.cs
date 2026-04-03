using System;
using System.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Core.Parsing;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class TemplateFormatter : FormatterBase
	{
		[Serializable]
		private class Template
		{
			public string name;

			public string text;

			public Format Format { get; set; }
		}

		[SerializeField]
		private List<Template> m_Templates;

		private IDictionary<string, Format> m_TemplatesDict;

		[NonSerialized]
		private SmartFormatter m_Formatter;

		private IDictionary<string, Format> Templates => null;

		public SmartFormatter Formatter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string[] DefaultNames => null;

		public override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			return false;
		}

		public void Register(string templateName, string template)
		{
		}

		public bool Remove(string templateName)
		{
			return false;
		}

		public override void OnAfterDeserialize()
		{
		}

		public void Clear()
		{
		}
	}
}
