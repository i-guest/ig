using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.SmartFormat.Core.Settings;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	public abstract class FormatItem
	{
		private struct PartialCharEnumerator : IEnumerable<char>, IEnumerable
		{
			[CompilerGenerated]
			private sealed class _003CGetEnumerator_003Ed__4 : IEnumerator<char>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private char _003C_003E2__current;

				public PartialCharEnumerator _003C_003E4__this;

				private int _003Ci_003E5__2;

				char IEnumerator<char>.Current
				{
					[DebuggerHidden]
					get
					{
						return '\0';
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
				public _003CGetEnumerator_003Ed__4(int _003C_003E1__state)
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
			}

			private string m_BaseString;

			private int m_From;

			private int m_To;

			public PartialCharEnumerator(string s, int from, int to)
			{
				m_BaseString = null;
				m_From = 0;
				m_To = 0;
			}

			[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__4))]
			public IEnumerator<char> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public string baseString;

		public int endIndex;

		protected SmartSettings SmartSettings;

		public int startIndex;

		protected string m_RawText;

		public FormatItem Parent { get; private set; }

		public string RawText => null;

		public void Init(SmartSettings smartSettings, FormatItem parent, int startIndex)
		{
		}

		public void Init(SmartSettings smartSettings, FormatItem parent, int startIndex, int endIndex)
		{
		}

		public void Init(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex)
		{
		}

		public virtual void Clear()
		{
		}

		public IEnumerable<char> ToEnumerable()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
