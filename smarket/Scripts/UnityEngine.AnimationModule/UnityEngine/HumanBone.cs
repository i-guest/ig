using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/HumanDescription.h")]
	[RequiredByNativeCode]
	[NativeType(CodegenOptions.Custom, "MonoHumanBone")]
	public struct HumanBone
	{
		private string m_BoneName;

		private string m_HumanName;

		[NativeName("m_Limit")]
		public HumanLimit limit;
	}
}
