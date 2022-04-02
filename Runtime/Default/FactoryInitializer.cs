namespace Moqunity
{
	[global::UnityEngine.DefaultExecutionOrder(-10000)]
	public class FactoryInitializer : global::UnityEngine.MonoBehaviour
	{
		private void Awake()
		{
			Context.Factory.Init();
			Destroy(this);
		}
	}
}