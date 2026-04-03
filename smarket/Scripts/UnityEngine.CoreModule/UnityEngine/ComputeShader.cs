using System;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/RayTracing/RayTracingAccelerationStructure.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	public sealed class ComputeShader : Object
	{
		public LocalKeywordSpace keywordSpace => default(LocalKeywordSpace);

		public string[] shaderKeywords
		{
			set
			{
			}
		}

		[RequiredByNativeCode]
		[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
		public int FindKernel(string name)
		{
			return 0;
		}

		[FreeFunction(Name = "ComputeShaderScripting::HasKernel", HasExplicitThis = true)]
		public bool HasKernel(string name)
		{
			return false;
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetValue<int>", HasExplicitThis = true)]
		public void SetInt(int nameID, int val)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetArray<int>", HasExplicitThis = true)]
		private void SetIntArray(int nameID, int[] values)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = true)]
		private void Internal_SetBuffer(int kernelIndex, int nameID, [NotNull] ComputeBuffer buffer)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = true)]
		private void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, [NotNull] GraphicsBuffer buffer)
		{
		}

		public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
		{
		}

		public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
		}

		[FreeFunction(Name = "ComputeShaderScripting::SetConstantBuffer", HasExplicitThis = true)]
		private void SetConstantComputeBuffer(int nameID, [NotNull] ComputeBuffer buffer, int offset, int size)
		{
		}

		[NativeMethod(Name = "ComputeShaderScripting::GetKernelThreadGroupSizes", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
		public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z)
		{
			x = default(uint);
			y = default(uint);
			z = default(uint);
		}

		[NativeName("DispatchComputeShader")]
		public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
		}

		[FreeFunction("ComputeShaderScripting::EnableKeyword", HasExplicitThis = true)]
		public void EnableKeyword(string keyword)
		{
		}

		[FreeFunction("ComputeShaderScripting::DisableKeyword", HasExplicitThis = true)]
		public void DisableKeyword(string keyword)
		{
		}

		[FreeFunction("ComputeShaderScripting::SetShaderKeywords", HasExplicitThis = true)]
		private void SetShaderKeywords(string[] names)
		{
		}

		private ComputeShader()
		{
		}

		public void SetInts(int nameID, params int[] values)
		{
		}

		public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
		}

		private static int FindKernel_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
			return 0;
		}

		private static bool HasKernel_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
			return false;
		}

		private static void SetInt_Injected(IntPtr _unity_self, int nameID, int val)
		{
		}

		private static void SetIntArray_Injected(IntPtr _unity_self, int nameID, ref ManagedSpanWrapper values)
		{
		}

		private static void Internal_SetBuffer_Injected(IntPtr _unity_self, int kernelIndex, int nameID, IntPtr buffer)
		{
		}

		private static void Internal_SetGraphicsBuffer_Injected(IntPtr _unity_self, int kernelIndex, int nameID, IntPtr buffer)
		{
		}

		private static void SetConstantComputeBuffer_Injected(IntPtr _unity_self, int nameID, IntPtr buffer, int offset, int size)
		{
		}

		private static void GetKernelThreadGroupSizes_Injected(IntPtr _unity_self, int kernelIndex, out uint x, out uint y, out uint z)
		{
			x = default(uint);
			y = default(uint);
			z = default(uint);
		}

		private static void Dispatch_Injected(IntPtr _unity_self, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
		}

		private static void get_keywordSpace_Injected(IntPtr _unity_self, out LocalKeywordSpace ret)
		{
			ret = default(LocalKeywordSpace);
		}

		private static void EnableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword)
		{
		}

		private static void DisableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword)
		{
		}

		private static void SetShaderKeywords_Injected(IntPtr _unity_self, string[] names)
		{
		}
	}
}
