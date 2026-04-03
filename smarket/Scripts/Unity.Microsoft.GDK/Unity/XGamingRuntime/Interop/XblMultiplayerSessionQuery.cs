using System;

namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerSessionQuery
	{
		internal readonly byte[] Scid;

		private uint MaxItems;

		internal bool IncludePrivateSessions;

		internal bool IncludeReservations;

		internal bool IncludeInactiveSessions;

		private readonly IntPtr XuidFilters;

		private SizeT XuidFiltersCount;

		internal UTF8StringPtr KeywordFilter;

		internal readonly byte[] SessionTemplateNameFilter;

		private XblMultiplayerSessionVisibility VisibilityFilter;

		private uint ContractVersionFilter;

		internal XblMultiplayerSessionQuery(Unity.XGamingRuntime.XblMultiplayerSessionQuery publicObject, DisposableCollection disposableCollection)
		{
			Scid = null;
			MaxItems = 0u;
			IncludePrivateSessions = false;
			IncludeReservations = false;
			IncludeInactiveSessions = false;
			XuidFilters = (IntPtr)0;
			XuidFiltersCount = default(SizeT);
			KeywordFilter = default(UTF8StringPtr);
			SessionTemplateNameFilter = null;
			VisibilityFilter = default(XblMultiplayerSessionVisibility);
			ContractVersionFilter = 0u;
		}
	}
}
