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

		public void Init()
		{
			lock (this)
			{
				if (needsInitialization)
				{
					Application = CreateApplication();
					Screen = CreateScreen();
					Input = CreateInput();
					Time = CreateTime();
					needsInitialization = false;
				}
				else
				{
					global::UnityEngine.Debug.LogWarning("factory already initialized");
				}
			}
		}

		protected virtual Application CreateApplication() => new DefaultApplication();

		protected virtual Screen CreateScreen() => new DefaultScreen();

		protected virtual Input CreateInput() => new DefaultInput();

		protected virtual Time CreateTime() => new DefaultTime();
	}
}
