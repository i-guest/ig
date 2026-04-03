namespace UnityEngine.InputForUI
{
	internal interface IEventProviderImpl
	{
		void Initialize();

		void Shutdown();

		void Update();

		void OnFocusChanged(bool focus);
	}
}
