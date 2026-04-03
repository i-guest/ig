using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Android
{
	[StructLayout((LayoutKind)0)]
	[NativeType(Header = "Modules/AndroidJNI/Public/AndroidConfiguration.bindings.h")]
	[RequiredByNativeCode]
	[NativeAsStruct]
	public sealed class AndroidConfiguration
	{
		private int colorMode { get; }

		public int densityDpi { get; }

		public float fontScale { get; }

		public int fontWeightAdjustment { get; }

		public AndroidKeyboard keyboard { get; }

		public AndroidHardwareKeyboardHidden hardKeyboardHidden { get; }

		public AndroidKeyboardHidden keyboardHidden { get; }

		public int mobileCountryCode { get; }

		public int mobileNetworkCode { get; }

		public AndroidNavigation navigation { get; }

		public AndroidNavigationHidden navigationHidden { get; }

		public AndroidOrientation orientation { get; }

		public int screenHeightDp { get; }

		public int screenWidthDp { get; }

		public int smallestScreenWidthDp { get; }

		private int screenLayout { get; }

		public AndroidTouchScreen touchScreen { get; }

		private int uiMode { get; }

		private string primaryLocaleCountry { get; }

		private string primaryLocaleLanguage { get; }

		public AndroidLocale[] locales => null;

		public AndroidColorModeHdr colorModeHdr => default(AndroidColorModeHdr);

		public AndroidColorModeWideColorGamut colorModeWideColorGamut => default(AndroidColorModeWideColorGamut);

		public AndroidScreenLayoutDirection screenLayoutDirection => default(AndroidScreenLayoutDirection);

		public AndroidScreenLayoutLong screenLayoutLong => default(AndroidScreenLayoutLong);

		public AndroidScreenLayoutRound screenLayoutRound => default(AndroidScreenLayoutRound);

		public AndroidScreenLayoutSize screenLayoutSize => default(AndroidScreenLayoutSize);

		public AndroidUIModeNight uiModeNight => default(AndroidUIModeNight);

		public AndroidUIModeType uiModeType => default(AndroidUIModeType);

		[Preserve]
		public override string ToString()
		{
			return null;
		}
	}
}
