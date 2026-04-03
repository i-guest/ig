using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.Archive
{
	[StaticAccessor("GetManagedArchiveSystem()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/VirtualFileSystem/ArchiveFileSystem/ArchiveFileHandle.h")]
	[RequiredByNativeCode]
	public static class ArchiveFileInterface
	{
	}
}
