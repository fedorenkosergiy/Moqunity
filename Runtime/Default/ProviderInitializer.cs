namespace Moqunity
{
	[global::UnityEngine.DefaultExecutionOrder(-10000)]
	public class ProviderInitializer : global::UnityEngine.MonoBehaviour
	{
		private static bool _needInit = true;

		private void Awake()
		{
			if (_needInit)
			{
				MoqunityApi.Static.Init(MoqunityApi.Factory);
				_needInit = false;
			}

			Destroy(this);
		}
	}
}
