namespace UnityEngine.InputForUI
{
	internal struct EventSanitizer
	{
		private interface IEventSanitizer
		{
			void Reset();

			void BeforeProviderUpdate();

			void AfterProviderUpdate();

			void Inspect(in Event ev);
		}

		private IEventSanitizer[] _sanitizers;

		public void Reset()
		{
		}

		public void BeforeProviderUpdate()
		{
		}

		public void AfterProviderUpdate()
		{
		}

		public void Inspect(in Event ev)
		{
		}
	}
}
