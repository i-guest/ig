namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	public class Selector : FormatItem
	{
		private string m_Operator;

		internal int operatorStart;

		public int SelectorIndex { get; internal set; }

		public string Operator => null;

		public override void Clear()
		{
		}
	}
}
