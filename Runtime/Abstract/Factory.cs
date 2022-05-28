using Moqunity.Abstract.UnityEngine;

namespace Moqunity.Abstract
{
	public partial interface Factory
	{
		public interface RenderingFactory
		{
			UnityEngine.Rendering.AsyncGPUReadback NewAsyncGPUReadback();
			UnityEngine.Rendering.OnDemandRendering NewOnDemandRendering();
		}
		RenderingFactory Rendering { get; }

		/// <summary>
		/// Perform a ping to the supplied target IP address.
		/// </summary>
		/// <param name="address">address</param>
		Ping NewPing(string address);

		Application NewApplication();
		Screen NewScreen();
		Input NewInput();
		Time NewTime();
		SystemInfo NewSystemInfo();
		Random NewRandom();
		Debug NewDebug();
		PlayerPrefs NewPlayerPrefs();
		Resources NewResources();
	}
}
