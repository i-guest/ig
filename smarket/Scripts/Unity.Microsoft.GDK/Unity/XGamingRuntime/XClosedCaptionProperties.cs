using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XClosedCaptionProperties
	{
		internal Unity.XGamingRuntime.Interop.XClosedCaptionProperties _interop;

		internal XColor _backgroundColor;

		internal XColor _fontColor;

		internal XColor _windowColor;

		internal Unity.XGamingRuntime.Interop.XClosedCaptionProperties interop => default(Unity.XGamingRuntime.Interop.XClosedCaptionProperties);

		public XColor BackgroundColor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XColor FontColor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XColor WindowColor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XClosedCaptionFontEdgeAttribute FontEdgeAttribute
		{
			get
			{
				return default(XClosedCaptionFontEdgeAttribute);
			}
			set
			{
			}
		}

		public XClosedCaptionFontStyle FontStyle
		{
			get
			{
				return default(XClosedCaptionFontStyle);
			}
			set
			{
			}
		}

		public float FontScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal XClosedCaptionProperties(Unity.XGamingRuntime.Interop.XClosedCaptionProperties interop)
		{
		}

		public XClosedCaptionProperties()
		{
		}
	}
}
