using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Microsoft.GDK.Tools
{
	[CreateAssetMenu(fileName = "GDKSettings", menuName = "GDK/GDK Settings", order = 1)]
	public class GdkSettingsAsset : ScriptableObject
	{
		public enum ShellVisualsMode
		{
			Disabled = 0,
			RunMakePriAndCopy = 1,
			CopyOnly = 2
		}

		[Serializable]
		public class PlatformGdkSettings
		{
			public RuntimePlatform runtimePlatform;

			public bool targetMicrosoftGdk;

			public GameConfigAsset gameConfigAsset;

			public ShellVisualsMode shellVisualsMode;

			[Obsolete("Please do not use, will be removed in future. The MICROSOFT_GDK_SUPPORT define is now present when targetMicrosoftGdk is true", false)]
			public bool createScriptingDefine;

			public bool createPackage;

			public bool sideloadPackage;
		}

		public bool createGdkPlatformSettingsCs;

		public bool createGdkPlatformSettingsDefine;

		public string gdkPlatformSettingsCsNamespace;

		public List<PlatformGdkSettings> settingsList;

		public bool SettingsExistForRuntimePlatform(RuntimePlatform platform)
		{
			return false;
		}

		public bool SettingsForRuntimePlatform(RuntimePlatform platform, out PlatformGdkSettings platformSettings)
		{
			platformSettings = null;
			return false;
		}

		public IEnumerable<PlatformGdkSettings> GetPlatformSettingsList()
		{
			return null;
		}
	}
}
