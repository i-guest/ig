using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	[NativeHeader("Editor/Src/Graphics/ShaderCompilerData.h")]
	public struct ShaderKeywordSet
	{
		private IntPtr m_KeywordState;

		private IntPtr m_Shader;

		private IntPtr m_ComputeShader;

		private ulong m_StateIndex;

		[FreeFunction("keywords::IsKeywordEnabled")]
		private static bool IsKeywordNameEnabled(ShaderKeywordSet state, string name)
		{
			return false;
		}

		[FreeFunction("keywords::GetEnabledKeywords")]
		private static ShaderKeyword[] GetEnabledKeywords(ShaderKeywordSet state)
		{
			return null;
		}

		private void CheckKeywordCompatible(ShaderKeyword keyword)
		{
		}

		public bool IsEnabled(ShaderKeyword keyword)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		private static int ShaderKeywordComparer(ShaderKeyword kw1, ShaderKeyword kw2)
		{
			return 0;
		}

		private static bool IsKeywordNameEnabled_Injected([In] ref ShaderKeywordSet state, ref ManagedSpanWrapper name)
		{
			return false;
		}

		private static ShaderKeyword[] GetEnabledKeywords_Injected([In] ref ShaderKeywordSet state)
		{
			return null;
		}
	}
}
