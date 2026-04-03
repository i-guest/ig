using System;
using UnityEngine.Serialization;

namespace UnityEngine.LowLevelPhysics2D
{
	public readonly struct PhysicsShape : IEquatable<PhysicsShape>
	{
		[Serializable]
		public struct SurfaceMaterial
		{
			public enum MixingMode
			{
				Average = 0,
				Mean = 1,
				Multiply = 2,
				Minimum = 3,
				Maximum = 4
			}

			[Min(0f)]
			[SerializeField]
			private float m_Friction;

			[SerializeField]
			[Min(0f)]
			private float m_Bounciness;

			[FormerlySerializedAs("m_FrictionCombine")]
			[SerializeField]
			private MixingMode m_FrictionMixing;

			[FormerlySerializedAs("m_BouncinessCombine")]
			[SerializeField]
			private MixingMode m_BouncinessMixing;

			[Range(0f, 65535f)]
			[SerializeField]
			private ushort m_FrictionPriority;

			[SerializeField]
			[Range(0f, 65535f)]
			private ushort m_BouncinessPriority;

			[SerializeField]
			[Min(0f)]
			private float m_RollingResistance;

			[SerializeField]
			private float m_TangentSpeed;

			[SerializeField]
			private Color32 m_CustomColor;

			public static SurfaceMaterial Default => default(SurfaceMaterial);

			public SurfaceMaterial()
			{
				m_Friction = 0f;
				m_Bounciness = 0f;
				m_FrictionMixing = default(MixingMode);
				m_BouncinessMixing = default(MixingMode);
				m_FrictionPriority = 0;
				m_BouncinessPriority = 0;
				m_RollingResistance = 0f;
				m_TangentSpeed = 0f;
				m_CustomColor = default(Color32);
			}
		}

		public enum ShapeType
		{
			Circle = 0,
			Capsule = 1,
			Segment = 2,
			Polygon = 3,
			ChainSegment = 4
		}

		public readonly struct ContactId
		{
			private readonly int m_IndexId;

			private readonly ushort m_WorldId;

			private readonly ushort m_Padding;

			private readonly int m_GenerationId;

			public bool isValid => false;

			public override string ToString()
			{
				return null;
			}
		}

		[Serializable]
		public struct ContactFilter
		{
			public static PhysicsMask DefaultCategories;

			public static PhysicsMask DefaultContacts;

			public static ContactFilter Everything;

			public static ContactFilter defaultFilter;

			[SerializeField]
			internal PhysicsMask m_Categories;

			[SerializeField]
			internal PhysicsMask m_Contacts;

			[SerializeField]
			internal int m_GroupIndex;

			public ContactFilter(PhysicsMask categories, PhysicsMask contacts, int groupIndex = 0)
			{
				m_Categories = default(PhysicsMask);
				m_Contacts = default(PhysicsMask);
				m_GroupIndex = 0;
			}
		}

		[Serializable]
		public struct MoverData
		{
			private float m_PushLimit;

			private bool m_ClipVelocity;

			public MoverData()
			{
				m_PushLimit = 0f;
				m_ClipVelocity = false;
			}
		}

		private readonly int m_Index1;

		private readonly ushort m_World0;

		private readonly ushort m_Generation;

		public bool isValid => false;

		public ShapeType shapeType => default(ShapeType);

		public object callbackTarget => null;

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(PhysicsShape other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
