using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XStoreConsumableResult
	{
		internal Unity.XGamingRuntime.Interop.XStoreConsumableResult interop;

		public uint Quantity
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		internal XStoreConsumableResult(Unity.XGamingRuntime.Interop.XStoreConsumableResult interop)
		{
		}

		public XStoreConsumableResult()
		{
		}
	}
}
