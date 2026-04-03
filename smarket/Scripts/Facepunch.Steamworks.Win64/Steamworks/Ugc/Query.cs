using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	public struct Query
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPageAsync_003Ed__76 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<ResultPage?> _003C_003Et__builder;

			public int page;

			public Query _003C_003E4__this;

			private CallResult<SteamUGCQueryCompleted_t> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private UgcType matchingType;

		private UGCQuery queryType;

		private AppId consumerApp;

		private AppId creatorApp;

		private string searchText;

		private SteamId? steamid;

		private UserUGCList userType;

		private UserUGCListSortOrder userSort;

		private PublishedFileId[] Files;

		private int? maxCacheAge;

		private string language;

		private int? trendDays;

		private List<string> requiredTags;

		private bool? matchAnyTag;

		private List<string> excludedTags;

		private Dictionary<string, string> requiredKv;

		private bool? WantsReturnOnlyIDs;

		private bool? WantsReturnKeyValueTags;

		private bool? WantsReturnLongDescription;

		private bool? WantsReturnMetadata;

		private bool? WantsReturnChildren;

		private bool? WantsReturnAdditionalPreviews;

		private bool? WantsReturnTotalOnly;

		private uint? WantsReturnPlaytimeStats;

		private bool? WantsDefaultStats;

		public static Query All => default(Query);

		public static Query Items => default(Query);

		public static Query ItemsMtx => default(Query);

		public static Query ItemsReadyToUse => default(Query);

		public static Query Collections => default(Query);

		public static Query Artwork => default(Query);

		public static Query Videos => default(Query);

		public static Query Screenshots => default(Query);

		public static Query AllGuides => default(Query);

		public static Query WebGuides => default(Query);

		public static Query IntegratedGuides => default(Query);

		public static Query UsableInGame => default(Query);

		public static Query ControllerBindings => default(Query);

		public static Query GameManagedItems => default(Query);

		public Query(UgcType type)
		{
			matchingType = default(UgcType);
			queryType = default(UGCQuery);
			consumerApp = default(AppId);
			creatorApp = default(AppId);
			searchText = null;
			steamid = null;
			userType = default(UserUGCList);
			userSort = default(UserUGCListSortOrder);
			Files = null;
			maxCacheAge = null;
			language = null;
			trendDays = null;
			requiredTags = null;
			matchAnyTag = null;
			excludedTags = null;
			requiredKv = null;
			WantsReturnOnlyIDs = null;
			WantsReturnKeyValueTags = null;
			WantsReturnLongDescription = null;
			WantsReturnMetadata = null;
			WantsReturnChildren = null;
			WantsReturnAdditionalPreviews = null;
			WantsReturnTotalOnly = null;
			WantsReturnPlaytimeStats = null;
			WantsDefaultStats = null;
		}

		public Query RankedByVote()
		{
			return default(Query);
		}

		public Query RankedByPublicationDate()
		{
			return default(Query);
		}

		public Query RankedByAcceptanceDate()
		{
			return default(Query);
		}

		public Query RankedByTrend()
		{
			return default(Query);
		}

		public Query FavoritedByFriends()
		{
			return default(Query);
		}

		public Query CreatedByFriends()
		{
			return default(Query);
		}

		public Query RankedByNumTimesReported()
		{
			return default(Query);
		}

		public Query CreatedByFollowedUsers()
		{
			return default(Query);
		}

		public Query NotYetRated()
		{
			return default(Query);
		}

		public Query RankedByTotalVotesAsc()
		{
			return default(Query);
		}

		public Query RankedByVotesUp()
		{
			return default(Query);
		}

		public Query RankedByTextSearch()
		{
			return default(Query);
		}

		public Query RankedByTotalUniqueSubscriptions()
		{
			return default(Query);
		}

		public Query RankedByPlaytimeTrend()
		{
			return default(Query);
		}

		public Query RankedByTotalPlaytime()
		{
			return default(Query);
		}

		public Query RankedByAveragePlaytimeTrend()
		{
			return default(Query);
		}

		public Query RankedByLifetimeAveragePlaytime()
		{
			return default(Query);
		}

		public Query RankedByPlaytimeSessionsTrend()
		{
			return default(Query);
		}

		public Query RankedByLifetimePlaytimeSessions()
		{
			return default(Query);
		}

		internal Query LimitUser(SteamId steamid)
		{
			return default(Query);
		}

		public Query WhereUserPublished(SteamId user = default(SteamId))
		{
			return default(Query);
		}

		public Query WhereUserVotedOn(SteamId user = default(SteamId))
		{
			return default(Query);
		}

		public Query WhereUserVotedUp(SteamId user = default(SteamId))
		{
			return default(Query);
		}

		public Query WhereUserVotedDown(SteamId user = default(SteamId))
		{
			return default(Query);
		}

		public Query WhereUserWillVoteLater(SteamId user = default(SteamId))
		{
			return default(Query);
		}

		public Query WhereUserFavorited(SteamId user = default(SteamId))
		{
			return default(Query);
		}

		public Query WhereUserSubscribed(SteamId user = default(SteamId))
		{
			return default(Query);
		}

		public Query WhereUserUsedOrPlayed(SteamId user = default(SteamId))
		{
			return default(Query);
		}

		public Query WhereUserFollowed(SteamId user = default(SteamId))
		{
			return default(Query);
		}

		public Query SortByCreationDate()
		{
			return default(Query);
		}

		public Query SortByCreationDateAsc()
		{
			return default(Query);
		}

		public Query SortByTitleAsc()
		{
			return default(Query);
		}

		public Query SortByUpdateDate()
		{
			return default(Query);
		}

		public Query SortBySubscriptionDate()
		{
			return default(Query);
		}

		public Query SortByVoteScore()
		{
			return default(Query);
		}

		public Query SortByModeration()
		{
			return default(Query);
		}

		public Query WhereSearchText(string searchText)
		{
			return default(Query);
		}

		public Query WithFileId(params PublishedFileId[] files)
		{
			return default(Query);
		}

		[AsyncStateMachine(typeof(_003CGetPageAsync_003Ed__76))]
		public Task<ResultPage?> GetPageAsync(int page)
		{
			return null;
		}

		public Query WithType(UgcType type)
		{
			return default(Query);
		}

		public Query AllowCachedResponse(int maxSecondsAge)
		{
			return default(Query);
		}

		public Query InLanguage(string lang)
		{
			return default(Query);
		}

		public Query WithTrendDays(int days)
		{
			return default(Query);
		}

		public Query MatchAnyTag()
		{
			return default(Query);
		}

		public Query MatchAllTags()
		{
			return default(Query);
		}

		public Query WithTag(string tag)
		{
			return default(Query);
		}

		public Query AddRequiredKeyValueTag(string key, string value)
		{
			return default(Query);
		}

		public Query WithoutTag(string tag)
		{
			return default(Query);
		}

		private void ApplyConstraints(UGCQueryHandle_t handle)
		{
		}

		public Query WithOnlyIDs(bool b)
		{
			return default(Query);
		}

		public Query WithKeyValueTags(bool b)
		{
			return default(Query);
		}

		[Obsolete("Renamed to WithKeyValueTags")]
		public Query WithKeyValueTag(bool b)
		{
			return default(Query);
		}

		public Query WithLongDescription(bool b)
		{
			return default(Query);
		}

		public Query WithMetadata(bool b)
		{
			return default(Query);
		}

		public Query WithChildren(bool b)
		{
			return default(Query);
		}

		public Query WithAdditionalPreviews(bool b)
		{
			return default(Query);
		}

		public Query WithTotalOnly(bool b)
		{
			return default(Query);
		}

		public Query WithPlaytimeStats(uint unDays)
		{
			return default(Query);
		}

		private void ApplyReturns(UGCQueryHandle_t handle)
		{
		}

		public Query WithDefaultStats(bool b)
		{
			return default(Query);
		}
	}
}
