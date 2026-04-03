using System;

namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerPerformQoSMeasurementsArgs
	{
		private unsafe readonly XblMultiplayerConnectionAddressDeviceTokenPair* remoteClients;

		internal readonly SizeT remoteClientsSize;

		internal T[] GetRemoteClients<T>(Func<XblMultiplayerConnectionAddressDeviceTokenPair, T> ctor)
		{
			return null;
		}

		internal unsafe XblMultiplayerPerformQoSMeasurementsArgs(Unity.XGamingRuntime.XblMultiplayerPerformQoSMeasurementsArgs publicObject, DisposableCollection disposableCollection)
		{
			remoteClients = null;
			remoteClientsSize = default(SizeT);
		}
	}
}
