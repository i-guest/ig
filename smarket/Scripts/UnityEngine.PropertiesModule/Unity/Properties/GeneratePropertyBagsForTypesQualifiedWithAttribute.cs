using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Properties
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public class GeneratePropertyBagsForTypesQualifiedWithAttribute : Attribute
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Type _003CType_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly TypeGenerationOptions _003COptions_003Ek__BackingField;

		public GeneratePropertyBagsForTypesQualifiedWithAttribute(Type type, TypeGenerationOptions options = TypeGenerationOptions.Default)
		{
		}
	}
}
