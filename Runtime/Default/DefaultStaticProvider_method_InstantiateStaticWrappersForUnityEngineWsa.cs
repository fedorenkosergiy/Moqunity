#if UNITY_WSA
using Moqunity.Abstract;

namespace Moqunity
{
	public partial class DefaultStaticProvider : Static
	{
		partial void InstantiateStaticWrappersForUnityEngineWsa(Factory factory)
		{
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.WSA.Application), factory.WSA.NewApplication());
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.WSA.Cursor), factory.WSA.NewCursor());
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.WSA.Launcher), factory.WSA.NewLauncher());
			staticWrappers.Add(typeof(Moqunity.Abstract.UnityEngine.Windows.File), factory.Windows.NewFile());
		}
	}
}
#endif
