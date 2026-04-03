using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamHTTP : SteamInterface
	{
		public const string Version = "STEAMHTTP_INTERFACE_VERSION003";

		internal ISteamHTTP(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamHTTP_v003();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamGameServerHTTP_v003();

		public override IntPtr GetServerInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern HTTPRequestHandle _CreateHTTPRequest(IntPtr self, HTTPMethod eHTTPRequestMethod, string pchAbsoluteURL);

		internal HTTPRequestHandle CreateHTTPRequest(HTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		[PreserveSig]
		private static extern bool _SetHTTPRequestContextValue(IntPtr self, HTTPRequestHandle hRequest, ulong ulContextValue);

		internal bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetHTTPRequestNetworkActivityTimeout(IntPtr self, HTTPRequestHandle hRequest, uint unTimeoutSeconds);

		internal bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetHTTPRequestHeaderValue(IntPtr self, HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue);

		internal bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetHTTPRequestGetOrPostParameter(IntPtr self, HTTPRequestHandle hRequest, string pchParamName, string pchParamValue);

		internal bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SendHTTPRequest(IntPtr self, HTTPRequestHandle hRequest, ref SteamAPICall_t pCallHandle);

		internal bool SendHTTPRequest(HTTPRequestHandle hRequest, ref SteamAPICall_t pCallHandle)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SendHTTPRequestAndStreamResponse(IntPtr self, HTTPRequestHandle hRequest, ref SteamAPICall_t pCallHandle);

		internal bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, ref SteamAPICall_t pCallHandle)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _DeferHTTPRequest(IntPtr self, HTTPRequestHandle hRequest);

		internal bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _PrioritizeHTTPRequest(IntPtr self, HTTPRequestHandle hRequest);

		internal bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetHTTPResponseHeaderSize(IntPtr self, HTTPRequestHandle hRequest, string pchHeaderName, ref uint unResponseHeaderSize);

		internal bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, ref uint unResponseHeaderSize)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetHTTPResponseHeaderValue(IntPtr self, HTTPRequestHandle hRequest, string pchHeaderName, ref byte pHeaderValueBuffer, uint unBufferSize);

		internal bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, ref byte pHeaderValueBuffer, uint unBufferSize)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetHTTPResponseBodySize(IntPtr self, HTTPRequestHandle hRequest, ref uint unBodySize);

		internal bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, ref uint unBodySize)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetHTTPResponseBodyData(IntPtr self, HTTPRequestHandle hRequest, ref byte pBodyDataBuffer, uint unBufferSize);

		internal bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, ref byte pBodyDataBuffer, uint unBufferSize)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetHTTPStreamingResponseBodyData(IntPtr self, HTTPRequestHandle hRequest, uint cOffset, ref byte pBodyDataBuffer, uint unBufferSize);

		internal bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, ref byte pBodyDataBuffer, uint unBufferSize)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _ReleaseHTTPRequest(IntPtr self, HTTPRequestHandle hRequest);

		internal bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetHTTPDownloadProgressPct(IntPtr self, HTTPRequestHandle hRequest, ref float pflPercentOut);

		internal bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, ref float pflPercentOut)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetHTTPRequestRawPostBody(IntPtr self, HTTPRequestHandle hRequest, string pchContentType, [In][Out] byte[] pubBody, uint unBodyLen);

		internal bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, [In][Out] byte[] pubBody, uint unBodyLen)
		{
			return false;
		}

		[PreserveSig]
		private static extern HTTPCookieContainerHandle _CreateCookieContainer(IntPtr self, bool bAllowResponsesToModify);

		internal HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		[PreserveSig]
		private static extern bool _ReleaseCookieContainer(IntPtr self, HTTPCookieContainerHandle hCookieContainer);

		internal bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetCookie(IntPtr self, HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie);

		internal bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetHTTPRequestCookieContainer(IntPtr self, HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer);

		internal bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetHTTPRequestUserAgentInfo(IntPtr self, HTTPRequestHandle hRequest, string pchUserAgentInfo);

		internal bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetHTTPRequestRequiresVerifiedCertificate(IntPtr self, HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate);

		internal bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _SetHTTPRequestAbsoluteTimeoutMS(IntPtr self, HTTPRequestHandle hRequest, uint unMilliseconds);

		internal bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _GetHTTPRequestWasTimedOut(IntPtr self, HTTPRequestHandle hRequest, ref bool pbWasTimedOut);

		internal bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, ref bool pbWasTimedOut)
		{
			return false;
		}
	}
}
