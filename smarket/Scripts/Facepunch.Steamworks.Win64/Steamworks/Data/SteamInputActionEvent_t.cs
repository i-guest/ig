using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
	internal struct SteamInputActionEvent_t
	{
		internal ulong ControllerHandle;

		internal SteamInputActionEventType EEventType;
	}
}
