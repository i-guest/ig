using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace UnityEngine.AddressableAssets
{
	public class InvalidKeyException : Exception
	{
		internal enum Format
		{
			StandardMessage = 0,
			NoMergeMode = 1,
			MultipleTypesRequested = 2,
			NoLocation = 3,
			TypeMismatch = 4,
			MultipleTypeMismatch = 5,
			MergeModeBase = 6,
			UnionAvailableForKeys = 7,
			UnionAvailableForKeysWithoutOther = 8,
			IntersectionAvailable = 9,
			KeyAvailableAsType = 10
		}

		private AddressablesImpl m_Addressables;

		internal const string BaseInvalidKeyMessageFormat = "{0}, Key={1}, Type={2}";

		internal const string NoLocationMessageFormat = "{0} No Location found for Key={1}";

		internal const string MultipleTypeMismatchMessageFormat = "{0} No Asset found for Key={1} with Type={2}. Key exists as multiple Types={3}, which is not assignable from the requested Type={2}";

		internal const string TypeMismatchMessageFormat = "{0} No Asset found for Key={1} with Type={2}. Key exists as Type={3}, which is not assignable from the requested Type={2}";

		internal const string MultipleTypesMessageFormat = "{0} Enumerable key contains multiple Types. {1}, all Keys are expected to be strings";

		internal const string MergeModeNoLocationMessageFormat = "\nNo Location found for Key={0}";

		internal const string NoMergeModeMessageFormat = "{0} No MergeMode is set to merge the multiple keys requested. {1}, Type={2}";

		internal const string MergeModeBaseMessageFormat = "{0} No {1} of Assets between {2} with Type={3}";

		internal const string UnionAvailableForKeysMessageFormat = "\nUnion of Type={0} found with {1}";

		internal const string UnionAvailableForKeysWithoutOtherMessageFormat = "\nUnion of Type={0} found with {1}. Without {2}";

		internal const string IntersectionAvailableMessageFormat = "\nAn Intersection exists for Type={0}";

		internal const string KeyAvailableAsTypeMessageFormat = "\nType={0} exists for {1}";

		public object Key { get; private set; }

		public Type Type { get; private set; }

		public Addressables.MergeMode? MergeMode { get; }

		public override string Message => null;

		public InvalidKeyException(object key)
		{
		}

		public InvalidKeyException(object key, Type type)
		{
		}

		internal InvalidKeyException(object key, Type type, AddressablesImpl addr)
		{
		}

		public InvalidKeyException(object key, Type type, Addressables.MergeMode mergeMode)
		{
		}

		internal InvalidKeyException(object key, Type type, Addressables.MergeMode mergeMode, AddressablesImpl addr)
		{
		}

		public InvalidKeyException()
		{
		}

		public InvalidKeyException(string message)
		{
		}

		public InvalidKeyException(string message, Exception innerException)
		{
		}

		protected InvalidKeyException(SerializationInfo message, StreamingContext context)
		{
		}

		internal string FormatMessage(Format format, string foundWithTypeString = null)
		{
			return null;
		}

		internal string FormatMergeModeMessage(Format format, string keysAvailable = null, string keysUnavailable = null, string typeString = null)
		{
			return null;
		}

		private string GetMessageForSingleKey(string keyString)
		{
			return null;
		}

		private string FormatNotFoundMessage(string keyString)
		{
			return null;
		}

		private string FormatTypeNotAssignableMessage(string keyString, HashSet<Type> typesAvailableForKey)
		{
			return null;
		}

		private string FormatMultipleAssignableTypesMessage(string keyString, HashSet<Type> typesAvailableForKey)
		{
			return null;
		}

		private string GetMessageforMergeKeys(List<string> keys)
		{
			return null;
		}

		private HashSet<Type> GetTypesForKey(string keyString)
		{
			return null;
		}

		private bool GetTypeToKeys(string key, Dictionary<Type, List<string>> typeToKeys)
		{
			return false;
		}

		internal string GetKeyString()
		{
			return null;
		}

		internal static string GetCSVString(IEnumerable enumerator, string prefixSingle, string prefixPlural)
		{
			return null;
		}
	}
}
