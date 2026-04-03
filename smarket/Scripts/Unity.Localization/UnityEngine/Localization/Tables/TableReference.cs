using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Localization.Tables
{
	[Serializable]
	public struct TableReference : ISerializationCallbackReceiver, IEquatable<TableReference>
	{
		public enum Type
		{
			Empty = 0,
			Guid = 1,
			Name = 2
		}

		private static readonly Dictionary<Guid, string> s_GuidToStringCache;

		private static readonly Dictionary<string, Guid> s_StringToGuidCache;

		[SerializeField]
		[FormerlySerializedAs("m_TableName")]
		private string m_TableCollectionName;

		private bool m_Valid;

		private const string k_GuidTag = "GUID:";

		public Type ReferenceType { get; private set; }

		public Guid TableCollectionNameGuid { get; private set; }

		public string TableCollectionName
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		internal SharedTableData SharedTableData => null;

		public static implicit operator TableReference(string tableCollectionName)
		{
			return default(TableReference);
		}

		public static implicit operator TableReference(Guid tableCollectionNameGuid)
		{
			return default(TableReference);
		}

		public static implicit operator string(TableReference tableReference)
		{
			return null;
		}

		public static implicit operator Guid(TableReference tableReference)
		{
			return default(Guid);
		}

		internal void Validate()
		{
		}

		internal string GetSerializedString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(TableReference other)
		{
			return false;
		}

		internal static Guid GuidFromString(string value)
		{
			return default(Guid);
		}

		internal static string StringFromGuid(Guid value)
		{
			return null;
		}

		internal static TableReference TableReferenceFromString(string value)
		{
			return default(TableReference);
		}

		internal static bool IsGuid(string value)
		{
			return false;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
