using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Steamworks.Data
{
	public struct Achievement
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public string ident;

			public int i;

			public bool gotCallback;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetIconAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Image?> _003C_003Et__builder;

			public Achievement _003C_003E4__this;

			public int timeout;

			private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

			private int _003Cwaited_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		internal string Value;

		public bool State => false;

		public string Identifier => null;

		public string Name => null;

		public string Description => null;

		public DateTime? UnlockTime => null;

		public float GlobalUnlocked => 0f;

		public Achievement(string name)
		{
			Value = null;
		}

		public override string ToString()
		{
			return null;
		}

		public Image? GetIcon()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetIconAsync_003Ed__14))]
		public Task<Image?> GetIconAsync(int timeout = 5000)
		{
			return null;
		}

		public bool Trigger(bool apply = true)
		{
			return false;
		}

		public bool Clear()
		{
			return false;
		}
	}
}
