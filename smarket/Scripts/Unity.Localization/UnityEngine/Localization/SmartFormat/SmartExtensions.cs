using System.IO;
using System.Text;
using UnityEngine.Localization.SmartFormat.Core.Formatting;

namespace UnityEngine.Localization.SmartFormat
{
	public static class SmartExtensions
	{
		public static void AppendSmart(this StringBuilder sb, string format, params object[] args)
		{
		}

		public static void AppendLineSmart(this StringBuilder sb, string format, params object[] args)
		{
		}

		public static void WriteSmart(this TextWriter writer, string format, params object[] args)
		{
		}

		public static void WriteLineSmart(this TextWriter writer, string format, params object[] args)
		{
		}

		public static string FormatSmart(this string format, params object[] args)
		{
			return null;
		}

		public static string FormatSmart(this string format, ref FormatCache cache, params object[] args)
		{
			return null;
		}
	}
}
