using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
	[NativeHeader("Runtime/Graphics/Texture.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	public struct AsyncGPUReadbackRequest
	{
		internal IntPtr m_Ptr;

		internal int m_Version;

		public bool done => false;

		public bool hasError => false;

		public int layerCount => 0;

		public int layerDataSize => 0;

		public void WaitForCompletion()
		{
		}

		public NativeArray<T> GetData<T>(int layer = 0) where T : struct
		{
			return default(NativeArray<T>);
		}

		private bool IsDone()
		{
			return false;
		}

		private bool HasError()
		{
			return false;
		}

		private int GetLayerCount()
		{
			return 0;
		}

		private int GetLayerDataSize()
		{
			return 0;
		}

		internal void SetScriptingCallback(Action<AsyncGPUReadbackRequest> callback)
		{
		}

		private IntPtr GetDataRaw(int layer)
		{
			return (IntPtr)0;
		}

		[RequiredByNativeCode]
		private static void InvokeCallback(Action<AsyncGPUReadbackRequest> callback, AsyncGPUReadbackRequest obj)
		{
		}
	}
}
