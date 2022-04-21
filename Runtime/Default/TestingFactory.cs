using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine;
using Moqunity.UnityEngine;

namespace Moqunity
{
	public class TestingFactory : Factory
	{
		private Factory innerFactory = new DefaultFactory();
		public virtual Application Application => innerFactory.Application;
		public virtual Screen Screen => innerFactory.Screen;
		public virtual Input Input => innerFactory.Input;
		public virtual Time Time => innerFactory.Time;
		public virtual SystemInfo SystemInfo => innerFactory.SystemInfo;
		public virtual Random Random => innerFactory.Random;
		public virtual Debug Debug => innerFactory.Debug;
		public virtual PlayerPrefs PlayerPrefs => innerFactory.PlayerPrefs;
		public virtual void Init() => innerFactory.Init();
		public virtual T Get<T>() where T : StaticWrapper => innerFactory.Get<T>();
	}
}
