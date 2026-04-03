using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Properties
{
	public static class TypeTraits
	{
		public static bool IsContainer(Type type)
		{
			return false;
		}
	}
	public static class TypeTraits<T>
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static readonly bool _003CIsMultidimensionalArray_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly bool _003CIsEnumFlags_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static readonly bool _003CIsPrimitiveOrString_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static readonly bool _003CIsLazyLoadReference_003Ek__BackingField;

		public static bool IsValueType { get; }

		public static bool IsPrimitive { get; }

		public static bool IsInterface { get; }

		public static bool IsAbstract { get; }

		public static bool IsArray { get; }

		public static bool IsEnum { get; }

		public static bool IsNullable { get; }

		public static bool IsObject { get; }

		public static bool IsString { get; }

		public static bool IsContainer { get; }

		public static bool CanBeNull { get; }

		public static bool IsAbstractOrInterface { get; }

		public static bool IsUnityObject { get; }

		static TypeTraits()
		{
		}
	}
}
