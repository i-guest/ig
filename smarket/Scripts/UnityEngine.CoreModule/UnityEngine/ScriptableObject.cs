using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[NativeClass(null)]
	[ExtensionOfNativeClass]
	[RequiredByNativeCode]
	public class ScriptableObject : Object
	{
		public static ScriptableObject CreateInstance(string className)
		{
			return null;
		}

		public static ScriptableObject CreateInstance(Type type)
		{
			return null;
		}

		public static T CreateInstance<T>() where T : ScriptableObject
		{
			return null;
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		private static void CreateScriptableObject([Writable] ScriptableObject self)
		{
		}

		[FreeFunction("Scripting::CreateScriptableObject")]
		private static ScriptableObject CreateScriptableObjectInstanceFromName(string className)
		{
			return null;
		}

		[NativeMethod(Name = "Scripting::CreateScriptableObjectWithType", IsFreeFunction = true, ThrowsException = true)]
		internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset)
		{
			return null;
		}

		private static IntPtr CreateScriptableObjectInstanceFromName_Injected(ref ManagedSpanWrapper className)
		{
			return (IntPtr)0;
		}

		private static IntPtr CreateScriptableObjectInstanceFromType_Injected(Type type, bool applyDefaultsAndReset)
		{
			return (IntPtr)0;
		}
	}
}
