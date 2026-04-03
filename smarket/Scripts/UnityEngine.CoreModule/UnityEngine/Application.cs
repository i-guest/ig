using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Input/InputManager.h")]
	[NativeHeader("Runtime/Misc/BuildSettings.h")]
	[NativeHeader("Runtime/Misc/Player.h")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	[NativeHeader("Runtime/Application/AdsIdHandler.h")]
	[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
	[NativeHeader("NativeKernel/Logging/LogSystem.h")]
	[NativeHeader("Runtime/Input/TargetFrameRate.h")]
	[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
	[NativeHeader("Runtime/Application/ApplicationInfo.h")]
	[NativeHeader("Runtime/Network/NetworkUtility.h")]
	[NativeHeader("Runtime/Utilities/Argv.h")]
	[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
	[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
	[NativeHeader("Runtime/Utilities/URLUtility.h")]
	[NativeHeader("Runtime/Misc/SystemInfo.h")]
	public class Application
	{
		public delegate void LowMemoryCallback();

		public delegate void MemoryUsageChangedCallback(in ApplicationMemoryUsageChange usage);

		public delegate void LogCallback(string condition, string stackTrace, LogType type);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static LowMemoryCallback lowMemory;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static MemoryUsageChangedCallback memoryUsageChanged;

		private static LogCallback s_LogCallbackHandler;

		private static LogCallback s_LogCallbackHandlerThreaded;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<string> deepLinkActivated;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Func<bool> wantsToQuit;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action unloading;

		private static CancellationTokenSource s_currentCancellationTokenSource;

		public static bool isPlaying
		{
			[FreeFunction("IsWorldPlaying")]
			get
			{
				return false;
			}
		}

		public static bool isFocused
		{
			[FreeFunction("IsPlayerFocused")]
			get
			{
				return false;
			}
		}

		public static bool runInBackground
		{
			[FreeFunction("GetPlayerSettingsRunInBackground")]
			get
			{
				return false;
			}
			[FreeFunction("SetPlayerSettingsRunInBackground")]
			set
			{
			}
		}

		public static bool isBatchMode
		{
			[FreeFunction("::IsBatchmode")]
			get
			{
				return false;
			}
		}

		public static string dataPath
		{
			[FreeFunction("GetAppDataPath", IsThreadSafe = true)]
			get
			{
				return null;
			}
		}

		public static string streamingAssetsPath
		{
			[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = true)]
			get
			{
				return null;
			}
		}

		public static string persistentDataPath
		{
			[FreeFunction("GetPersistentDataPathApplicationSpecific")]
			get
			{
				return null;
			}
		}

		public static string unityVersion
		{
			[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = true)]
			get
			{
				return null;
			}
		}

		internal static int unityVersionVer
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			[FreeFunction("Application_Bindings::GetUnityVersionVer", IsThreadSafe = true)]
			get
			{
				return 0;
			}
		}

		internal static int unityVersionMaj
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			[FreeFunction("Application_Bindings::GetUnityVersionMaj", IsThreadSafe = true)]
			get
			{
				return 0;
			}
		}

		public static string productName
		{
			[FreeFunction("GetPlayerSettings().GetProductName")]
			get
			{
				return null;
			}
		}

		public static int targetFrameRate
		{
			[FreeFunction("GetTargetFrameRate")]
			get
			{
				return 0;
			}
			[FreeFunction("SetTargetFrameRate")]
			set
			{
			}
		}

		public static RuntimePlatform platform
		{
			[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = true)]
			get
			{
				return default(RuntimePlatform);
			}
		}

		public static bool isMobilePlatform => false;

		public static SystemLanguage systemLanguage
		{
			[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
			get
			{
				return default(SystemLanguage);
			}
		}

		public static NetworkReachability internetReachability
		{
			[FreeFunction("GetInternetReachability")]
			get
			{
				return default(NetworkReachability);
			}
		}

		public static bool isEditor => false;

		public static event LogCallback logMessageReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<bool> focusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action quitting
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[FreeFunction("GetInputManager().QuitApplication")]
		public static void Quit(int exitCode)
		{
		}

		public static void Quit()
		{
		}

		[FreeFunction("GetBuildSettings().GetHasPROVersion")]
		public static bool HasProLicense()
		{
			return false;
		}

		[FreeFunction("OpenURL")]
		public static void OpenURL(string url)
		{
		}

		[FreeFunction("Application_Bindings::SetLogCallbackDefined")]
		private static void SetLogCallbackDefined(bool defined)
		{
		}

		[RequiredByNativeCode]
		internal static void CallLowMemory(ApplicationMemoryUsage usage)
		{
		}

		[RequiredByNativeCode]
		internal static bool HasLogCallback()
		{
			return false;
		}

		[RequiredByNativeCode]
		private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
		{
		}

		[RequiredByNativeCode]
		private static bool Internal_ApplicationWantsToQuit()
		{
			return false;
		}

		[RequiredByNativeCode]
		private static void Internal_InitializeExitCancellationToken()
		{
		}

		[RequiredByNativeCode]
		private static void Internal_RaiseExitCancellationToken()
		{
		}

		[RequiredByNativeCode]
		private static void Internal_ApplicationQuit()
		{
		}

		[RequiredByNativeCode]
		private static void Internal_ApplicationUnload()
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeOnBeforeRender()
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeFocusChanged(bool focus)
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeDeepLinkActivated(string url)
		{
		}

		private static void get_dataPath_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void get_streamingAssetsPath_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void get_persistentDataPath_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void get_unityVersion_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void get_productName_Injected(out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void OpenURL_Injected(ref ManagedSpanWrapper url)
		{
		}
	}
}
