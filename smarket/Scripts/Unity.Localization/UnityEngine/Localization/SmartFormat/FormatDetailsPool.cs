using System;
using System.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Formatting;
using UnityEngine.Localization.SmartFormat.Core.Output;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Pool;

namespace UnityEngine.Localization.SmartFormat
{
	internal static class FormatDetailsPool
	{
		internal static readonly ObjectPool<FormatDetails> s_Pool;

		public static FormatDetails Get(SmartFormatter formatter, Format originalFormat, IList<object> originalArgs, FormatCache formatCache, IFormatProvider provider, IOutput output)
		{
			return null;
		}

		public static PooledObject<FormatDetails> Get(SmartFormatter formatter, Format originalFormat, object[] originalArgs, FormatCache formatCache, IFormatProvider provider, IOutput output, out FormatDetails value)
		{
			value = null;
			return default(PooledObject<FormatDetails>);
		}

		public static void Release(FormatDetails toRelease)
		{
		}
	}
}
