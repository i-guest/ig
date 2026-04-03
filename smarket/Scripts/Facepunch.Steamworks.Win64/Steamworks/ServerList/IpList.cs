using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Steamworks.ServerList
{
	public class IpList : Internet
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRunQueryAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public IpList _003C_003E4__this;

			public float timeoutSeconds;

			private int _003CblockSize_003E5__2;

			private int _003Cpointer_003E5__3;

			private string[] _003Cips_003E5__4;

			private List<string> _003Csublist_003E5__5;

			private Internet _003Clist_003E5__6;

			private TaskAwaiter<bool> _003C_003Eu__1;

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

		public List<string> Ips;

		private bool wantsCancel;

		public IpList(IEnumerable<string> list)
		{
		}

		public IpList(params string[] list)
		{
		}

		[AsyncStateMachine(typeof(_003CRunQueryAsync_003Ed__4))]
		public override Task<bool> RunQueryAsync(float timeoutSeconds = 10f)
		{
			return null;
		}

		public override void Cancel()
		{
		}

		public override void Dispose()
		{
		}
	}
}
