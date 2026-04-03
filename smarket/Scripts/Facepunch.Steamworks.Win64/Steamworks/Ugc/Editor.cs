using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks.Ugc
{
	public struct Editor
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSubmitAsync_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PublishResult> _003C_003Et__builder;

			public IProgress<float> progress;

			public Editor _003C_003E4__this;

			public Action<PublishResult> onItemCreated;

			private PublishResult _003Cresult_003E5__2;

			private CallResult<CreateItemResult_t> _003C_003Eu__1;

			private UGCUpdateHandle_t _003Chandle_003E5__3;

			private CallResult<SubmitItemUpdateResult_t> _003Cupdating_003E5__4;

			private TaskAwaiter _003C_003Eu__2;

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

		private PublishedFileId fileId;

		private bool creatingNew;

		private WorkshopFileType creatingType;

		private AppId consumerAppId;

		private string Title;

		private string Description;

		private string MetaData;

		private string ChangeLog;

		private string Language;

		private string PreviewFile;

		private DirectoryInfo ContentFolder;

		private RemoteStoragePublishedFileVisibility? Visibility;

		private List<string> Tags;

		private Dictionary<string, List<string>> KeyValueTags;

		private HashSet<string> KeyValueTagsToRemove;

		public static Editor NewCommunityFile => default(Editor);

		public static Editor NewCollection => default(Editor);

		public static Editor NewMicrotransactionFile => default(Editor);

		public static Editor NewGameManagedFile => default(Editor);

		internal Editor(WorkshopFileType filetype)
		{
			fileId = default(PublishedFileId);
			creatingNew = false;
			creatingType = default(WorkshopFileType);
			consumerAppId = default(AppId);
			Title = null;
			Description = null;
			MetaData = null;
			ChangeLog = null;
			Language = null;
			PreviewFile = null;
			ContentFolder = null;
			Visibility = null;
			Tags = null;
			KeyValueTags = null;
			KeyValueTagsToRemove = null;
		}

		public Editor(PublishedFileId fileId)
		{
			this.fileId = default(PublishedFileId);
			creatingNew = false;
			creatingType = default(WorkshopFileType);
			consumerAppId = default(AppId);
			Title = null;
			Description = null;
			MetaData = null;
			ChangeLog = null;
			Language = null;
			PreviewFile = null;
			ContentFolder = null;
			Visibility = null;
			Tags = null;
			KeyValueTags = null;
			KeyValueTagsToRemove = null;
		}

		public Editor ForAppId(AppId id)
		{
			return default(Editor);
		}

		public Editor WithTitle(string t)
		{
			return default(Editor);
		}

		public Editor WithDescription(string t)
		{
			return default(Editor);
		}

		public Editor WithMetaData(string t)
		{
			return default(Editor);
		}

		public Editor WithChangeLog(string t)
		{
			return default(Editor);
		}

		public Editor InLanguage(string t)
		{
			return default(Editor);
		}

		public Editor WithPreviewFile(string t)
		{
			return default(Editor);
		}

		public Editor WithContent(DirectoryInfo t)
		{
			return default(Editor);
		}

		public Editor WithContent(string folderName)
		{
			return default(Editor);
		}

		public Editor WithPublicVisibility()
		{
			return default(Editor);
		}

		public Editor WithFriendsOnlyVisibility()
		{
			return default(Editor);
		}

		public Editor WithPrivateVisibility()
		{
			return default(Editor);
		}

		public Editor WithTag(string tag)
		{
			return default(Editor);
		}

		public Editor AddKeyValueTag(string key, string value)
		{
			return default(Editor);
		}

		public Editor RemoveKeyValueTags(string key)
		{
			return default(Editor);
		}

		[AsyncStateMachine(typeof(_003CSubmitAsync_003Ed__40))]
		public Task<PublishResult> SubmitAsync(IProgress<float> progress = null, Action<PublishResult> onItemCreated = null)
		{
			return null;
		}
	}
}
