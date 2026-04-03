using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class MakeSerializableAttribute : Attribute
	{
		private Type serializableType;

		[RequiredByNativeCode]
		private Type GetSerializableType()
		{
			return null;
		}
	}
}
