using System;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Core.Settings;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class ListFormatter : FormatterBase, ISource, IFormatterLiteralExtractor
	{
		[SerializeReference]
		[HideInInspector]
		private SmartSettings m_SmartSettings;

		public override string[] DefaultNames => null;

		private static int CollectionIndex { get; set; }

		public ListFormatter(SmartFormatter formatter)
		{
		}

		public bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			return false;
		}

		public override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			return false;
		}

		public void WriteAllLiterals(IFormattingInfo formattingInfo)
		{
		}
	}
}
