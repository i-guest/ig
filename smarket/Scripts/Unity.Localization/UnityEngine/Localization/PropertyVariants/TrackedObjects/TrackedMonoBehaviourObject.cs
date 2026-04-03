using System;
using UnityEngine.Events;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	[Serializable]
	[CustomTrackedObject(typeof(MonoBehaviour), true)]
	public class TrackedMonoBehaviourObject : JsonSerializerTrackedObject
	{
		[SerializeField]
		private UnityEvent m_Changed;

		public UnityEvent Changed => null;

		protected override void PostApplyTrackedProperties()
		{
		}
	}
}
