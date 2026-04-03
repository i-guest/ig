using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.Animations.Rigging
{
	internal static class RigUtils
	{
		private struct RigSyncSceneToStreamData : IAnimationJobData, IRigSyncSceneToStreamData
		{
			private readonly bool m_IsValid;

			public Transform[] syncableTransforms { get; private set; }

			public SyncableProperties[] syncableProperties { get; private set; }

			public bool[] rigStates { get; set; }

			public RigSyncSceneToStreamData(Transform[] transforms, SyncableProperties[] properties, int rigCount)
			{
				syncableTransforms = null;
				syncableProperties = null;
				rigStates = null;
				m_IsValid = false;
			}

			private static int[] UniqueTransformIndices(Transform[] transforms)
			{
				return null;
			}

			bool IAnimationJobData.IsValid()
			{
				return false;
			}

			void IAnimationJobData.SetDefaultValues()
			{
			}
		}

		internal static readonly Dictionary<Type, PropertyDescriptor> s_SupportedPropertyTypeToDescriptor;

		public static IAnimationJobBinder syncSceneToStreamBinder { get; }

		public static IRigConstraint[] GetConstraints(Rig rig)
		{
			return null;
		}

		private static Transform[] GetSyncableRigTransforms(Animator animator)
		{
			return null;
		}

		private static bool ExtractTransformType(Animator animator, FieldInfo field, object data, List<Transform> syncableTransforms)
		{
			return false;
		}

		private static bool ExtractPropertyType(FieldInfo field, object data, List<Property> syncableProperties, string namePrefix = "")
		{
			return false;
		}

		private static bool ExtractWeightedTransforms(Animator animator, FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties)
		{
			return false;
		}

		private static bool ExtractNestedPropertyType(Animator animator, FieldInfo field, object data, List<Transform> syncableTransforms, List<Property> syncableProperties, string namePrefix = "")
		{
			return false;
		}

		private static void ExtractAllSyncableData(Animator animator, IList<IRigLayer> layers, out List<Transform> syncableTransforms, out List<SyncableProperties> syncableProperties)
		{
			syncableTransforms = null;
			syncableProperties = null;
		}

		public static IAnimationJob[] CreateAnimationJobs(Animator animator, IRigConstraint[] constraints)
		{
			return null;
		}

		public static void DestroyAnimationJobs(IRigConstraint[] constraints, IAnimationJob[] jobs)
		{
		}

		internal static IAnimationJobData CreateSyncSceneToStreamData(Animator animator, IList<IRigLayer> layers)
		{
			return null;
		}
	}
}
