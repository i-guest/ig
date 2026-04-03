using System.Text;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Core.Output
{
	public class StringOutput : IOutput
	{
		private readonly StringBuilder output;

		public StringOutput()
		{
		}

		public StringOutput(int capacity)
		{
		}

		public StringOutput(StringBuilder output)
		{
		}

		public void SetCapacity(int capacity)
		{
		}

		public void Write(string text, IFormattingInfo formattingInfo)
		{
		}

		public void Write(string text, int startIndex, int length, IFormattingInfo formattingInfo)
		{
		}

		public void Clear()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
