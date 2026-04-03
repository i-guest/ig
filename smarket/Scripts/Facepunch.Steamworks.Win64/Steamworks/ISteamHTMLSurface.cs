using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamHTMLSurface : SteamInterface
	{
		public const string Version = "STEAMHTMLSURFACE_INTERFACE_VERSION_005";

		internal ISteamHTMLSurface(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamHTMLSurface_v005();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern bool _Init(IntPtr self);

		internal bool Init()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool _Shutdown(IntPtr self);

		internal bool Shutdown()
		{
			return false;
		}

		[PreserveSig]
		private static extern SteamAPICall_t _CreateBrowser(IntPtr self, string pchUserAgent, string pchUserCSS);

		internal CallResult<HTML_BrowserReady_t> CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			return default(CallResult<HTML_BrowserReady_t>);
		}

		[PreserveSig]
		private static extern void _RemoveBrowser(IntPtr self, HHTMLBrowser unBrowserHandle);

		internal void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
		}

		[PreserveSig]
		private static extern void _LoadURL(IntPtr self, HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData);

		internal void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
		}

		[PreserveSig]
		private static extern void _SetSize(IntPtr self, HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight);

		internal void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
		}

		[PreserveSig]
		private static extern void _StopLoad(IntPtr self, HHTMLBrowser unBrowserHandle);

		internal void StopLoad(HHTMLBrowser unBrowserHandle)
		{
		}

		[PreserveSig]
		private static extern void _Reload(IntPtr self, HHTMLBrowser unBrowserHandle);

		internal void Reload(HHTMLBrowser unBrowserHandle)
		{
		}

		[PreserveSig]
		private static extern void _GoBack(IntPtr self, HHTMLBrowser unBrowserHandle);

		internal void GoBack(HHTMLBrowser unBrowserHandle)
		{
		}

		[PreserveSig]
		private static extern void _GoForward(IntPtr self, HHTMLBrowser unBrowserHandle);

		internal void GoForward(HHTMLBrowser unBrowserHandle)
		{
		}

		[PreserveSig]
		private static extern void _AddHeader(IntPtr self, HHTMLBrowser unBrowserHandle, string pchKey, string pchValue);

		internal void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
		}

		[PreserveSig]
		private static extern void _ExecuteJavascript(IntPtr self, HHTMLBrowser unBrowserHandle, string pchScript);

		internal void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
		}

		[PreserveSig]
		private static extern void _MouseUp(IntPtr self, HHTMLBrowser unBrowserHandle, IntPtr eMouseButton);

		internal void MouseUp(HHTMLBrowser unBrowserHandle, IntPtr eMouseButton)
		{
		}

		[PreserveSig]
		private static extern void _MouseDown(IntPtr self, HHTMLBrowser unBrowserHandle, IntPtr eMouseButton);

		internal void MouseDown(HHTMLBrowser unBrowserHandle, IntPtr eMouseButton)
		{
		}

		[PreserveSig]
		private static extern void _MouseDoubleClick(IntPtr self, HHTMLBrowser unBrowserHandle, IntPtr eMouseButton);

		internal void MouseDoubleClick(HHTMLBrowser unBrowserHandle, IntPtr eMouseButton)
		{
		}

		[PreserveSig]
		private static extern void _MouseMove(IntPtr self, HHTMLBrowser unBrowserHandle, int x, int y);

		internal void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		[PreserveSig]
		private static extern void _MouseWheel(IntPtr self, HHTMLBrowser unBrowserHandle, int nDelta);

		internal void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
		}

		[PreserveSig]
		private static extern void _KeyDown(IntPtr self, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, IntPtr eHTMLKeyModifiers, bool bIsSystemKey);

		internal void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, IntPtr eHTMLKeyModifiers, bool bIsSystemKey)
		{
		}

		[PreserveSig]
		private static extern void _KeyUp(IntPtr self, HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, IntPtr eHTMLKeyModifiers);

		internal void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, IntPtr eHTMLKeyModifiers)
		{
		}

		[PreserveSig]
		private static extern void _KeyChar(IntPtr self, HHTMLBrowser unBrowserHandle, uint cUnicodeChar, IntPtr eHTMLKeyModifiers);

		internal void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, IntPtr eHTMLKeyModifiers)
		{
		}

		[PreserveSig]
		private static extern void _SetHorizontalScroll(IntPtr self, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		internal void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		[PreserveSig]
		private static extern void _SetVerticalScroll(IntPtr self, HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll);

		internal void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		[PreserveSig]
		private static extern void _SetKeyFocus(IntPtr self, HHTMLBrowser unBrowserHandle, bool bHasKeyFocus);

		internal void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
		}

		[PreserveSig]
		private static extern void _ViewSource(IntPtr self, HHTMLBrowser unBrowserHandle);

		internal void ViewSource(HHTMLBrowser unBrowserHandle)
		{
		}

		[PreserveSig]
		private static extern void _CopyToClipboard(IntPtr self, HHTMLBrowser unBrowserHandle);

		internal void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		[PreserveSig]
		private static extern void _PasteFromClipboard(IntPtr self, HHTMLBrowser unBrowserHandle);

		internal void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		[PreserveSig]
		private static extern void _Find(IntPtr self, HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse);

		internal void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
		}

		[PreserveSig]
		private static extern void _StopFind(IntPtr self, HHTMLBrowser unBrowserHandle);

		internal void StopFind(HHTMLBrowser unBrowserHandle)
		{
		}

		[PreserveSig]
		private static extern void _GetLinkAtPosition(IntPtr self, HHTMLBrowser unBrowserHandle, int x, int y);

		internal void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		[PreserveSig]
		private static extern void _SetCookie(IntPtr self, string pchHostname, string pchKey, string pchValue, string pchPath, RTime32 nExpires, bool bSecure, bool bHTTPOnly);

		internal void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath, RTime32 nExpires, bool bSecure, bool bHTTPOnly)
		{
		}

		[PreserveSig]
		private static extern void _SetPageScaleFactor(IntPtr self, HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY);

		internal void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
		}

		[PreserveSig]
		private static extern void _SetBackgroundMode(IntPtr self, HHTMLBrowser unBrowserHandle, bool bBackgroundMode);

		internal void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
		}

		[PreserveSig]
		private static extern void _SetDPIScalingFactor(IntPtr self, HHTMLBrowser unBrowserHandle, float flDPIScaling);

		internal void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling)
		{
		}

		[PreserveSig]
		private static extern void _OpenDeveloperTools(IntPtr self, HHTMLBrowser unBrowserHandle);

		internal void OpenDeveloperTools(HHTMLBrowser unBrowserHandle)
		{
		}

		[PreserveSig]
		private static extern void _AllowStartRequest(IntPtr self, HHTMLBrowser unBrowserHandle, bool bAllowed);

		internal void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
		}

		[PreserveSig]
		private static extern void _JSDialogResponse(IntPtr self, HHTMLBrowser unBrowserHandle, bool bResult);

		internal void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
		}

		[PreserveSig]
		private static extern void _FileLoadDialogResponse(IntPtr self, HHTMLBrowser unBrowserHandle, string pchSelectedFiles);

		internal void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, string pchSelectedFiles)
		{
		}
	}
}
