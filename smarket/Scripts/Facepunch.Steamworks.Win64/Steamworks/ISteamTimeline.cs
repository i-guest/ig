using System;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	internal class ISteamTimeline : SteamInterface
	{
		public const string Version = "STEAMTIMELINE_INTERFACE_V004";

		internal ISteamTimeline(bool IsGameServer)
		{
		}

		[PreserveSig]
		internal static extern IntPtr SteamAPI_SteamTimeline_v004();

		public override IntPtr GetUserInterfacePointer()
		{
			return (IntPtr)0;
		}

		[PreserveSig]
		private static extern void _SetTimelineTooltip(IntPtr self, string pchDescription, float flTimeDelta);

		internal void SetTimelineTooltip(string pchDescription, float flTimeDelta)
		{
		}

		[PreserveSig]
		private static extern void _ClearTimelineTooltip(IntPtr self, float flTimeDelta);

		internal void ClearTimelineTooltip(float flTimeDelta)
		{
		}

		[PreserveSig]
		private static extern void _SetTimelineGameMode(IntPtr self, TimelineGameMode eMode);

		internal void SetTimelineGameMode(TimelineGameMode eMode)
		{
		}

		[PreserveSig]
		private static extern TimelineEventHandle _AddInstantaneousTimelineEvent(IntPtr self, string pchTitle, string pchDescription, string pchIcon, uint unIconPriority, float flStartOffsetSeconds, TimelineEventClipPriority ePossibleClip);

		internal TimelineEventHandle AddInstantaneousTimelineEvent(string pchTitle, string pchDescription, string pchIcon, uint unIconPriority, float flStartOffsetSeconds, TimelineEventClipPriority ePossibleClip)
		{
			return default(TimelineEventHandle);
		}

		[PreserveSig]
		private static extern TimelineEventHandle _AddRangeTimelineEvent(IntPtr self, string pchTitle, string pchDescription, string pchIcon, uint unIconPriority, float flStartOffsetSeconds, float flDuration, TimelineEventClipPriority ePossibleClip);

		internal TimelineEventHandle AddRangeTimelineEvent(string pchTitle, string pchDescription, string pchIcon, uint unIconPriority, float flStartOffsetSeconds, float flDuration, TimelineEventClipPriority ePossibleClip)
		{
			return default(TimelineEventHandle);
		}

		[PreserveSig]
		private static extern TimelineEventHandle _StartRangeTimelineEvent(IntPtr self, string pchTitle, string pchDescription, string pchIcon, uint unPriority, float flStartOffsetSeconds, TimelineEventClipPriority ePossibleClip);

		internal TimelineEventHandle StartRangeTimelineEvent(string pchTitle, string pchDescription, string pchIcon, uint unPriority, float flStartOffsetSeconds, TimelineEventClipPriority ePossibleClip)
		{
			return default(TimelineEventHandle);
		}

		[PreserveSig]
		private static extern void _UpdateRangeTimelineEvent(IntPtr self, TimelineEventHandle ulEvent, string pchTitle, string pchDescription, string pchIcon, uint unPriority, TimelineEventClipPriority ePossibleClip);

		internal void UpdateRangeTimelineEvent(TimelineEventHandle ulEvent, string pchTitle, string pchDescription, string pchIcon, uint unPriority, TimelineEventClipPriority ePossibleClip)
		{
		}

		[PreserveSig]
		private static extern void _EndRangeTimelineEvent(IntPtr self, TimelineEventHandle ulEvent, float flEndOffsetSeconds);

		internal void EndRangeTimelineEvent(TimelineEventHandle ulEvent, float flEndOffsetSeconds)
		{
		}

		[PreserveSig]
		private static extern void _RemoveTimelineEvent(IntPtr self, TimelineEventHandle ulEvent);

		internal void RemoveTimelineEvent(TimelineEventHandle ulEvent)
		{
		}

		[PreserveSig]
		private static extern SteamAPICall_t _DoesEventRecordingExist(IntPtr self, TimelineEventHandle ulEvent);

		internal CallResult<SteamTimelineEventRecordingExists_t> DoesEventRecordingExist(TimelineEventHandle ulEvent)
		{
			return default(CallResult<SteamTimelineEventRecordingExists_t>);
		}

		[PreserveSig]
		private static extern void _StartGamePhase(IntPtr self);

		internal void StartGamePhase()
		{
		}

		[PreserveSig]
		private static extern void _EndGamePhase(IntPtr self);

		internal void EndGamePhase()
		{
		}

		[PreserveSig]
		private static extern void _SetGamePhaseID(IntPtr self, string pchPhaseID);

		internal void SetGamePhaseID(string pchPhaseID)
		{
		}

		[PreserveSig]
		private static extern SteamAPICall_t _DoesGamePhaseRecordingExist(IntPtr self, string pchPhaseID);

		internal CallResult<SteamTimelineGamePhaseRecordingExists_t> DoesGamePhaseRecordingExist(string pchPhaseID)
		{
			return default(CallResult<SteamTimelineGamePhaseRecordingExists_t>);
		}

		[PreserveSig]
		private static extern void _AddGamePhaseTag(IntPtr self, string pchTagName, string pchTagIcon, string pchTagGroup, uint unPriority);

		internal void AddGamePhaseTag(string pchTagName, string pchTagIcon, string pchTagGroup, uint unPriority)
		{
		}

		[PreserveSig]
		private static extern void _SetGamePhaseAttribute(IntPtr self, string pchAttributeGroup, string pchAttributeValue, uint unPriority);

		internal void SetGamePhaseAttribute(string pchAttributeGroup, string pchAttributeValue, uint unPriority)
		{
		}

		[PreserveSig]
		private static extern void _OpenOverlayToGamePhase(IntPtr self, string pchPhaseID);

		internal void OpenOverlayToGamePhase(string pchPhaseID)
		{
		}

		[PreserveSig]
		private static extern void _OpenOverlayToTimelineEvent(IntPtr self, TimelineEventHandle ulEvent);

		internal void OpenOverlayToTimelineEvent(TimelineEventHandle ulEvent)
		{
		}
	}
}
