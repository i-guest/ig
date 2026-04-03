using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class XRSRPSettings
	{
		public static bool enabled => false;

		public static bool isDeviceActive => false;

		public static string loadedDeviceName => null;

		public static string[] supportedDevices => null;

		public static RenderTextureDescriptor eyeTextureDesc => default(RenderTextureDescriptor);

		public static int eyeTextureWidth => 0;

		public static int eyeTextureHeight => 0;

		public static float occlusionMeshScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static bool useVisibilityMesh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int mirrorViewMode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}
}
