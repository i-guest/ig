using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XGameStreamingTouchControlsStateValue
	{
		internal Unity.XGamingRuntime.Interop.XGameStreamingTouchControlsStateValue interop;

		internal string _stringValue;

		public XGameStreamingTouchControlsStateValueKind ValueKind
		{
			get
			{
				return default(XGameStreamingTouchControlsStateValueKind);
			}
			set
			{
			}
		}

		public string StringValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public double DoubleValue
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public bool BoolValue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public uint IntegerValue
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		internal XGameStreamingTouchControlsStateValue(Unity.XGamingRuntime.Interop.XGameStreamingTouchControlsStateValue interop)
		{
		}

		public XGameStreamingTouchControlsStateValue()
		{
		}
	}
}
