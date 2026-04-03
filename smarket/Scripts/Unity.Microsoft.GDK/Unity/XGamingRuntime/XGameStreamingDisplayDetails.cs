using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XGameStreamingDisplayDetails
	{
		internal Unity.XGamingRuntime.Interop.XGameStreamingDisplayDetails _interop;

		internal RECT rect;

		internal Unity.XGamingRuntime.Interop.XGameStreamingDisplayDetails interop => default(Unity.XGamingRuntime.Interop.XGameStreamingDisplayDetails);

		public uint PreferredWidth
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint PreferredHeight
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public RECT SafeArea
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint MaxPixels
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint MaxWidth
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint MaxHeight
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public XGameStreamingVideoFlags Flags
		{
			get
			{
				return default(XGameStreamingVideoFlags);
			}
			set
			{
			}
		}

		internal XGameStreamingDisplayDetails(Unity.XGamingRuntime.Interop.XGameStreamingDisplayDetails interop)
		{
		}

		public XGameStreamingDisplayDetails()
		{
		}
	}
}
