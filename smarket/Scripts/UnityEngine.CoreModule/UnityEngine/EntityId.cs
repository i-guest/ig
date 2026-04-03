using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 4)]
	[NativeClass("EntityId")]
	[UsedByNativeCode]
	public struct EntityId : IEquatable<EntityId>, IComparable<EntityId>
	{
		[SerializeField]
		private int m_Data;

		public static EntityId None => default(EntityId);

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(EntityId other)
		{
			return false;
		}

		public int CompareTo(EntityId other)
		{
			return 0;
		}

		public static bool operator ==(EntityId left, EntityId right)
		{
			return false;
		}

		public static bool operator !=(EntityId left, EntityId right)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static implicit operator int(EntityId entityId)
		{
			return 0;
		}

		public static implicit operator EntityId(int intValue)
		{
			return default(EntityId);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
