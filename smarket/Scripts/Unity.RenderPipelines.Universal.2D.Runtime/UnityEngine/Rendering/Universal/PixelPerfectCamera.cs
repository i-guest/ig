using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.Universal
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("Rendering/2D/Pixel Perfect Camera")]
	[RequireComponent(typeof(Camera))]
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.Universal", null, null)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@latest/index.html?subfolder=/manual/2d-pixelperfect.html%23properties")]
	public class PixelPerfectCamera : MonoBehaviour, IPixelPerfectCamera, ISerializationCallbackReceiver
	{
		public enum CropFrame
		{
			None = 0,
			Pillarbox = 1,
			Letterbox = 2,
			Windowbox = 3,
			StretchFill = 4
		}

		public enum GridSnapping
		{
			None = 0,
			PixelSnapping = 1,
			UpscaleRenderTexture = 2
		}

		public enum PixelPerfectFilterMode
		{
			RetroAA = 0,
			Point = 1
		}

		private enum ComponentVersions
		{
			Version_Unserialized = 0,
			Version_1 = 1
		}

		[SerializeField]
		private int m_AssetsPPU;

		[SerializeField]
		private int m_RefResolutionX;

		[SerializeField]
		private int m_RefResolutionY;

		[SerializeField]
		private CropFrame m_CropFrame;

		[SerializeField]
		private GridSnapping m_GridSnapping;

		[SerializeField]
		private PixelPerfectFilterMode m_FilterMode;

		private Camera m_Camera;

		private PixelPerfectCameraInternal m_Internal;

		private bool m_CinemachineCompatibilityMode;

		public CropFrame cropFrame
		{
			get
			{
				return default(CropFrame);
			}
			set
			{
			}
		}

		public GridSnapping gridSnapping
		{
			get
			{
				return default(GridSnapping);
			}
			set
			{
			}
		}

		public float orthographicSize => 0f;

		public int assetsPPU
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int refResolutionX
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int refResolutionY
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Obsolete("Use gridSnapping instead #from(2021.2)")]
		public bool upscaleRT
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Use gridSnapping instead #from(2021.2)")]
		public bool pixelSnapping
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Use cropFrame instead #from(2021.2)")]
		public bool cropFrameX
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Use cropFrame instead #from(2021.2)")]
		public bool cropFrameY
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Use cropFrame instead. #from(2021.2)")]
		public bool stretchFill
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int pixelRatio => 0;

		public bool requiresUpscalePass => false;

		internal FilterMode finalBlitFilterMode => default(FilterMode);

		internal Vector2Int offscreenRTSize => default(Vector2Int);

		private Vector2Int cameraRTSize => default(Vector2Int);

		public Vector3 RoundToPixel(Vector3 position)
		{
			return default(Vector3);
		}

		public float CorrectCinemachineOrthoSize(float targetOrthoSize)
		{
			return 0f;
		}

		private void PixelSnap()
		{
		}

		private void Awake()
		{
		}

		private void UpdateCameraProperties()
		{
		}

		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		private void OnEnable()
		{
		}

		internal void OnDisable()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
