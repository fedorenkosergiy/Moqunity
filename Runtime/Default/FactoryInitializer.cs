namespace Moqunity
{
	[global::UnityEngine.DefaultExecutionOrder(-10000)]
	public class FactoryInitializer : global::UnityEngine.MonoBehaviour
	{
		private static bool _needInit = true;

		private void Awake()
		{
			if (_needInit)
			{
				Context.Factory.Init();
				_needInit = false;
			}

			Destroy(this);
		}
	}
}
