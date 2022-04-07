using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine;
using Moqunity.UnityEngine;

namespace Moqunity
{
	public class TestingFactory : Factory
	{
		public Application Application { get; private set; }
		public Screen Screen { get; private set; }
		public Input Input { get; private set; }
		public Time Time { get; private set; }
		public SystemInfo SystemInfo { get; private set; }
		public Random Random { get; private set; }

		public void Init()
		{
			Application = CreateApplication();
			Screen = CreateScreen();
			Input = CreateInput();
			Time = CreateTime();
			SystemInfo = CreateSystemInfo();
			Random = CreateRandom();
		}

		protected virtual Application CreateApplication() => new DefaultApplication();

		protected virtual Screen CreateScreen() => new DefaultScreen();

		protected virtual Input CreateInput() => new DefaultInput();

		protected virtual Time CreateTime() => new DefaultTime();

		protected virtual SystemInfo CreateSystemInfo() => new DefaultSystemInfo();

		protected virtual Random CreateRandom() => new DefaultRandom();
	}
}
