using Moqunity.Abstract;
using Moqunity.Abstract.UnityEngine;
using Moqunity.UnityEngine;

namespace Moqunity
{
	public class TestingStaticProvider : StaticProvider
	{
		private StaticProvider _innerStaticProvider = new DefaultStaticProvider();
		public virtual Application Application => _innerStaticProvider.Application;
		public virtual Screen Screen => _innerStaticProvider.Screen;
		public virtual Input Input => _innerStaticProvider.Input;
		public virtual Time Time => _innerStaticProvider.Time;
		public virtual SystemInfo SystemInfo => _innerStaticProvider.SystemInfo;
		public virtual Random Random => _innerStaticProvider.Random;
		public virtual Debug Debug => _innerStaticProvider.Debug;
		public virtual PlayerPrefs PlayerPrefs => _innerStaticProvider.PlayerPrefs;
		public virtual Resources Resources => _innerStaticProvider.Resources;
		public virtual void Init(Factory factory) => _innerStaticProvider.Init(factory);
		public virtual T Get<T>() where T : StaticWrapper => _innerStaticProvider.Get<T>();
	}
}
