using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Unity.AI.Navigation
{
	[ExecuteAlways]
	[DefaultExecutionOrder(-101)]
	[AddComponentMenu("Navigation/NavMesh Link", 33)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@2.0/manual/NavMeshLink.html")]
	public class NavMeshLink : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private byte m_SerializedVersion;

		[SerializeField]
		private int m_AgentTypeID;

		[SerializeField]
		private Vector3 m_StartPoint;

		[SerializeField]
		private Vector3 m_EndPoint;

		[SerializeField]
		private Transform m_StartTransform;

		[SerializeField]
		private Transform m_EndTransform;

		[SerializeField]
		private bool m_Activated;

		[SerializeField]
		private float m_Width;

		[SerializeField]
		[Min(0f)]
		private float m_CostModifier;

		[SerializeField]
		private bool m_IsOverridingCost;

		[SerializeField]
		private bool m_Bidirectional;

		[SerializeField]
		private bool m_AutoUpdatePosition;

		[SerializeField]
		private int m_Area;

		private NavMeshLinkInstance m_LinkInstance;

		private bool m_StartTransformWasEmpty;

		private bool m_EndTransformWasEmpty;

		private Vector3 m_LastStartWorldPosition;

		private Vector3 m_LastEndWorldPosition;

		private Vector3 m_LastPosition;

		private Quaternion m_LastRotation;

		private static readonly List<NavMeshLink> s_Tracked;

		public int agentTypeID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Vector3 startPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 endPoint
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Transform startTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform endTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float costModifier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool bidirectional
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool autoUpdate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int area
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool activated
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool occupied => false;

		[Obsolete("autoUpdatePositions has been deprecated. Use autoUpdate instead. (UnityUpgradable) -> autoUpdate")]
		public bool autoUpdatePositions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("biDirectional has been deprecated. Use bidirectional instead. (UnityUpgradable) -> bidirectional")]
		public bool biDirectional
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("costOverride has been deprecated. Use costModifier instead. (UnityUpgradable) -> costModifier")]
		public float costOverride
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void ClearTrackedList()
		{
		}

		private void UpgradeSerializedVersion()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateLink()
		{
		}

		private static void AddTracking(NavMeshLink link)
		{
		}

		private static void RemoveTracking(NavMeshLink link)
		{
		}

		internal void GetWorldPositions(out Vector3 worldStartPosition, out Vector3 worldEndPosition)
		{
			worldStartPosition = default(Vector3);
			worldEndPosition = default(Vector3);
		}

		internal void GetLocalPositions(out Vector3 localStartPosition, out Vector3 localEndPosition)
		{
			localStartPosition = default(Vector3);
			localEndPosition = default(Vector3);
		}

		private void AddLink()
		{
		}

		internal void RecordEndpointTransforms()
		{
		}

		internal bool HaveTransformsChanged()
		{
			return false;
		}

		internal Matrix4x4 LocalToWorldUnscaled()
		{
			return default(Matrix4x4);
		}

		private void OnDidApplyAnimationProperties()
		{
		}

		private static void UpdateTrackedInstances()
		{
		}

		[Obsolete("UpdatePositions() has been deprecated. Use UpdateLink() instead. (UnityUpgradable) -> UpdateLink(*)")]
		public void UpdatePositions()
		{
		}
	}
}
