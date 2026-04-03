using System;

namespace UnityEngine.Rendering
{
	[ExecuteAlways]
	[AddComponentMenu("Rendering/Probe Adjustment Volume")]
	public class ProbeAdjustmentVolume : MonoBehaviour, ISerializationCallbackReceiver
	{
		public enum Shape
		{
			Box = 0,
			Sphere = 1
		}

		public enum Mode
		{
			InvalidateProbes = 0,
			OverrideValidityThreshold = 1,
			ApplyVirtualOffset = 2,
			OverrideVirtualOffsetSettings = 3,
			OverrideSkyDirection = 4,
			OverrideSampleCount = 5,
			OverrideRenderingLayerMask = 6,
			IntensityScale = 99
		}

		public enum RenderingLayerMaskOperation
		{
			Override = 0,
			Add = 1,
			Remove = 2
		}

		private enum Version
		{
			Initial = 0,
			Mode = 1,
			Count = 2
		}

		[Tooltip("Select the shape used for this Probe Adjustment Volume.")]
		public Shape shape;

		[Min(0f)]
		[Tooltip("Modify the size of this Probe Adjustment Volume. This is unaffected by the GameObject's Transform's Scale property.")]
		public Vector3 size;

		[Min(0f)]
		[Tooltip("Modify the radius of this Probe Adjustment Volume. This is unaffected by the GameObject's Transform's Scale property.")]
		public float radius;

		public Mode mode;

		[Range(0.0001f, 2f)]
		[Tooltip("A multiplier applied to the intensity of probes covered by this Probe Adjustment Volume.")]
		public float intensityScale;

		[Range(0f, 0.95f)]
		public float overriddenDilationThreshold;

		public Vector3 virtualOffsetRotation;

		[Min(0f)]
		public float virtualOffsetDistance;

		[Range(0f, 1f)]
		[Tooltip("Determines how far Unity pushes a probe out of geometry after a ray hit.")]
		public float geometryBias;

		[Range(0f, 0.95f)]
		public float virtualOffsetThreshold;

		[Range(-0.05f, 0f)]
		[Tooltip("Distance from the probe position used to determine the origin of the sampling ray.")]
		public float rayOriginBias;

		[Tooltip("The direction for sampling the ambient probe in worldspace when using the Sky Visibility feature.")]
		public Vector3 skyDirection;

		internal Vector3 skyShadingDirectionRotation;

		[Logarithmic(1, 1024)]
		[Tooltip("Number of samples for direct lighting computations.")]
		public int directSampleCount;

		[Logarithmic(1, 8192)]
		[Tooltip("Number of samples for indirect lighting computations. This includes environment samples.")]
		public int indirectSampleCount;

		[Min(0f)]
		[Tooltip("Multiplier for the number of samples specified above.")]
		public int sampleCountMultiplier;

		[Min(0f)]
		[Tooltip("Maximum number of bounces for indirect lighting.")]
		public int maxBounces;

		[Logarithmic(1, 8192)]
		public int skyOcclusionSampleCount;

		[Range(0f, 5f)]
		public int skyOcclusionMaxBounces;

		public RenderingLayerMaskOperation renderingLayerMaskOperation;

		public byte renderingLayerMask;

		[SerializeField]
		private Version version;

		[Obsolete("This field is only kept for migration purpose. Use mode instead. #from(2023.1)")]
		public bool invalidateProbes;

		[Obsolete("This field is only kept for migration purpose. Use mode instead. #from(2023.1)")]
		public bool overrideDilationThreshold;

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}
	}
}
