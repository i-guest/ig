using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout((LayoutKind)0, Pack = 1, Size = 2)]
	public struct DigitalState
	{
		internal byte BState;

		internal byte BActive;

		public bool Pressed => false;

		public bool Active => false;
	}
}
