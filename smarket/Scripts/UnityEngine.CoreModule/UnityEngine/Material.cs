using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Shaders/Material.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	public class Material : Object
	{
		private static readonly int k_ColorId;

		private static readonly int k_MainTexId;

		public Shader shader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Texture mainTexture => null;

		public Vector2 mainTextureOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 mainTextureScale
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public int renderQueue
		{
			[NativeName("GetActualRenderQueue")]
			get
			{
				return 0;
			}
			[NativeName("SetCustomRenderQueue")]
			set
			{
			}
		}

		public LocalKeyword[] enabledKeywords
		{
			set
			{
			}
		}

		public MaterialGlobalIlluminationFlags globalIlluminationFlags
		{
			get
			{
				return default(MaterialGlobalIlluminationFlags);
			}
			set
			{
			}
		}

		[NativeProperty("EnableInstancingVariants")]
		public bool enableInstancing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int passCount
		{
			[NativeName("GetShader()->GetPassCount")]
			get
			{
				return 0;
			}
		}

		public string[] shaderKeywords
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[FreeFunction("MaterialScripting::CreateWithShader")]
		private static void CreateWithShader([Writable] Material self, [NotNull] Shader shader)
		{
		}

		[FreeFunction("MaterialScripting::CreateWithMaterial")]
		private static void CreateWithMaterial([Writable] Material self, [NotNull] Material source)
		{
		}

		public Material(Shader shader)
		{
		}

		[RequiredByNativeCode]
		public Material(Material source)
		{
		}

		[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Material(string contents)
		{
		}

		[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
		private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag)
		{
			return 0;
		}

		[NativeName("HasPropertyFromScript")]
		public bool HasProperty(int nameID)
		{
			return false;
		}

		public bool HasProperty(string name)
		{
			return false;
		}

		[NativeName("HasFloatFromScript")]
		private bool HasFloatImpl(int name)
		{
			return false;
		}

		public bool HasFloat(int nameID)
		{
			return false;
		}

		public void EnableKeyword(string keyword)
		{
		}

		public void DisableKeyword(string keyword)
		{
		}

		public bool IsKeywordEnabled(string keyword)
		{
			return false;
		}

		[FreeFunction("MaterialScripting::EnableKeyword", HasExplicitThis = true)]
		private void EnableLocalKeyword(LocalKeyword keyword)
		{
		}

		[FreeFunction("MaterialScripting::DisableKeyword", HasExplicitThis = true)]
		private void DisableLocalKeyword(LocalKeyword keyword)
		{
		}

		public void EnableKeyword(in LocalKeyword keyword)
		{
		}

		public void DisableKeyword(in LocalKeyword keyword)
		{
		}

		[FreeFunction("MaterialScripting::SetEnabledKeywords", HasExplicitThis = true)]
		private void SetEnabledKeywords(LocalKeyword[] keywords)
		{
		}

		public int FindPass(string passName)
		{
			return 0;
		}

		[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = true)]
		public bool SetPass(int pass)
		{
			return false;
		}

		[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = true)]
		public void CopyPropertiesFromMaterial(Material mat)
		{
		}

		[FreeFunction("MaterialScripting::CopyMatchingPropertiesFrom", HasExplicitThis = true)]
		public void CopyMatchingPropertiesFromMaterial(Material mat)
		{
		}

		[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = true)]
		private string[] GetShaderKeywords()
		{
			return null;
		}

		[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = true)]
		private void SetShaderKeywords(string[] names)
		{
		}

		public int ComputeCRC()
		{
			return 0;
		}

		[NativeName("SetIntFromScript")]
		private void SetIntImpl(int name, int value)
		{
		}

		[NativeName("SetFloatFromScript")]
		private void SetFloatImpl(int name, float value)
		{
		}

		[NativeName("SetColorFromScript")]
		private void SetColorImpl(int name, Color value)
		{
		}

		[NativeName("SetMatrixFromScript")]
		private void SetMatrixImpl(int name, Matrix4x4 value)
		{
		}

		[NativeName("SetTextureFromScript")]
		private void SetTextureImpl(int name, Texture value)
		{
		}

		[NativeName("SetBufferFromScript")]
		private void SetGraphicsBufferImpl(int name, GraphicsBuffer value)
		{
		}

		[NativeName("SetConstantBufferFromScript")]
		private void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
		{
		}

		[NativeName("GetFloatFromScript")]
		private float GetFloatImpl(int name)
		{
			return 0f;
		}

		[NativeName("GetColorFromScript")]
		private Color GetColorImpl(int name)
		{
			return default(Color);
		}

		[NativeName("GetTextureFromScript")]
		private Texture GetTextureImpl(int name)
		{
			return null;
		}

		[FreeFunction(Name = "MaterialScripting::SetFloatArray", HasExplicitThis = true)]
		private void SetFloatArrayImpl(int name, float[] values, int count)
		{
		}

		[FreeFunction(Name = "MaterialScripting::SetVectorArray", HasExplicitThis = true)]
		private void SetVectorArrayImpl(int name, Vector4[] values, int count)
		{
		}

		[FreeFunction(Name = "MaterialScripting::SetMatrixArray", HasExplicitThis = true)]
		private void SetMatrixArrayImpl(int name, Matrix4x4[] values, int count)
		{
		}

		[NativeName("GetTextureScaleAndOffsetFromScript")]
		private Vector4 GetTextureScaleAndOffsetImpl(int name)
		{
			return default(Vector4);
		}

		[NativeName("SetTextureOffsetFromScript")]
		private void SetTextureOffsetImpl(int name, Vector2 offset)
		{
		}

		[NativeName("SetTextureScaleFromScript")]
		private void SetTextureScaleImpl(int name, Vector2 scale)
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

		public void SetColor(string name, Color value)
		{
		}

		public void SetColor(int nameID, Color value)
		{
		}

		public void SetVector(string name, Vector4 value)
		{
		}

		public void SetVector(int nameID, Vector4 value)
		{
		}

		public void SetMatrix(string name, Matrix4x4 value)
		{
		}

		public void SetMatrix(int nameID, Matrix4x4 value)
		{
		}

		public void SetTexture(string name, Texture value)
		{
		}

		public void SetTexture(int nameID, Texture value)
		{
		}

		public void SetBuffer(string name, GraphicsBuffer value)
		{
		}

		public void SetBuffer(int nameID, GraphicsBuffer value)
		{
		}

		public void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
		{
		}

		public void SetFloatArray(int nameID, float[] values)
		{
		}

		public void SetVectorArray(string name, Vector4[] values)
		{
		}

		public void SetVectorArray(int nameID, Vector4[] values)
		{
		}

		public void SetMatrixArray(int nameID, Matrix4x4[] values)
		{
		}

		public int GetInt(string name)
		{
			return 0;
		}

		public float GetFloat(string name)
		{
			return 0f;
		}

		public float GetFloat(int nameID)
		{
			return 0f;
		}

		public Color GetColor(string name)
		{
			return default(Color);
		}

		public Color GetColor(int nameID)
		{
			return default(Color);
		}

		public Vector4 GetVector(string name)
		{
			return default(Vector4);
		}

		public Vector4 GetVector(int nameID)
		{
			return default(Vector4);
		}

		public Texture GetTexture(string name)
		{
			return null;
		}

		public Texture GetTexture(int nameID)
		{
			return null;
		}

		public void SetTextureOffset(string name, Vector2 value)
		{
		}

		public void SetTextureOffset(int nameID, Vector2 value)
		{
		}

		public void SetTextureScale(string name, Vector2 value)
		{
		}

		public void SetTextureScale(int nameID, Vector2 value)
		{
		}

		public Vector2 GetTextureOffset(string name)
		{
			return default(Vector2);
		}

		public Vector2 GetTextureOffset(int nameID)
		{
			return default(Vector2);
		}

		public Vector2 GetTextureScale(string name)
		{
			return default(Vector2);
		}

		public Vector2 GetTextureScale(int nameID)
		{
			return default(Vector2);
		}

		private static void CreateWithShader_Injected([Writable] Material self, IntPtr shader)
		{
		}

		private static void CreateWithMaterial_Injected([Writable] Material self, IntPtr source)
		{
		}

		private static IntPtr get_shader_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_shader_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static int GetFirstPropertyNameIdByAttribute_Injected(IntPtr _unity_self, ShaderPropertyFlags attributeFlag)
		{
			return 0;
		}

		private static bool HasProperty_Injected(IntPtr _unity_self, int nameID)
		{
			return false;
		}

		private static bool HasFloatImpl_Injected(IntPtr _unity_self, int name)
		{
			return false;
		}

		private static int get_renderQueue_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void set_renderQueue_Injected(IntPtr _unity_self, int value)
		{
		}

		private static void EnableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword)
		{
		}

		private static void DisableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword)
		{
		}

		private static bool IsKeywordEnabled_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword)
		{
			return false;
		}

		private static void EnableLocalKeyword_Injected(IntPtr _unity_self, [In] ref LocalKeyword keyword)
		{
		}

		private static void DisableLocalKeyword_Injected(IntPtr _unity_self, [In] ref LocalKeyword keyword)
		{
		}

		private static void SetEnabledKeywords_Injected(IntPtr _unity_self, LocalKeyword[] keywords)
		{
		}

		private static MaterialGlobalIlluminationFlags get_globalIlluminationFlags_Injected(IntPtr _unity_self)
		{
			return default(MaterialGlobalIlluminationFlags);
		}

		private static void set_globalIlluminationFlags_Injected(IntPtr _unity_self, MaterialGlobalIlluminationFlags value)
		{
		}

		private static bool get_enableInstancing_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_enableInstancing_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static int get_passCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int FindPass_Injected(IntPtr _unity_self, ref ManagedSpanWrapper passName)
		{
			return 0;
		}

		private static bool SetPass_Injected(IntPtr _unity_self, int pass)
		{
			return false;
		}

		private static void CopyPropertiesFromMaterial_Injected(IntPtr _unity_self, IntPtr mat)
		{
		}

		private static void CopyMatchingPropertiesFromMaterial_Injected(IntPtr _unity_self, IntPtr mat)
		{
		}

		private static string[] GetShaderKeywords_Injected(IntPtr _unity_self)
		{
			return null;
		}

		private static void SetShaderKeywords_Injected(IntPtr _unity_self, string[] names)
		{
		}

		private static int ComputeCRC_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void SetIntImpl_Injected(IntPtr _unity_self, int name, int value)
		{
		}

		private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value)
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

		private static void SetGraphicsBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value)
		{
		}

		private static void SetConstantBufferImpl_Injected(IntPtr _unity_self, int name, IntPtr value, int offset, int size)
		{
		}

		private static float GetFloatImpl_Injected(IntPtr _unity_self, int name)
		{
			return 0f;
		}

		private static void GetColorImpl_Injected(IntPtr _unity_self, int name, out Color ret)
		{
			ret = default(Color);
		}

		private static IntPtr GetTextureImpl_Injected(IntPtr _unity_self, int name)
		{
			return (IntPtr)0;
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

		private static void GetTextureScaleAndOffsetImpl_Injected(IntPtr _unity_self, int name, out Vector4 ret)
		{
			ret = default(Vector4);
		}

		private static void SetTextureOffsetImpl_Injected(IntPtr _unity_self, int name, [In] ref Vector2 offset)
		{
		}

		private static void SetTextureScaleImpl_Injected(IntPtr _unity_self, int name, [In] ref Vector2 scale)
		{
		}
	}
}
