using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Core.Formatting;
using UnityEngine.Localization.SmartFormat.Core.Output;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Localization.SmartFormat.Core.Settings;

namespace UnityEngine.Localization.SmartFormat
{
	[Serializable]
	public class SmartFormatter : ISerializationCallbackReceiver
	{
		[SerializeReference]
		private SmartSettings m_Settings;

		[SerializeReference]
		private Parser m_Parser;

		[SerializeReference]
		private List<ISource> m_Sources;

		[SerializeReference]
		private List<IFormatter> m_Formatters;

		private List<string> m_NotEmptyFormatterExtensionNames;

		private static readonly object[] k_Empty;

		public List<ISource> SourceExtensions => null;

		public List<IFormatter> FormatterExtensions => null;

		public Parser Parser
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SmartSettings Settings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event EventHandler<FormattingErrorEventArgs> OnFormattingFailure
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public List<string> GetNotEmptyFormatterExtensionNames()
		{
			return null;
		}

		public void AddExtensions(params ISource[] sourceExtensions)
		{
		}

		public void AddExtensions(params IFormatter[] formatterExtensions)
		{
		}

		public T GetSourceExtension<T>() where T : class
		{
			return null;
		}

		public T GetFormatterExtension<T>() where T : class
		{
			return null;
		}

		public string Format(string format, params object[] args)
		{
			return null;
		}

		public string Format(IList<object> args, string format)
		{
			return null;
		}

		public string Format(IFormatProvider provider, string format, params object[] args)
		{
			return null;
		}

		public string Format(IFormatProvider provider, IList<object> args, string format)
		{
			return null;
		}

		public void FormatInto(IOutput output, string format, params object[] args)
		{
		}

		public string FormatWithCache(ref FormatCache cache, string format, IList<object> args)
		{
			return null;
		}

		public string FormatWithCache(ref FormatCache cache, string format, IFormatProvider formatProvider, IList<object> args)
		{
			return null;
		}

		public void FormatWithCacheInto(ref FormatCache cache, IOutput output, string format, params object[] args)
		{
		}

		private void Format(FormatDetails formatDetails, Format format, object current)
		{
		}

		public virtual void Format(FormattingInfo formattingInfo)
		{
		}

		private void FormatError(FormatItem errorItem, Exception innerException, int startIndex, FormattingInfo formattingInfo)
		{
		}

		private void CheckForExtensions()
		{
		}

		private void EvaluateSelectors(FormattingInfo formattingInfo)
		{
		}

		private bool InvokeSourceExtensions(FormattingInfo formattingInfo)
		{
			return false;
		}

		private void EvaluateFormatters(FormattingInfo formattingInfo)
		{
		}

		private bool InvokeFormatterExtensions(FormattingInfo formattingInfo)
		{
			return false;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
