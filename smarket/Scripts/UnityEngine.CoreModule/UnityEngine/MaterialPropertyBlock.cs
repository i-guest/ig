using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
	public sealed class MaterialPropertyBlock
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(MaterialPropertyBlock materialPropertyBlock)
			{
				return (IntPtr)0;
			}
		}

		internal IntPtr m_Ptr;

		[NativeName("SetIntFromScript")]
		[ThreadSafe]
		private void SetIntImpl(int name, int value)
		{
		}

		[NativeName("SetFloatFromScript")]
		[ThreadSafe]
		private void SetFloatImpl(int name, float value)
		{
		}

		[NativeName("SetVectorFromScript")]
		[ThreadSafe]
		private void SetVectorImpl(int name, Vector4 value)
		{
		}

		[ThreadSafe]
		[NativeName("SetColorFromScript")]
		private void SetColorImpl(int name, Color value)
		{
		}

		[ThreadSafe]
		[NativeName("SetMatrixFromScript")]
		private void SetMatrixImpl(int name, Matrix4x4 value)
		{
		}

		[ThreadSafe]
		[NativeName("SetTextureFromScript")]
		private void SetTextureImpl(int name, [NotNull] Texture value)
		{
		}

		[ThreadSafe]
		[NativeName("SetRenderTextureFromScript")]
		private void SetRenderTextureImpl(int name, [NotNull] RenderTexture value, RenderTextureSubElement element)
		{
		}

		[NativeName("SetBufferFromScript")]
		[ThreadSafe]
		private void SetBufferImpl(int name, ComputeBuffer value)
		{
		}

		[NativeName("SetConstantBufferFromScript")]
		[ThreadSafe]
		private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
		}

		[NativeName("SetFloatArrayFromScript")]
		[ThreadSafe]
		private void SetFloatArrayImpl(int name, float[] values, int count)
		{
		}

		[NativeName("SetVectorArrayFromScript")]
		[ThreadSafe]
		private void SetVectorArrayImpl(int name, Vector4[] values, int count)
		{
		}

		[NativeName("SetMatrixArrayFromScript")]
		[ThreadSafe]
		private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count)
		{
		}

		[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = true)]
		private static IntPtr CreateImpl()
		{
			return (IntPtr)0;
		}

		[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = true, IsThreadSafe = true)]
		private static void DestroyImpl(IntPtr mpb)
		{
		}

		[ThreadSafe]
		private void Clear(bool keepMemory)
		{
		}

		public void Clear()
		{
		}

		private void SetFloatArray(int name, float[] values, int count)
		{
		}

		private void SetVectorArray(int name, Vector4[] values, int count)
		{
		}

		private void SetMatrixArray(int name, Matrix4x4[] values, int count)
		{
		}

		~MaterialPropertyBlock()
		{
		}

		private void Dispose()
		{
		}

		public void SetInt(string name, int value)
		{
		}

		public void SetInt(int nameID, int value)
		{
		}

		public void SetFloat(string name, float value)
		{
		}

		public void SetFloat(int nameID, float value)
		{
		}

		public void SetInteger(int nameID, int value)
		{
		}

		public void SetVector(string name, Vector4 value)
		{
		}

		public void SetVector(int nameID, Vector4 value)
		{
		}

		public void SetColor(string name, Color value)
		{
		}

		public void SetColor(int nameID, Color value)
		{
		}

		public void SetMatrix(string name, Matrix4x4 value)
		{
		}

		public void SetMatrix(int nameID, Matrix4x4 value)
		{
		}

		public void SetBuffer(string name, ComputeBuffer value)
		{
		}

		public void SetBuffer(int nameID, ComputeBuffer value)
		{
		}

		public void SetTexture(string name, Texture value)
		{
		}

		public void SetTexture(int nameID, Texture value)
		{
		}

		public void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element)
		{
		}

		public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
		}

		public void SetFloatArray(string name, float[] values)
		{
		}

		public void SetVectorArray(string name, Vector4[] values)
		{
		}

		public void SetVectorArray(int nameID, Vector4[] values)
		{
		}

		public void SetMatrixArray(string name, Matrix4x4[] values)
		{
		}

		private static void SetIntImpl_Injected(IntPtr _unity_self, int name, int value)
		{
		}

		private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value)
		{
		}

		private static void SetVectorImpl_Injected(IntPtr _unity_self, int name, [In] ref Vector4 value)
		{
		}

		private static void SetColorImpl_Injected(IntPtr _unity_self, int name, [In] ref Color value)
		{
		}

		private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, [In] ref Matrix4x4 value)
		{
		}

		private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value)
		{
		}

		private static void SetRenderTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value, RenderTextureSubElement element)
		{
		}

		private static void SetBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value)
		{
		}

		private static void SetConstantBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value, int offset, int size)
		{
		}

		private static void SetFloatArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count)
		{
		}

		private static void SetVectorArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count)
		{
		}

		private static void SetMatrixArrayImpl_Injected(IntPtr _unity_self, int name, ref ManagedSpanWrapper values, int count)
		{
		}

		private static void Clear_Injected(IntPtr _unity_self, bool keepMemory)
		{
		}
	}
}
