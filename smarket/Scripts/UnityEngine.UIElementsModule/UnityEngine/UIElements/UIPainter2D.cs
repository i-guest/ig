using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIPainter2D.bindings.h")]
	internal static class UIPainter2D
	{
		public static IntPtr Create(bool computeBBox = false)
		{
			return (IntPtr)0;
		}

		public static void Destroy(IntPtr handle)
		{
		}

		public static void Reset(IntPtr handle)
		{
		}

		public static void ClearSnapshots(IntPtr handle)
		{
		}

		[ThreadSafe]
		public static MeshWriteDataInterface ExecuteSnapshotFromJob(IntPtr painterHandle, int i)
		{
			return default(MeshWriteDataInterface);
		}

		private static void ExecuteSnapshotFromJob_Injected(IntPtr painterHandle, int i, out MeshWriteDataInterface ret)
		{
			ret = default(MeshWriteDataInterface);
		}
	}
}
