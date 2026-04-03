using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	internal static class TimeSpanFormatOptionsConverter
	{
		[CompilerGenerated]
		private sealed class _003CAllFlags_003Ed__3 : IEnumerable<TimeSpanFormatOptions>, IEnumerable, IEnumerator<TimeSpanFormatOptions>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private TimeSpanFormatOptions _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private TimeSpanFormatOptions timeSpanFormatOptions;

			public TimeSpanFormatOptions _003C_003E3__timeSpanFormatOptions;

			private uint _003Cvalue_003E5__2;

			TimeSpanFormatOptions IEnumerator<TimeSpanFormatOptions>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(TimeSpanFormatOptions);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CAllFlags_003Ed__3(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<TimeSpanFormatOptions> IEnumerable<TimeSpanFormatOptions>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static readonly Regex parser;

		public static TimeSpanFormatOptions Merge(this TimeSpanFormatOptions left, TimeSpanFormatOptions right)
		{
			return default(TimeSpanFormatOptions);
		}

		public static TimeSpanFormatOptions Mask(this TimeSpanFormatOptions timeSpanFormatOptions, TimeSpanFormatOptions mask)
		{
			return default(TimeSpanFormatOptions);
		}

		[IteratorStateMachine(typeof(_003CAllFlags_003Ed__3))]
		public static IEnumerable<TimeSpanFormatOptions> AllFlags(this TimeSpanFormatOptions timeSpanFormatOptions)
		{
			return null;
		}

		public static TimeSpanFormatOptions Parse(string formatOptionsString)
		{
			return default(TimeSpanFormatOptions);
		}
	}
}
