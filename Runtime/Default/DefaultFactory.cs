using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine;
using Moqunity.UnityEngine;

namespace Moqunity
{
	public class DefaultFactory : Factory
	{
		private bool needsInitialization = true;
		public Application Application { get; private set; }
		public Screen Screen { get; private set; }
		public Input Input { get; private set; }
		public Time Time { get; private set; }
		public SystemInfo SystemInfo { get; private set; }

		public void Init()
		{
			lock (this)
			{
				if (needsInitialization)
				{
					Application = new DefaultApplication();
					Screen = new DefaultScreen();
					Input = new DefaultInput();
					Time = new DefaultTime();
					SystemInfo = new DefaultSystemInfo();
					needsInitialization = false;
				}
				else
				{
					global::UnityEngine.Debug.LogWarning("factory already initialized");
				}
			}
		}
	}
}
