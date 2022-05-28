using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine;
using Moqunity.Abstract.UnityEngine.Rendering;
using Moqunity.UnityEngine;
using Moqunity.UnityEngine.Rendering;

namespace Moqunity
{
	public partial class DefaultFactory : Factory
	{
		private class DefaultRenderingFactory : Factory.RenderingFactory
		{
			public AsyncGPUReadback NewAsyncGPUReadback() => new DefaultAsyncGPUReadback();
			public OnDemandRendering NewOnDemandRendering() => new DefaultOnDemandRendering();
		}

		public Factory.RenderingFactory Rendering { get; } = new DefaultRenderingFactory();

		public Ping NewPing(string address) => new DefaultPing(address);
		public Application NewApplication() => new DefaultApplication();
		public Screen NewScreen() => new DefaultScreen();
		public Input NewInput() => new DefaultInput();
		public Time NewTime() => new DefaultTime();
		public SystemInfo NewSystemInfo() => new DefaultSystemInfo();
		public Random NewRandom() => new DefaultRandom();
		public Debug NewDebug() => new DefaultDebug();
		public PlayerPrefs NewPlayerPrefs() => new DefaultPlayerPrefs();
		public Resources NewResources() => new DefaultResources();
	}
}
