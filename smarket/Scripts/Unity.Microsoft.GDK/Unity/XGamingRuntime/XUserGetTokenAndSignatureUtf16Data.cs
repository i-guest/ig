using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XUserGetTokenAndSignatureUtf16Data
	{
		internal Unity.XGamingRuntime.Interop.XUserGetTokenAndSignatureUtf16Data interop;

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

		internal XUserGetTokenAndSignatureUtf16Data(Unity.XGamingRuntime.Interop.XUserGetTokenAndSignatureUtf16Data interop)
		{
		}

		public XUserGetTokenAndSignatureUtf16Data()
		{
		}
	}
}
