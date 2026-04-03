using System;
using System.Runtime.InteropServices;
using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine.Animations
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ProcessAnimationJobStruct<T> where T : struct
	{
		public delegate void ExecuteJobFunction(ref T data, IntPtr animationStreamPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex);

		private static IntPtr jobReflectionData;

		public static IntPtr GetJobReflectionData()
		{
			return (IntPtr)0;
		}

		public static void Execute(ref T data, IntPtr animationStreamPtr, IntPtr methodIndex, ref JobRanges ranges, int jobIndex)
		{
		}
	}
}
