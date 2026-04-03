using System.ComponentModel;
using System.Runtime.Serialization;

namespace System.Net.WebSockets
{
	/// <summary>Represents an exception that occurred when performing an operation on a WebSocket connection.</summary>
	[Serializable]
	public sealed class WebSocketException : Win32Exception
	{
		private readonly WebSocketError _webSocketErrorCode;

		/// <summary>The native error code for the exception that occurred.</summary>
		/// <returns>Returns <see cref="T:System.Int32" />.</returns>
		public override int ErrorCode => 0;

		/// <summary>Creates an instance of the <see cref="T:System.Net.WebSockets.WebSocketException" /> class.</summary>
		public WebSocketException()
		{
		}

		/// <summary>Creates an instance of the <see cref="T:System.Net.WebSockets.WebSocketException" /> class.</summary>
		/// <param name="error">The error from the WebSocketError enumeration.</param>
		public WebSocketException(WebSocketError error)
		{
		}

		/// <summary>Creates an instance of the <see cref="T:System.Net.WebSockets.WebSocketException" /> class.</summary>
		/// <param name="error">The error from the WebSocketError enumeration.</param>
		/// <param name="message">The description of the error.</param>
		public WebSocketException(WebSocketError error, string message)
		{
		}

		/// <summary>Creates an instance of the <see cref="T:System.Net.WebSockets.WebSocketException" /> class.</summary>
		/// <param name="error">The error from the WebSocketError enumeration.</param>
		/// <param name="innerException">Indicates the previous exception that led to the current exception.</param>
		public WebSocketException(WebSocketError error, Exception innerException)
		{
		}

		/// <summary>Creates an instance of the <see cref="T:System.Net.WebSockets.WebSocketException" /> class.</summary>
		/// <param name="error">The error from the WebSocketError enumeration.</param>
		/// <param name="message">The description of the error.</param>
		/// <param name="innerException">Indicates the previous exception that led to the current exception.</param>
		public WebSocketException(WebSocketError error, string message, Exception innerException)
		{
		}

		/// <summary>Creates an instance of the <see cref="T:System.Net.WebSockets.WebSocketException" /> class.</summary>
		/// <param name="nativeError">The native error code for the exception.</param>
		public WebSocketException(int nativeError)
		{
		}

		/// <summary>Creates an instance of the <see cref="T:System.Net.WebSockets.WebSocketException" /> class.</summary>
		/// <param name="message">The description of the error.</param>
		public WebSocketException(string message)
		{
		}

		/// <summary>Creates an instance of the <see cref="T:System.Net.WebSockets.WebSocketException" /> class.</summary>
		/// <param name="message">The description of the error.</param>
		/// <param name="innerException">Indicates the previous exception that led to the current exception.</param>
		public WebSocketException(string message, Exception innerException)
		{
		}

		private WebSocketException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		/// <summary>Sets the SerializationInfo object with the file name and line number where the exception occurred.</summary>
		/// <param name="info">A SerializationInfo object.</param>
		/// <param name="context">The contextual information about the source or destination.</param>
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private static string GetErrorMessage(WebSocketError error)
		{
			return null;
		}

		private void SetErrorCodeOnError(int nativeError)
		{
		}

		private static bool Succeeded(int hr)
		{
			return false;
		}
	}
}
