using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[UsedByNativeCode]
	public readonly struct GlobalKeyword
	{
		internal readonly uint m_Index;

		public string name => null;

		[FreeFunction("ShaderScripting::GetGlobalKeywordCount")]
		private static uint GetGlobalKeywordCount()
		{
			return 0u;
		}

		[FreeFunction("ShaderScripting::GetGlobalKeywordIndex")]
		private static uint GetGlobalKeywordIndex(string keyword)
		{
			return 0u;
		}

		[FreeFunction("ShaderScripting::CreateGlobalKeyword")]
		private static void CreateGlobalKeyword(string keyword)
		{
		}

		[FreeFunction("ShaderScripting::GetGlobalKeywordName")]
		private static string GetGlobalKeywordName(uint keywordIndex)
		{
			return null;
		}

		public static GlobalKeyword Create(string name)
		{
			return default(GlobalKeyword);
		}

		public GlobalKeyword(string name)
		{
			m_Index = 0u;
		}

		public override string ToString()
		{
			return null;
		}

		private static uint GetGlobalKeywordIndex_Injected(ref ManagedSpanWrapper keyword)
		{
			return 0u;
		}

		private static void CreateGlobalKeyword_Injected(ref ManagedSpanWrapper keyword)
		{
		}

		private static void GetGlobalKeywordName_Injected(uint keywordIndex, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}
	}
}
