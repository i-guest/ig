using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	internal static class InstanceTypeInfo
	{
		public const int kInstanceTypeBitCount = 1;

		public const int kMaxInstanceTypesCount = 2;

		public const uint kInstanceTypeMask = 1u;

		private static InstanceType[] s_ParentTypes;

		private static List<InstanceType>[] s_ChildTypes;

		static InstanceTypeInfo()
		{
		}

		private static void InitParentTypes()
		{
		}

		private static void InitChildTypes()
		{
		}

		private static InstanceType GetMaxChildTypeRecursively(InstanceType type)
		{
			return default(InstanceType);
		}

		private static void FlattenChildInstanceTypes(InstanceType instanceType, NativeList<InstanceType> instanceTypes)
		{
		}

		private static void ValidateTypeRelationsAreCorrectlySorted()
		{
		}

		public static InstanceType GetParentType(InstanceType type)
		{
			return default(InstanceType);
		}

		public static List<InstanceType> GetChildTypes(InstanceType type)
		{
			return null;
		}
	}
}
