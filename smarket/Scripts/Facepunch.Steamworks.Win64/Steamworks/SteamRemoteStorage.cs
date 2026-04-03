using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Steamworks
{
	public class SteamRemoteStorage : SteamClientClass<SteamRemoteStorage>
	{
		[CompilerGenerated]
		private sealed class _003Cget_Files_003Ed__27 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int _003C__003E5__2;

			private int _003Ci_003E5__3;

			string IEnumerator<string>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003Cget_Files_003Ed__27(int _003C_003E1__state)
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
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal static ISteamRemoteStorage Internal => null;

		public static ulong QuotaBytes => 0uL;

		public static ulong QuotaUsedBytes => 0uL;

		public static ulong QuotaRemainingBytes => 0uL;

		public static bool IsCloudEnabled => false;

		public static bool IsCloudEnabledForAccount => false;

		public static bool IsCloudEnabledForApp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int FileCount => 0;

		public static IEnumerable<string> Files
		{
			[IteratorStateMachine(typeof(_003Cget_Files_003Ed__27))]
			get
			{
				return null;
			}
		}

		internal override bool InitializeInterface(bool server)
		{
			return false;
		}

		public static bool FileWrite(string filename, byte[] data)
		{
			return false;
		}

		public static byte[] FileRead(string filename)
		{
			return null;
		}

		public static bool FileExists(string filename)
		{
			return false;
		}

		public static bool FilePersisted(string filename)
		{
			return false;
		}

		public static DateTime FileTime(string filename)
		{
			return default(DateTime);
		}

		public static int FileSize(string filename)
		{
			return 0;
		}

		public static bool FileForget(string filename)
		{
			return false;
		}

		public static bool FileDelete(string filename)
		{
			return false;
		}
	}
}
