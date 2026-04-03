using System;
using UnityEngine.Localization.Metadata;

namespace UnityEngine.Localization.Platform.iOS
{
	[Serializable]
	[DisplayName("Apple App Info", null)]
	[Metadata(AllowedTypes = MetadataType.LocalizationSettings, AllowMultiple = false, MenuItem = "Apple/App Info")]
	public class AppInfo : IMetadata
	{
		[Tooltip("The user-visible name for the bundle, used by Siri, visible on the iOS Home screen and Mac app menu.\nThis name can contain up to 15 characters.\nCFBundleName field in xcode projects info.plist file.")]
		[SerializeField]
		private LocalizedString m_ShortName;

		[Tooltip("The user-visible name for the bundle, used by Siri visible on the iOS Home screen and Mac app menu.\nUse this key if you want a product name that's longer than Bundle Name.\nCFBundleDisplayName field in xcode projects info.plist file.")]
		[SerializeField]
		private LocalizedString m_DisplayName;

		[Tooltip("A message that tells the user why the app is requesting access to the device’s camera.\nNSCameraUsageDescription field in xcode projects info.plist file.")]
		[SerializeField]
		private LocalizedString m_CameraUsageDescription;

		[Tooltip("A message that tells the user why the app is requesting access to the device’s microphone.\nNSMicrophoneUsageDescription field in xcode projects info.plist file.")]
		[SerializeField]
		private LocalizedString m_MicrophoneUsageDescription;

		[Tooltip("A message that tells the user why the app is requesting access to the user’s location information while the app is running in the foreground.\nNSLocationWhenInUseUsageDescription field in xcode projects info.plist file.")]
		[SerializeField]
		private LocalizedString m_LocationUsageDescription;

		[Tooltip("A message that informs the user why an app is requesting permission to use data for tracking the user or the device.\nNSUserTrackingUsageDescription field in xcode projects info.plist file.")]
		[SerializeField]
		private LocalizedString m_UserTrackingUsageDescription;

		public LocalizedString ShortName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedString DisplayName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedString CameraUsageDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedString MicrophoneUsageDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedString LocationUsageDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedString UserTrackingUsageDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
