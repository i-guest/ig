using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XUserGetTokenAndSignatureData
	{
		internal Unity.XGamingRuntime.Interop.XUserGetTokenAndSignatureData interop;

		public ulong TokenSize
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public ulong SignatureSize
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		public string Token
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Signature
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal XUserGetTokenAndSignatureData(Unity.XGamingRuntime.Interop.XUserGetTokenAndSignatureData interop)
		{
		}

		public XUserGetTokenAndSignatureData()
		{
		}
	}
}
