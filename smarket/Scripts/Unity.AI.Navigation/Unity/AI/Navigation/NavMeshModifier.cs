using System.Collections.Generic;
using UnityEngine;

namespace Unity.AI.Navigation
{
	[ExecuteAlways]
	[DefaultExecutionOrder(-103)]
	[AddComponentMenu("Navigation/NavMesh Modifier", 32)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@2.0/manual/NavMeshModifier.html")]
	public class NavMeshModifier : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private byte m_SerializedVersion;

		[SerializeField]
		private bool m_OverrideArea;

		[SerializeField]
		private int m_Area;

		[SerializeField]
		private bool m_OverrideGenerateLinks;

		[SerializeField]
		private bool m_GenerateLinks;

		[SerializeField]
		private bool m_IgnoreFromBuild;

		[SerializeField]
		private bool m_ApplyToChildren;

		[SerializeField]
		private List<int> m_AffectedAgents;

		private static bool s_RebuildNavMeshModifiers;

		private static List<NavMeshModifier> s_NavMeshModifiers;

		private static readonly HashSet<NavMeshModifier> s_NavMeshModifiersSet;

		public bool overrideArea
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

		public bool overrideGenerateLinks
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool generateLinks
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreFromBuild
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool applyToChildren
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static List<NavMeshModifier> activeModifiers => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void ClearNavMeshModifiers()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RegisterModifier()
		{
		}

		private void UnregisterModifier()
		{
		}

		public bool AffectsAgentType(int agentTypeID)
		{
			return false;
		}
	}
}
