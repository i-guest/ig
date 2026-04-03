using System;
using Steamworks.Data;

namespace Steamworks.ServerList
{
	internal struct ServerFilterMarshaler : IDisposable
	{
		private static readonly int SizeOfPointer;

		private static readonly int SizeOfKeyValuePair;

		private IntPtr _arrayPtr;

		private IntPtr _itemsPtr;

		public int Count { get; private set; }

		public IntPtr Pointer => (IntPtr)0;

		public ServerFilterMarshaler(MatchMakingKeyValuePair[] filters)
		{
			_arrayPtr = (IntPtr)0;
			_itemsPtr = (IntPtr)0;
			Count = 0;
		}

		public void Dispose()
		{
		}
	}
}
