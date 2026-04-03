using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using UnityEngine.Localization.PropertyVariants.TrackedProperties;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	[Serializable]
	public abstract class JsonSerializerTrackedObject : TrackedObject
	{
		public enum ApplyChangesMethod
		{
			Partial = 0,
			Full = 1
		}

		private class DeferredJsonStringOperation
		{
			public JValue jsonValue;

			public readonly Action<AsyncOperationHandle<string>> callback;

			public static readonly ObjectPool<DeferredJsonStringOperation> Pool;

			private void OnStringLoaded(AsyncOperationHandle<string> asyncOperationHandle)
			{
			}
		}

		private class DeferredJsonObjectOperation
		{
			public JValue jsonValue;

			public readonly Action<AsyncOperationHandle<Object>> callback;

			public static readonly ObjectPool<DeferredJsonObjectOperation> Pool;

			private void OnAssetLoaded(AsyncOperationHandle<Object> asyncOperationHandle)
			{
			}
		}

		internal struct ArrayResult
		{
			public string path;

			public int arrayStartIndex;

			public int arrayDataIndexStart;

			public int arrayDataIndexEnd;

			public bool IsArraySize => false;

			public bool IsArrayElement => false;

			public int GetDataIndex()
			{
				return 0;
			}

			public ArrayResult(string p, int start, int bracketStart, int bracketEnd)
			{
				path = null;
				arrayStartIndex = 0;
				arrayDataIndexStart = 0;
				arrayDataIndexEnd = 0;
			}
		}

		[Tooltip("Determines the type of property update that will be performed.- Full update reads the entire object into JSON, patches the properties, then reapplies the new JSON.\n- Partial update generates a partial patch and applies the changes for the tracked properties only.\nPartial update provides better performance however is not supported when modifying collections or properties that contain a serialized version such as Rect.\nThis value is automatically set based on the properties tracked.")]
		[SerializeField]
		private ApplyChangesMethod m_UpdateType;

		public ApplyChangesMethod UpdateType
		{
			get
			{
				return default(ApplyChangesMethod);
			}
			set
			{
			}
		}

		public override void AddTrackedProperty(ITrackedProperty trackedProperty)
		{
		}

		public override AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale)
		{
			return default(AsyncOperationHandle);
		}

		private void ApplyArraySizes(IEnumerable<ArraySizeTrackedProperty> arraySizes, JObject jsonObject, LocaleIdentifier variantLocale, LocaleIdentifier defaultLocale)
		{
		}

		private void ApplyJson(JObject jsonObject)
		{
		}

		internal static ArrayResult GetNextArrayItem(string path, int startIndex)
		{
			return default(ArrayResult);
		}

		internal static JToken GetPropertyFromPath(string path, JContainer obj)
		{
			return null;
		}
	}
}
