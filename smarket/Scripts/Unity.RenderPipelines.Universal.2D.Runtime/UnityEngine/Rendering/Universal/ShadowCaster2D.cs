using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.Universal
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("Rendering/2D/Shadow Caster 2D")]
	[MovedFrom(false, "UnityEngine.Experimental.Rendering.Universal", "com.unity.render-pipelines.universal", null)]
	public class ShadowCaster2D : ShadowCasterGroup2D, ISerializationCallbackReceiver
	{
		internal enum ComponentVersions
		{
			Version_Unserialized = 0,
			Version_1 = 1,
			Version_2 = 2,
			Version_3 = 3,
			Version_4 = 4,
			Version_5 = 5
		}

		internal enum ShadowCastingSources
		{
			None = 0,
			ShapeEditor = 1,
			ShapeProvider = 2
		}

		public enum ShadowCastingOptions
		{
			SelfShadow = 0,
			CastShadow = 1,
			CastAndSelfShadow = 2,
			NoShadow = 3
		}

		internal enum EdgeProcessing
		{
			None = 0,
			Clipping = 1
		}

		private const ComponentVersions k_CurrentComponentVersion = ComponentVersions.Version_5;

		[SerializeField]
		private ComponentVersions m_ComponentVersion;

		[SerializeField]
		private bool m_HasRenderer;

		[SerializeField]
		private bool m_UseRendererSilhouette;

		[SerializeField]
		private bool m_CastsShadows;

		[SerializeField]
		private bool m_SelfShadows;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_AlphaCutoff;

		[SerializeField]
		private int[] m_ApplyToSortingLayers;

		[SerializeField]
		private Vector3[] m_ShapePath;

		[SerializeField]
		private int m_ShapePathHash;

		[SerializeField]
		private int m_InstanceId;

		[SerializeField]
		private Component m_ShadowShape2DComponent;

		[SerializeReference]
		private ShadowShape2DProvider m_ShadowShape2DProvider;

		[SerializeField]
		private ShadowCastingSources m_ShadowCastingSource;

		[SerializeField]
		internal ShadowMesh2D m_ShadowMesh;

		[SerializeField]
		private ShadowCastingOptions m_CastingOption;

		[SerializeField]
		internal float m_PreviousTrimEdge;

		[SerializeField]
		internal int m_PreviousEdgeProcessing;

		[SerializeField]
		internal int m_PreviousShadowCastingSource;

		[SerializeField]
		internal Component m_PreviousShadowShape2DSource;

		internal ShadowCasterGroup2D m_ShadowCasterGroup;

		internal ShadowCasterGroup2D m_PreviousShadowCasterGroup;

		internal bool m_ForceShadowMeshRebuild;

		private int m_PreviousShadowGroup;

		private bool m_PreviousCastsShadows;

		private int m_PreviousPathHash;

		private int m_SpriteMaterialCount;

		internal Vector3 m_CachedPosition;

		internal Vector3 m_CachedLossyScale;

		internal Quaternion m_CachedRotation;

		internal Matrix4x4 m_CachedShadowMatrix;

		internal Matrix4x4 m_CachedInverseShadowMatrix;

		internal Matrix4x4 m_CachedLocalToWorldMatrix;

		internal EdgeProcessing edgeProcessing
		{
			get
			{
				return default(EdgeProcessing);
			}
			set
			{
			}
		}

		public Mesh mesh => null;

		public BoundingSphere boundingSphere => default(BoundingSphere);

		public float trimEdge
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float alphaCutoff
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3[] shapePath => null;

		internal int shapePathHash
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal ShadowCastingSources shadowCastingSource
		{
			get
			{
				return default(ShadowCastingSources);
			}
			set
			{
			}
		}

		internal Component shadowShape2DComponent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ShadowShape2DProvider shadowShape2DProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal int spriteMaterialCount => 0;

		public ShadowCastingOptions castingOption
		{
			get
			{
				return default(ShadowCastingOptions);
			}
			set
			{
			}
		}

		[Obsolete("useRendererSilhoutte is deprecated. Use selfShadows instead. #from(2023.1)")]
		public bool useRendererSilhouette
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool selfShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool castsShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal override void CacheValues()
		{
		}

		private static int[] SetDefaultSortingLayers()
		{
			return null;
		}

		internal bool IsLit(Light2D light)
		{
			return false;
		}

		internal bool IsShadowedLayer(int layer)
		{
			return false;
		}

		private void SetShadowShape(ShadowMesh2D shadowMesh)
		{
		}

		private void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		public void Update()
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
