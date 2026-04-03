namespace System.Net.WebSockets
{
	internal static class WebSocketValidate
	{
		internal static void ThrowIfInvalidState(WebSocketState currentState, bool isDisposed, WebSocketState[] validStates)
		{
		}

		internal static void ValidateSubprotocol(string subProtocol)
		{
		}

		internal static void ValidateCloseStatus(WebSocketCloseStatus closeStatus, string statusDescription)
		{
		}

		internal static void ValidateArraySegment(ArraySegment<byte> arraySegment, string parameterName)
		{
		}
	}
}
