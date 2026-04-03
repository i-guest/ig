using System;
using System.Runtime.InteropServices;

namespace Unity.XGamingRuntime.Interop
{
	internal class XGRInterop
	{
		[PreserveSig]
		public static extern int HCInitialize(IntPtr args);

		[PreserveSig]
		public static extern int HCCleanupAsync(XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		public static extern int HCWebSocketCreate(out IntPtr websocket, [Optional] HCWebSocketMessageFunction messageFunc, [Optional] HCWebSocketBinaryMessageFunction binaryMessageFunc, [Optional] HCWebSocketCloseEventFunction closeFunc, IntPtr functionContext);

		[PreserveSig]
		public static extern int HCWebSocketSetProxyUri(IntPtr websocket, byte[] proxyUri);

		[PreserveSig]
		public static extern int HCWebSocketSetHeader(IntPtr websocket, byte[] headerName, byte[] headerValue);

		[PreserveSig]
		public static extern int HCWebSocketGetEventFunctions(IntPtr websocket, [Optional] out HCWebSocketMessageFunction messageFunc, [Optional] out HCWebSocketBinaryMessageFunction binaryMessageFunc, [Optional] out HCWebSocketCloseEventFunction closeFunc, out IntPtr functionContext);

		[PreserveSig]
		public static extern int HCWebSocketConnectAsync(byte[] uri, byte[] subProtocol, IntPtr websocket, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		public static extern int HCGetWebSocketConnectResult(XAsyncBlockPtr asyncBlock, [In] ref WebSocketCompletionResult result);

		[PreserveSig]
		public static extern int HCWebSocketSendMessageAsync(IntPtr websocket, byte[] message, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		public static extern int HCWebSocketSendBinaryMessageAsync(IntPtr websocket, byte[] data, uint payloadSize, XAsyncBlockPtr asyncBlock);

		[PreserveSig]
		public static extern int HCGetWebSocketSendMessageResult(XAsyncBlockPtr asyncBlock, [In] ref WebSocketCompletionResult result);

		[PreserveSig]
		public static extern int HCWebSocketDisconnect(IntPtr websocket);

		[PreserveSig]
		public static extern IntPtr HCWebSocketDuplicateHandle(IntPtr websocket);

		[PreserveSig]
		public static extern int HCWebSocketCloseHandle(IntPtr websocket);

		[PreserveSig]
		public static extern int HCAddWebSocketRoutedHandler(HCWebSocketRoutedHandler handler, IntPtr conext);

		[PreserveSig]
		public static extern void HCRemoveWebSocketRoutedHandler(int handlerId);
	}
}
