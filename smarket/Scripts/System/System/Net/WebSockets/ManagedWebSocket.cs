using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.WebSockets
{
	internal sealed class ManagedWebSocket : WebSocket
	{
		private sealed class Utf8MessageState
		{
			internal bool SequenceInProgress;

			internal int AdditionalBytesExpected;

			internal int ExpectedValueMin;

			internal int CurrentDecodeBits;
		}

		private enum MessageOpcode : byte
		{
			Continuation = 0,
			Text = 1,
			Binary = 2,
			Close = 8,
			Ping = 9,
			Pong = 10
		}

		[StructLayout((LayoutKind)3)]
		private struct MessageHeader
		{
			internal MessageOpcode Opcode;

			internal bool Fin;

			internal long PayloadLength;

			internal int Mask;
		}

		private interface IWebSocketReceiveResultGetter<TResult>
		{
			TResult GetResult(int count, WebSocketMessageType messageType, bool endOfMessage, WebSocketCloseStatus? closeStatus, string closeDescription);
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		private readonly struct WebSocketReceiveResultGetter : IWebSocketReceiveResultGetter<WebSocketReceiveResult>
		{
			public WebSocketReceiveResult GetResult(int count, WebSocketMessageType messageType, bool endOfMessage, WebSocketCloseStatus? closeStatus, string closeDescription)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWaitForWriteTaskAsync_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ValueTask writeTask;

			public ManagedWebSocket _003C_003E4__this;

			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSendFrameFallbackAsync_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ManagedWebSocket _003C_003E4__this;

			public MessageOpcode opcode;

			public bool endOfMessage;

			public ReadOnlyMemory<byte> payloadBuffer;

			public CancellationToken cancellationToken;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			private CancellationTokenRegistration _003C_003E7__wrap1;

			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter _003C_003Eu__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReceiveAsyncPrivate_003Ed__61<TWebSocketReceiveResultGetter, TWebSocketReceiveResult> : IAsyncStateMachine where TWebSocketReceiveResultGetter : struct, IWebSocketReceiveResultGetter<TWebSocketReceiveResult>
		{
			public int _003C_003E1__state;

			public AsyncValueTaskMethodBuilder<TWebSocketReceiveResult> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public ManagedWebSocket _003C_003E4__this;

			public TWebSocketReceiveResultGetter resultGetter;

			public Memory<byte> payloadBuffer;

			private CancellationTokenRegistration _003Cregistration_003E5__2;

			private MessageHeader _003Cheader_003E5__3;

			private int _003CtotalBytesReceived_003E5__4;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter _003C_003Eu__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CHandleReceivedCloseAsync_003Ed__62 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ManagedWebSocket _003C_003E4__this;

			public MessageHeader header;

			public CancellationToken cancellationToken;

			private WebSocketCloseStatus _003CcloseStatus_003E5__2;

			private string _003CcloseStatusDescription_003E5__3;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CWaitForServerToCloseConnectionAsync_003Ed__63 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ManagedWebSocket _003C_003E4__this;

			public CancellationToken cancellationToken;

			private CancellationTokenSource _003CfinalCts_003E5__2;

			private CancellationTokenRegistration _003C_003E7__wrap2;

			private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CHandleReceivedPingPongAsync_003Ed__64 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public MessageHeader header;

			public ManagedWebSocket _003C_003E4__this;

			public CancellationToken cancellationToken;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter _003C_003Eu__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCloseWithReceiveErrorAndThrowAsync_003Ed__66 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ManagedWebSocket _003C_003E4__this;

			public WebSocketCloseStatus closeStatus;

			public WebSocketError error;

			public Exception innerException;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCloseAsyncPrivate_003Ed__68 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ManagedWebSocket _003C_003E4__this;

			public WebSocketCloseStatus closeStatus;

			public string statusDescription;

			public CancellationToken cancellationToken;

			private byte[] _003CcloseBuffer_003E5__2;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSendCloseFrameAsync_003Ed__69 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string closeStatusDescription;

			public WebSocketCloseStatus closeStatus;

			public ManagedWebSocket _003C_003E4__this;

			public CancellationToken cancellationToken;

			private byte[] _003Cbuffer_003E5__2;

			private ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter _003C_003Eu__1;

			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CEnsureBufferContainsAsync_003Ed__71 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ManagedWebSocket _003C_003E4__this;

			public int minimumRequiredBytes;

			public CancellationToken cancellationToken;

			public bool throwOnPrematureClosure;

			private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter _003C_003Eu__1;

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

		private static readonly RandomNumberGenerator s_random;

		private static readonly UTF8Encoding s_textEncoding;

		private static readonly WebSocketState[] s_validSendStates;

		private static readonly WebSocketState[] s_validReceiveStates;

		private static readonly WebSocketState[] s_validCloseOutputStates;

		private static readonly WebSocketState[] s_validCloseStates;

		private static readonly Task<WebSocketReceiveResult> s_cachedCloseTask;

		private readonly Stream _stream;

		private readonly bool _isServer;

		private readonly string _subprotocol;

		private readonly Timer _keepAliveTimer;

		private readonly CancellationTokenSource _abortSource;

		private Memory<byte> _receiveBuffer;

		private readonly Utf8MessageState _utf8TextState;

		private readonly SemaphoreSlim _sendFrameAsyncLock;

		private WebSocketState _state;

		private bool _disposed;

		private bool _sentCloseFrame;

		private bool _receivedCloseFrame;

		private WebSocketCloseStatus? _closeStatus;

		private string _closeStatusDescription;

		private MessageHeader _lastReceiveHeader;

		private int _receiveBufferOffset;

		private int _receiveBufferCount;

		private int _receivedMaskOffsetOffset;

		private byte[] _sendBuffer;

		private bool _lastSendWasFragment;

		private Task _lastReceiveAsync;

		private object StateUpdateLock => null;

		private object ReceiveAsyncLock => null;

		public override WebSocketCloseStatus? CloseStatus => null;

		public override string CloseStatusDescription => null;

		public override WebSocketState State => default(WebSocketState);

		public static ManagedWebSocket CreateFromConnectedStream(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval)
		{
			return null;
		}

		private ManagedWebSocket(Stream stream, bool isServer, string subprotocol, TimeSpan keepAliveInterval)
		{
		}

		public override void Dispose()
		{
		}

		private void DisposeCore()
		{
		}

		public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			return null;
		}

		private ValueTask SendPrivateAsync(ReadOnlyMemory<byte> buffer, WebSocketMessageType messageType, bool endOfMessage, CancellationToken cancellationToken)
		{
			return default(ValueTask);
		}

		public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task CloseAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			return null;
		}

		public override void Abort()
		{
		}

		private ValueTask SendFrameAsync(MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer, CancellationToken cancellationToken)
		{
			return default(ValueTask);
		}

		private ValueTask SendFrameLockAcquiredNonCancelableAsync(MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer)
		{
			return default(ValueTask);
		}

		[AsyncStateMachine(typeof(_003CWaitForWriteTaskAsync_003Ed__55))]
		private Task WaitForWriteTaskAsync(ValueTask writeTask)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSendFrameFallbackAsync_003Ed__56))]
		private Task SendFrameFallbackAsync(MessageOpcode opcode, bool endOfMessage, ReadOnlyMemory<byte> payloadBuffer, CancellationToken cancellationToken)
		{
			return null;
		}

		private int WriteFrameToSendBuffer(MessageOpcode opcode, bool endOfMessage, ReadOnlySpan<byte> payloadBuffer)
		{
			return 0;
		}

		private void SendKeepAliveFrameAsync()
		{
		}

		private static int WriteHeader(MessageOpcode opcode, byte[] sendBuffer, ReadOnlySpan<byte> payload, bool endOfMessage, bool useMask)
		{
			return 0;
		}

		private static void WriteRandomMask(byte[] buffer, int offset)
		{
		}

		[AsyncStateMachine(typeof(_003CReceiveAsyncPrivate_003Ed__61<, >))]
		private ValueTask<TWebSocketReceiveResult> ReceiveAsyncPrivate<TWebSocketReceiveResultGetter, TWebSocketReceiveResult>(Memory<byte> payloadBuffer, CancellationToken cancellationToken, TWebSocketReceiveResultGetter resultGetter = default(TWebSocketReceiveResultGetter)) where TWebSocketReceiveResultGetter : struct, IWebSocketReceiveResultGetter<TWebSocketReceiveResult>
		{
			return default(ValueTask<TWebSocketReceiveResult>);
		}

		[AsyncStateMachine(typeof(_003CHandleReceivedCloseAsync_003Ed__62))]
		private Task HandleReceivedCloseAsync(MessageHeader header, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CWaitForServerToCloseConnectionAsync_003Ed__63))]
		private Task WaitForServerToCloseConnectionAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CHandleReceivedPingPongAsync_003Ed__64))]
		private Task HandleReceivedPingPongAsync(MessageHeader header, CancellationToken cancellationToken)
		{
			return null;
		}

		private static bool IsValidCloseStatus(WebSocketCloseStatus closeStatus)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CCloseWithReceiveErrorAndThrowAsync_003Ed__66))]
		private Task CloseWithReceiveErrorAndThrowAsync(WebSocketCloseStatus closeStatus, WebSocketError error, Exception innerException = null)
		{
			return null;
		}

		private bool TryParseMessageHeaderFromReceiveBuffer(out MessageHeader resultHeader)
		{
			resultHeader = default(MessageHeader);
			return false;
		}

		[AsyncStateMachine(typeof(_003CCloseAsyncPrivate_003Ed__68))]
		private Task CloseAsyncPrivate(WebSocketCloseStatus closeStatus, string statusDescription, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSendCloseFrameAsync_003Ed__69))]
		private Task SendCloseFrameAsync(WebSocketCloseStatus closeStatus, string closeStatusDescription, CancellationToken cancellationToken)
		{
			return null;
		}

		private void ConsumeFromBuffer(int count)
		{
		}

		[AsyncStateMachine(typeof(_003CEnsureBufferContainsAsync_003Ed__71))]
		private Task EnsureBufferContainsAsync(int minimumRequiredBytes, CancellationToken cancellationToken, bool throwOnPrematureClosure = true)
		{
			return null;
		}

		private void ThrowIfEOFUnexpected(bool throwOnPrematureClosure)
		{
		}

		private void AllocateSendBuffer(int minLength)
		{
		}

		private void ReleaseSendBuffer()
		{
		}

		private static int CombineMaskBytes(Span<byte> buffer, int maskOffset)
		{
			return 0;
		}

		private static int ApplyMask(Span<byte> toMask, byte[] mask, int maskOffset, int maskOffsetIndex)
		{
			return 0;
		}

		private static int ApplyMask(Span<byte> toMask, int mask, int maskIndex)
		{
			return 0;
		}

		private void ThrowIfOperationInProgress(bool operationCompleted, [CallerMemberName] string methodName = null)
		{
		}

		private void ThrowOperationInProgress(string methodName)
		{
		}

		private static Exception CreateOperationCanceledException(Exception innerException, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		private static bool TryValidateUtf8(Span<byte> span, bool endOfMessage, Utf8MessageState state)
		{
			return false;
		}

		private Task ValidateAndReceiveAsync(Task receiveTask, byte[] buffer, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
