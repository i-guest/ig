namespace Unity.XGamingRuntime.Interop
{
	internal struct XblMultiplayerSessionReference
	{
		private unsafe fixed byte Scid[40];

		private unsafe fixed byte SessionTemplateName[100];

		private unsafe fixed byte SessionName[100];

		internal string GetScid()
		{
			return null;
		}

		internal string GetSessionTemplateName()
		{
			return null;
		}

		internal string GetSessionName()
		{
			return null;
		}

		internal XblMultiplayerSessionReference(Unity.XGamingRuntime.XblMultiplayerSessionReference publicObject)
		{
		}
	}
}
