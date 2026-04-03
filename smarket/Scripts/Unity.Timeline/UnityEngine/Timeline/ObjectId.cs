using System;

namespace UnityEngine.Timeline
{
	[Serializable]
	internal struct ObjectId : IEquatable<ObjectId>, IComparable<ObjectId>
	{
		public static readonly ObjectId InvalidId;

		public static readonly ObjectId DefaultId;

		[SerializeField]
		private int m_Data;

		internal ObjectId(int data)
		{
			m_Data = 0;
		}

		public static implicit operator ObjectId(EntityId entityId)
		{
			return default(ObjectId);
		}

		public static implicit operator EntityId(ObjectId objectId)
		{
			return default(EntityId);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObjectId other)
		{
			return false;
		}

		public int CompareTo(ObjectId other)
		{
			return 0;
		}

		public static bool operator ==(ObjectId left, ObjectId right)
		{
			return false;
		}

		public static bool operator !=(ObjectId left, ObjectId right)
		{
			return false;
		}

		public static bool operator <(ObjectId left, ObjectId right)
		{
			return false;
		}

		public static bool operator >(ObjectId left, ObjectId right)
		{
			return false;
		}

		public static bool operator <=(ObjectId left, ObjectId right)
		{
			return false;
		}

		public static bool operator >=(ObjectId left, ObjectId right)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
