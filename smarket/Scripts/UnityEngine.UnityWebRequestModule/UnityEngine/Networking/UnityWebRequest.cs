using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
	public class UnityWebRequest : IDisposable
	{
		internal enum UnityWebRequestMethod
		{
			Get = 0,
			Post = 1,
			Put = 2,
			Head = 3,
			Custom = 4
		}

		internal enum UnityWebRequestError
		{
			OK = 0,
			OKCached = 1,
			Unknown = 2,
			SDKError = 3,
			UnsupportedProtocol = 4,
			MalformattedUrl = 5,
			CannotResolveProxy = 6,
			CannotResolveHost = 7,
			CannotConnectToHost = 8,
			AccessDenied = 9,
			GenericHttpError = 10,
			WriteError = 11,
			ReadError = 12,
			OutOfMemory = 13,
			Timeout = 14,
			HTTPPostError = 15,
			SSLCannotConnect = 16,
			Aborted = 17,
			TooManyRedirects = 18,
			ReceivedNoData = 19,
			SSLNotSupported = 20,
			FailedToSendData = 21,
			FailedToReceiveData = 22,
			SSLCertificateError = 23,
			SSLCipherNotAvailable = 24,
			SSLCACertError = 25,
			UnrecognizedContentEncoding = 26,
			LoginFailed = 27,
			SSLShutdownFailed = 28,
			RedirectLimitInvalid = 29,
			InvalidRedirect = 30,
			CannotModifyRequest = 31,
			HeaderNameContainsInvalidCharacters = 32,
			HeaderValueContainsInvalidCharacters = 33,
			CannotOverrideSystemHeaders = 34,
			AlreadySent = 35,
			InvalidMethod = 36,
			NotImplemented = 37,
			NoInternetConnection = 38,
			DataProcessingError = 39,
			InsecureConnectionNotAllowed = 40
		}

		public enum Result
		{
			InProgress = 0,
			Success = 1,
			ConnectionError = 2,
			ProtocolError = 3,
			DataProcessingError = 4
		}

		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(UnityWebRequest unityWebRequest)
			{
				return (IntPtr)0;
			}
		}

		[NonSerialized]
		internal IntPtr m_Ptr;

		[NonSerialized]
		internal DownloadHandler m_DownloadHandler;

		[NonSerialized]
		internal UploadHandler m_UploadHandler;

		[NonSerialized]
		internal CertificateHandler m_CertificateHandler;

		[NonSerialized]
		internal Uri m_Uri;

		public const string kHttpVerbGET = "GET";

		public const string kHttpVerbHEAD = "HEAD";

		public const string kHttpVerbPOST = "POST";

		public const string kHttpVerbPUT = "PUT";

		public const string kHttpVerbCREATE = "CREATE";

		public const string kHttpVerbDELETE = "DELETE";

		public bool disposeCertificateHandlerOnDispose { get; set; }

		public bool disposeDownloadHandlerOnDispose { get; set; }

		public bool disposeUploadHandlerOnDispose { get; set; }

		public string method
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string error => null;

		public string url
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Uri uri
		{
			set
			{
			}
		}

		public long responseCode => 0L;

		public float uploadProgress => 0f;

		public bool isModifiable
		{
			[NativeMethod("IsModifiable")]
			get
			{
				return false;
			}
		}

		public bool isDone => false;

		public Result result
		{
			[NativeMethod("GetResult")]
			get
			{
				return default(Result);
			}
		}

		public float downloadProgress => 0f;

		public ulong downloadedBytes => 0uL;

		public int redirectLimit
		{
			set
			{
			}
		}

		public UploadHandler uploadHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DownloadHandler downloadHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CertificateHandler certificateHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int timeout
		{
			set
			{
			}
		}

		[NativeMethod(IsThreadSafe = true)]
		[NativeConditional("ENABLE_UNITYWEBREQUEST")]
		private static string GetWebErrorString(UnityWebRequestError err)
		{
			return null;
		}

		[VisibleToOtherModules]
		internal static string GetHTTPStatusString(long responseCode)
		{
			return null;
		}

		[NativeThrows]
		internal static IntPtr Create()
		{
			return (IntPtr)0;
		}

		[NativeMethod(IsThreadSafe = true)]
		private void Release()
		{
		}

		internal void InternalDestroy()
		{
		}

		private void InternalSetDefaults()
		{
		}

		public UnityWebRequest()
		{
		}

		public UnityWebRequest(string url, string method)
		{
		}

		public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
		{
		}

		public UnityWebRequest(Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
		{
		}

		~UnityWebRequest()
		{
		}

		public void Dispose()
		{
		}

		private void DisposeHandlers()
		{
		}

		[NativeThrows]
		internal UnityWebRequestAsyncOperation BeginWebRequest()
		{
			return null;
		}

		public UnityWebRequestAsyncOperation SendWebRequest()
		{
			return null;
		}

		[NativeMethod(IsThreadSafe = true)]
		public void Abort()
		{
		}

		private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType)
		{
			return default(UnityWebRequestError);
		}

		internal void InternalSetMethod(UnityWebRequestMethod methodType)
		{
		}

		private UnityWebRequestError SetCustomMethod(string customMethodName)
		{
			return default(UnityWebRequestError);
		}

		internal void InternalSetCustomMethod(string customMethodName)
		{
		}

		internal UnityWebRequestMethod GetMethod()
		{
			return default(UnityWebRequestMethod);
		}

		internal string GetCustomMethod()
		{
			return null;
		}

		private UnityWebRequestError GetError()
		{
			return default(UnityWebRequestError);
		}

		private string GetUrl()
		{
			return null;
		}

		private UnityWebRequestError SetUrl(string url)
		{
			return default(UnityWebRequestError);
		}

		private void InternalSetUrl(string url)
		{
		}

		private float GetUploadProgress()
		{
			return 0f;
		}

		private bool IsExecuting()
		{
			return false;
		}

		private float GetDownloadProgress()
		{
			return 0f;
		}

		[NativeThrows]
		private void SetRedirectLimitFromScripting(int limit)
		{
		}

		[NativeMethod("SetRequestHeader")]
		internal UnityWebRequestError InternalSetRequestHeader(string name, string value)
		{
			return default(UnityWebRequestError);
		}

		public void SetRequestHeader(string name, string value)
		{
		}

		public string GetResponseHeader(string name)
		{
			return null;
		}

		private UnityWebRequestError SetUploadHandler(UploadHandler uh)
		{
			return default(UnityWebRequestError);
		}

		private UnityWebRequestError SetDownloadHandler(DownloadHandler dh)
		{
			return default(UnityWebRequestError);
		}

		private UnityWebRequestError SetCertificateHandler(CertificateHandler ch)
		{
			return default(UnityWebRequestError);
		}

		private UnityWebRequestError SetTimeoutMsec(int timeout)
		{
			return default(UnityWebRequestError);
		}

		public static UnityWebRequest Get(string uri)
		{
			return null;
		}

		public static UnityWebRequest Post(string uri, WWWForm formData)
		{
			return null;
		}

		private static void SetupPost(UnityWebRequest request, WWWForm formData)
		{
		}

		private static void GetWebErrorString_Injected(UnityWebRequestError err, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void GetHTTPStatusString_Injected(long responseCode, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void Release_Injected(IntPtr _unity_self)
		{
		}

		private static IntPtr BeginWebRequest_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void Abort_Injected(IntPtr _unity_self)
		{
		}

		private static UnityWebRequestError SetMethod_Injected(IntPtr _unity_self, UnityWebRequestMethod methodType)
		{
			return default(UnityWebRequestError);
		}

		private static UnityWebRequestError SetCustomMethod_Injected(IntPtr _unity_self, ref ManagedSpanWrapper customMethodName)
		{
			return default(UnityWebRequestError);
		}

		private static UnityWebRequestMethod GetMethod_Injected(IntPtr _unity_self)
		{
			return default(UnityWebRequestMethod);
		}

		private static void GetCustomMethod_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static UnityWebRequestError GetError_Injected(IntPtr _unity_self)
		{
			return default(UnityWebRequestError);
		}

		private static void GetUrl_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static UnityWebRequestError SetUrl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper url)
		{
			return default(UnityWebRequestError);
		}

		private static long get_responseCode_Injected(IntPtr _unity_self)
		{
			return 0L;
		}

		private static float GetUploadProgress_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static bool IsExecuting_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_isModifiable_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static Result get_result_Injected(IntPtr _unity_self)
		{
			return default(Result);
		}

		private static float GetDownloadProgress_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static ulong get_downloadedBytes_Injected(IntPtr _unity_self)
		{
			return 0uL;
		}

		private static void SetRedirectLimitFromScripting_Injected(IntPtr _unity_self, int limit)
		{
		}

		private static UnityWebRequestError InternalSetRequestHeader_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, ref ManagedSpanWrapper value)
		{
			return default(UnityWebRequestError);
		}

		private static void GetResponseHeader_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static UnityWebRequestError SetUploadHandler_Injected(IntPtr _unity_self, IntPtr uh)
		{
			return default(UnityWebRequestError);
		}

		private static UnityWebRequestError SetDownloadHandler_Injected(IntPtr _unity_self, IntPtr dh)
		{
			return default(UnityWebRequestError);
		}

		private static UnityWebRequestError SetCertificateHandler_Injected(IntPtr _unity_self, IntPtr ch)
		{
			return default(UnityWebRequestError);
		}

		private static UnityWebRequestError SetTimeoutMsec_Injected(IntPtr _unity_self, int timeout)
		{
			return default(UnityWebRequestError);
		}
	}
}
