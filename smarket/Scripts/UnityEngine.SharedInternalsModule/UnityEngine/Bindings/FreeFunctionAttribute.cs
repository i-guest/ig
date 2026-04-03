using System;

namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	[AttributeUsage(AttributeTargets.Method)]
	internal class FreeFunctionAttribute : NativeMethodAttribute
	{
		public FreeFunctionAttribute()
		{
		}

		public FreeFunctionAttribute(string name)
		{
		}

		public FreeFunctionAttribute(string name, bool isThreadSafe)
		{
		}
	}
}
