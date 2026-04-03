using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	public abstract class UxmlSerializedData
	{
		[Flags]
		public enum UxmlAttributeFlags : byte
		{
			Ignore = 0,
			OverriddenInUxml = 1,
			DefaultValue = 2
		}

		internal const string AttributeFlagSuffix = "_UxmlAttributeFlags";

		private const UxmlAttributeFlags k_DefaultFlags = UxmlAttributeFlags.OverriddenInUxml;

		[HideInInspector]
		[UxmlIgnore]
		[SerializeField]
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal int uxmlAssetId;

		private static UxmlAttributeFlags s_CurrentDeserializeFlags;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ShouldWriteAttributeValue(UxmlAttributeFlags attributeFlags)
		{
			return false;
		}

		public abstract object CreateInstance();

		public abstract void Deserialize(object obj);
	}
}
