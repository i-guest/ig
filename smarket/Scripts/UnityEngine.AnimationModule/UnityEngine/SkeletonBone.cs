using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[NativeType(CodegenOptions.Custom, "MonoSkeletonBone")]
	[NativeHeader("Modules/Animation/HumanDescription.h")]
	public struct SkeletonBone
	{
		[NativeName("m_Name")]
		public string name;

		[NativeName("m_ParentName")]
		internal string parentName;

		[NativeName("m_Position")]
		public Vector3 position;

		[NativeName("m_Rotation")]
		public Quaternion rotation;

		[NativeName("m_Scale")]
		public Vector3 scale;
	}
}
