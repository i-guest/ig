using System;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class DictionarySource : ISource
	{
		public DictionarySource(SmartFormatter formatter)
		{
		}

		public bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			return false;
		}
	}
}
