using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	public struct Item
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddDependency_003Ed__156 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public Item _003C_003E4__this;

			public PublishedFileId child;

			private CallResult<AddUGCDependencyResult_t> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddFavorite_003Ed__81 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public Item _003C_003E4__this;

			private CallResult<UserFavoriteItemsListChanged_t> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDownloadAsync_003Ed__79 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public Item _003C_003E4__this;

			public Action<float> progress;

			public int milisecondsUpdateDelay;

			public CancellationToken ct;

			private TaskAwaiter<bool> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAsync_003Ed__75 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Item?> _003C_003Et__builder;

			public PublishedFileId id;

			private TaskAwaiter<ResultPage?> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetUserVote_003Ed__84 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<UserItemVote?> _003C_003Et__builder;

			public Item _003C_003E4__this;

			private CallResult<GetUserItemVoteResult_t> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRemoveDependency_003Ed__157 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public Item _003C_003E4__this;

			public PublishedFileId child;

			private CallResult<RemoveUGCDependencyResult_t> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRemoveFavorite_003Ed__82 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public Item _003C_003E4__this;

			private CallResult<UserFavoriteItemsListChanged_t> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSubscribe_003Ed__78 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public Item _003C_003E4__this;

			private CallResult<RemoteStorageSubscribePublishedFileResult_t> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUnsubscribe_003Ed__80 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public Item _003C_003E4__this;

			private CallResult<RemoteStorageUnsubscribePublishedFileResult_t> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CVote_003Ed__83 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Result?> _003C_003Et__builder;

			public Item _003C_003E4__this;

			public bool up;

			private CallResult<SetUserItemVoteResult_t> _003C_003Eu__1;

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

		internal SteamUGCDetails_t details;

		internal PublishedFileId _id;

		public PublishedFileId[] Children;

		public PublishedFileId Id => default(PublishedFileId);

		public string Title { get; internal set; }

		public string Description { get; internal set; }

		public string[] Tags { get; internal set; }

		public Dictionary<string, string> KeyValueTags { get; internal set; }

		public AppId CreatorApp => default(AppId);

		public AppId ConsumerApp => default(AppId);

		public Friend Owner => default(Friend);

		public float Score => 0f;

		public DateTime Created => default(DateTime);

		public DateTime Updated => default(DateTime);

		public bool IsPublic => false;

		public bool IsFriendsOnly => false;

		public bool IsPrivate => false;

		public bool IsBanned => false;

		public bool IsAcceptedForUse => false;

		public uint VotesUp => 0u;

		public uint VotesDown => 0u;

		public UgcAdditionalPreview[] AdditionalPreviews { get; internal set; }

		public bool IsInstalled => false;

		public bool IsDownloading => false;

		public bool IsDownloadPending => false;

		public bool IsSubscribed => false;

		public bool NeedsUpdate => false;

		public string Directory => null;

		public long DownloadBytesTotal => 0L;

		public long DownloadBytesDownloaded => 0L;

		public long SizeBytes => 0L;

		public float DownloadAmount => 0f;

		private ItemState State => default(ItemState);

		public string Url => null;

		public string ChangelogUrl => null;

		public string CommentsUrl => null;

		public string DiscussUrl => null;

		public string StatsUrl => null;

		public ulong NumSubscriptions { get; internal set; }

		public ulong NumFavorites { get; internal set; }

		public ulong NumFollowers { get; internal set; }

		public ulong NumUniqueSubscriptions { get; internal set; }

		public ulong NumUniqueFavorites { get; internal set; }

		public ulong NumUniqueFollowers { get; internal set; }

		public ulong NumUniqueWebsiteViews { get; internal set; }

		public ulong ReportScore { get; internal set; }

		public ulong NumSecondsPlayed { get; internal set; }

		public ulong NumPlaytimeSessions { get; internal set; }

		public ulong NumComments { get; internal set; }

		public ulong NumSecondsPlayedDuringTimePeriod { get; internal set; }

		public ulong NumPlaytimeSessionsDuringTimePeriod { get; internal set; }

		public string PreviewImageUrl { get; internal set; }

		public string Metadata { get; internal set; }

		public Result Result => default(Result);

		public Item(PublishedFileId id)
		{
			details = default(SteamUGCDetails_t);
			_id = default(PublishedFileId);
			Title = null;
			Description = null;
			Tags = null;
			KeyValueTags = null;
			Children = null;
			AdditionalPreviews = null;
			NumSubscriptions = 0uL;
			NumFavorites = 0uL;
			NumFollowers = 0uL;
			NumUniqueSubscriptions = 0uL;
			NumUniqueFavorites = 0uL;
			NumUniqueFollowers = 0uL;
			NumUniqueWebsiteViews = 0uL;
			ReportScore = 0uL;
			NumSecondsPlayed = 0uL;
			NumPlaytimeSessions = 0uL;
			NumComments = 0uL;
			NumSecondsPlayedDuringTimePeriod = 0uL;
			NumPlaytimeSessionsDuringTimePeriod = 0uL;
			PreviewImageUrl = null;
			Metadata = null;
		}

		public bool Download(bool highPriority = false)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CGetAsync_003Ed__75))]
		public static Task<Item?> GetAsync(PublishedFileId id, int maxageseconds = 1800)
		{
			return null;
		}

		internal static Item From(SteamUGCDetails_t details)
		{
			return default(Item);
		}

		public bool HasTag(string find)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CSubscribe_003Ed__78))]
		public Task<bool> Subscribe()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDownloadAsync_003Ed__79))]
		public Task<bool> DownloadAsync(Action<float> progress = null, int milisecondsUpdateDelay = 60, CancellationToken ct = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnsubscribe_003Ed__80))]
		public Task<bool> Unsubscribe()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAddFavorite_003Ed__81))]
		public Task<bool> AddFavorite()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRemoveFavorite_003Ed__82))]
		public Task<bool> RemoveFavorite()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CVote_003Ed__83))]
		public Task<Result?> Vote(bool up)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetUserVote_003Ed__84))]
		public Task<UserItemVote?> GetUserVote()
		{
			return null;
		}

		public Editor Edit()
		{
			return default(Editor);
		}

		[AsyncStateMachine(typeof(_003CAddDependency_003Ed__156))]
		public Task<bool> AddDependency(PublishedFileId child)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRemoveDependency_003Ed__157))]
		public Task<bool> RemoveDependency(PublishedFileId child)
		{
			return null;
		}
	}
}
