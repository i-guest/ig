using System;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class SubStringFormatter : FormatterBase
	{
		public enum SubStringOutOfRangeBehavior
		{
			ReturnEmptyString = 0,
			ReturnStartIndexToEndOfString = 1,
			ThrowException = 2
		}

		[SerializeField]
		private char m_ParameterDelimiter;

		[SerializeField]
		private string m_NullDisplayString;

		[SerializeField]
		private SubStringOutOfRangeBehavior m_OutOfRangeBehavior;

		public SubStringOutOfRangeBehavior OutOfRangeBehavior
		{
			get
			{
				return default(SubStringOutOfRangeBehavior);
			}
			set
			{
			}
		}

		public override string[] DefaultNames => null;

		public char ParameterDelimiter
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		public string NullDisplayString
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			return false;
		}
	}
}
