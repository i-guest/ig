using System;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class XElementFormatter : FormatterBase
	{
		public override string[] DefaultNames => null;

		public override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			return false;
		}
	}
}
