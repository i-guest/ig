using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout((LayoutKind)0, Pack = 1, Size = 13)]
	public struct AnalogState
	{
		public InputSourceMode EMode;

		public float X;

		public float Y;

		internal byte BActive;

		public bool Active => false;
	}
}
