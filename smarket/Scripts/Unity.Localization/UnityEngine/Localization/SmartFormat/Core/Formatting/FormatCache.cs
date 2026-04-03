using System.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization.SmartFormat.Core.Formatting
{
	public class FormatCache
	{
		public LocalizationTable Table;

		public Format Format { get; set; }

		public Dictionary<string, object> CachedObjects { get; }

		public IVariableGroup LocalVariables { get; set; }

		public List<IVariableValueChanged> VariableTriggers { get; }
	}
}
