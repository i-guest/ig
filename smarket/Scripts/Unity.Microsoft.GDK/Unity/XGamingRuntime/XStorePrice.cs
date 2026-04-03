using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XStorePrice
	{
		internal Unity.XGamingRuntime.Interop.XStorePrice interop;

		public float BasePrice
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Price
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RecurrencePrice
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public string CurrencyCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FormattedBasePrice
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FormattedPrice
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string FormattedRecurrencePrice
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsOnSale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long SaleEndDate
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal XStorePrice(Unity.XGamingRuntime.Interop.XStorePrice interop)
		{
		}

		public XStorePrice()
		{
		}
	}
}
