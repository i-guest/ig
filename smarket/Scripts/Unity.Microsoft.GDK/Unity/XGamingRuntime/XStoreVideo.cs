using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XStoreVideo
	{
		internal Unity.XGamingRuntime.Interop.XStoreVideo _interop;

		internal XStoreImage _previewImage;

		internal Unity.XGamingRuntime.Interop.XStoreVideo interop
		{
			get
			{
				return default(Unity.XGamingRuntime.Interop.XStoreVideo);
			}
			set
			{
			}
		}

		public string Uri
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint Height
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint Width
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public string Caption
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string VideoPurposeTag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XStoreImage PreviewImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal XStoreVideo(Unity.XGamingRuntime.Interop.XStoreVideo interop)
		{
		}

		public XStoreVideo()
		{
		}
	}
}
