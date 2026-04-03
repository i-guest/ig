using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 4, Size = 512)]
	internal struct MatchMakingKeyValuePair
	{
		internal string Key;

		internal string Value;

		[PreserveSig]
		internal static extern void InternalConstruct(ref MatchMakingKeyValuePair self);
	}
}
