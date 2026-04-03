using System;
using UnityEngine.Scripting;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	[RequiredByNativeCode]
	public sealed class PhysicsLowLevelSettings2D : ScriptableObject
	{
		[SerializeField]
		[Header("Layers")]
		private PhysicsLayers.LayerNames m_PhysicsLayerNames;

		[SerializeField]
		private bool m_UseFullLayers;

		[SerializeField]
		[Header("Default Definitions")]
		private PhysicsWorldDefinition m_PhysicsWorldDefinition;

		[SerializeField]
		private PhysicsBodyDefinition m_PhysicsBodyDefinition;

		[SerializeField]
		private PhysicsShapeDefinition m_PhysicsShapeDefinition;

		[SerializeField]
		private PhysicsChainDefinition m_PhysicsChainDefinition;

		[SerializeField]
		private PhysicsDistanceJointDefinition m_PhysicsDistanceJointDefinition;

		[SerializeField]
		private PhysicsFixedJointDefinition m_PhysicsFixedJointDefinition;

		[SerializeField]
		private PhysicsHingeJointDefinition m_PhysicsHingeJointDefinition;

		[SerializeField]
		private PhysicsRelativeJointDefinition m_PhysicsRelativeJointDefinition;

		[SerializeField]
		private PhysicsSliderJointDefinition m_PhysicsSliderJointDefinition;

		[SerializeField]
		private PhysicsWheelJointDefinition m_PhysicsWheelJointDefinition;

		[SerializeField]
		[Range(1f, 64f)]
		[Header("Globals")]
		private int m_ConcurrentSimulations;

		[Min(1E-05f)]
		[SerializeField]
		private float m_LengthUnitsPerMeter;

		[SerializeField]
		private bool m_DrawInBuild;

		[SerializeField]
		private bool m_BypassLowLevel;

		public PhysicsLayers.LayerNames physicsLayerNames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool useFullLayers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PhysicsWorldDefinition physicsWorldDefinition
		{
			get
			{
				return default(PhysicsWorldDefinition);
			}
			set
			{
			}
		}

		public PhysicsBodyDefinition physicsBodyDefinition
		{
			get
			{
				return default(PhysicsBodyDefinition);
			}
			set
			{
			}
		}

		public PhysicsShapeDefinition physicsShapeDefinition
		{
			get
			{
				return default(PhysicsShapeDefinition);
			}
			set
			{
			}
		}

		public PhysicsChainDefinition physicsChainDefinition
		{
			get
			{
				return default(PhysicsChainDefinition);
			}
			set
			{
			}
		}

		[Range(1f, 64f)]
		public int concurrentSimulations
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float lengthUnitsPerMeter
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool drawInBuild
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool bypassLowLevel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Reset()
		{
		}

		[RequiredByNativeCode]
		private void GetPhysicsLayerNames(out PhysicsLayers.LayerNames layerNames)
		{
			layerNames = null;
		}

		[RequiredByNativeCode]
		private void GetPhysicsWorldDefinition(out PhysicsWorldDefinition definition)
		{
			definition = default(PhysicsWorldDefinition);
		}

		[RequiredByNativeCode]
		private void GetPhysicsBodyDefinition(out PhysicsBodyDefinition definition)
		{
			definition = default(PhysicsBodyDefinition);
		}

		[RequiredByNativeCode]
		private void GetPhysicsShapeDefinition(out PhysicsShapeDefinition definition)
		{
			definition = default(PhysicsShapeDefinition);
		}

		[RequiredByNativeCode]
		private void GetPhysicsChainDefinition(out PhysicsChainDefinition definition)
		{
			definition = default(PhysicsChainDefinition);
		}

		[RequiredByNativeCode]
		private void GetPhysicsDistanceJointDefinition(out PhysicsDistanceJointDefinition definition)
		{
			definition = default(PhysicsDistanceJointDefinition);
		}

		[RequiredByNativeCode]
		private void GetPhysicsFixedJointDefinition(out PhysicsFixedJointDefinition definition)
		{
			definition = default(PhysicsFixedJointDefinition);
		}

		[RequiredByNativeCode]
		private void GetPhysicsHingeJointDefinition(out PhysicsHingeJointDefinition definition)
		{
			definition = default(PhysicsHingeJointDefinition);
		}

		[RequiredByNativeCode]
		private void GetPhysicsRelativeJointDefinition(out PhysicsRelativeJointDefinition definition)
		{
			definition = default(PhysicsRelativeJointDefinition);
		}

		[RequiredByNativeCode]
		private void GetPhysicsSliderJointDefinition(out PhysicsSliderJointDefinition definition)
		{
			definition = default(PhysicsSliderJointDefinition);
		}

		[RequiredByNativeCode]
		private void GetPhysicsWheelJointDefinition(out PhysicsWheelJointDefinition definition)
		{
			definition = default(PhysicsWheelJointDefinition);
		}

		[RequiredByNativeCode]
		private int GetConcurrentSimulations()
		{
			return 0;
		}

		[RequiredByNativeCode]
		private float GetLengthUnitsPerMeter()
		{
			return 0f;
		}

		[RequiredByNativeCode]
		private bool GetDrawInBuild()
		{
			return false;
		}

		[RequiredByNativeCode]
		private bool GetBypassLowLevel()
		{
			return false;
		}

		[RequiredByNativeCode]
		private bool GetUseFullLayers()
		{
			return false;
		}
	}
}
