using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct WeightedTransform : ITransformProvider, IWeightProvider, IEquatable<WeightedTransform>
	{
		public Transform transform;

		public float weight;

		Transform ITransformProvider.transform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		float IWeightProvider.weight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public WeightedTransform(Transform transform, float weight)
		{
			this.transform = null;
			this.weight = 0f;
		}

		public static WeightedTransform Default(float weight)
		{
			return default(WeightedTransform);
		}

		public bool Equals(WeightedTransform other)
		{
			return false;
		}
	}
}
