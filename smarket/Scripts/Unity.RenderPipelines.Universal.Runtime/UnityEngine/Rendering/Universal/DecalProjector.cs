using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	[ExecuteAlways]
	[AddComponentMenu("Rendering/URP Decal Projector")]
	public class DecalProjector : MonoBehaviour, ISerializationCallbackReceiver
	{
		internal delegate void DecalProjectorAction(DecalProjector decalProjector);

		private enum Version
		{
			Initial = 0,
			RenderingLayerMask = 1,
			Count = 2
		}

		[SerializeField]
		private Material m_Material;

		[SerializeField]
		private float m_DrawDistance;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_FadeScale;

		[SerializeField]
		[Range(0f, 180f)]
		private float m_StartAngleFade;

		[SerializeField]
		[Range(0f, 180f)]
		private float m_EndAngleFade;

		[SerializeField]
		private Vector2 m_UVScale;

		[SerializeField]
		private Vector2 m_UVBias;

		[SerializeField]
		private RenderingLayerMask m_RenderingLayerMask;

		[SerializeField]
		private DecalScaleMode m_ScaleMode;

		[SerializeField]
		internal Vector3 m_Offset;

		[SerializeField]
		internal Vector3 m_Size;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_FadeFactor;

		private Material m_OldMaterial;

		private float m_OldDrawDistance;

		private float m_OldFadeScale;

		private float m_OldStartAngleFade;

		private float m_OldEndAngleFade;

		private Vector2 m_OldUVScale;

		private Vector2 m_OldUVBias;

		private DecalScaleMode m_OldScaleMode;

		private Vector3 m_OldOffset;

		private Vector3 m_OldSize;

		private float m_OldFadeFactor;

		[SerializeField]
		private Version version;

		[SerializeField]
		[Obsolete("This field is only kept for migration purpose. Use m_RenderingLayersMask instead. #from(6000.2)")]
		private uint m_DecalLayerMask;

		internal static Material defaultMaterial { get; set; }

		internal static bool isSupported => false;

		internal DecalEntity decalEntity { get; set; }

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float drawDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fadeScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float startAngleFade
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float endAngleFade
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 uvScale
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 uvBias
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public RenderingLayerMask renderingLayerMask
		{
			get
			{
				return default(RenderingLayerMask);
			}
			set
			{
			}
		}

		public DecalScaleMode scaleMode
		{
			get
			{
				return default(DecalScaleMode);
			}
			set
			{
			}
		}

		public Vector3 pivot
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 size
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float fadeFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal Vector3 effectiveScale => default(Vector3);

		internal Vector3 decalSize => default(Vector3);

		internal Vector3 decalOffset => default(Vector3);

		internal Vector4 uvScaleBias => default(Vector4);

		internal static event DecalProjectorAction onDecalAdd
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

		internal static event DecalProjectorAction onDecalRemove
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

		internal static event DecalProjectorAction onDecalPropertyChange
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

		internal static event Action onAllDecalPropertyChange
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

		internal static event DecalProjectorAction onDecalMaterialChange
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

		private void InitMaterial()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		internal void OnValidate()
		{
		}

		private void OnDidApplyAnimationProperties()
		{
		}

		public bool IsValid()
		{
			return false;
		}

		internal static void UpdateAllDecalProperties()
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}
	}
}
