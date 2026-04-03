using System.Collections.Generic;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	public class Placeholder : FormatItem
	{
		public int NestedDepth { get; set; }

		public List<Selector> Selectors { get; }

		public int Alignment { get; set; }

		public string FormatterName { get; set; }

		public string FormatterOptions { get; set; }

		public Format Format { get; set; }

		public void ReleaseToPool()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
