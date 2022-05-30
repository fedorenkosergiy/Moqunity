#if UNITY_WSA
using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine.WSA;
using Moqunity.UnityEngine.WSA;

namespace Moqunity
{
	public partial class DefaultFactory
	{
		private class DefaultWsaFactory : Factory.WSAFactory
		{
			public Application NewApplication() => new DefaultApplication();
			public Cursor NewCursor() => new DefaultCursor();
			public Launcher NewLauncher() => new DefaultLauncher();
		}

		public Factory.WSAFactory WSA { get; } = new DefaultWsaFactory();
	}
}
#endif
