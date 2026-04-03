using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
	internal struct SteamInputGamepadSlotChange_t : ICallbackData
	{
		internal AppId AppID;

		internal ulong DeviceHandle;

		internal InputType DeviceType;

		internal int OldGamepadSlot;

		internal int NewGamepadSlot;

		public static int _datasize;

		public int DataSize => 0;

		public CallbackType CallbackType => default(CallbackType);
	}
}
