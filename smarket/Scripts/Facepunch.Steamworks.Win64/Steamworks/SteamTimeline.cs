using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public class SteamTimeline : SteamClientClass<SteamTimeline>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDoesEventRecordingExist_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public TimelineEventHandle handle;

			private CallResult<SteamTimelineEventRecordingExists_t> _003C_003Eu__1;

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
		private struct _003CDoesGamePhaseRecordingExist_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GamePhaseRecordingInfo?> _003C_003Et__builder;

			public string phaseId;

			private CallResult<SteamTimelineGamePhaseRecordingExists_t> _003C_003Eu__1;

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

		internal static ISteamTimeline Internal => null;

		internal override bool InitializeInterface(bool server)
		{
			return false;
		}

		internal static void InstallEvents()
		{
		}

		public static void SetTimelineTooltip(string description, float timeOffsetSeconds)
		{
		}

		public static void ClearTimelineTooltip(float timeOffsetSeconds)
		{
		}

		public static TimelineEventHandle AddInstantaneousTimelineEvent(string title, string description, string icon, uint priority, float startOffsetSeconds, TimelineEventClipPriority possibleClip)
		{
			return default(TimelineEventHandle);
		}

		public static TimelineEventHandle AddRangeTimelineEvent(string title, string description, string icon, uint priority, float startOffsetSeconds, float durationSeconds, TimelineEventClipPriority possibleClip)
		{
			return default(TimelineEventHandle);
		}

		public static TimelineEventHandle StartRangeTimelineEvent(string title, string description, string icon, uint priority, float startOffsetSeconds, TimelineEventClipPriority possibleClip)
		{
			return default(TimelineEventHandle);
		}

		public static void UpdateRangeTimelineEvent(TimelineEventHandle handle, string title, string description, string icon, uint priority, TimelineEventClipPriority possibleClip)
		{
		}

		public static void EndRangeTimelineEvent(TimelineEventHandle handle, float endOffsetSeconds)
		{
		}

		public static void RemoveTimelineEvent(TimelineEventHandle handle)
		{
		}

		[AsyncStateMachine(typeof(_003CDoesEventRecordingExist_003Ed__12))]
		public static Task<bool> DoesEventRecordingExist(TimelineEventHandle handle)
		{
			return null;
		}

		public static void StartGamePhase()
		{
		}

		public static void EndGamePhase()
		{
		}

		public static void SetGamePhaseId(string phaseId)
		{
		}

		[AsyncStateMachine(typeof(_003CDoesGamePhaseRecordingExist_003Ed__16))]
		public static Task<GamePhaseRecordingInfo?> DoesGamePhaseRecordingExist(string phaseId)
		{
			return null;
		}

		public static void AddGamePhaseTag(string tagName, string icon, string tagGroup, uint priority)
		{
		}

		public static void SetGamePhaseAttribute(string attributeGroup, string attributeValue, uint priority)
		{
		}

		public static void SetTimelineGameMode(TimelineGameMode gameMode)
		{
		}

		public static void OpenOverlayToGamePhase(string phaseId)
		{
		}

		public static void OpenOverlayToTimelineEvent(TimelineEventHandle handle)
		{
		}
	}
}
