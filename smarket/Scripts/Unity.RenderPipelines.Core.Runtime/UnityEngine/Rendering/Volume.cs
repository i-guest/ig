using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering
{
	[ExecuteAlways]
	[AddComponentMenu("Miscellaneous/Volume")]
	public class Volume : MonoBehaviour, IVolume
	{
		[SerializeField]
		[FormerlySerializedAs("isGlobal")]
		private bool m_IsGlobal;

		[Delayed]
		[FormerlySerializedAs("m_Priority")]
		public float priority;

		[FormerlySerializedAs("m_BlendDistance")]
		public float blendDistance;

		[Range(0f, 1f)]
		[FormerlySerializedAs("m_Weight")]
		public float weight;

		public VolumeProfile sharedProfile;

		private readonly List<Collider> m_Colliders;

		private GameObject m_CachedGameObject;

		private int m_PreviousLayer;

		private float m_PreviousPriority;

		private VolumeProfile m_InternalProfile;

		public bool isGlobal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public VolumeProfile profile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Collider> colliders => null;

		internal GameObject cachedGameObject => null;

		internal VolumeProfile profileRef => null;

		public bool HasInstantiatedProfile()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void UpdateColliders()
		{
		}

		internal void UpdateLayer()
		{
		}

		internal void UpdatePriority()
		{
		}

		private void OnValidate()
		{
		}
	}
}
