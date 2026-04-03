using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XSpeechSynthesizerVoiceInformation
	{
		internal Unity.XGamingRuntime.Interop.XSpeechSynthesizerVoiceInformation interop;

		public string Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DisplayName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XSpeechSynthesizerVoiceGender Gender
		{
			get
			{
				return default(XSpeechSynthesizerVoiceGender);
			}
			set
			{
			}
		}

		public string VoiceId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Language
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal XSpeechSynthesizerVoiceInformation(Unity.XGamingRuntime.Interop.XSpeechSynthesizerVoiceInformation interop)
		{
		}

		public XSpeechSynthesizerVoiceInformation()
		{
		}
	}
}
