using System;

namespace Steamworks
{
	internal abstract class SteamInterface
	{
		public IntPtr Self;

		public IntPtr SelfGlobal;

		public IntPtr SelfServer;

		public IntPtr SelfClient;

		public bool IsValid => false;

		public bool IsServer { get; private set; }

		public virtual IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		public virtual IntPtr GetServerInterfacePointer()
		{
			return (IntPtr)0;
		}

		public virtual IntPtr GetGlobalInterfacePointer()
		{
			return (IntPtr)0;
		}

		internal void SetupInterface(bool gameServer)
		{
		}

		internal void ShutdownInterface()
		{
		}
	}
}
