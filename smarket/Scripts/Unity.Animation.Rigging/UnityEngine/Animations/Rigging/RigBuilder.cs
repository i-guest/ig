using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Animations.Rigging
{
	[RequireComponent(typeof(Animator))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[AddComponentMenu("Animation Rigging/Setup/Rig Builder")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.4/manual/RiggingWorkflow.html#rig-builder-component")]
	public class RigBuilder : MonoBehaviour, IAnimationWindowPreview, IRigEffectorHolder
	{
		public delegate void OnAddRigBuilderCallback(RigBuilder rigBuilder);

		public delegate void OnRemoveRigBuilderCallback(RigBuilder rigBuilder);

		[SerializeField]
		private List<RigLayer> m_RigLayers;

		private IRigLayer[] m_RuntimeRigLayers;

		private SyncSceneToStreamLayer m_SyncSceneToStreamLayer;

		[SerializeField]
		private List<RigEffectorData> m_Effectors;

		private bool m_IsInPreview;

		public static OnAddRigBuilderCallback onAddRigBuilder;

		public static OnRemoveRigBuilderCallback onRemoveRigBuilder;

		public List<RigLayer> layers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private SyncSceneToStreamLayer syncSceneToStreamLayer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PlayableGraph graph { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Evaluate(float deltaTime)
		{
		}

		private void Update()
		{
		}

		public void SyncLayers()
		{
		}

		public bool Build()
		{
			return false;
		}

		public bool Build(PlayableGraph graph)
		{
			return false;
		}

		public void Clear()
		{
		}

		public void StartPreview()
		{
		}

		public void StopPreview()
		{
		}

		public void UpdatePreviewGraph(PlayableGraph graph)
		{
		}

		public Playable BuildPreviewGraph(PlayableGraph graph, Playable inputPlayable)
		{
			return default(Playable);
		}
	}
}
