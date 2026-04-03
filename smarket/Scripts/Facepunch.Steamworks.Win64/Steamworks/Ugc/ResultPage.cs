using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	public struct ResultPage : IDisposable
	{
		[CompilerGenerated]
		private sealed class _003Cget_Entries_003Ed__10 : IEnumerable<Item>, IEnumerable, IEnumerator<Item>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Item _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public ResultPage _003C_003E4__this;

			public ResultPage _003C_003E3___003C_003E4__this;

			private SteamUGCDetails_t _003Cdetails_003E5__2;

			private uint _003Ci_003E5__3;

			Item IEnumerator<Item>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(Item);
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
			public _003Cget_Entries_003Ed__10(int _003C_003E1__state)
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
			IEnumerator<Item> IEnumerable<Item>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal UGCQueryHandle_t Handle;

		public int ResultCount;

		public int TotalCount;

		public bool CachedData;

		internal bool ReturnsKeyValueTags;

		internal bool ReturnsDefaultStats;

		internal bool ReturnsMetadata;

		internal bool ReturnsChildren;

		internal bool ReturnsAdditionalPreviews;

		public IEnumerable<Item> Entries
		{
			[IteratorStateMachine(typeof(_003Cget_Entries_003Ed__10))]
			get
			{
				return null;
			}
		}

		private ulong GetStat(uint index, ItemStatistic stat)
		{
			return 0uL;
		}

		public void Dispose()
		{
		}
	}
}
