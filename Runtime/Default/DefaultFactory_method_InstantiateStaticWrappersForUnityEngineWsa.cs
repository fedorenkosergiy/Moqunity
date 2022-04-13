#if UNITY_WSA
using Moqunity.Abstract;

namespace Moqunity
{
	public partial class DefaultFactory : Factory
	{
		partial void InstantiateStaticWrappersForUnityEngineWsa()
		{
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.WSA.Application), new Moqunity.UnityEngine.WSA.DefaultApplication());
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.WSA.Cursor), new Moqunity.UnityEngine.WSA.DefaultCursor());
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.WSA.Launcher), new Moqunity.UnityEngine.WSA.DefaultLauncher());
		}
	}
}
#endif