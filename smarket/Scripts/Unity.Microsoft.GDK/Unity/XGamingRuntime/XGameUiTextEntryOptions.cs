using Unity.XGamingRuntime.Interop;

namespace Unity.XGamingRuntime
{
	public class XGameUiTextEntryOptions
	{
		internal Unity.XGamingRuntime.Interop.XGameUiTextEntryOptions data;

		public XGameUiTextEntryInputScope InputScope
		{
			get
			{
				return default(XGameUiTextEntryInputScope);
			}
			set
			{
			}
		}

		public XGameUiTextEntryPositionHint PositionHint
		{
			get
			{
				return default(XGameUiTextEntryPositionHint);
			}
			set
			{
			}
		}

		public XGameUiTextEntryVisibilityFlags VisibilityFlags
		{
			get
			{
				return default(XGameUiTextEntryVisibilityFlags);
			}
			set
			{
			}
		}

		internal XGameUiTextEntryOptions(Unity.XGamingRuntime.Interop.XGameUiTextEntryOptions interop)
		{
		}

		public XGameUiTextEntryOptions()
		{
		}
	}
}
