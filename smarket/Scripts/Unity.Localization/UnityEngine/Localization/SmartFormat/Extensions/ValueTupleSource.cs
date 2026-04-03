using System;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class ValueTupleSource : ISource
	{
		private SmartFormatter m_Formatter;

		public ValueTupleSource(SmartFormatter formatter)
		{
		}

		public bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			return false;
		}
	}
}
