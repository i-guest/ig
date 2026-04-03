using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	[NativeHeader("Runtime/Misc/ResourceManager.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
	[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/Shader.h")]
	public sealed class Shader : Object
	{
		[NativeProperty("MaximumShaderLOD")]
		public int maximumLOD
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isSupported
		{
			[NativeMethod("IsSupported")]
			get
			{
				return false;
			}
		}

		public static string globalRenderPipeline
		{
			set
			{
			}
		}

		public LocalKeywordSpace keywordSpace => default(LocalKeywordSpace);

		public int passCount
		{
			[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = true)]
			get
			{
				return 0;
			}
		}

		public static Shader Find(string name)
		{
			return null;
		}

		[FreeFunction("ShaderScripting::EnableKeyword")]
		public static void EnableKeyword(string keyword)
		{
		}

		[FreeFunction("ShaderScripting::DisableKeyword")]
		public static void DisableKeyword(string keyword)
		{
		}

		[FreeFunction("ShaderScripting::TagToID")]
		internal static int TagToID(string name)
		{
			return 0;
		}

		[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = true)]
		public static int PropertyToID(string name)
		{
			return 0;
		}

		[FreeFunction("ShaderScripting::SetGlobalFloat")]
		private static void SetGlobalFloatImpl(int name, float value)
		{
		}

		[FreeFunction("ShaderScripting::SetGlobalVector")]
		private static void SetGlobalVectorImpl(int name, Vector4 value)
		{
		}

		[FreeFunction("ShaderScripting::SetGlobalMatrix")]
		private static void SetGlobalMatrixImpl(int name, Matrix4x4 value)
		{
		}

		[FreeFunction("ShaderScripting::SetGlobalTexture")]
		private static void SetGlobalTextureImpl(int name, Texture value)
		{
		}

		[FreeFunction("ShaderScripting::SetGlobalBuffer")]
		private static void SetGlobalGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
		}

		[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
		private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
		}

		public static void SetGlobalFloat(string name, float value)
		{
		}

		public static void SetGlobalFloat(int nameID, float value)
		{
		}

		public static void SetGlobalVector(string name, Vector4 value)
		{
		}

		public static void SetGlobalColor(int nameID, Color value)
		{
		}

		public static void SetGlobalMatrix(string name, Matrix4x4 value)
		{
		}

		public static void SetGlobalTexture(string name, Texture value)
		{
		}

		public static void SetGlobalTexture(int nameID, Texture value)
		{
		}

		public static void SetGlobalBuffer(string name, GraphicsBuffer value)
		{
		}

		public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
		}

		private Shader()
		{
		}

		[FreeFunction("ShaderScripting::GetPropertyName")]
		private static string GetPropertyName([NotNull] Shader shader, int propertyIndex)
		{
			return null;
		}

		[FreeFunction("ShaderScripting::GetPropertyType")]
		private static ShaderPropertyType GetPropertyType([NotNull] Shader shader, int propertyIndex)
		{
			return default(ShaderPropertyType);
		}

		private static void CheckPropertyIndex(Shader s, int propertyIndex)
		{
		}

		public int GetPropertyCount()
		{
			return 0;
		}

		public int FindPropertyIndex(string propertyName)
		{
			return 0;
		}

		public string GetPropertyName(int propertyIndex)
		{
			return null;
		}

		public ShaderPropertyType GetPropertyType(int propertyIndex)
		{
			return default(ShaderPropertyType);
		}

		private static int get_maximumLOD_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_maximumLOD_Injected(IntPtr _unity_self, int value)
		{
		}

		private static bool get_isSupported_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_globalRenderPipeline_Injected(ref ManagedSpanWrapper value)
		{
		}

		private static void get_keywordSpace_Injected(IntPtr _unity_self, out LocalKeywordSpace ret)
		{
			ret = default(LocalKeywordSpace);
		}

		private static void EnableKeyword_Injected(ref ManagedSpanWrapper keyword)
		{
		}

		private static void DisableKeyword_Injected(ref ManagedSpanWrapper keyword)
		{
		}

		private static int TagToID_Injected(ref ManagedSpanWrapper name)
		{
			return 0;
		}

		private static int PropertyToID_Injected(ref ManagedSpanWrapper name)
		{
			return 0;
		}

		private static int get_passCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void SetGlobalVectorImpl_Injected(int name, [In] ref Vector4 value)
		{
		}

		private static void SetGlobalMatrixImpl_Injected(int name, [In] ref Matrix4x4 value)
		{
		}

		private static void SetGlobalTextureImpl_Injected(int name, IntPtr value)
		{
		}

		private static void SetGlobalGraphicsBufferImpl_Injected(int name, IntPtr value)
		{
		}

		private static void SetGlobalConstantBufferImpl_Injected(int name, IntPtr value, int offset, int size)
		{
		}

		private static void GetPropertyName_Injected(IntPtr shader, int propertyIndex, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static ShaderPropertyType GetPropertyType_Injected(IntPtr shader, int propertyIndex)
		{
			return default(ShaderPropertyType);
		}

		private static int GetPropertyCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int FindPropertyIndex_Injected(IntPtr _unity_self, ref ManagedSpanWrapper propertyName)
		{
			return 0;
		}
	}
}
