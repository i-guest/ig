namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerConnectionAddressDeviceTokenPair
	{
		internal readonly UTF8StringPtr connectionAddress;

		internal readonly XblDeviceToken deviceToken;

		internal XblMultiplayerConnectionAddressDeviceTokenPair(Unity.XGamingRuntime.XblMultiplayerConnectionAddressDeviceTokenPair publicObject, DisposableCollection disposableCollection)
		{
			connectionAddress = default(UTF8StringPtr);
			deviceToken = default(XblDeviceToken);
		}
	}
}
